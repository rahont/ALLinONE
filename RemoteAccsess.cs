using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLinONE
{
    public partial class RemoteAccsess : Form
    {
        public RemoteAccsess()
        {
            InitializeComponent();
        }

        private void RemoteAccsess_Load(object sender, EventArgs e)
        {
            tbPathPsExec.Text = Properties.Settings.Default.pathPsExec;
            openFileDialog.Filter = "All files (*.*)|*.*|exe file (*.exe)|*.exe|txt files (*.txt)|*.txt";
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Settings.Default.remaccBtnQuestion, "А ты знаешь что такое PsExec?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBrowsePathPsExec_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.pathPsExec = openFileDialog.FileName;
                tbPathPsExec.Text = openFileDialog.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void btnLoadListPC_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileStream = openFileDialog.OpenFile();

                StreamReader sr = new StreamReader(fileStream);
                string str;

                cbListPC.Items.Clear();

                while ((str = sr.ReadLine()) != null)
                {
                    cbListPC.Items.Add(str);
                }

                lblNameRemotePC.Text = $"Имя удаленного ПК ({cbListPC.Items.Count})";

                fileStream.Close();
            }
        }

        private async void btnServiceCommStart_Click(object sender, EventArgs e)
        {
            if (tbNameService.TextLength > 2)   //Проверка на наличие символов в ИмениСервиса
            {
                if (cbListPC.Text.Length == 0 && cbListPC.Items.Count > 0)
                {
                    StreamWriter sw = new StreamWriter(tbLogService.Text, true);

                    await Task.Run(() =>
                    {
                        for (int i = 0; i < cbListPC.Items.Count; i++)
                        {
                            string namePC = cbListPC.Items[i].ToString();
                            sw.Write(namePC + "\t");

                            //Проверяем доступность ПК
                            string pingResult = CheckPingPC(namePC);

                            if (pingResult == "Success")
                            {
                                var serviceController = new ServiceController(tbNameService.Text, namePC);
                                try
                                {
                                    if (rbtnServiceOn.Checked)
                                    {
                                        if (serviceController.Status.ToString() == "Stopped")   //Если служба остановлена, то
                                        {
                                            serviceController.Start();  //Запускаем службу
                                            serviceController.WaitForStatus(ServiceControllerStatus.Running);   //Ждем окончательной загрузки службы
                                            sw.Write($"Мы подняли службу {tbNameService.Text}\n");
                                        }
                                        else sw.Write($"Cлужба {tbNameService.Text} уже была запущена\n");
                                    }
                                    if (rbtnServiceOff.Checked)
                                    {
                                        if (serviceController.Status.ToString() != "Stopped")   //Если служба остановлена, то
                                        {
                                            serviceController.Stop();  //Останавливаем службу
                                            serviceController.WaitForStatus(ServiceControllerStatus.Stopped);   //Ждем окончательной остановки службы
                                            sw.Write($"Мы уронили службу {tbNameService.Text}\n");
                                        }
                                        else sw.Write($"Cлужба {tbNameService.Text} уже была остановлена\n");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    sw.Write(ex + "\n");
                                    continue;
                                }
                            }
                            else
                            {
                                sw.Write(pingResult + "\n");
                                continue;
                            }
                            
                        }
                        MessageBox.Show("Завершено");
                    });
                    sw.Close();
                }
                else
                {
                    string namePC = cbListPC.Text;

                    //Проверяем доступность ПК
                    string pingResult = CheckPingPC(namePC);

                    if (pingResult == "Success")
                    {
                        var serviceController = new ServiceController(tbNameService.Text, namePC);
                        try
                        {
                            if (rbtnServiceOn.Checked)
                            {
                                if (serviceController.Status.ToString() == "Stopped")   //Если служба остановлена, то
                                {
                                    serviceController.Start();  //Запускаем службу
                                    serviceController.WaitForStatus(ServiceControllerStatus.Running);   //Ждем окончательной загрузки службы
                                    MessageBox.Show($"Мы подняли службу {tbNameService.Text}\n");
                                }
                                else MessageBox.Show($"Cлужба {tbNameService.Text} уже была запущена\n");
                            }
                            if (rbtnServiceOff.Checked)
                            {
                                if (serviceController.Status.ToString() != "Stopped")   //Если служба остановлена, то
                                {
                                    serviceController.Stop();  //Останавливаем службу
                                    serviceController.WaitForStatus(ServiceControllerStatus.Stopped);   //Ждем окончательной остановки службы
                                    MessageBox.Show($"Мы уронили службу {tbNameService.Text}\n");
                                }
                                else MessageBox.Show($"Cлужба {tbNameService.Text} уже была остановлена\n");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show(namePC + "\t" + pingResult);
                        return;
                    }
                }
            }
        }

        private async void btnServiceStat_Click(object sender, EventArgs e)
        {
            string stat;

            if (CheckPingPC(cbListPC.Text) == "Success")
            {
                var serviceController = new ServiceController(tbNameService.Text, cbListPC.Text);
                stat = serviceController.Status.ToString();
            }
            else stat = "----------";

            btnServiceStat.Text = stat;
            await Task.Delay(3000);
            btnServiceStat.Text = "Проверить статус";
        }

        private async void btnRegistryCommStart_Click(object sender, EventArgs e)
        {
            if (tbPathRegistry.TextLength > 4 && tbKeyRegistry.TextLength > 0)   //Проверка на наличие символов в Реестре
            {
                if (cbListPC.Text.Length == 0 && cbListPC.Items.Count > 0)
                {
                    StreamWriter sw = new StreamWriter(tbLogRegistry.Text, true);

                    await Task.Run(() =>
                    {
                        for (int i = 0; i < cbListPC.Items.Count; i++)
                        {
                            string namePC = cbListPC.Items[i].ToString();
                            sw.Write(namePC + "\t");

                            //Проверяем доступность ПК
                            string pingResult = CheckPingPC(namePC);

                            if (pingResult == "Success")
                            {
                                string[] val = tbPathRegistry.Text.Split(new char[] { '\\' });
                                RegistryHive rh;
                                if (val[0] == "HKLM" || val[0] == "HKEY_LOCAL_MACHINE") rh = RegistryHive.LocalMachine;
                                if (val[0] == "HKCU" || val[0] == "HKEY_CURRENT_USER") rh = RegistryHive.CurrentUser;
                                else
                                {
                                    MessageBox.Show("HKLM или HKCU другого не дано...");
                                    return;
                                }
                                string pathKey = null;
                                for (int x = 1; x < val.Length -1; x++)
                                {
                                    pathKey += val[x] + "\\";
                                }
                                pathKey = pathKey.Remove(pathKey.Length - 1);
                                try
                                {
                                    if (tbValueRegistry.TextLength > 0)
                                    {
                                        if (rbtnRegistryAdd.Checked)
                                        {
                                            RegistryKey environmentKey;
                                            environmentKey = RegistryKey.OpenRemoteBaseKey(rh, namePC).CreateSubKey(pathKey);
                                            foreach (string valueName in environmentKey.GetValueNames())
                                            {
                                                if (valueName == tbKeyRegistry.Text)
                                                {
                                                    environmentKey.SetValue(valueName, tbValueRegistry.Text);
                                                    sw.Write($"Был записан ключ: {valueName}; Со значением: {tbValueRegistry.Text}\n");
                                                }
                                            }
                                        }
                                        if (rbtnRegistryDel.Checked)
                                        {
                                            RegistryKey environmentKey;
                                            environmentKey = RegistryKey.OpenRemoteBaseKey(rh, namePC).CreateSubKey(pathKey);
                                            foreach (string valueName in environmentKey.GetValueNames())
                                            {
                                                if (valueName == tbKeyRegistry.Text)
                                                {
                                                    environmentKey.DeleteValue(valueName, false);
                                                    sw.Write($"Был удален ключ: {valueName}; Со значением: {tbValueRegistry.Text}\n");
                                                }
                                            }
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    sw.Write(ex + "\n");
                                    continue;
                                }
                            }
                            else
                            {
                                sw.Write(pingResult + "\n");
                                continue;
                            }

                        }
                        MessageBox.Show("Завершено");
                    });
                    sw.Close();
                }
                else
                {
                    string namePC = cbListPC.Text;

                    //Проверяем доступность ПК
                    string pingResult = CheckPingPC(namePC);

                    if (pingResult == "Success")
                    {
                        var serviceController = new ServiceController(tbNameService.Text, namePC);
                        try
                        {
                            if (rbtnServiceOn.Checked)
                            {
                                if (serviceController.Status.ToString() == "Stopped")   //Если служба остановлена, то
                                {
                                    serviceController.Start();  //Запускаем службу
                                    serviceController.WaitForStatus(ServiceControllerStatus.Running);   //Ждем окончательной загрузки службы
                                    MessageBox.Show($"Мы подняли службу {tbNameService.Text}\n");
                                }
                                else MessageBox.Show($"Cлужба {tbNameService.Text} уже была запущена\n");
                            }
                            if (rbtnServiceOff.Checked)
                            {
                                if (serviceController.Status.ToString() != "Stopped")   //Если служба остановлена, то
                                {
                                    serviceController.Stop();  //Останавливаем службу
                                    serviceController.WaitForStatus(ServiceControllerStatus.Stopped);   //Ждем окончательной остановки службы
                                    MessageBox.Show($"Мы уронили службу {tbNameService.Text}\n");
                                }
                                else MessageBox.Show($"Cлужба {tbNameService.Text} уже была остановлена\n");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show(namePC + "\t" + pingResult);
                        return;
                    }
                }
            }









            //RegistryKey environmentKey;
            //environmentKey = RegistryKey.OpenRemoteBaseKey(
            //    RegistryHive.LocalMachine, namePC).CreateSubKey(
            //    @"SYSTEM\CurrentControlSet\Services\LanmanServer\Parameters");
            //foreach (string valueName in environmentKey.GetValueNames())
            //{
            //    if ((valueName == "RequireSecuritySignature") || (valueName == "EnableSecuritySignature"))
            //    {
            //        environmentKey.SetValue(valueName, 1);
            //        sw.Write($"Был записан ключ: {valueName}\n");
            //    }
            //}
        }

        string CheckPingPC(string namePC)
        {
            Ping ping = new Ping();
            //pr = ping.Send(namePC);
            string pingStat;

            try
            {
                PingReply pr = ping.Send(namePC);
                pingStat = pr.Status.ToString();
            }
            catch (Exception ex)
            {
                pingStat = ex.ToString();
            }

            return pingStat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
