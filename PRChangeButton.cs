using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ALLinONE
{
    public partial class PRChangeButton : Form
    {
        public SQLiteConnection DB; //БД

        public PRChangeButton()
        {
            InitializeComponent();
            DB = new SQLiteConnection("Data Source=Data_DB.db; Version=3"); //БД подключение
            DB.Open(); //открыть БД
        }

        private void RefreshLBList()
        {
            lbList.Items.Clear();

            SQLiteCommand comm = DB.CreateCommand(); //переменная БД
            comm.CommandText = "select btn_title from ProfRab"; //код БД в переменную
            SQLiteDataReader com = comm.ExecuteReader(); //результат кода в переменную
            while (com.Read()) //цикл перебора результатов кода БД
            {
                lbList.Items.Add(com["btn_title"]); //запись столбца БД в listbox
            }
        }

        private void LbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbName.Enabled = true;
            tbValue.Enabled = true;

            string str = lbList.SelectedItem.ToString();

            SQLiteCommand comm = DB.CreateCommand(); //переменная БД
            comm.CommandText = "select btn_title from ProfRab where btn_title like '" + str + "'"; //код БД в переменную
            tbName.Text = comm.ExecuteScalar().ToString(); //результат кода в textbox

            comm.CommandText = "select btn_value from ProfRab where btn_title like '" + str + "'"; //код БД в переменную
            tbValue.Text = comm.ExecuteScalar().ToString(); //результат кода в textbox
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (lbList.SelectedItem != null)
            {
                string str = lbList.SelectedItem.ToString();
                bool test = false;

                SQLiteCommand comm = DB.CreateCommand(); //переменная БД
                comm.CommandText = "select btn_title from ProfRab";//код БД в переменную
                SQLiteDataReader rdr = comm.ExecuteReader();
                while (rdr.Read())
                {
                    if (tbName.Text == rdr["btn_title"].ToString()) test = true;
                }
                rdr.Close();
                if (test == true && tbName.Text != str)
                {
                    MessageBox.Show("У тебя фантазии нет? Придумай что-то новенькое.", "ЛЕТСДУИТ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbName.Text = str;
                }
                else
                {
                    comm.CommandText = "update ProfRab set btn_title = '" + tbName.Text + "' where btn_title like '" + str + "'"; //код БД в переменную
                    comm.ExecuteNonQuery();
                    comm.CommandText = "update ProfRab set btn_value = '" + tbValue.Text + "' where btn_title like '" + tbName.Text + "'";
                    comm.ExecuteNonQuery();

                    tmrComm3333.Enabled = false;
                    tmrComm3333.Enabled = true;
                    lblSave.Visible = true;
                }

                RefreshLBList();
                lbList.SelectedItem = tbName.Text;
            }
            else MessageBox.Show("Что ты пытаешься сохранить? Ты ни чего не выбрал!", "Ну и дурак...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (lbList.SelectedItem != null)
            {
                string str = lbList.SelectedItem.ToString();
                SQLiteCommand comm = DB.CreateCommand(); //переменная БД

                comm.CommandText = "select id from ProfRab where btn_title like '" + str + "'";
                string id = comm.ExecuteScalar().ToString();

                comm.CommandText = "update ProfRab set btn_title = 'Проф " + id + "' where id like '" + id + "'";//код БД в переменную
                comm.ExecuteNonQuery();
                comm.CommandText = "update ProfRab set btn_value = '\\_(ツ)_/ -ать' where id like '" + id + "'";//код БД в переменную
                comm.ExecuteNonQuery();

                RefreshLBList();
                lbList.SelectedItem = "Проф " + id;

                tmrComm3333.Enabled = false;
                tmrComm3333.Enabled = true;
                lblSave.Visible = true;
            }
            else MessageBox.Show("Отчисти сначала свою голову, а потом попробуй снова...", "Ну и дурак...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tmrComm3333_Tick(object sender, EventArgs e)
        {
            lblSave.Visible = false;
            tmrComm3333.Enabled = false;
        }

        private void PRChangeButton_Load(object sender, EventArgs e)
        {
            RefreshLBList();
        }

        private void PRChangeButton_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            if (main != null) main.Refresh_btnPR();
        }
    }
}