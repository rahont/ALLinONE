using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLinONE.TabPrinters
{
    public partial class Printers : UserControl
    {
        public Printers()
        {
            InitializeComponent();
        }

        private void Printers_Load(object sender, EventArgs e)
        {
            lblPrintBuffer.BorderStyle = BorderStyle.None;
            lblPrintBuffer.AutoSize = true;
            MethodsPrinters mp = new MethodsPrinters();
            mp.RefreshPrinters(dgvPrinters);
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

        private void dgvPrinters_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete) //проверяем нажат ли Del,
                btnPrintRemove.PerformClick(); //если да, то жмем кнопку Удалить
        }

        private async void tbPrintName_Click(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.TextLength > 0)
            {
                Clipboard.SetText(tb.Text);
                lblPrintBuffer.Text = "В буфер уехало: " + tb.Text;

                await Task.Delay(Properties.Settings.Default.timeClean);
                lblPrintBuffer.Text = string.Empty;
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
                UseDB.InsertDB("Printers", "Name", "NetName", "Location", "InvNumber", tbPrintName.Text, tbPrintNetName.Text, tbPrintLocation.Text, tbPrintInvNumber.Text);
                MethodsPrinters mp = new MethodsPrinters();
                mp.RefreshPrinters(dgvPrinters);
                mp.ClearPrintTB(tbPrintName, tbPrintNetName, tbPrintLocation, tbPrintInvNumber);
            }
        }

        private void btnPrintChange_Click(object sender, EventArgs e)
        {
            if (tbPrintName.TextLength > 0)
            {
                UseDB.UpdateDB("Printers", "Name", "id", tbPrintName.Text, dgvPrinters.SelectedCells[0].Value.ToString());
                UseDB.UpdateDB("Printers", "NetName", "id", tbPrintNetName.Text, dgvPrinters.SelectedCells[0].Value.ToString());
                UseDB.UpdateDB("Printers", "Location", "id", tbPrintLocation.Text, dgvPrinters.SelectedCells[0].Value.ToString());
                UseDB.UpdateDB("Printers", "InvNumber", "id", tbPrintInvNumber.Text, dgvPrinters.SelectedCells[0].Value.ToString());

                dgvPrinters.SelectedCells[1].Value = tbPrintName.Text;
                dgvPrinters.SelectedCells[2].Value = tbPrintNetName.Text;
                dgvPrinters.SelectedCells[3].Value = tbPrintLocation.Text;
                dgvPrinters.SelectedCells[4].Value = tbPrintInvNumber.Text;
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
                    MethodsPrinters mp = new MethodsPrinters();
                    mp.ClearPrintTB(tbPrintName, tbPrintNetName, tbPrintLocation, tbPrintInvNumber);
                }
            }
        }

        private void btnSaveToExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "Список принтеров " + DateTime.Now.Date.ToShortDateString();

            //Сохранение файла
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                AiOMethods.SaveExcel(dgvPrinters, saveFileDialog.FileName);
            }
        }
    }
}
