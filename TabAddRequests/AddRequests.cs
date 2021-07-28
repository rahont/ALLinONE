using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLinONE.TabAddRequests
{
    public partial class AddRequests : UserControl
    {
        public AddRequests()
        {
            InitializeComponent();
        }

        private void btnCartPaper_Click(object sender, EventArgs e)
        {
            RequestPrinters form = new RequestPrinters();
            form.ShowDialog();
        }

        private void btnMassRequest_Click(object sender, EventArgs e)
        {
            MassRequest form = new MassRequest();
            form.ShowDialog();
            form.Close();
        }

        private void btnRemoveProg_Click(object sender, EventArgs e)
        {
            if (lbProgList.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Удалить запись '" + lbProgList.SelectedItem + "'?", "Ты уверен?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    UseDB.DeleteDB("ProgList", "Name", lbProgList.SelectedItem.ToString());
                    lbProgList.Items.RemoveAt(lbProgList.SelectedIndex);
                }
            }
            else MessageBox.Show("Шо те нада?", "Ну и дурак...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tbAddProg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) //проверяем нажат ли Enter,
                btnAddProg.PerformClick(); //если да, то жмем кнопку Добавить
        }

        private void btnAddProg_Click(object sender, EventArgs e)
        {
            if (tbAddProg.Text == "")
            {
                MessageBox.Show("Такого ПО не существует!", "Вбей ПО'шечку", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UseDB.InsertDB("ProgList", "Name", tbAddProg.Text);
                lbProgList.Items.Add(tbAddProg.Text);
                tbAddProg.Text = null;
            }
        }

        private void lbProgList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete) //проверяем нажат ли Del,
                btnRemoveProg.PerformClick(); //если да, то жмем кнопку Удалить

            if (e.KeyData == Keys.Enter)
                btnAddRequestDB.PerformClick();
        }

        private async void btnAddRequestDB_Click(object sender, EventArgs e)
        {
            if (lbProgList.SelectedItem != null && tbAddFIORequest.Text != "")
            {
                string str = null;

                if (rdbtnAddRequest1.Checked) str = "Установить ";
                if (rdbtnAddRequest2.Checked) str = "Переустановить ";
                if (rdbtnAddRequest3.Checked) str = "Обновить ";
                if (rdbtnAddRequest4.Checked) str = "Настроить ";
                if (rdbtnAddRequest5.Checked) str = "Удалить ";

                str += lbProgList.SelectedItem + ". " + tbAddFIORequest.Text;

                UseDB.InsertDB("RequestList", "Prefix", "Value", "User", "DateCreate", Properties.Settings.Default.prefixRequest, str, Environment.UserName, DateTime.Now.ToString());

                lblAddRequestDB.Text = "Улетело в БД:\n" + str;
                
                await Task.Delay(Properties.Settings.Default.timeClean);
                lblAddRequestDB.Text = string.Empty;
            }
            else MessageBox.Show("Что ты упустил?", "IQ тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tbAddFIORequest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) //проверяем нажат ли Enter,
                btnAddRequestDB.PerformClick(); //если да, то жмем кнопку Добавить
        }

        private void AddRequests_Load(object sender, EventArgs e)
        {
            MethodsAddRequests mar = new MethodsAddRequests();
            mar.RefreshProgList(lbProgList);
        }
    }
}
