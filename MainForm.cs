using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace ALLinONE
{
    public partial class MainForm : Form
    {
        #region Form
        public MainForm()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            CheckDBexist form = new CheckDBexist();
            
            RegistryKey registry = Registry.CurrentUser.CreateSubKey("SOFTWARE\\All in One");

            if (File.Exists(registry.GetValue("PathDB", "Data_DB.db").ToString()))
            {
                form.Close();
                Text += $" ({Environment.UserName})   - v.{AiOMethods.AiOVersion()}.alfa";

                LoadFormPosition2();     //Загрузка координат формы

                FormCreate formCreate = new FormCreate(pnlTabs);
            }
            else
            {
                DialogResult result = MessageBox.Show
                    ("Файл базы данных не найден.\nЖелаешь указать к нему путь или создать новый?", "Хде он?!?!?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    form.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Ну и фиг с тобой :P", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }

            registry.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UseDB.connectDB.Close(); //закрыть БД
            AiOMethods.SaveFormPosition(Location.X, Location.Y);
        }

        private void LoadFormPosition()
        {
            int allScreenWidth = 0;
            int allScreenHeight = 0;

            //Перебор всех мониторов
            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                // + width монитора
                allScreenWidth += Screen.AllScreens[i].Bounds.Width;

                //Если height монитора > переменной, то присвоить
                if (Screen.AllScreens[i].Bounds.Height > allScreenHeight)
                    allScreenHeight = Screen.AllScreens[i].Bounds.Height;
            }
            
            RegistryKey formPos = Registry.CurrentUser.CreateSubKey("SOFTWARE\\All in One");
            Location = new Point(Convert.ToInt32(formPos.GetValue("PositionX", Location.X)),
                Convert.ToInt32(formPos.GetValue("PositionY", Location.Y)));   //загрузить позицию формы из реестра
            formPos.Close();

            

            if ((Location.X < -500) || (Location.X > allScreenWidth) || (Location.Y < -500) || (Location.Y > allScreenHeight))
                Location = new Point(100, 100);
        }

        private void LoadFormPosition2()
        {
            RegistryKey formPos = Registry.CurrentUser.CreateSubKey("SOFTWARE\\All in One");
            Location = new Point(Convert.ToInt32(formPos.GetValue("PositionX", Location.X)),
                Convert.ToInt32(formPos.GetValue("PositionY", Location.Y)));   //загрузить позицию формы из реестра
            formPos.Close();

            var WidthScreenLocationForm = 
                Screen.GetWorkingArea(Location).X == 0 ? Screen.GetBounds(Location).Width : Screen.GetWorkingArea(Location).X;
            var HeightScreenLocationForm = Screen.GetWorkingArea(Location).Height;

            //Если Location формы на дисплее с отрицательной рабочей областью
            if (WidthScreenLocationForm < 0)
            {
                if ((Location.X < WidthScreenLocationForm) || (Location.X > 0) || (Location.Y > HeightScreenLocationForm) || (Location.Y < 0))
                    Location = new Point(100, 100);
            }
            else
            {
                if ((Location.X < -100) || (Location.X > WidthScreenLocationForm) || (Location.Y > HeightScreenLocationForm) || (Location.Y < 0))
                    Location = new Point(100, 100);
            }
        }
        #endregion

        #region MenuStrip
        private void toolStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void remoteAccsessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoteAccsess form = new RemoteAccsess();
            form.Owner = this;
            form.ShowDialog();
        }

        private void toolStripDBCheckCon_Click(object sender, EventArgs e)
        {
            string str = (UseDB.connectDB.State.ToString() == "Open") ? "Подключение к БД установлено" : "Подключение к БД отсутствует";
            MessageBox.Show(str, "Статус подключение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripDBInvertCon_Click(object sender, EventArgs e)
        {
            if (UseDB.connectDB.State.ToString() == "Open") UseDB.connectDB.Close();
            else UseDB.connectDB.Open();
        }

        private void toolStripAbout_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }
        #endregion

        private void toDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToDoList.FormOpenClose == false)
            {
                ToDoList tdl = new ToDoList();
                tdl.ShowDialog();
            }
        }

        private void toolStripTabsServices_Click(object sender, EventArgs e)
        {
            string name = null;
            ToolStripMenuItem ts = (ToolStripMenuItem)sender;
            if (ts.Text == "Сервис") name = "Services";
            if (ts.Text == "Проф. работы") name = "ProfRab";
            if (ts.Text == "Принтеры") name = "Printers";
            if (ts.Text == "Список заявок") name = "Requests";
            if (ts.Text == "Добавление заявок") name = "AddRequest";

            foreach (Control item in pnlTabs.Controls)
            {
                if (item.Name == name)
                {
                    item.Visible = true;

                    Properties.Settings.Default.startTab = item.Name;
                    Properties.Settings.Default.Save();
                }
                else item.Visible = false;
            }
        }

        private void toolStripTabs_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTabs.ShowDropDown();
        }
    }
}