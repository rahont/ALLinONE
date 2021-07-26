namespace ALLinONE
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDBCheckCon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDBInvertCon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteAccsessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTabs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTabsServices = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTabsProfRab = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTabsPrinters = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTabsListRequests = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTabsAddRequests = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFile,
            this.toDoToolStripMenuItem,
            this.remoteAccsessToolStripMenuItem,
            this.toolStripExcel,
            this.toolStripTabs});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(634, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripFile
            // 
            this.toolStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDB,
            this.toolStripSettings,
            this.toolStripAbout,
            this.toolStripSeparator1,
            this.toolStripExit});
            this.toolStripFile.Image = global::ALLinONE.Properties.Resources.down_arrow_icon_icons_com_64915;
            this.toolStripFile.Name = "toolStripFile";
            this.toolStripFile.Size = new System.Drawing.Size(64, 20);
            this.toolStripFile.Text = "Файл";
            // 
            // toolStripDB
            // 
            this.toolStripDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDBCheckCon,
            this.toolStripSeparator3,
            this.toolStripDBInvertCon});
            this.toolStripDB.Image = global::ALLinONE.Properties.Resources.Data_settings_theapplication_3364;
            this.toolStripDB.Name = "toolStripDB";
            this.toolStripDB.Size = new System.Drawing.Size(149, 22);
            this.toolStripDB.Text = "База Данных";
            // 
            // toolStripDBCheckCon
            // 
            this.toolStripDBCheckCon.Image = global::ALLinONE.Properties.Resources.dataencryption_application_dedatos_3363;
            this.toolStripDBCheckCon.Name = "toolStripDBCheckCon";
            this.toolStripDBCheckCon.Size = new System.Drawing.Size(237, 22);
            this.toolStripDBCheckCon.Text = "Проверить подключение";
            this.toolStripDBCheckCon.Click += new System.EventHandler(this.toolStripDBCheckCon_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(234, 6);
            // 
            // toolStripDBInvertCon
            // 
            this.toolStripDBInvertCon.Image = global::ALLinONE.Properties.Resources.databackup_theapplication_dedatos_3366;
            this.toolStripDBInvertCon.Name = "toolStripDBInvertCon";
            this.toolStripDBInvertCon.Size = new System.Drawing.Size(237, 22);
            this.toolStripDBInvertCon.Text = "Инвертировать подключение";
            this.toolStripDBInvertCon.Click += new System.EventHandler(this.toolStripDBInvertCon_Click);
            // 
            // toolStripSettings
            // 
            this.toolStripSettings.Image = global::ALLinONE.Properties.Resources._2849830_gear_interface_multimedia_options_setting_settings_107986;
            this.toolStripSettings.Name = "toolStripSettings";
            this.toolStripSettings.Size = new System.Drawing.Size(149, 22);
            this.toolStripSettings.Text = "Настройки";
            this.toolStripSettings.Visible = false;
            // 
            // toolStripAbout
            // 
            this.toolStripAbout.Name = "toolStripAbout";
            this.toolStripAbout.Size = new System.Drawing.Size(149, 22);
            this.toolStripAbout.Text = "О программе";
            this.toolStripAbout.Click += new System.EventHandler(this.toolStripAbout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // toolStripExit
            // 
            this.toolStripExit.Image = global::ALLinONE.Properties.Resources.switch_power_on_off_icon_178313;
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(149, 22);
            this.toolStripExit.Text = "Выход";
            this.toolStripExit.Click += new System.EventHandler(this.toolStripExit_Click);
            // 
            // toDoToolStripMenuItem
            // 
            this.toDoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toDoToolStripMenuItem.Name = "toDoToolStripMenuItem";
            this.toDoToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toDoToolStripMenuItem.Text = "ToDo";
            this.toDoToolStripMenuItem.Click += new System.EventHandler(this.toDoToolStripMenuItem_Click);
            // 
            // remoteAccsessToolStripMenuItem
            // 
            this.remoteAccsessToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.remoteAccsessToolStripMenuItem.Image = global::ALLinONE.Properties.Resources.wifi_signal_waves_icon_icons_com_72466;
            this.remoteAccsessToolStripMenuItem.Name = "remoteAccsessToolStripMenuItem";
            this.remoteAccsessToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.remoteAccsessToolStripMenuItem.Text = "RemoteAccsess";
            this.remoteAccsessToolStripMenuItem.Click += new System.EventHandler(this.remoteAccsessToolStripMenuItem_Click);
            // 
            // toolStripExcel
            // 
            this.toolStripExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripExcel.Image = global::ALLinONE.Properties.Resources.Excel_Mac_23559;
            this.toolStripExcel.Name = "toolStripExcel";
            this.toolStripExcel.Size = new System.Drawing.Size(62, 20);
            this.toolStripExcel.Text = "Excel";
            this.toolStripExcel.Visible = false;
            this.toolStripExcel.Click += new System.EventHandler(this.toolStripExcel_Click);
            // 
            // toolStripTabs
            // 
            this.toolStripTabs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTabsServices,
            this.toolStripTabsProfRab,
            this.toolStripTabsPrinters,
            this.toolStripTabsListRequests,
            this.toolStripTabsAddRequests});
            this.toolStripTabs.Name = "toolStripTabs";
            this.toolStripTabs.Size = new System.Drawing.Size(64, 20);
            this.toolStripTabs.Text = "Вкладки";
            // 
            // toolStripTabsServices
            // 
            this.toolStripTabsServices.Name = "toolStripTabsServices";
            this.toolStripTabsServices.Size = new System.Drawing.Size(180, 22);
            this.toolStripTabsServices.Text = "Сервис";
            this.toolStripTabsServices.Click += new System.EventHandler(this.toolStripTabsServices_Click);
            // 
            // toolStripTabsProfRab
            // 
            this.toolStripTabsProfRab.Name = "toolStripTabsProfRab";
            this.toolStripTabsProfRab.Size = new System.Drawing.Size(180, 22);
            this.toolStripTabsProfRab.Text = "Проф. работы";
            this.toolStripTabsProfRab.Click += new System.EventHandler(this.toolStripTabsServices_Click);
            // 
            // toolStripTabsPrinters
            // 
            this.toolStripTabsPrinters.Name = "toolStripTabsPrinters";
            this.toolStripTabsPrinters.Size = new System.Drawing.Size(180, 22);
            this.toolStripTabsPrinters.Text = "Принтеры";
            this.toolStripTabsPrinters.Click += new System.EventHandler(this.toolStripTabsServices_Click);
            // 
            // toolStripTabsListRequests
            // 
            this.toolStripTabsListRequests.Name = "toolStripTabsListRequests";
            this.toolStripTabsListRequests.Size = new System.Drawing.Size(180, 22);
            this.toolStripTabsListRequests.Text = "Список заявок";
            this.toolStripTabsListRequests.Click += new System.EventHandler(this.toolStripTabsServices_Click);
            // 
            // toolStripTabsAddRequests
            // 
            this.toolStripTabsAddRequests.Name = "toolStripTabsAddRequests";
            this.toolStripTabsAddRequests.Size = new System.Drawing.Size(180, 22);
            this.toolStripTabsAddRequests.Text = "Добавление заявок";
            this.toolStripTabsAddRequests.Click += new System.EventHandler(this.toolStripTabsServices_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            // 
            // pnlTabs
            // 
            this.pnlTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTabs.Location = new System.Drawing.Point(0, 27);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(634, 619);
            this.pnlTabs.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 646);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pnlTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 685);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All in One";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripExit;
        private System.Windows.Forms.ToolStripMenuItem toDoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteAccsessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripDB;
        private System.Windows.Forms.ToolStripMenuItem toolStripDBCheckCon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripDBInvertCon;
        private System.Windows.Forms.ToolStripMenuItem toolStripExcel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem toolStripAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripTabs;
        private System.Windows.Forms.ToolStripMenuItem toolStripTabsServices;
        private System.Windows.Forms.ToolStripMenuItem toolStripTabsProfRab;
        private System.Windows.Forms.ToolStripMenuItem toolStripTabsPrinters;
        private System.Windows.Forms.ToolStripMenuItem toolStripTabsListRequests;
        private System.Windows.Forms.ToolStripMenuItem toolStripTabsAddRequests;
        public System.Windows.Forms.Panel pnlTabs;
    }
}

