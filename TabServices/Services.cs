using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLinONE.TabServices
{
    public partial class Services : UserControl
    {
        //Чтобы при создании контрола Services первое событие VisibleChanged скипалось
        public static bool SkipFillingPB = true;

        public Services()
        {
            InitializeComponent();
        }

        private void lbRDP_DoubleClick(object sender, EventArgs e)
        {
            if (lbRDP.SelectedItem != null)
                Process.Start("mstsc", @"/admin /f /v:" + UseDB.SelectDBLike("ServiceRDP", "Name", "Title", lbRDP.SelectedItem.ToString()));
        }

        private void lbRDP_Leave(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            lb.ClearSelected();
        }

        private void lbShare_DoubleClick(object sender, EventArgs e)
        {
            if (lbShare.SelectedItem != null)
                Process.Start("explorer", UseDB.SelectDBLike("ServiceShare", "Name", "Title", lbShare.SelectedItem.ToString()));
        }

        private void chckbServiceSorted_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbServiceSorted.Checked)
            {
                lbRDP.Sorted = true;
                lbShare.Sorted = true;
                lbPingSuccess.Sorted = true;
                lbPingTimeOut.Sorted = true;
            }
            else
            {
                lbRDP.Sorted = false;
                lbShare.Sorted = false;
                lbPingSuccess.Sorted = false;
                lbPingTimeOut.Sorted = false;
            }

            MethodsServices ms = new MethodsServices();
            ms.RefreshLBRDPShare(lbRDP, "ServiceRDP");
            ms.RefreshLBRDPShare(lbShare, "ServiceShare");
        }

        private void numPingProgress_ValueChanged(object sender, EventArgs e)
        {
            pbPingProgress.Value = 0;
            pbPingProgress.Maximum = Convert.ToInt32(numPingProgress.Value) * 1000;

            AiOMethods.SaveInRegistry("ProgressBarSec", numPingProgress.Value);
        }

        private void btnRefreshPing_Click(object sender, EventArgs e)
        {
            //Останавливаем цикл пинга
            MethodsServices.PingStop = true;

            MethodsServices srvc = new MethodsServices();
            srvc.LoadLBPing(pbPingProgress, lbPingSuccess, lbPingTimeOut, numPingTimeOut);
        }

        private void tbMSTSCadress_KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                btnMSTSCstart.PerformClick();
        }

        private void btnMSTSCstart_Click(object sender, EventArgs e)
        {
            if (tbMSTSCadress.Text != string.Empty)
                MethodsServices.StartMSTSC(tbMSTSCadress.Text, tbMSTSClogin.Text, tbMSTSCpass.Text);
        }

        private void tbCyclePingAdress_KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) btnCyclePingStart.PerformClick();
        }

        private void btnCyclePingStart_Click(object sender, EventArgs e)
        {
            lbCyclePing.Items.Clear();
            MethodsServices.CyclePingStop = false;
            tbCyclePingAdress.Text = tbCyclePingAdress.Text.Replace(',', '.'); //Меняем *запятую* на *точку*
            MethodsServices.StartCyclePing(tbCyclePingAdress.Text, lbCyclePing);
            btnCyclePingStart.Enabled = false;
        }

        private async void btnCyclePingStop_Click(object sender, EventArgs e)
        {
            MethodsServices.CyclePingStop = true;

            await Task.Delay(1333);
            btnCyclePingStart.Enabled = true;
        }

        private void lbCyclePing_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush myBrush;

            if (lbCyclePing.Items.Count > 0)
            {
                myBrush = (lbCyclePing.Items[e.Index].ToString().Contains("мс")) ? Brushes.DarkGreen : Brushes.DarkRed;
                e.Graphics.DrawString(lbCyclePing.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds);
            }
        }

        private void btnSrvcChange_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            SrvcChange form = new SrvcChange();
            form.Owner = mf;
            form.ShowDialog();
        }

        private void Services_VisibleChanged(object sender, EventArgs e)
        {
            //Чтобы при создании контрола Services первое событие VisibleChanged скипалось
            if (SkipFillingPB == false)
            {
                MethodsServices.PingStop = !Visible;

                if (Visible)
                {
                    MethodsServices ms = new MethodsServices();
                    ms.FillingPB(pbPingProgress, lbPingSuccess, lbPingTimeOut, numPingTimeOut);
                }
            }
        }

        private void Services_Load(object sender, EventArgs e)
        {
            numPingProgress.Value = Convert.ToDecimal(AiOMethods.LoadFromRegistry("ProgressBarSec", 30));
            pbPingProgress.Maximum = Convert.ToInt32(numPingProgress.Value) * 1000;

            MethodsServices ms = new MethodsServices();
            ms.RefreshLBRDPShare(lbRDP, "ServiceRDP");
            ms.RefreshLBRDPShare(lbShare, "ServiceShare");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.Text = pbPingProgress.Maximum.ToString();

            Form fm = FindForm();

            string xy = fm.Location.X.ToString() + " " + fm.Location.Y.ToString()+"\r\n";
            MessageBox.Show(xy + Screen.FromControl(fm).ToString());
        }
    }
}