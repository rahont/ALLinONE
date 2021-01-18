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
        RegistryKey registry = Registry.CurrentUser.CreateSubKey("All in One");

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
            MessageBox.Show("Пока что не работаю", "Увы...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}