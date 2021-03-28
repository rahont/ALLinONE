using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace ALLinONE
{
    public partial class MainForm : Form
    {
        private string result3;

        #region Form
        public MainForm()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            CheckDBexist form = new CheckDBexist();
            RegistryKey registry = Registry.CurrentUser.CreateSubKey("SOFTWARE\\All in One");

            if (Registry.CurrentUser.OpenSubKey("SOFTWARE\\All in One") == null) //проверяем наличие раздела в реестре. если отсутствует раздел, то создаем
                registry.CreateSubKey("SOFTWARE\\All in One");

            if (File.Exists(registry.GetValue("PathDB", "Data_DB.db").ToString()))
            {
                form.Close();
                Text += $" ({Environment.UserName})   - v.2.12.3";

                LoadFormPosition();     //Загрузка координат формы
                Refresh_btnPR();        //Загрузка описаний кнопок на вкладке Проф
                //RefreshDBGrid();        //Загрузка заявок
                RefreshDBPrinters();    //Загрузка принтеров
                RefreshLBRDP();         //Загрузка ListBox RDP на вкладке Сервис
                RefreshLBShare();       //Загрузка ListBox Share на вкладке Сервис

                //Установка времени для пинга и максимального значения ProgressBar (вкладка Сервис)
                numPingProgress.Value = Convert.ToDecimal(registry.GetValue("ProgressBarSec", 30));
                pbPingProgress.Maximum = Convert.ToInt32(numPingProgress.Value) * 1000;
            }
            else
            {
                DialogResult result = MessageBox.Show
                    ("Файл базы данных не найден.\nЖелаешь указать к нему путь или создать новый?", "Хде он?!?!?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    form.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Ну и фиг с тобой :P", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }

            registry.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UseDB.connectDB.Close(); //закрыть БД
            AiOMethods.SaveFormPosition(Location.X, Location.Y);
        }

        private void LoadFormPosition()
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Size.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Size.Height;
            
            RegistryKey formPos = Registry.CurrentUser.CreateSubKey("SOFTWARE\\All in One");
            Location = new Point(Convert.ToInt32(formPos.GetValue("PositionX", Location.X)),
                Convert.ToInt32(formPos.GetValue("PositionY", Location.Y)));   //загрузить позицию формы из реестра
            formPos.Close();

            if ((Location.X < -500) || (Location.X > screenWidth) || (Location.Y < -500) || (Location.Y > screenHeight))
                Location = new Point(100, 100);
        }
        #endregion

        #region MenuStrip
        private void toolStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void remoteAccsessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoteAccsess form = new RemoteAccsess();
            form.Owner = this;
            form.ShowDialog();
        }

        private void toolStripDBCheckCon_Click(object sender, EventArgs e)
        {
            string str = (UseDB.connectDB.State.ToString() == "Open") ? "Подключение к БД установлено" : "Подключение к БД отсутствует";
            MessageBox.Show(str, "Статус подключение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripDBInvertCon_Click(object sender, EventArgs e)
        {
            if (UseDB.connectDB.State.ToString() == "Open") UseDB.connectDB.Close();
            else UseDB.connectDB.Open();
        }
        #endregion

        #region Methods
        public void Refresh_btnPR()
        {
            int count = UseDB.SelectDB("ProfRab", "btn_name").Length;

            for (int i = 1; i <= count; i++)
            {
                try
                {
                    var btn = GetControl(tabPageProfRab, "btnPR" + i);   //метод поиска контролов (записывем имя кнопки в переменную)
                    btn.Text = UseDB.SelectDBLike("ProfRab", "btn_title", "btn_name", "btnPR" + i.ToString()) ; //задаем Text кнопке
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
        }

        private Control GetControl(Control control, string name)    //метод поиска контролов
        {
            var fetchedControl = control.Controls[name];
            if (fetchedControl == null)
                foreach (Control c in control.Controls)
                {
                    fetchedControl = GetControl(c, name);
                    if (fetchedControl != null)
                        break;
                }
            return fetchedControl;
        }

        private void RefreshDBGrid()
        {
            UseDB.connectDB.Open();

            var sqlCommand = new SQLiteCommand();
            if (chckbMyRequest.Checked)
            {
                sqlCommand = new SQLiteCommand("select * from RequestList where User like '" + Environment.UserName + "'", UseDB.connectDB);

                //UseDB.table = "RequestList";
                //UseDB.col1 = "*";
                //UseDB.col2 = "User";
                //UseDB.str1 = Environment.UserName;
            }
            else
            {
                sqlCommand = new SQLiteCommand("select * from RequestList", UseDB.connectDB);
            }
            //UseDB.SelectDBLike();
            sqlCommand.ExecuteNonQuery();

            var dataTable = new DataTable("RequestList");
            var sqlAdapter = new SQLiteDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataTable);

            dgvRequest.DataSource = dataTable.DefaultView;
            sqlAdapter.Update(dataTable);

            UseDB.connectDB.Close();

            lblQuantity.Text = "Количество заявок: " + dgvRequest.Rows.Count.ToString();

            dgvRequest.Columns["id"].Visible = false;
            //Переименовка колонок в DataGridView
            dgvRequest.Columns["Value"].HeaderText = "Заявки";
            dgvRequest.Columns["User"].HeaderText = "Пользователь";
            dgvRequest.Columns["DateCreate"].HeaderText = "Добавлена";
            dgvRequest.Columns["DateUse"].HeaderText = "Использована";

            //Длина колонок в DataGridView
            dgvRequest.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //Автоподстройка длины столбца
            dgvRequest.Columns[2].Width = 100;
            dgvRequest.Columns[3].Width = 111;
            dgvRequest.Columns[4].Width = 111;

            dgvRequest.ClearSelection();
        }

        public void RefreshDBPrinters()
        {
            UseDB.connectDB.Open();
            var sqlCommand = new SQLiteCommand("select * from Printers", UseDB.connectDB);
            sqlCommand.ExecuteNonQuery();

            var dataTable = new DataTable("Printers");
            var sqlAdapter = new SQLiteDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataTable);

            dgvPrinters.DataSource = dataTable.DefaultView;
            sqlAdapter.Update(dataTable);

            UseDB.connectDB.Close();

            dgvPrinters.Columns["id"].Visible = false;
            //Переименовка колонок в DataGridView
            dgvPrinters.Columns["Name"].HeaderText = "Наименование";
            dgvPrinters.Columns["NetName"].HeaderText = "Сет. имя";
            dgvPrinters.Columns["Location"].HeaderText = "Расположение";
            dgvPrinters.Columns["InvNumber"].HeaderText = "Инвентарный";

            //Длина колонок в DataGridView
            dgvPrinters.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //Автоподстройка длины столбца
            dgvPrinters.Columns[2].Width = 87;
            dgvPrinters.Columns[3].Width = 91;
            dgvPrinters.Columns[4].Width = 82;

            dgvPrinters.ClearSelection();
        }

        private void ClearPrintTB()
        {
            tbPrintName1.Clear();
            tbPrintNetName1.Clear();
            tbPrintLocation1.Clear();
            tbPrintInvNumber1.Clear();
        }
        #endregion

        #region ProfRab
        private void BtnPR1_Click(object sender, EventArgs e)
        {
            string bName = (sender as Button).Name; //Получает имя нажатой кнопки

            string str = UseDB.SelectDBLike("ProfRab", "btn_value", "btn_name", bName);
            lblPR.Text = str;
            Clipboard.SetText(str);

            tmrComm5555.Enabled = false;
            tmrComm5555.Enabled = true;
        }

        private void BtnPRChange_Click(object sender, EventArgs e)
        {
            PRChangeButton form = new PRChangeButton();
            form.Owner = this;
            form.ShowDialog();
        }
        #endregion

        #region Service
        private void lbRDP_DoubleClick(object sender, EventArgs e)
        {
            if (lbRDP.SelectedItem != null)
                Process.Start("mstsc", @"/admin /f /v:" + UseDB.SelectDBLike("ServiceRDP", "Name", "Title", lbRDP.SelectedItem.ToString()));
        }

        private void lbShare_DoubleClick(object sender, EventArgs e)
        {
            if (lbShare.SelectedItem != null)
                Process.Start("explorer", UseDB.SelectDBLike("ServiceShare", "Name", "Title", lbShare.SelectedItem.ToString()));
        }

        private void lbRDP_Leave(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            lb.ClearSelected();
        }

        private void chckbServiceSorted_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbServiceSorted.Checked)
            {
                lbRDP.Sorted = true;
                lbShare.Sorted = true;
                lbPingSuccess.Sorted = true;
                lbPingTimeOut.Sorted = true;
            }
            else
            {
                lbRDP.Sorted = false;
                lbShare.Sorted = false;
                lbPingSuccess.Sorted = false;
                lbPingTimeOut.Sorted = false;
            }
            RefreshLBRDP();
            RefreshLBShare();
        }

        private void numPingProgress_ValueChanged(object sender, EventArgs e)
        {
            tmrServicePB.Enabled = false;
            pbPingProgress.Value = 0;
            pbPingProgress.Maximum = Convert.ToInt32(numPingProgress.Value) * 1000;
            tmrServicePB.Enabled = true;

            //Properties.Settings.Default.rdp_shareProgressBarSec = numPingProgress.Value;
            //Properties.Settings.Default.Save();

            RegistryKey ProgressBarSec = Registry.CurrentUser.CreateSubKey("SOFTWARE\\All in One");

            if (Registry.CurrentUser.OpenSubKey("SOFTWARE\\All in One") == null) //проверяем наличие раздела в реестре. если отсутствует раздел, то создаем
                ProgressBarSec.CreateSubKey("SOFTWARE\\All in One");

            ProgressBarSec.SetValue("ProgressBarSec", numPingProgress.Value);
            ProgressBarSec.Close();
        }

        private void btnSrvcChange_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            SrvcChange form = new SrvcChange();
            form.Owner = mf;
            form.ShowDialog();
        }

        private void tmrServicePB_Tick(object sender, EventArgs e)
        {
            //if (pbPingProgress.Value == pbPingProgress.Maximum)
            //{
            //    pbPingProgress.Maximum += 1;
            //    pbPingProgress.Value += 1;
            //    pbPingProgress.Maximum = pbPingProgress.Value;
            //}
            //else
            //    pbPingProgress.Value += 1;

            Service srvc = new Service();
            if (pbPingProgress.Value == pbPingProgress.Maximum) srvc.LoadLBPing(pbPingProgress, lbPingSuccess, lbPingTimeOut, numPingTimeOut);
            else pbPingProgress.Value += 100;
        }
        #endregion

        #region Printers
        private void dgvPrinters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbPrintName1.Text = dgvPrinters.SelectedCells[1].Value.ToString();
                tbPrintNetName1.Text = dgvPrinters.SelectedCells[2].Value.ToString();
                tbPrintLocation1.Text = dgvPrinters.SelectedCells[3].Value.ToString();
                tbPrintInvNumber1.Text = dgvPrinters.SelectedCells[4].Value.ToString();
            }
        }

        private void dgvPrinters_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete) //проверяем нажат ли Del,
                btnPrintRemove.PerformClick(); //если да, то жмем кнопку Удалить
        }

        private void tbPrintName_Click(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.TextLength > 0)
            {
                //tb.SelectAll();
                Clipboard.SetText(tb.Text);
                tmrComm5555.Enabled = false;
                tmrComm5555.Enabled = true;
                lblPrintBuffer.Text = "В буфер уехало: " + tb.Text;
            }
        }

        private void btnPrintPrinting_Click(object sender, EventArgs e)
        {
            result3 = null;
            for (int i = 0; i < dgvPrinters.RowCount; i++)
            {
                for (int j = 1; j < dgvPrinters.ColumnCount; j++)
                {
                    if (dgvPrinters[j, i].Value.ToString() != "")
                        result3 += dgvPrinters[j, i].Value.ToString() + "\t";
                }
                result3 += "\n";
            }

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintPageHandler;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print();
        }

        private void btnPrintAdd_Click(object sender, EventArgs e)
        {
            if (tbPrintName1.Text == "")
            {
                MessageBox.Show("Что забыл?", "Атата...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UseDB.InsertDB("Printers", "Name", "NetName", "Location", "InvNumber", tbPrintName1.Text, tbPrintNetName1.Text, tbPrintLocation1.Text, tbPrintInvNumber1.Text);
                RefreshDBPrinters();
                ClearPrintTB();
            }
        }

        private void btnPrintRemove_Click(object sender, EventArgs e)
        {
            if (dgvPrinters.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Кого кикаем?", "Упс", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                string strId = dgvPrinters.SelectedCells[0].Value.ToString();
                string strValue = dgvPrinters.SelectedCells[1].Value.ToString();

                DialogResult result = MessageBox.Show
                    ("Удалить запись?\n\n" + strValue, "Ты уверен?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    UseDB.DeleteDB("Printers", "Id", strId);
                    dgvPrinters.Rows.RemoveAt(dgvPrinters.CurrentRow.Index); //удаляет строку из DataGridView
                    ClearPrintTB();
                }
            }
        }
        #endregion

        #region Request
        private void dgvRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                tbAddRequest.Text = dgvRequest.SelectedCells[1].Value.ToString();
        }

        private void dgvRequest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRequest.SelectedRows.Count > 0) btnAddRequestBuffer.PerformClick();
        }

        private void dgvRequest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete) //проверяем нажат ли Del,
                btnRemoveRequest.PerformClick(); //если да, то жмем кнопку Удалить

            if (e.KeyData == Keys.Enter) //проверяем нажат ли Enter,
                btnAddRequestBuffer.PerformClick(); //если да, то жмем кнопку Добавления в буфер
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            if (tbAddRequest.Text == "")
            {
                MessageBox.Show("Что будем добавлять?", "Не заполнил!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UseDB.InsertDB("RequestList", "Value", "User", "DateCreate", tbAddRequest.Text, Environment.UserName, DateTime.Now.ToString());

                RefreshDBGrid();
                tbAddRequest.Clear();
            }
        }

        private void btnRemoveRequest_Click(object sender, EventArgs e)
        {
            if (dgvRequest.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Кого кикаем?", "Упс", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string strId = dgvRequest.SelectedCells[0].Value.ToString();
                string strValue = dgvRequest.SelectedCells[1].Value.ToString();
                string strUser = dgvRequest.SelectedCells[2].Value.ToString();
                string strDate = dgvRequest.SelectedCells[3].Value.ToString();

                DialogResult result = MessageBox.Show
                    ("Удалить запись?\n\n" +
                        "'" + strValue + "'\n\n" +
                            "Созданная: " + "'" + strDate + "'\n" +
                                "Пользователем: " + "'" + strUser + "'",
                    "Ты уверен?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    UseDB.DeleteDB("RequestList", "Id", strId);
                    dgvRequest.Rows.RemoveAt(dgvRequest.CurrentRow.Index); //удаляет строку из DataGridView
                    lblQuantity.Text = "Количество заявок: " + dgvRequest.Rows.Count.ToString(); // -1 заявка в lbl после удаления из dgv
                }
            }
        }

        private void btnAddRequestBuffer_Click(object sender, EventArgs e)
        {
            if (dgvRequest.SelectedRows.Count > 0)
            {
                tmrComm5555.Enabled = false;
                string strRequest = dgvRequest.SelectedCells[1].Value.ToString();
                Clipboard.SetText(strRequest);
                lblInfoRequest.Text = "В буфер уехало:\n" + strRequest;
                tmrComm5555.Enabled = true;

                UseDB.UpdateDB("RequestList", "Value", "DateUse", strRequest, DateTime.Now.ToString());

                dgvRequest.SelectedCells[4].Value = DateTime.Now.ToString(); //запись даты в ячейку "DataUse"

                if (chckbRemoveRequest.Checked)
                {
                    UseDB.DeleteDB("RequestList", "Value", strRequest);
                    dgvRequest.Rows.RemoveAt(dgvRequest.CurrentRow.Index); //удаляет строку из DataGridView
                    lblQuantity.Text = "Количество заявок: " + dgvRequest.Rows.Count.ToString(); // -1 заявка в lbl после удаления из dgv
                }
            }
        }

        private void tbAddRequest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) //проверяем нажат ли Enter,
                btnAddRequest.PerformClick(); //если да, то жмем кнопку Добавить
        }
        #endregion


        private void tmrRequest_Tick(object sender, EventArgs e)
        {
            lblInfoRequest.Text = string.Empty;
            lblAddRequestDB.Text = string.Empty;
            lblPrintBuffer.Text = string.Empty;
            lblPR.Text = string.Empty;
            tmrComm5555.Enabled = false;
        }

        private void btnAddRequestDB_Click(object sender, EventArgs e)
        {
            if (lbProgList.SelectedItem != null && tbAddFIORequest.Text != "")
            {
                tmrComm5555.Enabled = false;

                string str = null;

                if (rdbtnAddRequest1.Checked) str = "Установить ";
                if (rdbtnAddRequest2.Checked) str = "Переустановить ";
                if (rdbtnAddRequest3.Checked) str = "Обновить ";
                if (rdbtnAddRequest4.Checked) str = "Настроить ";

                str += lbProgList.SelectedItem + ". " + tbAddFIORequest.Text;

                UseDB.InsertDB("RequestList", "Value", "User", "DateCreate", str, Environment.UserName, DateTime.Now.ToString());

                lblAddRequestDB.Text = "Улетело в БД:\n" + str;
                tmrComm5555.Enabled = true;
            }
            else MessageBox.Show("Что ты упустил?", "IQ тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddProg_Click(object sender, EventArgs e)
        {
            if (tbAddProg.Text == "")
            {
                MessageBox.Show("Такого ПО не существует!", "Вбей ПО'шечку", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UseDB.InsertDB("ProgList", "Name", tbAddProg.Text);
                lbProgList.Items.Add(tbAddProg.Text);
                tbAddProg.Text = null;
            }
        }

        private void btnRemoveProg_Click(object sender, EventArgs e)
        {
            if (lbProgList.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Удалить запись '" + lbProgList.SelectedItem + "'?", "Ты уверен?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    UseDB.DeleteDB("ProgList", "Name", lbProgList.SelectedItem.ToString());
                    lbProgList.Items.RemoveAt(lbProgList.SelectedIndex);
                }
            }
            else MessageBox.Show("Шо те нада?", "Ну и дурак...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lbProgList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete) //проверяем нажат ли Del,
                btnRemoveProg.PerformClick(); //если да, то жмем кнопку Удалить

            if (e.KeyData == Keys.Enter)
                btnAddRequestDB.PerformClick();
        }

        private void tbAddProg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) //проверяем нажат ли Enter,
                btnAddProg.PerformClick(); //если да, то жмем кнопку Добавить
        }

        private void tbAddFIORequest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) //проверяем нажат ли Enter,
                btnAddRequestDB.PerformClick(); //если да, то жмем кнопку Добавить
        }

        private void chckbMyRequest_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDBGrid();
        }

        private void btnCartPaper_Click(object sender, EventArgs e)
        {
            RequestPrinters form = new RequestPrinters();
            form.ShowDialog();
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(result3, new Font("Arial", 12), Brushes.Black, 20, 20);
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //Страница сервис
            tmrServicePB.Enabled = (tabControl.SelectedTab == tabPageService);

            //Страница заявок
            if (tabControl.SelectedTab == tabPageDBList)
            {
                RefreshDBGrid();
                lblUserRequest.Text = Environment.UserName;
                dgvRequest.ClearSelection();
            }

            //Страница принтеров
            //if (tabControl.SelectedTab == tabPagePrinters) RefreshDBPrinters();

            //Страница записи заявок
            if (tabControl.SelectedTab == tabPageAddRequest) AiOMethods.RefreshProgList(lbProgList);
        }

        public void RefreshLBRDP()
        {
            lbRDP.Items.Clear();
            foreach (var item in UseDB.SelectDB("ServiceRDP", "Title"))
                lbRDP.Items.Add(item);
        }

        public void RefreshLBShare()
        {
            lbShare.Items.Clear();
            foreach (var item in UseDB.SelectDB("ServiceShare", "Title"))
                lbShare.Items.Add(item);
        }

        private void btnRefreshPing_Click(object sender, EventArgs e)
        {
            Service srvc = new Service();
            srvc.LoadLBPing(pbPingProgress, lbPingSuccess, lbPingTimeOut, numPingTimeOut);
        }

        private void btnMassRequest_Click(object sender, EventArgs e)
        {
            MassRequest form = new MassRequest();
            form.ShowDialog();
            form.Close();
        }

        private void toolStripExcel_Click(object sender, EventArgs e)
        {
            //Поиск DataGridView
            foreach (Control c in tabControl.SelectedTab.Controls)
            {
                if (c is DataGridView)
                {
                    saveFileDialog.FileName = Text.Replace(" ", null);
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        DataGridView dgv = null;
                        if (c == dgvPrinters)
                        {
                            dgv = dgvPrinters;
                            goto fin;
                        }
                        if (c == dgvRequest)
                        {
                            dgv = dgvRequest;
                            goto fin;
                        }

                        if (dgv == null) break;
                        fin:
                        AiOMethods.SaveExcel(dgv, saveFileDialog.FileName);
                        break;
                    }
                }
            }
        }

        private void lblPingTimeRefresh_MouseHover(object sender, EventArgs e)
        {
            Label lbl = (sender as Label);
            if (lbl == lblPingTimeRefresh) toolTip.Show("В секундах", lbl);
            if (lbl == lblPingTimeTimeOut) toolTip.Show("В миллисекундах", lbl);
        }

        private void toDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToDoList.FormOpenClose == false)
            {
                ToDoList tdl = new ToDoList();
                tdl.ShowDialog();
            }
        }

        private void btnMSTSCstart_Click(object sender, EventArgs e)
        {
            if (tbMSTSCadress.Text != string.Empty)
                Service.StartMSTSC(tbMSTSCadress.Text, tbMSTSClogin.Text, tbMSTSCpass.Text);
        }

        private void tbMSTSCadress_KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                btnMSTSCstart.PerformClick();
        }

        private void btnCyclePingStart_Click(object sender, EventArgs e)
        {
            lbCyclePing.Items.Clear();
            Service.CyclePingStop = false;
            Service.StartCyclePing(tbCyclePingAdress.Text, lbCyclePing);
            btnCyclePingStart.Enabled = false;
        }

        public async void btnCyclePingStop_Click(object sender, EventArgs e)
        {
            Service.CyclePingStop = true;

            await Task.Delay(1333);
            btnCyclePingStart.Enabled = true;
            //string s = btnMSTSCstart.Name;
        }

        private void tbMSTSCadress_TextChanged(object sender, EventArgs e)
        {
            //RegistryKey service = Registry.CurrentUser.CreateSubKey("SOFTWARE\\All in One\\Service");

            //var mtb = sender as MyTextBox;

            //if (mtb.Name == "tbMSTSCadress")
            //{
            //    MessageBox.Show("Test");
            //    service.SetValue("Adress", mtb?.Text);
            //}
            //if (mtb.Name == "tbMSTSClogin") service.SetValue("Login", mtb?.Text);

            //service.Close();
        }

        private void lbCyclePing_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush myBrush;

            if (lbCyclePing.Items.Count > 0)
            {
                myBrush = (lbCyclePing.Items[e.Index].ToString().Contains("Не доступен")) ? Brushes.DarkRed : Brushes.DarkGreen;
                e.Graphics.DrawString(lbCyclePing.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds);
            }
        }

        private void tbCyclePingAdress_KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) btnCyclePingStart.PerformClick();
        }

        private void btnPrintChange_Click(object sender, EventArgs e)
        {
            if (tbPrintName1.TextLength > 0)
            {
                UseDB.UpdateDB("Printers", "Name", "id", tbPrintName1.Text, dgvPrinters.SelectedCells[0].Value.ToString());
                UseDB.UpdateDB("Printers", "NetName", "id", tbPrintNetName1.Text, dgvPrinters.SelectedCells[0].Value.ToString());
                UseDB.UpdateDB("Printers", "Location", "id", tbPrintLocation1.Text, dgvPrinters.SelectedCells[0].Value.ToString());
                UseDB.UpdateDB("Printers", "InvNumber", "id", tbPrintInvNumber1.Text, dgvPrinters.SelectedCells[0].Value.ToString());

                dgvPrinters.SelectedCells[1].Value = tbPrintName1.Text;
                dgvPrinters.SelectedCells[2].Value = tbPrintNetName1.Text;
                dgvPrinters.SelectedCells[3].Value = tbPrintLocation1.Text;
                dgvPrinters.SelectedCells[4].Value = tbPrintInvNumber1.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Screen.PrimaryScreen.Bounds.Size.Width.ToString());
        }
    }
}