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
        readonly UseDB usedb = new UseDB();

        public PRChangeButton()
        {
            InitializeComponent();
        }

        private void RefreshLBList()
        {
            lbList.Items.Clear();

            foreach (var item in usedb.SelectDB("ProfRab", "btn_title"))
                lbList.Items.Add(item);
        }

        private void LbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbName.Enabled = true;
            tbValue.Enabled = true;

            string selectedItemLB = lbList.SelectedItem.ToString();

            tbName.Text = usedb.SelectDBLike("ProfRab", "btn_title", "btn_title", selectedItemLB);

            tbValue.Text = usedb.SelectDBLike("ProfRab", "btn_value", "btn_title", selectedItemLB);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (lbList.SelectedItem != null)
            {
                string selectedItemLB = lbList.SelectedItem.ToString();
                bool doubleCheckDB = false;

                //Проверка на наличие строки в БД
                foreach (var item in usedb.SelectDB("ProfRab", "btn_title"))
                    doubleCheckDB = (tbName.Text == item);

                if (doubleCheckDB == true && tbName.Text != selectedItemLB)
                {
                    MessageBox.Show("У тебя фантазии нет? Придумай что-то новенькое.", "ЛЕТСДУИТ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbName.Text = selectedItemLB;
                }
                else
                {
                    usedb.UpdateDB("ProfRab", "btn_title", "btn_title", tbName.Text, selectedItemLB);
                    usedb.UpdateDB("ProfRab", "btn_value", "btn_title", tbValue.Text, tbName.Text);

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

                string selectedItemLB = lbList.SelectedItem.ToString();

                string id = usedb.SelectDBLike("ProfRab", "id", "btn_title", selectedItemLB);

                string tmp = usedb.SelectDBLike("ProfRab", "btn_name", "btn_title", selectedItemLB);
                tmp = tmp.Replace("btnPR", "");

                usedb.UpdateDB("ProfRab", "btn_title", "id", "Проф " + tmp, id);
                usedb.UpdateDB("ProfRab", "btn_value", "id", "\\_(ツ)_/ -ать", id);

                RefreshLBList();
                lbList.SelectedItem = "Проф " + id;

                tmrComm3333.Enabled = false;
                tmrComm3333.Enabled = true;
                lblSave.Visible = true;
            }
            else MessageBox.Show("Очисти сначала свою голову, а потом попробуй снова...", "Ну и дурак...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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