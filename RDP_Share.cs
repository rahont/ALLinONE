using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Threading;

namespace ALLinONE
{
    public partial class RDP_Share : UserControl
    {
        public RDP_Share()
        {
            InitializeComponent();
        }

        List<string> listName = new List<string>();
        List<string> listTitle = new List<string>();
        Ping ping = new Ping();
        PingReply pingReply;

        private void lbRDP_Leave(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            lb.ClearSelected();
        }

        private void lbShare_DoubleClick(object sender, EventArgs e)
        {
            if (lbShare.SelectedItem != null)
            {
                UseDB useDB = new UseDB("ServiceShare", "Name", "Title", lbShare.SelectedItem.ToString());
                Process.Start("explorer", useDB.SelectDBLike());
            }
        }

        private void lbRDP_DoubleClick(object sender, EventArgs e)
        {
            if (lbRDP.SelectedItem != null)
            {
                UseDB useDB = new UseDB("ServiceRDP", "Name", "Title", lbRDP.SelectedItem.ToString());
                Process.Start("mstsc", @"/admin /f /v:" + useDB.SelectDBLike());
            }
        }

        public void RefreshLBShare()
        {
            UseDB usedb = new UseDB("ServiceShare", "Title");
            lbShare.Items.Clear();
            SQLiteDataReader addr = usedb.SelectDB();
            while (addr.Read()) //цикл перебора результатов кода БД
            {
                lbShare.Items.Add(addr["Title"]); //запись столбца БД в listbox
            }
        }

        public void RefreshLBRDP()
        {
            UseDB usedb = new UseDB("ServiceRDP", "Title");
            lbRDP.Items.Clear();
            SQLiteDataReader addr = usedb.SelectDB();
            while (addr.Read()) //цикл перебора результатов кода БД
            {
                lbRDP.Items.Add(addr["Title"]); //запись столбца БД в listbox
            }
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
            RefreshLBRDP();
            RefreshLBShare();
        }

        private void btnSrvcChange_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            SrvcChange form = new SrvcChange();
            form.Owner = mf;
            form.ShowDialog();
        }

        /// <summary>
        /// Пингует список из List`ов
        /// </summary>
        public void LoadLBPingSuccess()
        {
            lbPingSuccess.Items.Clear();
            lbPingTimeOut.Items.Clear();

            #region Старый код, рабочий, но жрет мнооооого озу
            //List<string> pingList = new List<string>();
            //UseDB usedb = new UseDB("PingList", "Title");

            //SQLiteDataReader addrList = usedb.SelectDB();
            //while (addrList.Read()) //цикл перебора результатов кода БД
            //{
            //    pingList.Add(addrList["Title"].ToString());
            //}



            //foreach (var item in pingList)
            //{

            //    UseDB useDB = new UseDB("PingList", "Name", "Title", item);
            //    try
            //    {
            //        pingReply = ping.Send(useDB.SelectDBLike(), Convert.ToInt32(numPingTimeOut.Value));

            //        if (pingReply.Status.ToString() != "Success")
            //            lbPingTimeOut.Items.Add(item);
            //        else
            //        {
            //            lbPingSuccess.Items.Add(item + ": " + pingReply.RoundtripTime.ToString());
            //            if (pingReply.RoundtripTime > 30)
            //                listBox1.Items.Add(item + ": " + pingReply.RoundtripTime.ToString());
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        lbPingTimeOut.Items.Add(ex.Message);
            //        lbPingTimeOut.Items.Add("Скорее всего введен не корректный адрес");
            //    }
            //    useDB = null;
            //}
            #endregion

            foreach (var item in listTitle)
            {
                try
                {
                    pingReply = ping.Send(listName[listTitle.IndexOf(item)], Convert.ToInt32(numPingTimeOut.Value));

                    if (pingReply.Status.ToString() != "Success")
                    {
                        if (pingReply.Status.ToString() != "Success")
                            lbPingTimeOut.Items.Add(item);
                        else
                            lbPingSuccess.Items.Add(item + ": " + pingReply.RoundtripTime.ToString());
                    }
                    else
                    {
                        lbPingSuccess.Items.Add(item + ": " + pingReply.RoundtripTime.ToString());
                    }
                }
                catch (Exception ex)
                {
                    lbPingTimeOut.Items.Add(ex.Message);
                    lbPingTimeOut.Items.Add("Скорее всего введен не корректный адрес");
                }

            }

            if (lbPingTimeOut.Items.Count > 0)
            {
                lblPingTimeOut.Visible = true;
                lbPingTimeOut.Visible = true;
            }
            else
            {
                lblPingTimeOut.Visible = false;
                lbPingTimeOut.Visible = false;
            }
        }

        /// <summary>
        /// Вытягивает из БД (PingList) столбцы Name и Title
        /// </summary>
        public void LoadListNameAndListTitle()
        {
            UseDB usedb = new UseDB("PingList", "Title");

            SQLiteDataReader addrList = usedb.SelectDB();
            while (addrList.Read()) //цикл перебора результатов кода БД
            {
                listTitle.Add(addrList["Title"].ToString());
            }

            foreach (var item in listTitle)
            {
                usedb = new UseDB("PingList", "Name", "Title", item);
                listName.Add(usedb.SelectDBLike());

                usedb = null;
            }
        }

        private void RDP_Share_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                pbPingProgress.Maximum = Convert.ToInt32(numPingProgress.Value) * 1000;
                timer.Enabled = true;
            }
            else timer.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pbPingProgress.Value == pbPingProgress.Maximum)
            {
                pbPingProgress.Value = 0;
                LoadLBPingSuccess();
            }
            else
            {
                pbPingProgress.Value += 100;
            }
        }

        private void numPingProgress_ValueChanged(object sender, EventArgs e)
        {
            timer.Enabled = false;
            pbPingProgress.Value = 0;
            pbPingProgress.Maximum = Convert.ToInt32(numPingProgress.Value) * 1000;
            LoadLBPingSuccess();
            timer.Enabled = true;

            Properties.Settings.Default.rdp_shareProgressBarSec = numPingProgress.Value;
            Properties.Settings.Default.Save();
        }

        private void RDP_Share_Load(object sender, EventArgs e)
        {
            numPingProgress.Value = Properties.Settings.Default.rdp_shareProgressBarSec;
            //LoadListNameAndListTitle();
        }
    }
}