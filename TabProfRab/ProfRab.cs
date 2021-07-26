using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLinONE.TabProfRab
{
    public partial class ProfRab : UserControl
    {
        public ProfRab()
        {
            InitializeComponent();
        }

        private void ProfRab_Load(object sender, EventArgs e)
        {
            lblPR.BorderStyle = BorderStyle.None;
            MethodsProfRab mpp = new MethodsProfRab();
            mpp.Refresh_btnPR(this);
        }

        private async void btnPR1_Click(object sender, EventArgs e)
        {
            string bName = (sender as Button).Name; //Получает имя нажатой кнопки

            string str = UseDB.SelectDBLike("ProfRab", "btn_value", "btn_name", bName);
            lblPR.Text = str;
            Clipboard.SetText(str);

            await Task.Delay(Properties.Settings.Default.timeClean);
            lblPR.Text = string.Empty;
        }

        private void btnPRChange_Click(object sender, EventArgs e)
        {
            PRChangeButton form = new PRChangeButton();
            //form.Owner = this;
            form.ShowDialog();
        }
    }
}
