using System;
using System.Windows.Forms;

namespace ALLinONE
{
    public partial class ToDoList : Form
    {
        public static bool FormOpenClose { get; set; }

        public ToDoList()
        {
            InitializeComponent();
        }

        private void ToDoList_Load(object sender, EventArgs e)
        {
            FormOpenClose = true;
            SetupDGV();
            RefreshList();
        }

        private void ToDoList_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormOpenClose = false;
        }

        private void dgvList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete) //проверяем нажат ли Del,
                btnRemove.PerformClick(); //если да, то жмем кнопку Удалить
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
                    UseDB.DeleteDB("ToDo", "id", strId);
                    dgvList.Rows.RemoveAt(dgvList.CurrentRow.Index); //удаляет строку из DataGridView
                    //lblQuantity.Text = "Количество заявок: " + dgvRequest.Rows.Count.ToString(); // -1 заявка в lbl после удаления из dgv
                }
            }
        }

        private void tbValue_KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) //проверяем нажат ли Enter,
                btnAdd.PerformClick(); //если да, то жмем кнопку Добавить
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbValue.Text == string.Empty)
            {
                MessageBox.Show("Что будем добавлять?", "Не заполнил!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string[] str = {null, tbValue.Text, DateTime.Now.ToString()};
                UseDB.InsertDB("ToDo", "Value", "Date", str[1], str[2]);
                //UseDB.InsertDB("ToDo", "Value", "Date", tbValue.Text, DateTime.Now.ToString());

                dgvList.Rows.Add(str);
                //RefreshList();
                tbValue.Text = null;
            }
        }

        private void SetupDGV()
        {
            //Создаем столбцы
            dgvList.ColumnCount = 3;
            dgvList.Columns[0].Name = "id";
            dgvList.Columns[1].Name = "Value";
            dgvList.Columns[2].Name = "Date";

            //Переименовка столбцов
            dgvList.Columns["Value"].HeaderText = "ТуДуШеЧКА";
            dgvList.Columns["Date"].HeaderText = "Добавлена";

            dgvList.Columns["id"].Visible = false;
            //Длина столбцов
            dgvList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //Автоподстройка длины столбца
            dgvList.Columns[2].Width = 110;
        }

        private void RefreshList()
        {
            dgvList.Rows.Clear();

            //Определяем количество строк в таблице
            int tmp = 0;
            foreach (var item in UseDB.SelectDB("ToDo", "id"))
                tmp++;

            //Проверка на наличие строк
            if (tmp > 0)
            {
                //Создание необходимого количества строк в DataGridView
                dgvList.Rows.Add(tmp);

                //Заполняем DataGridView
                for (int i = 0; i < 3; i++) //Столбцы
                {
                    //Массив столбца
                    string[] str = UseDB.SelectDB("ToDo", dgvList.Columns[i].Name);

                    for (int x = 0; x < tmp; x++) //Строки
                        dgvList.Rows[x].Cells[dgvList.Columns[i].Name].Value = str[x]; //Заполнение ячеек
                }
            }
            
            dgvList.ClearSelection();
        }

        private void btnRefreshDGV_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "ToDo_" + DateTime.Now.ToString().Replace(':', '-'); //Имя файла

            if (dgvList.Rows.Count <= 0) //Проверка на наличие строк в DGV
                MessageBox.Show("Выгружать нечего", "Пусто", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (saveFileDialog.ShowDialog() == DialogResult.OK) //Проверка на нажатие ОК
                AiOMethods.SaveExcel(dgvList, saveFileDialog.FileName);
        }
    }
}