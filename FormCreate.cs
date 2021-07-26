using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLinONE
{
    class FormCreate
    {
        Panel pnlTabs;

        /// <summary>
        /// 
        /// </summary>
        public FormCreate(Panel pnlTabs)
        {
            this.pnlTabs = pnlTabs;

            CheckRegData();
            CreateTabsControls();
            StartTab();

            //Чтобы при создании контрола Services первое событие VisibleChanged скипалось
            TabServices.Services.SkipFillingPB = false;
        }

        private void CreateTabsControls()
        {
            TabServices.Services services = new TabServices.Services();
            services.Dock = DockStyle.Fill;
            services.Name = "Services";
            services.Tag = "tagServices";
            services.Visible = false;
            pnlTabs.Controls.Add(services);

            TabProfRab.ProfRab profRab = new TabProfRab.ProfRab();
            profRab.Dock = DockStyle.Fill;
            profRab.Name = "ProfRab";
            profRab.Tag = "tagProfRab";
            profRab.Visible = false;
            pnlTabs.Controls.Add(profRab);
            
            TabPrinters.Printers printers = new TabPrinters.Printers();
            printers.Dock = DockStyle.Fill;
            printers.Name = "Printers";
            printers.Tag = "tagPrinters";
            printers.Visible = false;
            pnlTabs.Controls.Add(printers);

            TabRequests.Requests request = new TabRequests.Requests();
            request.Dock = DockStyle.Fill;
            request.Name = "Requests";
            request.Tag = "tagRequests";
            request.Visible = false;
            pnlTabs.Controls.Add(request);

            TabAddRequests.AddRequests addReq = new TabAddRequests.AddRequests();
            addReq.Dock = DockStyle.Fill;
            addReq.Name = "AddRequest";
            addReq.Tag = "tagAddRequest";
            addReq.Visible = false;
            pnlTabs.Controls.Add(addReq);
        }

        private void StartTab()
        {
            string startTab = Properties.Settings.Default.startTab;
            if (startTab == "") startTab = "Services";

            foreach (Control item in pnlTabs.Controls)
            {
                item.Visible = (item.Name == startTab);
            }
        }

        private void CheckRegData()
        {
            RegistryKey registry = Registry.CurrentUser.CreateSubKey("SOFTWARE\\All in One");
            if (Registry.CurrentUser.OpenSubKey("SOFTWARE\\All in One") == null) //проверяем наличие раздела в реестре. если отсутствует раздел, то создаем
                registry.CreateSubKey("SOFTWARE\\All in One");
        }
    }
}
