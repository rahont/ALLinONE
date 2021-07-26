using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLinONE.TabPrinters
{
    class MethodsPrinters
    {
        public void RefreshPrinters(DataGridView dgvPrinters)
        {
            //Заполняем dgv
            dgvPrinters.DataSource = UseDB.SelectAllDB("Printers");

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

        public void ClearPrintTB(
            TextBox tbPrintName, TextBox tbPrintNetName, TextBox tbPrintLocation, TextBox tbPrintInvNumber)
        {
            tbPrintName.Clear();
            tbPrintNetName.Clear();
            tbPrintLocation.Clear();
            tbPrintInvNumber.Clear();
        }
    }
}
