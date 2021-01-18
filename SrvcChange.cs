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
        UseDB usedb = new UseDB();

        public SrvcChange()
        {
            InitializeComponent();
        }

        private void BtnRDPAdd_Click(object sender, EventArgs e)
        {
            if (tbRDPName.Text == "" || tbRDPTitle.Text == "")
                MessageBox.Show("Заполни все поля под колонкой RDP!", "Не заполнил!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                usedb.InsertDB("ServiceRDP", "Name", "Title", tbRDPName.Text, tbRDPTitle.Text);

                tbRDPName.Text = null;
                tbRDPTitle.Text = null;

                RefreshLBRDP();
            }
        }

        private void BtnShareAdd_Click(object sender, EventArgs e)
        {
            if (tbShareName.Text == "" || tbShareTitle.Text == "")
                MessageBox.Show("Заполни все поля под колонкой Share!", "Не заполнил!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string str = null;
                if (tbShareName.TextLength > 1)
                {
                    string checkSimb = tbShareName.Text.Substring(0, 2); //записать в переменную первые 2 символа
                    if (checkSimb != @"\\") str = @"\\"; //проверяем первые 2 символа, если это не \\, то записать в переменную \\
                }

                usedb.InsertDB("ServiceShare", "Name", "Title", str + tbShareName.Text, tbShareTitle.Text);

                tbShareName.Text = null;
                tbShareTitle.Text = null;

                RefreshLBShare();
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
                    usedb.InsertDB("PingList", "Name", "Title", tbPingName.Text, tbPingTitle.Text);

                    tbPingName.Text = null;
                    tbPingTitle.Text = null;

                    RefreshLBPing();
                }
            }
        }

        private void SrvcChange_Load(object sender, EventArgs e)
        {
            RefreshLBRDP();
            RefreshLBShare();
            RefreshLBPing();
        }

        private void RefreshLBRDP()
        {
            lbRDP.Items.Clear();

            foreach (var item in usedb.SelectDB("ServiceRDP", "Title"))
            {
                lbRDP.Items.Add(item);
            }

            usedb.connectDB.Close();
        }

        private void RefreshLBShare()
        {
            lbShare.Items.Clear();

            foreach (var item in usedb.SelectDB("ServiceShare", "Title"))
            {
                lbShare.Items.Add(item);
            }
        }

        public void RefreshLBPing()
        {
            lbPing.Items.Clear();

            foreach (var item in usedb.SelectDB("PingList", "Title"))
            {
                lbPing.Items.Add(item);
            }
        }

        private void BtnRDPRmv_Click(object sender, EventArgs e)
        {
            if (lbRDP.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Удалить запись '" + lbRDP.SelectedItem + "'?", "Ты уверен?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    usedb.DeleteDB("ServiceRDP", "Title", lbRDP.SelectedItem.ToString());

                    RefreshLBRDP();
                }
            }
            else MessageBox.Show("Шо те нада?", "Ну и дурак...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnShareRmv_Click(object sender, EventArgs e)
        {
            if (lbShare.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Удалить запись '" + lbShare.SelectedItem + "'?", "Ты уверен?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    usedb.DeleteDB("ServiceShare", "Title", lbShare.SelectedItem.ToString());

                    RefreshLBShare();
                }
            }
            else MessageBox.Show("Шо те нада?", "Ну и дурак...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SrvcChange_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MainForm main = this.Owner as MainForm;
            MainForm main = new MainForm();
            //if (main != null)
            //{
                main.RefreshLBRDP();
                main.RefreshLBShare();
            //}
        }

        private void tbRDPName_Click(object sender, EventArgs e)
        {
            //TextBox tb = (TextBox)sender;
            //if (tb.Text == "Адрес" || tb.Text == "Наименование")
            //{
            //    tb.Text = "";
            //    tb.ForeColor = Color.Black;
            //}
        }

        private void tbRDPName_Leave(object sender, EventArgs e)
        {
            //TextBox tb = (TextBox)sender;
            //if (tb.Text == "")
            //{ 
            //    if (tb.Name.Contains("Name")) tb.Text = "Адрес";    //ищем в имени tb "Name", если находим, то вписываем "Адрес"
            //    else tb.Text = "Наименование";  //если не находим, то вписываем другой вариант
            //    tb.ForeColor = Color.Gray;
            //}
        }

        private void btnPingRmv_Click(object sender, EventArgs e)
        {
            if (lbPing.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Удалить запись '" + lbPing.SelectedItem + "'?", "Ты уверен?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    usedb.DeleteDB("PingList", "Title", lbPing.SelectedItem.ToString());

                    RefreshLBPing();
                }
            }
            else MessageBox.Show("Шо те нада?", "Ну и дурак...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}