using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLinONE.TabRequests
{
    public partial class Requests : UserControl
    {
        public Requests()
        {
            InitializeComponent();
        }

        private void dgvRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbAddRequest.Text = e.RowIndex >= 0 ? dgvRequest.SelectedCells[2].Value.ToString() : string.Empty;
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

        private void tbPrefixRequest__TextChanged(object sender, EventArgs e)
        {
            //Сохраняем префикс в реестре
            AiOMethods.SaveInRegistry("Prefix", tbPrefixRequest.Text);
        }

        private void tbAddRequest_KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnAddRequest.PerformClick();
        }

        private void chkbPrefixShow_CheckedChanged(object sender, EventArgs e)
        {
            dgvRequest.Columns["Prefix"].Visible = (chkbPrefixShow.Checked);
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            if (tbAddRequest.Text == "")
            {
                MessageBox.Show("Что будем добавлять?", "Не заполнил!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UseDB.InsertDB("RequestList", "Prefix", "Value", "User", "DateCreate", tbPrefixRequest.Text, tbAddRequest.Text, Environment.UserName, DateTime.Now.ToString());

                MethodsRequests mr = new MethodsRequests();
                mr.RefreshRequestsList(dgvRequest, lblQuantity, chkbPrefixShow);
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

        private async void  btnAddRequestBuffer_Click(object sender, EventArgs e)
        {
            if (dgvRequest.SelectedRows.Count > 0)
            {
                string strRequest = dgvRequest.SelectedCells[1].Value.ToString();
                Clipboard.SetText(strRequest);
                lblInfoRequest.Text = "В буфер уехало:\n" + strRequest;

                UseDB.UpdateDB("RequestList", "Value", "DateUse", strRequest, DateTime.Now.ToString());

                dgvRequest.SelectedCells[4].Value = DateTime.Now.ToString(); //запись даты в ячейку "DataUse"

                if (chckbRemoveRequest.Checked)
                {
                    UseDB.DeleteDB("RequestList", "Value", strRequest);
                    dgvRequest.Rows.RemoveAt(dgvRequest.CurrentRow.Index); //удаляет строку из DataGridView
                    lblQuantity.Text = "Количество заявок: " + dgvRequest.Rows.Count.ToString(); // -1 заявка в lbl после удаления из dgv
                }

                await Task.Delay(Properties.Settings.Default.timeClean);
                lblInfoRequest.Text = string.Empty;
            }
        }

        private void btnClearAllRequest_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                    ("Почистить весь список с заявками?",
                    "Ты уверен?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //Проверяем наличие строк в Заявках
                if (dgvRequest.Rows.Count > 0)
                {
                    //Перебираем все строки в Заявках
                    while (dgvRequest.Rows.Count > 0)
                    {
                        UseDB.DeleteDB("RequestList", "Id", dgvRequest[0, 0].Value.ToString());
                        dgvRequest.Rows.RemoveAt(0);
                    }

                    lblQuantity.Text = "0";
                }
                else
                    MessageBox.Show("Там и так все пусто. Если мы будем тереть дальше, то протрем дырень...",
                    "А зачем?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Requests_Load(object sender, EventArgs e)
        {
            //Прячем бордер лейбла, иначе выглядит не оч.
            lblInfoRequest.BorderStyle = BorderStyle.None;

            //Заполняем dgv
            MethodsRequests mr = new MethodsRequests();
            mr.RefreshRequestsList(dgvRequest, lblQuantity, chkbPrefixShow);

            //Загружаем префикс из реестра
            tbPrefixRequest.Text = AiOMethods.LoadFromRegistry("Prefix", "").ToString();
        }

        private void btnSaveToExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "Список заявок " + DateTime.Now.Date.ToShortDateString();

            //Сохранение файла
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                AiOMethods.SaveExcel(dgvRequest, saveFileDialog.FileName);
            }
        }
    }
}