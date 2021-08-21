using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLinONE
{
    public partial class MassRequest : Form
    {
        public MassRequest()
        {
            InitializeComponent();
        }

        private void RefreshListProg()
        {
            lbProgList.Items.Clear();
            foreach (var item in UseDB.SelectDB("ReinstallOS", "Prog"))
                lbProgList.Items.Add(item);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbAddProg.Text == "" || tbAddProg.Text == "Наименование")
            {
                MessageBox.Show("Мозга себе добавь...", "???", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UseDB.InsertDB("ReinstallOS", "Prog", tbAddProg.Text);
                RefreshListProg();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbProgList.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Удалить запись '" + lbProgList.SelectedItem + "'?", "Ты уверен?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    UseDB.DeleteDB("ReinstallOS", "Prog", lbProgList.SelectedItem.ToString());
                    RefreshListProg();
                }
            }
            else MessageBox.Show("Шо те нада?", "Ну и дурак...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lbProgList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete) //проверяем нажат ли Del,
                btnRemove.PerformClick(); //если да, то жмем кнопку Удалить
        }

        private void tbAddProg_KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) //проверяем нажат ли Del,
                btnAdd.PerformClick(); //если да, то жмем кнопку Удалить
        }

        private void btnResetProgList_Click(object sender, EventArgs e)
        {
            RefreshListProg();
        }

        private void lbProgList_DoubleClick(object sender, EventArgs e)
        {
            lbProgList.Items.Remove(lbProgList.SelectedItem);
        }

        private void chckbListSort_CheckedChanged(object sender, EventArgs e)
        {
            lbProgList.Items.Clear();
            lbProgList.Sorted = chckbListSort.Checked; //Условие
            RefreshListProg();
        }

        private void btnAddDB_Click(object sender, EventArgs e)
        {
            if (tbFIO.Text == "")
                MessageBox.Show("На кого оформляем?", "СберБанка", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else
            {
                foreach (var item in lbProgList.Items)
                {
                    string result = item.ToString() + ". " + tbFIO.Text;

                    UseDB.InsertDB("RequestList", "Prefix", "Value", "User", "DateCreate", AiOMethods.LoadFromRegistry("Prefix", "").ToString(), result, Environment.UserName, DateTime.Now.ToString());
                }
                tbFIO.Text = "";
                lblValue.Text = "Заявки (" + lbProgList.Items.Count + "шт.) улетели в БД";
                tmr3333.Enabled = false;
                tmr3333.Enabled = true;
            }
        }

        private void tmr3333_Tick(object sender, EventArgs e)
        {
            lblValue.Text = "";
            tmr3333.Enabled = false;
        }

        private void tbFIO_KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                btnAddDB.PerformClick();
        }

        private void MassRequest_Load(object sender, EventArgs e)
        {
            RefreshListProg();
        }
    }
}
