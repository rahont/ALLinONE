﻿using System;
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
    public partial class ReinstallOS : UserControl
    {
        public ReinstallOS()
        {
            InitializeComponent();
        }

        private void RefreshListProg()
        {
            UseDB usedb = new UseDB("ReinstallOS", "Prog");
            lbProgList.Items.Clear();
            SQLiteDataReader prog = usedb.SelectDB();
            while (prog.Read()) //цикл перебора результатов кода БД
            {
                lbProgList.Items.Add(prog["Prog"]); //запись столбца БД в listbox
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //MainForm main = new MainForm();

            if (tbAddProg.Text == "" || tbAddProg.Text == "Наименование")
            {
                MessageBox.Show("Мозга себе добавь...", "???", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UseDB usedb = new UseDB("ReinstallOS", "Prog", tbAddProg.Text);
                usedb.InsertDB();


                //SQLiteCommand comm = main.DB.CreateCommand(); //переменная БД
                //comm.CommandText = "insert into ReinstallOS(Act, Prog) values('" + tbAddProg.Text + "')"; //код БД в переменную
                //comm.ExecuteNonQuery();

                RefreshListProg();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();

            if (lbProgList.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Удалить запись '" + lbProgList.SelectedItem + "'?", "Ты уверен?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SQLiteCommand comm = main.DB.CreateCommand(); //переменная БД
                    comm.CommandText = "delete from ReinstallOS where Prog like '" + lbProgList.SelectedItem.ToString() + "'"; //код БД в переменную
                    comm.ExecuteNonQuery();

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

        private void tbAddProg_KeyDown(object sender, KeyEventArgs e)
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
            if (chckbListSort.Checked) lbProgList.Sorted = true;
            else lbProgList.Sorted = false;
            RefreshListProg();
        }

        private void btnAddDB_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();

            if (tbFIO.Text == "" || tbFIO.Text == "Наименование")
                MessageBox.Show("На кого оформляем?", "СберБанка", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else
            {
                foreach (var item in lbProgList.Items)
                {
                    string result = item.ToString() + ". " + tbFIO.Text;

                    UseDB usedb = new UseDB("RequestList", "Value", "User", "DateCreate", result, Environment.UserName, DateTime.Now.ToString());
                    usedb.InsertDB();
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

        private void tbFIO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) //проверяем нажат ли Del,
                btnAddDB.PerformClick(); //если да, то жмем кнопку Удалить
        }
    }
}