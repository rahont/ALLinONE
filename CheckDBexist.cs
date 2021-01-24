using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLinONE
{
    public partial class CheckDBexist : Form
    {
        RegistryKey registry = Registry.CurrentUser.CreateSubKey("SOFTWARE\\All in One");

        public CheckDBexist()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbPathFileDB.Text = openFileDialog.FileName;
                registry.SetValue("PathDB", openFileDialog.FileName);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (File.Exists(registry.GetValue("PathDB", "Data_DB").ToString()))
                Application.Restart();
            else
                MessageBox.Show("Попробуй выбрать заново.\nИли выбери другой файл.\nИли создай новый...", "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            string nameDB = (tbPathFileDB.TextLength == 0) ? "Data_DB" : tbPathFileDB.Text;

            DialogResult result = MessageBox.Show("Желаешь базу?\n" + nameDB, "Создаем?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                registry.SetValue("PathDB", Environment.CurrentDirectory + "\\" + nameDB + ".db");

                UseDB.CreateNewDB(nameDB);

                MessageBox.Show($"Создана база данных по пути:\n{Environment.CurrentDirectory}\nИмя БД: {nameDB}.db",
                    "Создано!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Application.Restart();
            }
            else MessageBox.Show("Базы, собирайтесь. Мы уходим!", ":P", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}