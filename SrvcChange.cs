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
    public partial class SrvcChange : Form
    {
        public SQLiteConnection DB; //БД
        public SrvcChange()
        {
            InitializeComponent();
            DB = new SQLiteConnection("Data Source=Data_DB.db; Version=3"); //БД подключение
            DB.Open(); //открыть БД
        }

        private void BtnRDPAdd_Click(object sender, EventArgs e)
        {
            if (tbRDPName.Text == "" || tbRDPTitle.Text == "" || tbRDPName.Text == "Адрес" || tbRDPTitle.Text == "Наименование")
            {
                MessageBox.Show("Заполни все поля под колонкой RDP!", "Не заполнил!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SQLiteCommand comm = DB.CreateCommand(); //переменная БД
                comm.CommandText = "insert into ServiceRDP(Name, Title) values('" + tbRDPName.Text + "', '" + tbRDPTitle.Text + "')"; //код БД в переменную
                comm.ExecuteNonQuery();

                tbRDPName.Text = "Адрес";
                tbRDPName.ForeColor = Color.Gray;
                tbRDPTitle.Text = "Наименование";
                tbRDPTitle.ForeColor = Color.Gray;

                RefreshLBRDP();
            }
        }

        private void BtnShareAdd_Click(object sender, EventArgs e)
        {
            if (tbShareName.Text == "" || tbShareTitle.Text == "")
                MessageBox.Show("Заполни все поля под колонкой Share!", "Не заполнил!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                string str = null;
                if (tbShareName.TextLength > 1)
                {
                    string checkSimb = tbShareName.Text.Substring(0, 2); //записать в переменную первые 2 символа
                    if (checkSimb != @"\\") str = @"\\"; //проверяем первые 2 символа, если это не \\, то записать в переменную \\
                }

                SQLiteCommand comm = DB.CreateCommand(); //переменная БД
                comm.CommandText = "insert into ServiceShare(Name, Title) values('" + str + tbShareName.Text + "', '" + tbShareTitle.Text + "')"; //код БД в переменную
                comm.ExecuteNonQuery();

                tbShareName.Text = "Адрес";
                tbShareName.ForeColor = Color.Gray;
                tbShareTitle.Text = "Наименование";
                tbShareTitle.ForeColor = Color.Gray;

                RefreshLBShare();
            }
        }

        private void SrvcChange_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("tadaaaaaaaa", "Не заполнил!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tbRDPName.ForeColor = Color.Gray;
            tbRDPTitle.ForeColor = Color.Gray;
            tbShareName.ForeColor = Color.Gray;
            tbShareTitle.ForeColor = Color.Gray;
            RefreshLBRDP();
            RefreshLBShare();
            RefreshLBPing();
        }

        private void RefreshLBRDP()
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

        private void RefreshLBShare()
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

        public void RefreshLBPing()
        {
            lbPing.Items.Clear();

            UseDB useDB = new UseDB("PingList", "Title");
            SQLiteDataReader ping = useDB.SelectDB();
            while (ping.Read()) //цикл перебора результатов кода БД
            {
                lbPing.Items.Add(ping["Title"]); //запись столбца БД в listbox
            }
        }

        private void BtnRDPRmv_Click(object sender, EventArgs e)
        {
            if (lbRDP.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Удалить запись '" + lbRDP.SelectedItem + "'?", "Ты уверен?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SQLiteCommand commRDP = DB.CreateCommand(); //переменная БД
                    commRDP.CommandText = "delete from ServiceRDP where Title like '" + lbRDP.SelectedItem.ToString() + "'"; //код БД в переменную
                    commRDP.ExecuteNonQuery();

                    RefreshLBRDP();
                }
            }
            else MessageBox.Show("Шо те нада?", "Ну и дурак...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnShareRmv_Click(object sender, EventArgs e)
        {
            if (lbShare.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Удалить запись '" + lbShare.SelectedItem + "'?", "Ты уверен?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SQLiteCommand commShare = DB.CreateCommand(); //переменная БД
                    commShare.CommandText = "delete from ServiceShare where Title like '" + lbShare.SelectedItem.ToString() + "'"; //код БД в переменную
                    commShare.ExecuteNonQuery();

                    RefreshLBShare();
                }
            }
            else MessageBox.Show("Шо те нада?", "Ну и дурак...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SrvcChange_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                main.RefreshLBRDP();
                main.RefreshLBShare();
            }
        }

        private void tbRDPName_Click(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Адрес" || tb.Text == "Наименование")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void tbRDPName_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            { 
                if (tb.Name.Contains("Name")) tb.Text = "Адрес";    //ищем в имени tb "Name", если находим, то вписываем "Адрес"
                else tb.Text = "Наименование";  //если не находим, то вписываем другой вариант
                tb.ForeColor = Color.Gray;
            }
        }

        private void btnPingAdd_Click(object sender, EventArgs e)
        {
            if (tbPingName.TextLength <= 0 || tbPingTitle.TextLength <= 0)
                MessageBox.Show("Заполни все поля под колонкой Ping!", "Не заполнил!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                bool available = false;
                foreach (var item in lbPing.Items)
                {
                    if (tbPingTitle.Text == item.ToString())
                    {
                        available = true;
                        MessageBox.Show("Такое название уже существует.", "Не плоди двойников", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (available == false)
                {
                    UseDB useDB = new UseDB("PingList", "Name", "Title", tbPingName.Text, tbPingTitle.Text);
                    useDB.InsertDB();

                    RefreshLBPing();
                }
            }
        }

        private void btnPingRmv_Click(object sender, EventArgs e)
        {
            if (lbPing.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Удалить запись '" + lbPing.SelectedItem + "'?", "Ты уверен?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    UseDB useDB = new UseDB("PingList", "Title", lbPing.SelectedItem.ToString());
                    useDB.DeleteDB();

                    RefreshLBPing();
                }
            }
            else MessageBox.Show("Шо те нада?", "Ну и дурак...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}