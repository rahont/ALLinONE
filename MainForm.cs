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
//using System.Drawing;

namespace ALLinONE
{
    public partial class MainForm : Form
    {
        public SQLiteConnection DB; //БД
        private string result3;

        public MainForm()
        {
            InitializeComponent();
            if (File.Exists("Data_DB.db"))
                DB = new SQLiteConnection("Data Source=Data_DB.db; Version=3"); //БД
            else
            {
                MessageBox.Show("Положи рядом с exe'шником файл БД с именем 'Data_DB.db' с правильными таблицами, иначе работать будешь без меня.", "Нам нужно поговорить...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            DB.Open(); //открыть БД
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFormPosition();
            //MainForm main = new MainForm();
            Text += " (" + Environment.UserName + ")   - v.2.6";
            Refresh_btnPR();
            RefreshProgList();
            panPR.Visible = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.Close(); //закрыть БД
            SaveFormPosition();
        }

        public void Refresh_btnPR()
        {
            SQLiteCommand comm = DB.CreateCommand();

            for (int i = 1; i < 27; i++)
            {
                comm.CommandText = "select btn_title from ProfRab where btn_name like '%btnPR" + i + "%'";
                var btn = GetControl(panPR, "btnPR" + i);   //метод поиска контролов (записывем имя кнопки в переменную)
                btn.Text = comm.ExecuteScalar().ToString(); //задаем Text кнопке

                //if (i == 1) btnPR1.Text = comm.ExecuteScalar().ToString();
                //if (i == 2) btnPR2.Text = comm.ExecuteScalar().ToString();
                //if (i == 3) btnPR3.Text = comm.ExecuteScalar().ToString();
                //if (i == 4) btnPR4.Text = comm.ExecuteScalar().ToString();
                //if (i == 5) btnPR5.Text = comm.ExecuteScalar().ToString();
                //if (i == 6) btnPR6.Text = comm.ExecuteScalar().ToString();
                //if (i == 7) btnPR7.Text = comm.ExecuteScalar().ToString();
                //if (i == 8) btnPR8.Text = comm.ExecuteScalar().ToString();
                //if (i == 9) btnPR9.Text = comm.ExecuteScalar().ToString();
                //if (i == 10) btnPR10.Text = comm.ExecuteScalar().ToString();
                //if (i == 11) btnPR11.Text = comm.ExecuteScalar().ToString();
                //if (i == 12) btnPR12.Text = comm.ExecuteScalar().ToString();
                //if (i == 13) btnPR13.Text = comm.ExecuteScalar().ToString();
                //if (i == 14) btnPR14.Text = comm.ExecuteScalar().ToString();
                //if (i == 15) btnPR15.Text = comm.ExecuteScalar().ToString();
                //if (i == 16) btnPR16.Text = comm.ExecuteScalar().ToString();
                //if (i == 17) btnPR17.Text = comm.ExecuteScalar().ToString();
                //if (i == 18) btnPR18.Text = comm.ExecuteScalar().ToString();
                //if (i == 19) btnPR19.Text = comm.ExecuteScalar().ToString();
                //if (i == 20) btnPR20.Text = comm.ExecuteScalar().ToString();
                //if (i == 21) btnPR21.Text = comm.ExecuteScalar().ToString();
                //if (i == 22) btnPR22.Text = comm.ExecuteScalar().ToString();
                //if (i == 23) btnPR23.Text = comm.ExecuteScalar().ToString();
                //if (i == 24) btnPR24.Text = comm.ExecuteScalar().ToString();
                //if (i == 25) btnPR25.Text = comm.ExecuteScalar().ToString();
                //if (i == 26) btnPR26.Text = comm.ExecuteScalar().ToString();
                //dfgbrthnjguyktfyjdfghdrtjghk
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

        //public void Style()
        //{
        //    foreach (Control panel in Controls)
        //    {
        //        Panel pnl = panel as Panel;
        //        if (pnl != null)
        //        {
        //            pnl.BackColor = ColorTranslator.FromHtml("#D0D0D0");
        //        }
        //    }
        //    foreach (Control button in panPR.Controls)
        //    {
        //        Button btn = button as Button;
        //        if (btn != null)
        //        {
        //            btn.FlatAppearance.BorderSize = 0;
        //            btn.FlatStyle = FlatStyle.Flat;
        //            btn.BackColor = ColorTranslator.FromHtml("#808080");
        //        }
        //    }
        //    menuStrip.BackColor = ColorTranslator.FromHtml("#D0D0D0");
        //}

        private void BtnPR1_Click(object sender, EventArgs e)
        {
            SQLiteCommand comm = DB.CreateCommand();
            string bName = (sender as Button).Name; //Получает имя нажатой кнопки
            comm.CommandText = "select btn_value from ProfRab where btn_name like '%" + bName + "%'";
            lblPR.Text = comm.ExecuteScalar().ToString();
            Clipboard.SetText(comm.ExecuteScalar().ToString());
            tmrComm5555.Enabled = false;
            tmrComm5555.Enabled = true;
        }

        private void BtnPRChange_Click(object sender, EventArgs e)
        {
            PRChangeButton form = new PRChangeButton();
            form.Owner = this;
            form.ShowDialog();
        }

        private void PanVis()
        {
            panPR.Visible = false;
            panSrvc.Visible = false;
            panPrint.Visible = false;
            panRequest.Visible = false;
            panAddRequest.Visible = false;
            reOS.Visible = false;
        }

        private void ToolStripPR_Click(object sender, EventArgs e)
        {
            if (panPR.Visible == false)
            {
                PanVis();
                panPR.Visible = true;
            }
        }

        private void ToolStripSrvc_Click(object sender, EventArgs e)
        {
            RefreshLBRDP();
            RefreshLBShare();

            if (panSrvc.Visible == false)
            {
                PanVis();
                panSrvc.Visible = true;
            }
        }

        private void ToolStripPrint_Click(object sender, EventArgs e)
        {
            if (panPrint.Visible == false)
            {
                PanVis();
                RefreshDBPrinters();
                panPrint.Visible = true;
            }
        }

        private void BtnSrvcChange_Click(object sender, EventArgs e)
        {
            SrvcChange form = new SrvcChange();
            form.Owner = this;
            form.ShowDialog();
        }

        public void RefreshLBRDP()
        {
            lbRDP.Items.Clear();

            SQLiteCommand commRDP = DB.CreateCommand(); //переменная БД
            commRDP.CommandText = "select Title from ServiceRDP"; //код БД в переменную
            SQLiteDataReader rdp = commRDP.ExecuteReader(); //результат кода в переменную
            while (rdp.Read()) //цикл перебора результатов кода БД
            {
                    lbRDP.Items.Add(rdp["Title"]); //запись столбца БД в listbox
            }
        }

        public void RefreshLBShare()
        {
            lbShare.Items.Clear();

            SQLiteCommand commShare = DB.CreateCommand(); //переменная БД
            commShare.CommandText = "select Title from ServiceShare"; //код БД в переменную
            SQLiteDataReader share = commShare.ExecuteReader(); //результат кода в переменную
            while (share.Read()) //цикл перебора результатов кода БД
            {
                lbShare.Items.Add(share["Title"]); //запись столбца БД в listbox
            }
        }

        private void LbRDP_Leave(object sender, EventArgs e)
        {
            lbRDP.ClearSelected();
        }

        private void LbShare_Leave(object sender, EventArgs e)
        {
            lbShare.ClearSelected();
        }

        private void LbRDP_DoubleClick(object sender, EventArgs e)
        {
            if (lbRDP.SelectedItem != null)
            {
                SQLiteCommand comm = DB.CreateCommand();
                comm.CommandText = "select Name from ServiceRDP where Title like '" + lbRDP.SelectedItem.ToString() + "'";
                //Process.Start("Cmd.exe", @"/C mstsc.exe /admin /f /v:" + comm.ExecuteScalar().ToString());
                Process.Start("mstsc", @"/admin /f /v:" + comm.ExecuteScalar().ToString());
            }
        }

        private void LbShare_DoubleClick(object sender, EventArgs e)
        {
            if (lbShare.SelectedItem != null)
            {
                SQLiteCommand comm = DB.CreateCommand();
                comm.CommandText = "select Name from ServiceShare where Title like '" + lbShare.SelectedItem.ToString() + "'";
                //Process.Start("Cmd.exe", @"/C explorer.exe " + comm.ExecuteScalar().ToString());
                Process.Start("explorer", comm.ExecuteScalar().ToString());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SQLiteCommand comm = DB.CreateCommand();
            Ping ping = new Ping();
            listBox1.Items.Clear();

            foreach (var item in lbRDP.Items)
            {
                
                comm.CommandText = "select Name from ServiceRDP where Title like '" + item.ToString() + "'";
                string str = comm.ExecuteScalar().ToString();
                PingReply pingReply = ping.Send(str, 64);
                if (pingReply.Status.ToString() != "Success") listBox1.Items.Insert(listBox1.Items.Count, ".!.");
                else listBox1.Items.Insert(listBox1.Items.Count, pingReply.RoundtripTime.ToString());
            }

            //for (int i = 0; i < lbRDP.Items.Count; i++)
            //{
            //    string str = null;
            //    str = lbRDP.Items.IndexOf[i];

            //    PingReply pingReply = ping.Send(str, 64);
            //}
            //PingReply pingReply = ping.Send("ya.ru", 64);
            //MessageBox.Show(pingReply.Status.ToString() + " " + pingReply.RoundtripTime.ToString(), "Test_ping", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void RefreshDBGrid()
        {
            var sqlCommand = new SQLiteCommand();
            if (chckbMyRequest.Checked) sqlCommand = new SQLiteCommand("select * from RequestList where User like '" + Environment.UserName + "'", DB);
            else sqlCommand = new SQLiteCommand("select * from RequestList", DB);
            sqlCommand.ExecuteNonQuery();

            var dataTable = new DataTable("RequestList");
            var sqlAdapter = new SQLiteDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataTable);

            dgvRequest.DataSource = dataTable.DefaultView;
            sqlAdapter.Update(dataTable);

            lblQuantity.Text = "Количество заявок: " + dgvRequest.Rows.Count.ToString();

            dgvRequest.Columns["id"].Visible = false;
            //Переименовка колонок в DataGridView
            dgvRequest.Columns["Value"].HeaderText = "Заявки";
            dgvRequest.Columns["User"].HeaderText = "Пользователь";
            dgvRequest.Columns["DateCreate"].HeaderText = "Добавлена";
            dgvRequest.Columns["DateUse"].HeaderText = "Использована";

            //Длина колонок в DataGridView
            dgvRequest.Columns[1].Width = dgvRequest.Width - 100 - 111 - 111 - 20;
            dgvRequest.Columns[2].Width = 100;
            dgvRequest.Columns[3].Width = 111;
            dgvRequest.Columns[4].Width = 111;

            dgvRequest.ClearSelection();
        }

        public void RefreshDBPrinters()
        {
            
            var sqlCommand = new SQLiteCommand("select * from Printers", DB);
            sqlCommand.ExecuteNonQuery();

            var dataTable = new DataTable("Printers");
            var sqlAdapter = new SQLiteDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataTable);

            dgvPrinters.DataSource = dataTable.DefaultView;
            sqlAdapter.Update(dataTable);

            dgvPrinters.Columns["id"].Visible = false;
            //Переименовка колонок в DataGridView
            dgvPrinters.Columns["Name"].HeaderText = "Наименование";
            dgvPrinters.Columns["NetName"].HeaderText = "Сет. имя";
            dgvPrinters.Columns["Location"].HeaderText = "Расположение";
            dgvPrinters.Columns["InvNumber"].HeaderText = "Инвентарный";

            //Длина колонок в DataGridView
            dgvPrinters.Columns[1].Width = dgvPrinters.Width - 87 - 91 - 82 - 20;
            dgvPrinters.Columns[2].Width = 87;
            dgvPrinters.Columns[3].Width = 91;
            dgvPrinters.Columns[4].Width = 82;

            dgvPrinters.ClearSelection();
        }

        private void ToolStripDBList_Click(object sender, EventArgs e)
        {
            RefreshDBGrid();
            lblUserRequest.Text = Environment.UserName;

            PanVis();
            panRequest.Visible = true;

            dgvRequest.ClearSelection();
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            if (tbAddRequest.Text == "")
            {
                MessageBox.Show("Что будем добавлять?", "Не заполнил!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UseDB usedb = new UseDB("RequestList", "Value", "User", "DateCreate", tbAddRequest.Text, Environment.UserName, DateTime.Now.ToString());
                usedb.InsertDB();

                RefreshDBGrid();
                tbAddRequest.Clear();
            }
        }

        private void dgvRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                tbAddRequest.Text = dgvRequest.SelectedCells[1].Value.ToString();
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
                    UseDB usedb = new UseDB("RequestList", "id", strId);
                    usedb.DeleteDB();
                    dgvRequest.Rows.RemoveAt(dgvRequest.CurrentRow.Index); //удаляет строку из DataGridView
                    lblQuantity.Text = "Количество заявок: " + dgvRequest.Rows.Count.ToString(); // -1 заявка в lbl после удаления из dgv
                }
            }
        }

        private void dgvRequest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRequest.SelectedRows.Count > 0) btnAddRequestBuffer.PerformClick();
        }

        private void tmrRequest_Tick(object sender, EventArgs e)
        {
            lblInfoRequest.Text = "";
            lblAddRequestDB.Text = "";
            lblPrintBuffer.Text = "";
            lblPR.Text = "";
            tmrComm5555.Enabled = false;
        }

        private void tbAddRequest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) //проверяем нажат ли Enter,
                btnAddRequest.PerformClick(); //если да, то жмем кнопку Добавить
        }

        private void dgvRequest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete) //проверяем нажат ли Del,
                btnRemoveRequest.PerformClick(); //если да, то жмем кнопку Удалить

            if (e.KeyData == Keys.Enter) //проверяем нажат ли Enter,
                btnAddRequestBuffer.PerformClick(); //если да, то жмем кнопку Добавления в буфер
        }

        private void toolStripReqOne_Click(object sender, EventArgs e)
        {
            PanVis();
            panAddRequest.Visible = true;
        }

        private void btnAddRequestDB_Click(object sender, EventArgs e)
        {
            if (lbProgList.SelectedItem != null && tbAddFIORequest.Text != "" && tbAddFIORequest.ForeColor != Color.Gray)
            {
                tmrComm5555.Enabled = false;
            
                string str = null;

                if (rdbtnAddRequest1.Checked) str = "Установить ";
                if (rdbtnAddRequest2.Checked) str = "Переустановить ";
                if (rdbtnAddRequest3.Checked) str = "Обновить ";
                if (rdbtnAddRequest4.Checked) str = "Настроить ";

                str += lbProgList.SelectedItem + ". " + tbAddFIORequest.Text;

                UseDB usedb = new UseDB("RequestList", "Value", "User", "DateCreate", str, Environment.UserName, DateTime.Now.ToString());
                usedb.InsertDB();

                lblAddRequestDB.Text = "Улетело в БД:\n"+str;
                tmrComm5555.Enabled = true;
            }
            else MessageBox.Show("Что ты упустил?", "IQ тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnAddProg_Click(object sender, EventArgs e)
        {
            if ((tbAddProg.Text == "") || (tbAddProg.ForeColor == Color.Gray))
            {
                MessageBox.Show("Такого ПО не существует!", "Вбей ПО'шечку", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UseDB usedb = new UseDB("ProgList", "Name", tbAddProg.Text);
                usedb.InsertDB();
                lbProgList.Items.Add(tbAddProg.Text);
                tbAddProg.Clear();
            }
        }

        private void btnRemoveProg_Click(object sender, EventArgs e)
        {
            if (lbProgList.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Удалить запись '" + lbProgList.SelectedItem + "'?", "Ты уверен?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    UseDB usedb = new UseDB("ProgList", "Name", lbProgList.SelectedItem.ToString());
                    usedb.DeleteDB();
                    lbProgList.Items.RemoveAt(lbProgList.SelectedIndex);
                }
            }
            else MessageBox.Show("Шо те нада?", "Ну и дурак...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RefreshProgList()
        {
            lbProgList.Items.Clear();

            UseDB usedb = new UseDB("ProgList", "Name");
            SQLiteDataReader rdp = usedb.SelectDB();

            while (rdp.Read()) //цикл перебора результатов кода БД
            {
                lbProgList.Items.Add(rdp["Name"]); //запись столбца БД в listbox
            }
        }

        private void lbProgList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete) //проверяем нажат ли Del,
                btnRemoveProg.PerformClick(); //если да, то жмем кнопку Удалить
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

        private void tbAddFIORequest_Leave(object sender, EventArgs e)
        {
            if (tbAddFIORequest.Text == "")
            {
                tbAddFIORequest.Text = "ФИО и любая другая инфа";
                tbAddFIORequest.ForeColor = Color.Gray;
            }
        }

        private void tbAddFIORequest_Enter(object sender, EventArgs e)
        {
            if (tbAddFIORequest.ForeColor == Color.Gray)
            {
                tbAddFIORequest.ForeColor = Color.Black;
                tbAddFIORequest.Text = "";
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

                UseDB usedb = new UseDB("RequestList", "Value", "DateUse", strRequest, DateTime.Now.ToString());
                usedb.UpdateDB();

                dgvRequest.SelectedCells[4].Value = DateTime.Now.ToString(); //запись даты в ячейку "DataUse"

                if (chckbRemoveRequest.Checked)
                {
                    usedb = new UseDB("RequestList", "Value", strRequest);
                    usedb.DeleteDB();
                    dgvRequest.Rows.RemoveAt(dgvRequest.CurrentRow.Index); //удаляет строку из DataGridView
                    lblQuantity.Text = "Количество заявок: " + dgvRequest.Rows.Count.ToString(); // -1 заявка в lbl после удаления из dgv
                }
            }
        }

        private void btnPrintAdd_Click(object sender, EventArgs e)
        {
            if (tbPrintName.Text == "")
            {
                MessageBox.Show("Что забыл?", "Атата...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UseDB usedb = new UseDB("Printers", "Name", "NetName", "Location", "InvNumber", tbPrintName.Text, tbPrintNetName.Text, tbPrintLocation.Text, tbPrintInvNumber.Text);
                usedb.InsertDB();
                RefreshDBPrinters();
                ClearPrintTB();
            }
        }

        private void SaveFormPosition()
        {
            RegistryKey formPos = Registry.CurrentUser.CreateSubKey("All in One");

            if (Registry.CurrentUser.OpenSubKey(@"All in One") == null) //проверяем наличие раздела в реестре. если отсутствует раздел, то создаем
                formPos.CreateSubKey("All in One");

            formPos.SetValue("PositionX", Location.X);
            formPos.SetValue("PositionY", Location.Y);
        }

        private void LoadFormPosition()
        {
            RegistryKey formPos = Registry.CurrentUser.CreateSubKey("All in One");
            Location = new Point(Convert.ToInt32(formPos.GetValue("PositionX", Location.X)), 
                Convert.ToInt32(formPos.GetValue("PositionY", Location.Y)));   //загрузить позицию формы из реестра
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

        private void chckbMyRequest_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDBGrid();
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
                    UseDB usedb = new UseDB("Printers", "Id", strId);
                    usedb.DeleteDB();
                    dgvPrinters.Rows.RemoveAt(dgvPrinters.CurrentRow.Index); //удаляет строку из DataGridView
                    ClearPrintTB();
                }
            }
        }

        private void dgvPrinters_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete) //проверяем нажат ли Del,
                btnPrintRemove.PerformClick(); //если да, то жмем кнопку Удалить
        }

        private void dgvPrinters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbPrintName.Text = dgvPrinters.SelectedCells[1].Value.ToString();
                tbPrintNetName.Text = dgvPrinters.SelectedCells[2].Value.ToString();
                tbPrintLocation.Text = dgvPrinters.SelectedCells[3].Value.ToString();
                tbPrintInvNumber.Text = dgvPrinters.SelectedCells[4].Value.ToString();
            }
        }

        private void chckbServiceSorted_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (chckbServiceSorted.Checked)
            {
                lbRDP.Sorted = true;
                lbShare.Sorted = true;
            }
            else
            {
                lbRDP.Sorted = false;
                lbShare.Sorted = false;
            }
            RefreshLBRDP();
            RefreshLBShare();
        }

        private void btnCartPaper_Click(object sender, EventArgs e)
        {
            RequestPrinters form = new RequestPrinters();
            form.ShowDialog();
        }

        private void toolStripReqOS_Click(object sender, EventArgs e)
        {
            PanVis();
            reOS.Visible = true;
        }

        private void reOS_VisibleChanged(object sender, EventArgs e)
        {
            if (reOS.Visible)
            {
                ReinstallOS reOS = new ReinstallOS();
                UseDB usedb = new UseDB("ReinstallOS", "Prog");
                this.reOS.lbProgList.Items.Clear();
                SQLiteDataReader val = usedb.SelectDB();
                while (val.Read()) //цикл перебора результатов кода БД
                {
                    this.reOS.lbProgList.Items.Add(val["Prog"]); //запись столбца БД в listbox
                }
            }
        }

        private void ClearPrintTB()
        {
            tbPrintName.Clear();
            tbPrintNetName.Clear();
            tbPrintLocation.Clear();
            tbPrintInvNumber.Clear();
        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(result3, new Font("Arial", 12), Brushes.Black, 20, 20);
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
    }
}