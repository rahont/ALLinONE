using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ALLinONE
{
    class Service : MainForm
    {
        List<string> listName = new List<string>();
        List<string> listTitle = new List<string>();
        Ping ping = new Ping();
        PingReply pingReply;

        public void LoadLBPing(decimal numPingTimeOutValue, out string[] resSucc, out string[] resFail)
        {
            LoadListNameAndListTitle();

            resSucc = new string[listName.Count];
            resFail = new string[listName.Count];

            foreach (var item in listTitle)
            {
                try
                {
                    pingReply = ping.Send(listName[listTitle.IndexOf(item)], Convert.ToInt32(numPingTimeOutValue));

                    if (pingReply.Status.ToString() == "Success")
                        resSucc[listTitle.IndexOf(item)] = item + ": " + pingReply.RoundtripTime.ToString();
                    else
                        resFail[listTitle.IndexOf(item)] = item;
                }
                catch (Exception ex)
                {
                    resFail[listTitle.IndexOf(item)] = ex.Message;
                }
            }
        }
        public void LoadListNameAndListTitle()
        {
            foreach (var item in usedb.SelectDB("PingList", "Title"))
            {
                listTitle.Add(item);
            }

            foreach (var item in listTitle)
            {
                usedb = new UseDB("PingList", "Name", "Title", item);
                listName.Add(usedb.SelectDBLike());

                usedb = null;
            }
        }
    }
}
