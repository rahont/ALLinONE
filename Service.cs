using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLinONE
{
    class Service : Form
    {
        List<string> listName = new List<string>();
        List<string> listTitle = new List<string>();
        Ping ping = new Ping();
        PingReply pingReply;

        //public void LoadLBPing(decimal numPingTimeOutValue, out string[] resSucc, out string[] resFail)
        //{
        //    LoadListNameAndListTitle();

        //    resSucc = new string[listName.Count];
        //    resFail = new string[listName.Count];

        //    foreach (var item in listTitle)
        //    {
        //        try
        //        {
        //            pingReply = ping.Send(listName[listTitle.IndexOf(item)], Convert.ToInt32(numPingTimeOutValue));

        //            if (pingReply.Status.ToString() == "Success")
        //                resSucc[listTitle.IndexOf(item)] = item + ": " + pingReply.RoundtripTime.ToString();
        //            else
        //                resFail[listTitle.IndexOf(item)] = item;
        //        }
        //        catch (Exception ex)
        //        {
        //            resFail[listTitle.IndexOf(item)] = ex.Message;
        //        }
        //    }
        //}

        public async void LoadLBPing(ProgressBar pb, ListBox lbS, ListBox lbT, NumericUpDown num)
        {
            LoadListNameAndListTitle();

            pb.Value = 0;
            lbS.Items.Clear();
            lbT.Items.Clear();

            foreach (var item in listTitle)
            {
                try
                {
                    pingReply = await ping.SendPingAsync(listName[listTitle.IndexOf(item)], Convert.ToInt32(num.Value));

                    if (pingReply.Status.ToString() == "Success")
                        lbS.Items.Add(item + ": " + pingReply.RoundtripTime.ToString());
                        //resSucc[listTitle.IndexOf(item)] = item + ": " + pingReply.RoundtripTime.ToString();
                    else
                        lbT.Items.Add(item);
                    //resFail[listTitle.IndexOf(item)] = item;
                }
                catch (Exception ex)
                {
                    lbT.Items.Add(ex.Message);
                }
            }
        }

        public void LoadListNameAndListTitle()
        {
            foreach (var item in UseDB.SelectDB("PingList", "Title"))
            {
                listTitle.Add(item);
            }

            foreach (var item in listTitle)
            {
                listName.Add(UseDB.SelectDBLike("PingList", "Name", "Title", item));
            }
        }

        public static void StartMSTSC(string adress, string login = null, string pass = null)
        {
            try
            {
                Process rdpProcess = new Process();
                rdpProcess.StartInfo.FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\cmdkey.exe");
                rdpProcess.StartInfo.Arguments = $"/generic:{adress} /user:{login} /pass:{pass}";
                rdpProcess.Start();

                rdpProcess.StartInfo.FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\mstsc.exe");
                rdpProcess.StartInfo.Arguments = "/v " + adress; // ip or name of computer to connect
                rdpProcess.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void StartCyclePing(string adress)
        {
            try
            {
                Process pingProcess = new Process();
                pingProcess.StartInfo.FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\ping.exe");
                pingProcess.StartInfo.Arguments = "-t " + adress; // ip or name of computer to connect
                //pingProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                pingProcess.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
