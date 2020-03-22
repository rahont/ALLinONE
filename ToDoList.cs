using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ALLinONE
{
    public partial class ToDoList : UserControl
    {
        public SQLiteConnection DB;

        public ToDoList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbValue.Text == "")
            {
                MessageBox.Show("Что будем добавлять?", "Не заполнил!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UseDB usedb = new UseDB("ToDo", "Value", "Date", tbValue.Text, DateTime.Now.ToString());
                usedb.InsertDB();

                RefreshList();
                tbValue.Clear();
            }
        }

        private void RefreshList()
        {
            MainForm mf = new MainForm();

            var sqlCommand = new SQLiteCommand("select * from ToDo", mf.DB);
            sqlCommand.ExecuteNonQuery();

            var dataTable = new DataTable("ToDo");
            var sqlAdapter = new SQLiteDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataTable);

            dgvList.DataSource = dataTable.DefaultView;
            sqlAdapter.Update(dataTable);

            //lblQuantity.Text = "Количество заявок: " + dgvRequest.Rows.Count.ToString();

            dgvList.Columns["id"].Visible = false;
            //Переименовка колонок в DataGridView
            dgvList.Columns["Value"].HeaderText = "ТуДу";
            dgvList.Columns["Date"].HeaderText = "Добавлена";

            //Длина колонок в DataGridView
            dgvList.Columns[1].Width = dgvList.Width - 110 - 20;
            dgvList.Columns[2].Width = 110;

            dgvList.ClearSelection();
        }

        private void ToDoList_Load(object sender, EventArgs e)
        {
            //DB = new SQLiteConnection("Data Source=Data_DB.db; Version=3"); //БД
            //DB.Open();

            //RefreshList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Кого кикаем?", "Упс", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string strId = dgvList.SelectedCells[0].Value.ToString();
                string strValue = dgvList.SelectedCells[1].Value.ToString();
                string strDate = dgvList.SelectedCells[2].Value.ToString();

                DialogResult result = MessageBox.Show
                    ("Удалить запись?\n\n" +
                        "'" + strValue + "'\n\n" +
                            "Созданная: " + "'" + strDate + "'",
                    "Ты уверен?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    UseDB usedb = new UseDB("ToDo", "id", strId);
                    usedb.DeleteDB();
                    dgvList.Rows.RemoveAt(dgvList.CurrentRow.Index); //удаляет строку из DataGridView
                    //lblQuantity.Text = "Количество заявок: " + dgvRequest.Rows.Count.ToString(); // -1 заявка в lbl после удаления из dgv
                }
            }
        }

        private void tbValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) //проверяем нажат ли Enter,
                btnAdd.PerformClick(); //если да, то жмем кнопку Добавить
        }

        private void dgvList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete) //проверяем нажат ли Del,
                btnRemove.PerformClick(); //если да, то жмем кнопку Добавить
        }
    }
}
