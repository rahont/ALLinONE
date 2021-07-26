using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLinONE.TabServices
{
    class MethodsServices
    {
        List<string> listName = new List<string>();
        List<string> listTitle = new List<string>();
        Ping ping = new Ping();
        PingReply pingReply;
        public static bool CyclePingStop { get; set; }
        public static bool PingStop { get; set; }

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
                    lbT.Items.Add(item + ": " + ex.InnerException.Message);
                }
            }

            PingStop = false;
            FillingPB(pb, lbS, lbT, num);
        }

        public void LoadListNameAndListTitle()
        {
            //Чистим листы
            listTitle.Clear();
            listName.Clear();

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

        public async static void StartCyclePing(string adress, ListBox lb)
        {
            Ping ping = new Ping();
            PingReply pingReply;

            adress = adress.Replace(',', '.'); //Меняем *запятую* на *точку*
            string echo;
            string tmp;
            try
            {
                while (true)
                {
                    await Task.Run(async () =>
                    {
                        await Task.Delay(1000);
                    });

                    pingReply = await ping.SendPingAsync(adress, 128);

                    //Присвоить IP в скобках, если адрес = DNS имя
                    tmp = (adress == pingReply.Address.ToString()) ? string.Empty : " (" + pingReply.Address.ToString() + ")";

                    //Проверяем доступность адреса
                    echo = (pingReply.Status.ToString() == "Success") ?
                        adress + tmp + $": {pingReply.RoundtripTime}мс" : adress + ": Не доступен";
                        //Собираем строку для последующего вывода       : //Если адрес не доступен

                    Action action = () => lb.Items.Add(echo);
                    action?.Invoke();
                    lb.TopIndex = lb.Items.Count - 1;


                    if (CyclePingStop) //Если поле true, то остановить пинг
                        break;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.InnerException.Message, "Накосячил", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lb.Items.Add(ex.InnerException.Message);
            }
        }

        public async void FillingPB(ProgressBar pb, ListBox lbSuccess, ListBox lbTimeOut, NumericUpDown num)
        {
            while (true)
            {
                if (PingStop) break;

                if (pb.Value == pb.Maximum)
                {
                    await Task.Delay(555); //Для полного заполнения ProgressBar
                    LoadLBPing(pb, lbSuccess, lbTimeOut, num);
                    pb.Value = 0;
                    break;
                }
                else pb.Value += 100;

                await Task.Delay(100);
            }
        }

        public void RefreshLBRDPShare(ListBox lb, string tableDB)
        {
            lb.Items.Clear();
            foreach (var item in UseDB.SelectDB(tableDB, "Title"))
                lb.Items.Add(item);
        }
    }
}