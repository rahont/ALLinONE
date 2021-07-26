using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLinONE.TabRequests
{
    class MethodsRequests
    {
        public void RefreshRequestsList(DataGridView dgvRequest, Label lblQuantity, CheckBox chkbPrefixShow)
        {
            //Заполняем dgv
            dgvRequest.DataSource = UseDB.SelectAllDB("RequestList");

            lblQuantity.Text = "Количество заявок: " + dgvRequest.Rows.Count.ToString();

            dgvRequest.Columns["id"].Visible = false;
            dgvRequest.Columns["Prefix"].Visible = chkbPrefixShow.Checked;
            //Переименовка колонок в DataGridView
            dgvRequest.Columns["Prefix"].HeaderText = "Префикс";
            dgvRequest.Columns["Value"].HeaderText = "Заявки";
            dgvRequest.Columns["User"].HeaderText = "Пользователь";
            dgvRequest.Columns["DateCreate"].HeaderText = "Добавлена";

            //Длина колонок в DataGridView
            dgvRequest.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //Автоподстройка длины столбца
            dgvRequest.Columns[3].Width = 100;
            dgvRequest.Columns[4].Width = 111;

            dgvRequest.ClearSelection();
        }
    }
}
