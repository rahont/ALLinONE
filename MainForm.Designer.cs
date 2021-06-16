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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteAccsessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrComm5555 = new System.Windows.Forms.Timer(this.components);
            this.tmrServicePB = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl = new System.Windows.Forms.CustomTabControl();
            this.tabPageService = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCyclePingStop = new System.Windows.Forms.Button();
            this.lbCyclePing = new System.Windows.Forms.ListBox();
            this.btnCyclePingStart = new System.Windows.Forms.Button();
            this.tbCyclePingAdress = new ALLinONE.MyTextBox();
            this.lblMSTSC = new System.Windows.Forms.Label();
            this.btnMSTSCstart = new System.Windows.Forms.Button();
            this.tbMSTSCadress = new ALLinONE.MyTextBox();
            this.tbMSTSCpass = new ALLinONE.MyTextBox();
            this.tbMSTSClogin = new ALLinONE.MyTextBox();
            this.lblPingTimeTimeOut = new System.Windows.Forms.Label();
            this.lblPingTimeRefresh = new System.Windows.Forms.Label();
            this.btnRefreshPing = new System.Windows.Forms.Button();
            this.numPingTimeOut = new System.Windows.Forms.NumericUpDown();
            this.numPingProgress = new System.Windows.Forms.NumericUpDown();
            this.pbPingProgress = new System.Windows.Forms.ProgressBar();
            this.lblPingTimeOut = new System.Windows.Forms.Label();
            this.lblPingSuccess = new System.Windows.Forms.Label();
            this.lbPingTimeOut = new System.Windows.Forms.ListBox();
            this.lbPingSuccess = new System.Windows.Forms.ListBox();
            this.btnSrvcChange = new System.Windows.Forms.Button();
            this.chckbServiceSorted = new System.Windows.Forms.CheckBox();
            this.lblShare = new System.Windows.Forms.Label();
            this.lblRDP = new System.Windows.Forms.Label();
            this.lbShare = new System.Windows.Forms.ListBox();
            this.lbRDP = new System.Windows.Forms.ListBox();
            this.tabPageProfRab = new System.Windows.Forms.TabPage();
            this.lblPR = new System.Windows.Forms.Label();
            this.btnPR1 = new System.Windows.Forms.Button();
            this.btnPR4 = new System.Windows.Forms.Button();
            this.btnPRChange = new System.Windows.Forms.Button();
            this.btnPR26 = new System.Windows.Forms.Button();
            this.btnPR2 = new System.Windows.Forms.Button();
            this.btnPR25 = new System.Windows.Forms.Button();
            this.btnPR5 = new System.Windows.Forms.Button();
            this.btnPR3 = new System.Windows.Forms.Button();
            this.btnPR23 = new System.Windows.Forms.Button();
            this.btnPR6 = new System.Windows.Forms.Button();
            this.btnPR7 = new System.Windows.Forms.Button();
            this.btnPR8 = new System.Windows.Forms.Button();
            this.btnPR9 = new System.Windows.Forms.Button();
            this.btnPR24 = new System.Windows.Forms.Button();
            this.btnPR10 = new System.Windows.Forms.Button();
            this.btnPR22 = new System.Windows.Forms.Button();
            this.btnPR11 = new System.Windows.Forms.Button();
            this.btnPR21 = new System.Windows.Forms.Button();
            this.btnPR12 = new System.Windows.Forms.Button();
            this.btnPR20 = new System.Windows.Forms.Button();
            this.btnPR13 = new System.Windows.Forms.Button();
            this.btnPR19 = new System.Windows.Forms.Button();
            this.btnPR14 = new System.Windows.Forms.Button();
            this.btnPR18 = new System.Windows.Forms.Button();
            this.btnPR15 = new System.Windows.Forms.Button();
            this.btnPR17 = new System.Windows.Forms.Button();
            this.btnPR16 = new System.Windows.Forms.Button();
            this.tabPagePrinters = new System.Windows.Forms.TabPage();
            this.btnPrintChange = new System.Windows.Forms.Button();
            this.tbPrintInvNumber = new ALLinONE.MyTextBox();
            this.tbPrintLocation = new ALLinONE.MyTextBox();
            this.tbPrintNetName = new ALLinONE.MyTextBox();
            this.tbPrintName = new ALLinONE.MyTextBox();
            this.dgvPrinters = new System.Windows.Forms.DataGridView();
            this.btnPrintPrinting = new System.Windows.Forms.Button();
            this.btnPrintRemove = new System.Windows.Forms.Button();
            this.tbPrintName1 = new System.Windows.Forms.TextBox();
            this.lblPrintBuffer = new System.Windows.Forms.Label();
            this.tbPrintNetName1 = new System.Windows.Forms.TextBox();
            this.lblPrintInvNumber = new System.Windows.Forms.Label();
            this.tbPrintLocation1 = new System.Windows.Forms.TextBox();
            this.lblPrintLocation = new System.Windows.Forms.Label();
            this.btnPrintAdd = new System.Windows.Forms.Button();
            this.lblPrintNetName = new System.Windows.Forms.Label();
            this.tbPrintInvNumber1 = new System.Windows.Forms.TextBox();
            this.lblPrintName = new System.Windows.Forms.Label();
            this.tabPageDBList = new System.Windows.Forms.TabPage();
            this.chkbPrefixShow = new System.Windows.Forms.CheckBox();
            this.tbPrefixRequest = new ALLinONE.MyTextBox();
            this.tbAddRequest = new ALLinONE.MyTextBox();
            this.btnClearAllRequest = new System.Windows.Forms.Button();
            this.lblInfoRequest = new System.Windows.Forms.Label();
            this.dgvRequest = new System.Windows.Forms.DataGridView();
            this.chckbMyRequest = new System.Windows.Forms.CheckBox();
            this.chckbRemoveRequest = new System.Windows.Forms.CheckBox();
            this.btnAddRequest = new System.Windows.Forms.Button();
            this.btnAddRequestBuffer = new System.Windows.Forms.Button();
            this.btnRemoveRequest = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblUserRequest = new System.Windows.Forms.Label();
            this.tabPageAddRequest = new System.Windows.Forms.TabPage();
            this.btnMassRequest = new System.Windows.Forms.Button();
            this.tbAddFIORequest = new ALLinONE.MyTextBox();
            this.tbAddProg = new ALLinONE.MyTextBox();
            this.btnCartPaper = new System.Windows.Forms.Button();
            this.btnRemoveProg = new System.Windows.Forms.Button();
            this.btnAddProg = new System.Windows.Forms.Button();
            this.lblAddRequestDB = new System.Windows.Forms.Label();
            this.btnAddRequestDB = new System.Windows.Forms.Button();
            this.gbAddRequest = new System.Windows.Forms.GroupBox();
            this.rdbtnAddRequest3 = new System.Windows.Forms.RadioButton();
            this.rdbtnAddRequest4 = new System.Windows.Forms.RadioButton();
            this.rdbtnAddRequest2 = new System.Windows.Forms.RadioButton();
            this.rdbtnAddRequest1 = new System.Windows.Forms.RadioButton();
            this.lbProgList = new System.Windows.Forms.ListBox();
            this.toolStripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPingTimeOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPingProgress)).BeginInit();
            this.tabPageProfRab.SuspendLayout();
            this.tabPagePrinters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinters)).BeginInit();
            this.tabPageDBList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
            this.tabPageAddRequest.SuspendLayout();
            this.gbAddRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFile,
            this.toDoToolStripMenuItem,
            this.remoteAccsessToolStripMenuItem,
            this.toolStripExcel});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
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
            this.toolStripDB.Size = new System.Drawing.Size(180, 22);
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
            this.toolStripSettings.Size = new System.Drawing.Size(180, 22);
            this.toolStripSettings.Text = "Настройки";
            this.toolStripSettings.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripExit
            // 
            this.toolStripExit.Image = global::ALLinONE.Properties.Resources.switch_power_on_off_icon_178313;
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(180, 22);
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
            this.toolStripExcel.Click += new System.EventHandler(this.toolStripExcel_Click);
            // 
            // tmrComm5555
            // 
            this.tmrComm5555.Interval = 5555;
            this.tmrComm5555.Tick += new System.EventHandler(this.tmrRequest_Tick);
            // 
            // tmrServicePB
            // 
            this.tmrServicePB.Tick += new System.EventHandler(this.tmrServicePB_Tick);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xlsx";
            this.saveFileDialog.FileName = "AiO";
            this.saveFileDialog.Filter = "xlsx|*.xlsx|All Files|*.*";
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageService);
            this.tabControl.Controls.Add(this.tabPageProfRab);
            this.tabControl.Controls.Add(this.tabPagePrinters);
            this.tabControl.Controls.Add(this.tabPageDBList);
            this.tabControl.Controls.Add(this.tabPageAddRequest);
            this.tabControl.DisplayStyle = System.Windows.Forms.TabStyle.Angled;
            // 
            // 
            // 
            this.tabControl.DisplayStyleProvider.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.tabControl.DisplayStyleProvider.BorderColorHot = System.Drawing.SystemColors.ControlDark;
            this.tabControl.DisplayStyleProvider.BorderColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControl.DisplayStyleProvider.CloserColor = System.Drawing.Color.DarkGray;
            this.tabControl.DisplayStyleProvider.FocusTrack = false;
            this.tabControl.DisplayStyleProvider.HotTrack = true;
            this.tabControl.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tabControl.DisplayStyleProvider.Opacity = 1F;
            this.tabControl.DisplayStyleProvider.Overlap = 7;
            this.tabControl.DisplayStyleProvider.Padding = new System.Drawing.Point(10, 3);
            this.tabControl.DisplayStyleProvider.Radius = 10;
            this.tabControl.DisplayStyleProvider.ShowTabCloser = false;
            this.tabControl.DisplayStyleProvider.TextColor = System.Drawing.SystemColors.ControlText;
            this.tabControl.DisplayStyleProvider.TextColorDisabled = System.Drawing.SystemColors.ControlDark;
            this.tabControl.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(0, 22);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(634, 624);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Selecting);
            // 
            // tabPageService
            // 
            this.tabPageService.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageService.Controls.Add(this.button1);
            this.tabPageService.Controls.Add(this.btnCyclePingStop);
            this.tabPageService.Controls.Add(this.lbCyclePing);
            this.tabPageService.Controls.Add(this.btnCyclePingStart);
            this.tabPageService.Controls.Add(this.tbCyclePingAdress);
            this.tabPageService.Controls.Add(this.lblMSTSC);
            this.tabPageService.Controls.Add(this.btnMSTSCstart);
            this.tabPageService.Controls.Add(this.tbMSTSCadress);
            this.tabPageService.Controls.Add(this.tbMSTSCpass);
            this.tabPageService.Controls.Add(this.tbMSTSClogin);
            this.tabPageService.Controls.Add(this.lblPingTimeTimeOut);
            this.tabPageService.Controls.Add(this.lblPingTimeRefresh);
            this.tabPageService.Controls.Add(this.btnRefreshPing);
            this.tabPageService.Controls.Add(this.numPingTimeOut);
            this.tabPageService.Controls.Add(this.numPingProgress);
            this.tabPageService.Controls.Add(this.pbPingProgress);
            this.tabPageService.Controls.Add(this.lblPingTimeOut);
            this.tabPageService.Controls.Add(this.lblPingSuccess);
            this.tabPageService.Controls.Add(this.lbPingTimeOut);
            this.tabPageService.Controls.Add(this.lbPingSuccess);
            this.tabPageService.Controls.Add(this.btnSrvcChange);
            this.tabPageService.Controls.Add(this.chckbServiceSorted);
            this.tabPageService.Controls.Add(this.lblShare);
            this.tabPageService.Controls.Add(this.lblRDP);
            this.tabPageService.Controls.Add(this.lbShare);
            this.tabPageService.Controls.Add(this.lbRDP);
            this.tabPageService.Location = new System.Drawing.Point(4, 23);
            this.tabPageService.Name = "tabPageService";
            this.tabPageService.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageService.Size = new System.Drawing.Size(626, 597);
            this.tabPageService.TabIndex = 1;
            this.tabPageService.Text = "Сервис";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 48;
            this.button1.TabStop = false;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCyclePingStop
            // 
            this.btnCyclePingStop.Location = new System.Drawing.Point(574, 424);
            this.btnCyclePingStop.Name = "btnCyclePingStop";
            this.btnCyclePingStop.Size = new System.Drawing.Size(42, 21);
            this.btnCyclePingStop.TabIndex = 14;
            this.btnCyclePingStop.Text = "Стоп";
            this.btnCyclePingStop.UseVisualStyleBackColor = true;
            this.btnCyclePingStop.Click += new System.EventHandler(this.btnCyclePingStop_Click);
            // 
            // lbCyclePing
            // 
            this.lbCyclePing.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbCyclePing.FormattingEnabled = true;
            this.lbCyclePing.Location = new System.Drawing.Point(325, 451);
            this.lbCyclePing.Name = "lbCyclePing";
            this.lbCyclePing.Size = new System.Drawing.Size(291, 95);
            this.lbCyclePing.TabIndex = 15;
            this.lbCyclePing.TabStop = false;
            this.lbCyclePing.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbCyclePing_DrawItem);
            // 
            // btnCyclePingStart
            // 
            this.btnCyclePingStart.Location = new System.Drawing.Point(521, 424);
            this.btnCyclePingStart.Name = "btnCyclePingStart";
            this.btnCyclePingStart.Size = new System.Drawing.Size(44, 22);
            this.btnCyclePingStart.TabIndex = 13;
            this.btnCyclePingStart.Text = "Старт";
            this.btnCyclePingStart.UseVisualStyleBackColor = true;
            this.btnCyclePingStart.Click += new System.EventHandler(this.btnCyclePingStart_Click);
            // 
            // tbCyclePingAdress
            // 
            this.tbCyclePingAdress.Location = new System.Drawing.Point(325, 425);
            this.tbCyclePingAdress.MaximumSize = new System.Drawing.Size(1000, 20);
            this.tbCyclePingAdress.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbCyclePingAdress.Name = "tbCyclePingAdress";
            this.tbCyclePingAdress.PasswordChar = '\0';
            this.tbCyclePingAdress.Size = new System.Drawing.Size(190, 20);
            this.tbCyclePingAdress.TabIndex = 12;
            this.tbCyclePingAdress.TextMaxLength = 1024;
            this.tbCyclePingAdress.TextTitle = "IP-адрес или DNS-имя";
            this.tbCyclePingAdress.KeyDownEvent += new System.Windows.Forms.KeyEventHandler(this.tbCyclePingAdress_KeyDownEvent);
            // 
            // lblMSTSC
            // 
            this.lblMSTSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMSTSC.Location = new System.Drawing.Point(309, 356);
            this.lblMSTSC.Name = "lblMSTSC";
            this.lblMSTSC.Size = new System.Drawing.Size(10, 45);
            this.lblMSTSC.TabIndex = 43;
            this.lblMSTSC.Text = "MSTSC";
            // 
            // btnMSTSCstart
            // 
            this.btnMSTSCstart.Location = new System.Drawing.Point(548, 355);
            this.btnMSTSCstart.Name = "btnMSTSCstart";
            this.btnMSTSCstart.Size = new System.Drawing.Size(68, 47);
            this.btnMSTSCstart.TabIndex = 11;
            this.btnMSTSCstart.Text = "Запустить RDP";
            this.btnMSTSCstart.UseVisualStyleBackColor = true;
            this.btnMSTSCstart.Click += new System.EventHandler(this.btnMSTSCstart_Click);
            // 
            // tbMSTSCadress
            // 
            this.tbMSTSCadress.Location = new System.Drawing.Point(325, 381);
            this.tbMSTSCadress.MaximumSize = new System.Drawing.Size(1000, 20);
            this.tbMSTSCadress.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbMSTSCadress.Name = "tbMSTSCadress";
            this.tbMSTSCadress.PasswordChar = '\0';
            this.tbMSTSCadress.Size = new System.Drawing.Size(217, 20);
            this.tbMSTSCadress.TabIndex = 10;
            this.tbMSTSCadress.TextMaxLength = 1024;
            this.tbMSTSCadress.TextTitle = "IP-адрес или DNS-имя";
            this.tbMSTSCadress.KeyDownEvent += new System.Windows.Forms.KeyEventHandler(this.tbMSTSCadress_KeyDownEvent);
            this.tbMSTSCadress._TextChanged += new System.EventHandler(this.tbMSTSCadress_TextChanged);
            // 
            // tbMSTSCpass
            // 
            this.tbMSTSCpass.Location = new System.Drawing.Point(455, 356);
            this.tbMSTSCpass.MaximumSize = new System.Drawing.Size(1000, 20);
            this.tbMSTSCpass.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbMSTSCpass.Name = "tbMSTSCpass";
            this.tbMSTSCpass.PasswordChar = '*';
            this.tbMSTSCpass.Size = new System.Drawing.Size(87, 20);
            this.tbMSTSCpass.TabIndex = 9;
            this.tbMSTSCpass.TextMaxLength = 1024;
            this.tbMSTSCpass.TextTitle = "Пароль (опц.)";
            this.tbMSTSCpass.KeyDownEvent += new System.Windows.Forms.KeyEventHandler(this.tbMSTSCadress_KeyDownEvent);
            // 
            // tbMSTSClogin
            // 
            this.tbMSTSClogin.Location = new System.Drawing.Point(325, 356);
            this.tbMSTSClogin.MaximumSize = new System.Drawing.Size(1000, 20);
            this.tbMSTSClogin.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbMSTSClogin.Name = "tbMSTSClogin";
            this.tbMSTSClogin.PasswordChar = '\0';
            this.tbMSTSClogin.Size = new System.Drawing.Size(124, 20);
            this.tbMSTSClogin.TabIndex = 8;
            this.tbMSTSClogin.TextMaxLength = 1024;
            this.tbMSTSClogin.TextTitle = "Логин (опционально)";
            this.tbMSTSClogin.KeyDownEvent += new System.Windows.Forms.KeyEventHandler(this.tbMSTSCadress_KeyDownEvent);
            // 
            // lblPingTimeTimeOut
            // 
            this.lblPingTimeTimeOut.AutoSize = true;
            this.lblPingTimeTimeOut.Location = new System.Drawing.Point(198, 550);
            this.lblPingTimeTimeOut.Name = "lblPingTimeTimeOut";
            this.lblPingTimeTimeOut.Size = new System.Drawing.Size(88, 13);
            this.lblPingTimeTimeOut.TabIndex = 38;
            this.lblPingTimeTimeOut.Text = "Таймаут пакета";
            this.lblPingTimeTimeOut.MouseHover += new System.EventHandler(this.lblPingTimeRefresh_MouseHover);
            // 
            // lblPingTimeRefresh
            // 
            this.lblPingTimeRefresh.AccessibleDescription = "";
            this.lblPingTimeRefresh.AutoSize = true;
            this.lblPingTimeRefresh.Location = new System.Drawing.Point(11, 550);
            this.lblPingTimeRefresh.Name = "lblPingTimeRefresh";
            this.lblPingTimeRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPingTimeRefresh.Size = new System.Drawing.Size(94, 13);
            this.lblPingTimeRefresh.TabIndex = 37;
            this.lblPingTimeRefresh.Text = "Обновлять через";
            this.lblPingTimeRefresh.MouseHover += new System.EventHandler(this.lblPingTimeRefresh_MouseHover);
            // 
            // btnRefreshPing
            // 
            this.btnRefreshPing.Location = new System.Drawing.Point(275, 574);
            this.btnRefreshPing.Name = "btnRefreshPing";
            this.btnRefreshPing.Size = new System.Drawing.Size(75, 20);
            this.btnRefreshPing.TabIndex = 7;
            this.btnRefreshPing.Text = "Обновить";
            this.btnRefreshPing.UseVisualStyleBackColor = true;
            this.btnRefreshPing.Click += new System.EventHandler(this.btnRefreshPing_Click);
            // 
            // numPingTimeOut
            // 
            this.numPingTimeOut.Location = new System.Drawing.Point(155, 548);
            this.numPingTimeOut.Maximum = new decimal(new int[] {
            164,
            0,
            0,
            0});
            this.numPingTimeOut.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numPingTimeOut.Name = "numPingTimeOut";
            this.numPingTimeOut.Size = new System.Drawing.Size(39, 20);
            this.numPingTimeOut.TabIndex = 6;
            this.numPingTimeOut.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // numPingProgress
            // 
            this.numPingProgress.Location = new System.Drawing.Point(109, 548);
            this.numPingProgress.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numPingProgress.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPingProgress.Name = "numPingProgress";
            this.numPingProgress.Size = new System.Drawing.Size(34, 20);
            this.numPingProgress.TabIndex = 5;
            this.numPingProgress.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numPingProgress.ValueChanged += new System.EventHandler(this.numPingProgress_ValueChanged);
            // 
            // pbPingProgress
            // 
            this.pbPingProgress.Location = new System.Drawing.Point(27, 574);
            this.pbPingProgress.Maximum = 10000;
            this.pbPingProgress.Name = "pbPingProgress";
            this.pbPingProgress.Size = new System.Drawing.Size(242, 20);
            this.pbPingProgress.TabIndex = 34;
            // 
            // lblPingTimeOut
            // 
            this.lblPingTimeOut.AutoSize = true;
            this.lblPingTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPingTimeOut.Location = new System.Drawing.Point(176, 339);
            this.lblPingTimeOut.Name = "lblPingTimeOut";
            this.lblPingTimeOut.Size = new System.Drawing.Size(92, 15);
            this.lblPingTimeOut.TabIndex = 33;
            this.lblPingTimeOut.Text = "Не доступны";
            // 
            // lblPingSuccess
            // 
            this.lblPingSuccess.AutoSize = true;
            this.lblPingSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPingSuccess.Location = new System.Drawing.Point(38, 339);
            this.lblPingSuccess.Name = "lblPingSuccess";
            this.lblPingSuccess.Size = new System.Drawing.Size(72, 15);
            this.lblPingSuccess.TabIndex = 32;
            this.lblPingSuccess.Text = "Доступны";
            // 
            // lbPingTimeOut
            // 
            this.lbPingTimeOut.ForeColor = System.Drawing.Color.Maroon;
            this.lbPingTimeOut.FormattingEnabled = true;
            this.lbPingTimeOut.Location = new System.Drawing.Point(155, 356);
            this.lbPingTimeOut.Name = "lbPingTimeOut";
            this.lbPingTimeOut.Size = new System.Drawing.Size(135, 186);
            this.lbPingTimeOut.Sorted = true;
            this.lbPingTimeOut.TabIndex = 4;
            this.lbPingTimeOut.Leave += new System.EventHandler(this.lbRDP_Leave);
            // 
            // lbPingSuccess
            // 
            this.lbPingSuccess.ForeColor = System.Drawing.Color.Green;
            this.lbPingSuccess.FormattingEnabled = true;
            this.lbPingSuccess.Location = new System.Drawing.Point(8, 356);
            this.lbPingSuccess.Name = "lbPingSuccess";
            this.lbPingSuccess.Size = new System.Drawing.Size(135, 186);
            this.lbPingSuccess.Sorted = true;
            this.lbPingSuccess.TabIndex = 3;
            this.lbPingSuccess.Leave += new System.EventHandler(this.lbRDP_Leave);
            // 
            // btnSrvcChange
            // 
            this.btnSrvcChange.Location = new System.Drawing.Point(505, 553);
            this.btnSrvcChange.Name = "btnSrvcChange";
            this.btnSrvcChange.Size = new System.Drawing.Size(113, 37);
            this.btnSrvcChange.TabIndex = 16;
            this.btnSrvcChange.Text = "Может нам что-то поменять?";
            this.btnSrvcChange.UseVisualStyleBackColor = true;
            this.btnSrvcChange.Click += new System.EventHandler(this.btnSrvcChange_Click);
            // 
            // chckbServiceSorted
            // 
            this.chckbServiceSorted.Checked = true;
            this.chckbServiceSorted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckbServiceSorted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chckbServiceSorted.Location = new System.Drawing.Point(253, 283);
            this.chckbServiceSorted.Name = "chckbServiceSorted";
            this.chckbServiceSorted.Size = new System.Drawing.Size(58, 50);
            this.chckbServiceSorted.TabIndex = 2;
            this.chckbServiceSorted.Text = "Сорт. по имени";
            this.chckbServiceSorted.UseVisualStyleBackColor = true;
            this.chckbServiceSorted.CheckedChanged += new System.EventHandler(this.chckbServiceSorted_CheckedChanged);
            // 
            // lblShare
            // 
            this.lblShare.AutoSize = true;
            this.lblShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShare.Location = new System.Drawing.Point(435, 4);
            this.lblShare.Name = "lblShare";
            this.lblShare.Size = new System.Drawing.Size(57, 20);
            this.lblShare.TabIndex = 31;
            this.lblShare.Text = "Share";
            // 
            // lblRDP
            // 
            this.lblRDP.AutoSize = true;
            this.lblRDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRDP.Location = new System.Drawing.Point(97, 4);
            this.lblRDP.Name = "lblRDP";
            this.lblRDP.Size = new System.Drawing.Size(46, 20);
            this.lblRDP.TabIndex = 30;
            this.lblRDP.Text = "RDP";
            // 
            // lbShare
            // 
            this.lbShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbShare.FormattingEnabled = true;
            this.lbShare.ItemHeight = 18;
            this.lbShare.Location = new System.Drawing.Point(311, 26);
            this.lbShare.Name = "lbShare";
            this.lbShare.Size = new System.Drawing.Size(307, 310);
            this.lbShare.Sorted = true;
            this.lbShare.TabIndex = 1;
            this.lbShare.DoubleClick += new System.EventHandler(this.lbShare_DoubleClick);
            this.lbShare.Leave += new System.EventHandler(this.lbRDP_Leave);
            // 
            // lbRDP
            // 
            this.lbRDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRDP.FormattingEnabled = true;
            this.lbRDP.ItemHeight = 18;
            this.lbRDP.Location = new System.Drawing.Point(8, 26);
            this.lbRDP.Name = "lbRDP";
            this.lbRDP.Size = new System.Drawing.Size(242, 310);
            this.lbRDP.Sorted = true;
            this.lbRDP.TabIndex = 0;
            this.lbRDP.DoubleClick += new System.EventHandler(this.lbRDP_DoubleClick);
            this.lbRDP.Leave += new System.EventHandler(this.lbRDP_Leave);
            // 
            // tabPageProfRab
            // 
            this.tabPageProfRab.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageProfRab.Controls.Add(this.lblPR);
            this.tabPageProfRab.Controls.Add(this.btnPR1);
            this.tabPageProfRab.Controls.Add(this.btnPR4);
            this.tabPageProfRab.Controls.Add(this.btnPRChange);
            this.tabPageProfRab.Controls.Add(this.btnPR26);
            this.tabPageProfRab.Controls.Add(this.btnPR2);
            this.tabPageProfRab.Controls.Add(this.btnPR25);
            this.tabPageProfRab.Controls.Add(this.btnPR5);
            this.tabPageProfRab.Controls.Add(this.btnPR3);
            this.tabPageProfRab.Controls.Add(this.btnPR23);
            this.tabPageProfRab.Controls.Add(this.btnPR6);
            this.tabPageProfRab.Controls.Add(this.btnPR7);
            this.tabPageProfRab.Controls.Add(this.btnPR8);
            this.tabPageProfRab.Controls.Add(this.btnPR9);
            this.tabPageProfRab.Controls.Add(this.btnPR24);
            this.tabPageProfRab.Controls.Add(this.btnPR10);
            this.tabPageProfRab.Controls.Add(this.btnPR22);
            this.tabPageProfRab.Controls.Add(this.btnPR11);
            this.tabPageProfRab.Controls.Add(this.btnPR21);
            this.tabPageProfRab.Controls.Add(this.btnPR12);
            this.tabPageProfRab.Controls.Add(this.btnPR20);
            this.tabPageProfRab.Controls.Add(this.btnPR13);
            this.tabPageProfRab.Controls.Add(this.btnPR19);
            this.tabPageProfRab.Controls.Add(this.btnPR14);
            this.tabPageProfRab.Controls.Add(this.btnPR18);
            this.tabPageProfRab.Controls.Add(this.btnPR15);
            this.tabPageProfRab.Controls.Add(this.btnPR17);
            this.tabPageProfRab.Controls.Add(this.btnPR16);
            this.tabPageProfRab.Location = new System.Drawing.Point(4, 23);
            this.tabPageProfRab.Name = "tabPageProfRab";
            this.tabPageProfRab.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfRab.Size = new System.Drawing.Size(626, 597);
            this.tabPageProfRab.TabIndex = 0;
            this.tabPageProfRab.Text = "ПрофРаботы";
            // 
            // lblPR
            // 
            this.lblPR.AutoEllipsis = true;
            this.lblPR.Cursor = System.Windows.Forms.Cursors.No;
            this.lblPR.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPR.Enabled = false;
            this.lblPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPR.Location = new System.Drawing.Point(3, 485);
            this.lblPR.Name = "lblPR";
            this.lblPR.Size = new System.Drawing.Size(620, 109);
            this.lblPR.TabIndex = 27;
            this.lblPR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPR1
            // 
            this.btnPR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR1.Location = new System.Drawing.Point(6, 6);
            this.btnPR1.Name = "btnPR1";
            this.btnPR1.Size = new System.Drawing.Size(118, 39);
            this.btnPR1.TabIndex = 0;
            this.btnPR1.Text = "DB Error";
            this.btnPR1.UseVisualStyleBackColor = true;
            this.btnPR1.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR4
            // 
            this.btnPR4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR4.Location = new System.Drawing.Point(378, 6);
            this.btnPR4.Name = "btnPR4";
            this.btnPR4.Size = new System.Drawing.Size(118, 39);
            this.btnPR4.TabIndex = 3;
            this.btnPR4.Text = "DB Error";
            this.btnPR4.UseVisualStyleBackColor = true;
            this.btnPR4.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPRChange
            // 
            this.btnPRChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPRChange.Location = new System.Drawing.Point(539, 431);
            this.btnPRChange.Name = "btnPRChange";
            this.btnPRChange.Size = new System.Drawing.Size(81, 40);
            this.btnPRChange.TabIndex = 26;
            this.btnPRChange.TabStop = false;
            this.btnPRChange.Text = "Изменить";
            this.btnPRChange.UseVisualStyleBackColor = true;
            this.btnPRChange.Click += new System.EventHandler(this.BtnPRChange_Click);
            // 
            // btnPR26
            // 
            this.btnPR26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR26.Location = new System.Drawing.Point(130, 431);
            this.btnPR26.Name = "btnPR26";
            this.btnPR26.Size = new System.Drawing.Size(282, 40);
            this.btnPR26.TabIndex = 25;
            this.btnPR26.Text = "DB Error";
            this.btnPR26.UseVisualStyleBackColor = true;
            this.btnPR26.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR2
            // 
            this.btnPR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR2.Location = new System.Drawing.Point(130, 7);
            this.btnPR2.Name = "btnPR2";
            this.btnPR2.Size = new System.Drawing.Size(118, 39);
            this.btnPR2.TabIndex = 1;
            this.btnPR2.Text = "DB Error";
            this.btnPR2.UseVisualStyleBackColor = true;
            this.btnPR2.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR25
            // 
            this.btnPR25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR25.Location = new System.Drawing.Point(6, 431);
            this.btnPR25.Name = "btnPR25";
            this.btnPR25.Size = new System.Drawing.Size(107, 40);
            this.btnPR25.TabIndex = 24;
            this.btnPR25.Text = "DB Error";
            this.btnPR25.UseVisualStyleBackColor = true;
            this.btnPR25.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR5
            // 
            this.btnPR5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR5.Location = new System.Drawing.Point(502, 6);
            this.btnPR5.Name = "btnPR5";
            this.btnPR5.Size = new System.Drawing.Size(118, 39);
            this.btnPR5.TabIndex = 4;
            this.btnPR5.Text = "DB Error";
            this.btnPR5.UseVisualStyleBackColor = true;
            this.btnPR5.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR3
            // 
            this.btnPR3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR3.Location = new System.Drawing.Point(254, 6);
            this.btnPR3.Name = "btnPR3";
            this.btnPR3.Size = new System.Drawing.Size(118, 39);
            this.btnPR3.TabIndex = 2;
            this.btnPR3.Text = "DB Error";
            this.btnPR3.UseVisualStyleBackColor = true;
            this.btnPR3.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR23
            // 
            this.btnPR23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR23.Location = new System.Drawing.Point(254, 186);
            this.btnPR23.Name = "btnPR23";
            this.btnPR23.Size = new System.Drawing.Size(118, 39);
            this.btnPR23.TabIndex = 22;
            this.btnPR23.Text = "DB Error";
            this.btnPR23.UseVisualStyleBackColor = true;
            this.btnPR23.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR6
            // 
            this.btnPR6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR6.Location = new System.Drawing.Point(6, 51);
            this.btnPR6.Name = "btnPR6";
            this.btnPR6.Size = new System.Drawing.Size(118, 39);
            this.btnPR6.TabIndex = 5;
            this.btnPR6.Text = "DB Error";
            this.btnPR6.UseVisualStyleBackColor = true;
            this.btnPR6.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR7
            // 
            this.btnPR7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR7.Location = new System.Drawing.Point(130, 51);
            this.btnPR7.Name = "btnPR7";
            this.btnPR7.Size = new System.Drawing.Size(118, 39);
            this.btnPR7.TabIndex = 6;
            this.btnPR7.Text = "DB Error";
            this.btnPR7.UseVisualStyleBackColor = true;
            this.btnPR7.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR8
            // 
            this.btnPR8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR8.Location = new System.Drawing.Point(254, 51);
            this.btnPR8.Name = "btnPR8";
            this.btnPR8.Size = new System.Drawing.Size(118, 39);
            this.btnPR8.TabIndex = 7;
            this.btnPR8.Text = "DB Error";
            this.btnPR8.UseVisualStyleBackColor = true;
            this.btnPR8.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR9
            // 
            this.btnPR9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR9.Location = new System.Drawing.Point(378, 51);
            this.btnPR9.Name = "btnPR9";
            this.btnPR9.Size = new System.Drawing.Size(118, 39);
            this.btnPR9.TabIndex = 8;
            this.btnPR9.Text = "DB Error";
            this.btnPR9.UseVisualStyleBackColor = true;
            this.btnPR9.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR24
            // 
            this.btnPR24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR24.Location = new System.Drawing.Point(378, 186);
            this.btnPR24.Name = "btnPR24";
            this.btnPR24.Size = new System.Drawing.Size(118, 39);
            this.btnPR24.TabIndex = 23;
            this.btnPR24.Text = "DB Error";
            this.btnPR24.UseVisualStyleBackColor = true;
            this.btnPR24.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR10
            // 
            this.btnPR10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR10.Location = new System.Drawing.Point(502, 51);
            this.btnPR10.Name = "btnPR10";
            this.btnPR10.Size = new System.Drawing.Size(118, 39);
            this.btnPR10.TabIndex = 9;
            this.btnPR10.Text = "DB Error";
            this.btnPR10.UseVisualStyleBackColor = true;
            this.btnPR10.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR22
            // 
            this.btnPR22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR22.Location = new System.Drawing.Point(130, 186);
            this.btnPR22.Name = "btnPR22";
            this.btnPR22.Size = new System.Drawing.Size(118, 39);
            this.btnPR22.TabIndex = 21;
            this.btnPR22.Text = "DB Error";
            this.btnPR22.UseVisualStyleBackColor = true;
            this.btnPR22.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR11
            // 
            this.btnPR11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR11.Location = new System.Drawing.Point(6, 96);
            this.btnPR11.Name = "btnPR11";
            this.btnPR11.Size = new System.Drawing.Size(118, 39);
            this.btnPR11.TabIndex = 10;
            this.btnPR11.Text = "DB Error";
            this.btnPR11.UseVisualStyleBackColor = true;
            this.btnPR11.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR21
            // 
            this.btnPR21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR21.Location = new System.Drawing.Point(6, 186);
            this.btnPR21.Name = "btnPR21";
            this.btnPR21.Size = new System.Drawing.Size(118, 39);
            this.btnPR21.TabIndex = 20;
            this.btnPR21.Text = "DB Error";
            this.btnPR21.UseVisualStyleBackColor = true;
            this.btnPR21.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR12
            // 
            this.btnPR12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR12.Location = new System.Drawing.Point(130, 96);
            this.btnPR12.Name = "btnPR12";
            this.btnPR12.Size = new System.Drawing.Size(118, 39);
            this.btnPR12.TabIndex = 11;
            this.btnPR12.Text = "DB Error";
            this.btnPR12.UseVisualStyleBackColor = true;
            this.btnPR12.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR20
            // 
            this.btnPR20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR20.Location = new System.Drawing.Point(502, 141);
            this.btnPR20.Name = "btnPR20";
            this.btnPR20.Size = new System.Drawing.Size(118, 39);
            this.btnPR20.TabIndex = 19;
            this.btnPR20.Text = "DB Error";
            this.btnPR20.UseVisualStyleBackColor = true;
            this.btnPR20.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR13
            // 
            this.btnPR13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR13.Location = new System.Drawing.Point(254, 96);
            this.btnPR13.Name = "btnPR13";
            this.btnPR13.Size = new System.Drawing.Size(118, 39);
            this.btnPR13.TabIndex = 12;
            this.btnPR13.Text = "DB Error";
            this.btnPR13.UseVisualStyleBackColor = true;
            this.btnPR13.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR19
            // 
            this.btnPR19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR19.Location = new System.Drawing.Point(378, 141);
            this.btnPR19.Name = "btnPR19";
            this.btnPR19.Size = new System.Drawing.Size(118, 39);
            this.btnPR19.TabIndex = 18;
            this.btnPR19.Text = "DB Error";
            this.btnPR19.UseVisualStyleBackColor = true;
            this.btnPR19.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR14
            // 
            this.btnPR14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR14.Location = new System.Drawing.Point(378, 96);
            this.btnPR14.Name = "btnPR14";
            this.btnPR14.Size = new System.Drawing.Size(118, 39);
            this.btnPR14.TabIndex = 13;
            this.btnPR14.Text = "DB Error";
            this.btnPR14.UseVisualStyleBackColor = true;
            this.btnPR14.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR18
            // 
            this.btnPR18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR18.Location = new System.Drawing.Point(254, 141);
            this.btnPR18.Name = "btnPR18";
            this.btnPR18.Size = new System.Drawing.Size(118, 39);
            this.btnPR18.TabIndex = 17;
            this.btnPR18.Text = "DB Error";
            this.btnPR18.UseVisualStyleBackColor = true;
            this.btnPR18.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR15
            // 
            this.btnPR15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR15.Location = new System.Drawing.Point(502, 96);
            this.btnPR15.Name = "btnPR15";
            this.btnPR15.Size = new System.Drawing.Size(118, 39);
            this.btnPR15.TabIndex = 14;
            this.btnPR15.Text = "DB Error";
            this.btnPR15.UseVisualStyleBackColor = true;
            this.btnPR15.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR17
            // 
            this.btnPR17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR17.Location = new System.Drawing.Point(130, 141);
            this.btnPR17.Name = "btnPR17";
            this.btnPR17.Size = new System.Drawing.Size(118, 39);
            this.btnPR17.TabIndex = 16;
            this.btnPR17.Text = "DB Error";
            this.btnPR17.UseVisualStyleBackColor = true;
            this.btnPR17.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // btnPR16
            // 
            this.btnPR16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPR16.Location = new System.Drawing.Point(6, 141);
            this.btnPR16.Name = "btnPR16";
            this.btnPR16.Size = new System.Drawing.Size(118, 39);
            this.btnPR16.TabIndex = 15;
            this.btnPR16.Text = "DB Error";
            this.btnPR16.UseVisualStyleBackColor = true;
            this.btnPR16.Click += new System.EventHandler(this.BtnPR1_Click);
            // 
            // tabPagePrinters
            // 
            this.tabPagePrinters.BackColor = System.Drawing.SystemColors.Control;
            this.tabPagePrinters.Controls.Add(this.btnPrintChange);
            this.tabPagePrinters.Controls.Add(this.tbPrintInvNumber);
            this.tabPagePrinters.Controls.Add(this.tbPrintLocation);
            this.tabPagePrinters.Controls.Add(this.tbPrintNetName);
            this.tabPagePrinters.Controls.Add(this.tbPrintName);
            this.tabPagePrinters.Controls.Add(this.dgvPrinters);
            this.tabPagePrinters.Controls.Add(this.btnPrintPrinting);
            this.tabPagePrinters.Controls.Add(this.btnPrintRemove);
            this.tabPagePrinters.Controls.Add(this.tbPrintName1);
            this.tabPagePrinters.Controls.Add(this.lblPrintBuffer);
            this.tabPagePrinters.Controls.Add(this.tbPrintNetName1);
            this.tabPagePrinters.Controls.Add(this.lblPrintInvNumber);
            this.tabPagePrinters.Controls.Add(this.tbPrintLocation1);
            this.tabPagePrinters.Controls.Add(this.lblPrintLocation);
            this.tabPagePrinters.Controls.Add(this.btnPrintAdd);
            this.tabPagePrinters.Controls.Add(this.lblPrintNetName);
            this.tabPagePrinters.Controls.Add(this.tbPrintInvNumber1);
            this.tabPagePrinters.Controls.Add(this.lblPrintName);
            this.tabPagePrinters.Location = new System.Drawing.Point(4, 23);
            this.tabPagePrinters.Name = "tabPagePrinters";
            this.tabPagePrinters.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrinters.Size = new System.Drawing.Size(626, 597);
            this.tabPagePrinters.TabIndex = 2;
            this.tabPagePrinters.Text = "Принтеры";
            // 
            // btnPrintChange
            // 
            this.btnPrintChange.Location = new System.Drawing.Point(545, 539);
            this.btnPrintChange.Name = "btnPrintChange";
            this.btnPrintChange.Size = new System.Drawing.Size(75, 23);
            this.btnPrintChange.TabIndex = 5;
            this.btnPrintChange.Text = "Изменить";
            this.btnPrintChange.UseVisualStyleBackColor = true;
            this.btnPrintChange.Click += new System.EventHandler(this.btnPrintChange_Click);
            // 
            // tbPrintInvNumber
            // 
            this.tbPrintInvNumber.Location = new System.Drawing.Point(378, 568);
            this.tbPrintInvNumber.MaximumSize = new System.Drawing.Size(1000, 20);
            this.tbPrintInvNumber.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbPrintInvNumber.Name = "tbPrintInvNumber";
            this.tbPrintInvNumber.PasswordChar = '\0';
            this.tbPrintInvNumber.Size = new System.Drawing.Size(100, 20);
            this.tbPrintInvNumber.TabIndex = 15;
            this.tbPrintInvNumber.TextMaxLength = 15;
            this.tbPrintInvNumber.TextTitle = "Инвентарный";
            this.tbPrintInvNumber.Visible = false;
            // 
            // tbPrintLocation
            // 
            this.tbPrintLocation.Location = new System.Drawing.Point(256, 568);
            this.tbPrintLocation.MaximumSize = new System.Drawing.Size(1000, 20);
            this.tbPrintLocation.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbPrintLocation.Name = "tbPrintLocation";
            this.tbPrintLocation.PasswordChar = '\0';
            this.tbPrintLocation.Size = new System.Drawing.Size(100, 20);
            this.tbPrintLocation.TabIndex = 14;
            this.tbPrintLocation.TextMaxLength = 20;
            this.tbPrintLocation.TextTitle = "Расположение";
            this.tbPrintLocation.Visible = false;
            // 
            // tbPrintNetName
            // 
            this.tbPrintNetName.Location = new System.Drawing.Point(131, 568);
            this.tbPrintNetName.MaximumSize = new System.Drawing.Size(1000, 20);
            this.tbPrintNetName.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbPrintNetName.Name = "tbPrintNetName";
            this.tbPrintNetName.PasswordChar = '\0';
            this.tbPrintNetName.Size = new System.Drawing.Size(100, 20);
            this.tbPrintNetName.TabIndex = 13;
            this.tbPrintNetName.TextMaxLength = 50;
            this.tbPrintNetName.TextTitle = "Сетевое имя";
            this.tbPrintNetName.Visible = false;
            // 
            // tbPrintName
            // 
            this.tbPrintName.Location = new System.Drawing.Point(6, 568);
            this.tbPrintName.MaximumSize = new System.Drawing.Size(1000, 20);
            this.tbPrintName.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbPrintName.Name = "tbPrintName";
            this.tbPrintName.PasswordChar = '\0';
            this.tbPrintName.Size = new System.Drawing.Size(100, 20);
            this.tbPrintName.TabIndex = 12;
            this.tbPrintName.TextMaxLength = 100;
            this.tbPrintName.TextTitle = "Наименование";
            this.tbPrintName.Visible = false;
            // 
            // dgvPrinters
            // 
            this.dgvPrinters.AllowUserToAddRows = false;
            this.dgvPrinters.AllowUserToDeleteRows = false;
            this.dgvPrinters.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPrinters.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPrinters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPrinters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrinters.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPrinters.Location = new System.Drawing.Point(3, 3);
            this.dgvPrinters.MultiSelect = false;
            this.dgvPrinters.Name = "dgvPrinters";
            this.dgvPrinters.ReadOnly = true;
            this.dgvPrinters.RowHeadersVisible = false;
            this.dgvPrinters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrinters.Size = new System.Drawing.Size(620, 487);
            this.dgvPrinters.TabIndex = 0;
            this.dgvPrinters.TabStop = false;
            this.dgvPrinters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrinters_CellClick);
            this.dgvPrinters.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPrinters_KeyDown);
            // 
            // btnPrintPrinting
            // 
            this.btnPrintPrinting.Location = new System.Drawing.Point(353, 497);
            this.btnPrintPrinting.Name = "btnPrintPrinting";
            this.btnPrintPrinting.Size = new System.Drawing.Size(183, 23);
            this.btnPrintPrinting.TabIndex = 11;
            this.btnPrintPrinting.TabStop = false;
            this.btnPrintPrinting.Text = "Кривоватая, но все же печать";
            this.btnPrintPrinting.UseVisualStyleBackColor = true;
            this.btnPrintPrinting.Visible = false;
            this.btnPrintPrinting.Click += new System.EventHandler(this.btnPrintPrinting_Click);
            // 
            // btnPrintRemove
            // 
            this.btnPrintRemove.Location = new System.Drawing.Point(545, 568);
            this.btnPrintRemove.Name = "btnPrintRemove";
            this.btnPrintRemove.Size = new System.Drawing.Size(75, 23);
            this.btnPrintRemove.TabIndex = 6;
            this.btnPrintRemove.Text = "Удалить";
            this.btnPrintRemove.UseVisualStyleBackColor = true;
            this.btnPrintRemove.Click += new System.EventHandler(this.btnPrintRemove_Click);
            // 
            // tbPrintName1
            // 
            this.tbPrintName1.Location = new System.Drawing.Point(6, 542);
            this.tbPrintName1.MaxLength = 100;
            this.tbPrintName1.Name = "tbPrintName1";
            this.tbPrintName1.Size = new System.Drawing.Size(100, 20);
            this.tbPrintName1.TabIndex = 0;
            this.tbPrintName1.Click += new System.EventHandler(this.tbPrintName_Click);
            // 
            // lblPrintBuffer
            // 
            this.lblPrintBuffer.AutoSize = true;
            this.lblPrintBuffer.Enabled = false;
            this.lblPrintBuffer.Location = new System.Drawing.Point(3, 493);
            this.lblPrintBuffer.Name = "lblPrintBuffer";
            this.lblPrintBuffer.Size = new System.Drawing.Size(0, 13);
            this.lblPrintBuffer.TabIndex = 10;
            // 
            // tbPrintNetName1
            // 
            this.tbPrintNetName1.Location = new System.Drawing.Point(131, 542);
            this.tbPrintNetName1.MaxLength = 50;
            this.tbPrintNetName1.Name = "tbPrintNetName1";
            this.tbPrintNetName1.Size = new System.Drawing.Size(100, 20);
            this.tbPrintNetName1.TabIndex = 1;
            this.tbPrintNetName1.Click += new System.EventHandler(this.tbPrintName_Click);
            // 
            // lblPrintInvNumber
            // 
            this.lblPrintInvNumber.AutoSize = true;
            this.lblPrintInvNumber.Location = new System.Drawing.Point(389, 523);
            this.lblPrintInvNumber.Name = "lblPrintInvNumber";
            this.lblPrintInvNumber.Size = new System.Drawing.Size(76, 13);
            this.lblPrintInvNumber.TabIndex = 9;
            this.lblPrintInvNumber.Text = "Инвентарный";
            // 
            // tbPrintLocation1
            // 
            this.tbPrintLocation1.Location = new System.Drawing.Point(256, 542);
            this.tbPrintLocation1.MaxLength = 20;
            this.tbPrintLocation1.Name = "tbPrintLocation1";
            this.tbPrintLocation1.Size = new System.Drawing.Size(100, 20);
            this.tbPrintLocation1.TabIndex = 2;
            this.tbPrintLocation1.Click += new System.EventHandler(this.tbPrintName_Click);
            // 
            // lblPrintLocation
            // 
            this.lblPrintLocation.AutoSize = true;
            this.lblPrintLocation.Location = new System.Drawing.Point(265, 523);
            this.lblPrintLocation.Name = "lblPrintLocation";
            this.lblPrintLocation.Size = new System.Drawing.Size(82, 13);
            this.lblPrintLocation.TabIndex = 8;
            this.lblPrintLocation.Text = "Расположение";
            // 
            // btnPrintAdd
            // 
            this.btnPrintAdd.Location = new System.Drawing.Point(545, 510);
            this.btnPrintAdd.Name = "btnPrintAdd";
            this.btnPrintAdd.Size = new System.Drawing.Size(75, 23);
            this.btnPrintAdd.TabIndex = 4;
            this.btnPrintAdd.Text = "Добавить";
            this.btnPrintAdd.UseVisualStyleBackColor = true;
            this.btnPrintAdd.Click += new System.EventHandler(this.btnPrintAdd_Click);
            // 
            // lblPrintNetName
            // 
            this.lblPrintNetName.AutoSize = true;
            this.lblPrintNetName.Location = new System.Drawing.Point(145, 523);
            this.lblPrintNetName.Name = "lblPrintNetName";
            this.lblPrintNetName.Size = new System.Drawing.Size(72, 13);
            this.lblPrintNetName.TabIndex = 7;
            this.lblPrintNetName.Text = "Сетевое имя";
            // 
            // tbPrintInvNumber1
            // 
            this.tbPrintInvNumber1.Location = new System.Drawing.Point(378, 542);
            this.tbPrintInvNumber1.MaxLength = 15;
            this.tbPrintInvNumber1.Name = "tbPrintInvNumber1";
            this.tbPrintInvNumber1.Size = new System.Drawing.Size(100, 20);
            this.tbPrintInvNumber1.TabIndex = 3;
            this.tbPrintInvNumber1.Click += new System.EventHandler(this.tbPrintName_Click);
            // 
            // lblPrintName
            // 
            this.lblPrintName.AutoSize = true;
            this.lblPrintName.Location = new System.Drawing.Point(13, 523);
            this.lblPrintName.Name = "lblPrintName";
            this.lblPrintName.Size = new System.Drawing.Size(83, 13);
            this.lblPrintName.TabIndex = 6;
            this.lblPrintName.Text = "Наименование";
            // 
            // tabPageDBList
            // 
            this.tabPageDBList.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageDBList.Controls.Add(this.chkbPrefixShow);
            this.tabPageDBList.Controls.Add(this.tbPrefixRequest);
            this.tabPageDBList.Controls.Add(this.tbAddRequest);
            this.tabPageDBList.Controls.Add(this.btnClearAllRequest);
            this.tabPageDBList.Controls.Add(this.lblInfoRequest);
            this.tabPageDBList.Controls.Add(this.dgvRequest);
            this.tabPageDBList.Controls.Add(this.chckbMyRequest);
            this.tabPageDBList.Controls.Add(this.chckbRemoveRequest);
            this.tabPageDBList.Controls.Add(this.btnAddRequest);
            this.tabPageDBList.Controls.Add(this.btnAddRequestBuffer);
            this.tabPageDBList.Controls.Add(this.btnRemoveRequest);
            this.tabPageDBList.Controls.Add(this.lblQuantity);
            this.tabPageDBList.Controls.Add(this.lblUserRequest);
            this.tabPageDBList.Location = new System.Drawing.Point(4, 23);
            this.tabPageDBList.Name = "tabPageDBList";
            this.tabPageDBList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDBList.Size = new System.Drawing.Size(626, 597);
            this.tabPageDBList.TabIndex = 3;
            this.tabPageDBList.Text = "Список заявок";
            // 
            // chkbPrefixShow
            // 
            this.chkbPrefixShow.AutoSize = true;
            this.chkbPrefixShow.Location = new System.Drawing.Point(3, 440);
            this.chkbPrefixShow.Name = "chkbPrefixShow";
            this.chkbPrefixShow.Size = new System.Drawing.Size(130, 17);
            this.chkbPrefixShow.TabIndex = 8;
            this.chkbPrefixShow.Text = "Показать префиксы";
            this.chkbPrefixShow.UseVisualStyleBackColor = true;
            this.chkbPrefixShow.CheckedChanged += new System.EventHandler(this.chkbPrefixShow_CheckedChanged);
            // 
            // tbPrefixRequest
            // 
            this.tbPrefixRequest.Location = new System.Drawing.Point(3, 414);
            this.tbPrefixRequest.MaximumSize = new System.Drawing.Size(10000, 20);
            this.tbPrefixRequest.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbPrefixRequest.Name = "tbPrefixRequest";
            this.tbPrefixRequest.PasswordChar = '\0';
            this.tbPrefixRequest.Size = new System.Drawing.Size(100, 20);
            this.tbPrefixRequest.TabIndex = 8;
            this.tbPrefixRequest.TextMaxLength = 1024;
            this.tbPrefixRequest.TextTitle = "Префикс";
            this.tbPrefixRequest._TextChanged += new System.EventHandler(this.tbPrefixRequest__TextChanged);
            // 
            // tbAddRequest
            // 
            this.tbAddRequest.Location = new System.Drawing.Point(109, 414);
            this.tbAddRequest.MaximumSize = new System.Drawing.Size(10000, 20);
            this.tbAddRequest.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbAddRequest.Name = "tbAddRequest";
            this.tbAddRequest.PasswordChar = '\0';
            this.tbAddRequest.Size = new System.Drawing.Size(514, 20);
            this.tbAddRequest.TabIndex = 1;
            this.tbAddRequest.TextMaxLength = 1024;
            this.tbAddRequest.TextTitle = "Тут можно добавлять заявки в список";
            this.tbAddRequest.KeyDownEvent += new System.Windows.Forms.KeyEventHandler(this.tbAddRequest_KeyDownEvent);
            // 
            // btnClearAllRequest
            // 
            this.btnClearAllRequest.Location = new System.Drawing.Point(540, 510);
            this.btnClearAllRequest.Name = "btnClearAllRequest";
            this.btnClearAllRequest.Size = new System.Drawing.Size(75, 49);
            this.btnClearAllRequest.TabIndex = 7;
            this.btnClearAllRequest.Text = "Очистить список заявок";
            this.btnClearAllRequest.UseVisualStyleBackColor = true;
            this.btnClearAllRequest.Click += new System.EventHandler(this.btnClearAllRequest_Click);
            // 
            // lblInfoRequest
            // 
            this.lblInfoRequest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblInfoRequest.Enabled = false;
            this.lblInfoRequest.Location = new System.Drawing.Point(3, 566);
            this.lblInfoRequest.Name = "lblInfoRequest";
            this.lblInfoRequest.Size = new System.Drawing.Size(620, 28);
            this.lblInfoRequest.TabIndex = 6;
            this.lblInfoRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvRequest
            // 
            this.dgvRequest.AllowUserToAddRows = false;
            this.dgvRequest.AllowUserToDeleteRows = false;
            this.dgvRequest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRequest.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRequest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequest.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRequest.Location = new System.Drawing.Point(3, 3);
            this.dgvRequest.MultiSelect = false;
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.ReadOnly = true;
            this.dgvRequest.RowHeadersVisible = false;
            this.dgvRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequest.Size = new System.Drawing.Size(620, 405);
            this.dgvRequest.TabIndex = 0;
            this.dgvRequest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequest_CellClick);
            this.dgvRequest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequest_CellDoubleClick);
            this.dgvRequest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRequest_KeyDown);
            // 
            // chckbMyRequest
            // 
            this.chckbMyRequest.AutoSize = true;
            this.chckbMyRequest.Checked = true;
            this.chckbMyRequest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckbMyRequest.Location = new System.Drawing.Point(11, 527);
            this.chckbMyRequest.Name = "chckbMyRequest";
            this.chckbMyRequest.Size = new System.Drawing.Size(86, 17);
            this.chckbMyRequest.TabIndex = 4;
            this.chckbMyRequest.Text = "Только мои";
            this.chckbMyRequest.UseVisualStyleBackColor = true;
            this.chckbMyRequest.CheckedChanged += new System.EventHandler(this.chckbMyRequest_CheckedChanged);
            // 
            // chckbRemoveRequest
            // 
            this.chckbRemoveRequest.AutoSize = true;
            this.chckbRemoveRequest.Checked = true;
            this.chckbRemoveRequest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckbRemoveRequest.Location = new System.Drawing.Point(550, 487);
            this.chckbRemoveRequest.Name = "chckbRemoveRequest";
            this.chckbRemoveRequest.Size = new System.Drawing.Size(69, 17);
            this.chckbRemoveRequest.TabIndex = 6;
            this.chckbRemoveRequest.Text = "Удалять";
            this.chckbRemoveRequest.UseVisualStyleBackColor = true;
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.Location = new System.Drawing.Point(218, 440);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(75, 23);
            this.btnAddRequest.TabIndex = 2;
            this.btnAddRequest.Text = "Добавить";
            this.btnAddRequest.UseVisualStyleBackColor = true;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // btnAddRequestBuffer
            // 
            this.btnAddRequestBuffer.Location = new System.Drawing.Point(550, 445);
            this.btnAddRequestBuffer.Name = "btnAddRequestBuffer";
            this.btnAddRequestBuffer.Size = new System.Drawing.Size(65, 36);
            this.btnAddRequestBuffer.TabIndex = 5;
            this.btnAddRequestBuffer.Text = "Закинуть в буфер";
            this.btnAddRequestBuffer.UseVisualStyleBackColor = true;
            this.btnAddRequestBuffer.Click += new System.EventHandler(this.btnAddRequestBuffer_Click);
            // 
            // btnRemoveRequest
            // 
            this.btnRemoveRequest.Location = new System.Drawing.Point(299, 440);
            this.btnRemoveRequest.Name = "btnRemoveRequest";
            this.btnRemoveRequest.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveRequest.TabIndex = 3;
            this.btnRemoveRequest.Text = "Удалить";
            this.btnRemoveRequest.UseVisualStyleBackColor = true;
            this.btnRemoveRequest.Click += new System.EventHandler(this.btnRemoveRequest_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(8, 509);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(100, 13);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "NumberOfRequests";
            // 
            // lblUserRequest
            // 
            this.lblUserRequest.AutoSize = true;
            this.lblUserRequest.Location = new System.Drawing.Point(8, 487);
            this.lblUserRequest.Name = "lblUserRequest";
            this.lblUserRequest.Size = new System.Drawing.Size(79, 13);
            this.lblUserRequest.TabIndex = 5;
            this.lblUserRequest.Text = "UserNameError";
            // 
            // tabPageAddRequest
            // 
            this.tabPageAddRequest.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAddRequest.Controls.Add(this.btnMassRequest);
            this.tabPageAddRequest.Controls.Add(this.tbAddFIORequest);
            this.tabPageAddRequest.Controls.Add(this.tbAddProg);
            this.tabPageAddRequest.Controls.Add(this.btnCartPaper);
            this.tabPageAddRequest.Controls.Add(this.btnRemoveProg);
            this.tabPageAddRequest.Controls.Add(this.btnAddProg);
            this.tabPageAddRequest.Controls.Add(this.lblAddRequestDB);
            this.tabPageAddRequest.Controls.Add(this.btnAddRequestDB);
            this.tabPageAddRequest.Controls.Add(this.gbAddRequest);
            this.tabPageAddRequest.Controls.Add(this.lbProgList);
            this.tabPageAddRequest.Location = new System.Drawing.Point(4, 23);
            this.tabPageAddRequest.Name = "tabPageAddRequest";
            this.tabPageAddRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddRequest.Size = new System.Drawing.Size(626, 597);
            this.tabPageAddRequest.TabIndex = 4;
            this.tabPageAddRequest.Text = "Запись заявок";
            // 
            // btnMassRequest
            // 
            this.btnMassRequest.Location = new System.Drawing.Point(502, 360);
            this.btnMassRequest.Name = "btnMassRequest";
            this.btnMassRequest.Size = new System.Drawing.Size(107, 43);
            this.btnMassRequest.TabIndex = 19;
            this.btnMassRequest.Text = "Массовые заявки по ПК";
            this.btnMassRequest.UseVisualStyleBackColor = true;
            this.btnMassRequest.Click += new System.EventHandler(this.btnMassRequest_Click);
            // 
            // tbAddFIORequest
            // 
            this.tbAddFIORequest.Location = new System.Drawing.Point(309, 155);
            this.tbAddFIORequest.MaximumSize = new System.Drawing.Size(1000, 20);
            this.tbAddFIORequest.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbAddFIORequest.Name = "tbAddFIORequest";
            this.tbAddFIORequest.PasswordChar = '\0';
            this.tbAddFIORequest.Size = new System.Drawing.Size(205, 20);
            this.tbAddFIORequest.TabIndex = 18;
            this.tbAddFIORequest.TextMaxLength = 100;
            this.tbAddFIORequest.TextTitle = "ФИО и любая другая инфа";
            this.tbAddFIORequest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAddFIORequest_KeyDown);
            // 
            // tbAddProg
            // 
            this.tbAddProg.Location = new System.Drawing.Point(278, 542);
            this.tbAddProg.MaximumSize = new System.Drawing.Size(1000, 20);
            this.tbAddProg.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbAddProg.Name = "tbAddProg";
            this.tbAddProg.PasswordChar = '\0';
            this.tbAddProg.Size = new System.Drawing.Size(269, 20);
            this.tbAddProg.TabIndex = 17;
            this.tbAddProg.TextMaxLength = 100;
            this.tbAddProg.TextTitle = "Название ПО";
            this.tbAddProg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAddProg_KeyDown);
            // 
            // btnCartPaper
            // 
            this.btnCartPaper.Location = new System.Drawing.Point(320, 360);
            this.btnCartPaper.Name = "btnCartPaper";
            this.btnCartPaper.Size = new System.Drawing.Size(86, 43);
            this.btnCartPaper.TabIndex = 16;
            this.btnCartPaper.Text = "Картриджи и замятие";
            this.btnCartPaper.UseVisualStyleBackColor = true;
            this.btnCartPaper.Click += new System.EventHandler(this.btnCartPaper_Click);
            // 
            // btnRemoveProg
            // 
            this.btnRemoveProg.Location = new System.Drawing.Point(278, 568);
            this.btnRemoveProg.Name = "btnRemoveProg";
            this.btnRemoveProg.Size = new System.Drawing.Size(75, 24);
            this.btnRemoveProg.TabIndex = 9;
            this.btnRemoveProg.Text = "Удалить";
            this.btnRemoveProg.UseVisualStyleBackColor = true;
            this.btnRemoveProg.Click += new System.EventHandler(this.btnRemoveProg_Click);
            // 
            // btnAddProg
            // 
            this.btnAddProg.Location = new System.Drawing.Point(472, 568);
            this.btnAddProg.Name = "btnAddProg";
            this.btnAddProg.Size = new System.Drawing.Size(75, 23);
            this.btnAddProg.TabIndex = 11;
            this.btnAddProg.Text = "Добавить";
            this.btnAddProg.UseVisualStyleBackColor = true;
            this.btnAddProg.Click += new System.EventHandler(this.btnAddProg_Click);
            // 
            // lblAddRequestDB
            // 
            this.lblAddRequestDB.Enabled = false;
            this.lblAddRequestDB.Location = new System.Drawing.Point(317, 228);
            this.lblAddRequestDB.Name = "lblAddRequestDB";
            this.lblAddRequestDB.Size = new System.Drawing.Size(292, 120);
            this.lblAddRequestDB.TabIndex = 12;
            this.lblAddRequestDB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddRequestDB
            // 
            this.btnAddRequestDB.Location = new System.Drawing.Point(412, 187);
            this.btnAddRequestDB.Name = "btnAddRequestDB";
            this.btnAddRequestDB.Size = new System.Drawing.Size(102, 26);
            this.btnAddRequestDB.TabIndex = 15;
            this.btnAddRequestDB.Text = "Закинуть в БД";
            this.btnAddRequestDB.UseVisualStyleBackColor = true;
            this.btnAddRequestDB.Click += new System.EventHandler(this.btnAddRequestDB_Click);
            // 
            // gbAddRequest
            // 
            this.gbAddRequest.Controls.Add(this.rdbtnAddRequest3);
            this.gbAddRequest.Controls.Add(this.rdbtnAddRequest4);
            this.gbAddRequest.Controls.Add(this.rdbtnAddRequest2);
            this.gbAddRequest.Controls.Add(this.rdbtnAddRequest1);
            this.gbAddRequest.Location = new System.Drawing.Point(293, 28);
            this.gbAddRequest.Name = "gbAddRequest";
            this.gbAddRequest.Size = new System.Drawing.Size(180, 114);
            this.gbAddRequest.TabIndex = 13;
            this.gbAddRequest.TabStop = false;
            this.gbAddRequest.Text = "Что будем делать?";
            // 
            // rdbtnAddRequest3
            // 
            this.rdbtnAddRequest3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbtnAddRequest3.AutoSize = true;
            this.rdbtnAddRequest3.Location = new System.Drawing.Point(17, 65);
            this.rdbtnAddRequest3.Name = "rdbtnAddRequest3";
            this.rdbtnAddRequest3.Size = new System.Drawing.Size(66, 23);
            this.rdbtnAddRequest3.TabIndex = 3;
            this.rdbtnAddRequest3.Text = "Обновить";
            this.rdbtnAddRequest3.UseVisualStyleBackColor = true;
            // 
            // rdbtnAddRequest4
            // 
            this.rdbtnAddRequest4.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbtnAddRequest4.AutoSize = true;
            this.rdbtnAddRequest4.Location = new System.Drawing.Point(17, 88);
            this.rdbtnAddRequest4.Name = "rdbtnAddRequest4";
            this.rdbtnAddRequest4.Size = new System.Drawing.Size(71, 23);
            this.rdbtnAddRequest4.TabIndex = 4;
            this.rdbtnAddRequest4.Text = "Настроить";
            this.rdbtnAddRequest4.UseVisualStyleBackColor = true;
            // 
            // rdbtnAddRequest2
            // 
            this.rdbtnAddRequest2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbtnAddRequest2.AutoSize = true;
            this.rdbtnAddRequest2.Location = new System.Drawing.Point(17, 42);
            this.rdbtnAddRequest2.Name = "rdbtnAddRequest2";
            this.rdbtnAddRequest2.Size = new System.Drawing.Size(100, 23);
            this.rdbtnAddRequest2.TabIndex = 2;
            this.rdbtnAddRequest2.Text = "Переустановить";
            this.rdbtnAddRequest2.UseVisualStyleBackColor = true;
            // 
            // rdbtnAddRequest1
            // 
            this.rdbtnAddRequest1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbtnAddRequest1.AutoSize = true;
            this.rdbtnAddRequest1.Checked = true;
            this.rdbtnAddRequest1.Location = new System.Drawing.Point(17, 19);
            this.rdbtnAddRequest1.Name = "rdbtnAddRequest1";
            this.rdbtnAddRequest1.Size = new System.Drawing.Size(77, 23);
            this.rdbtnAddRequest1.TabIndex = 1;
            this.rdbtnAddRequest1.TabStop = true;
            this.rdbtnAddRequest1.Text = "Установить";
            this.rdbtnAddRequest1.UseVisualStyleBackColor = true;
            // 
            // lbProgList
            // 
            this.lbProgList.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbProgList.FormattingEnabled = true;
            this.lbProgList.Location = new System.Drawing.Point(3, 3);
            this.lbProgList.Name = "lbProgList";
            this.lbProgList.Size = new System.Drawing.Size(269, 591);
            this.lbProgList.Sorted = true;
            this.lbProgList.TabIndex = 8;
            this.lbProgList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbProgList_KeyDown);
            // 
            // toolStripAbout
            // 
            this.toolStripAbout.Name = "toolStripAbout";
            this.toolStripAbout.Size = new System.Drawing.Size(180, 22);
            this.toolStripAbout.Text = "О программе";
            this.toolStripAbout.Click += new System.EventHandler(this.toolStripAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 646);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 685);
            this.MinimumSize = new System.Drawing.Size(650, 685);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All in One";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageService.ResumeLayout(false);
            this.tabPageService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPingTimeOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPingProgress)).EndInit();
            this.tabPageProfRab.ResumeLayout(false);
            this.tabPagePrinters.ResumeLayout(false);
            this.tabPagePrinters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinters)).EndInit();
            this.tabPageDBList.ResumeLayout(false);
            this.tabPageDBList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
            this.tabPageAddRequest.ResumeLayout(false);
            this.gbAddRequest.ResumeLayout(false);
            this.gbAddRequest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPR2;
        private System.Windows.Forms.Button btnPR3;
        private System.Windows.Forms.Button btnPR4;
        private System.Windows.Forms.Button btnPR5;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripExit;
        private System.Windows.Forms.Button btnPR6;
        private System.Windows.Forms.Button btnPR18;
        private System.Windows.Forms.Button btnPR17;
        private System.Windows.Forms.Button btnPR16;
        private System.Windows.Forms.Button btnPR15;
        private System.Windows.Forms.Button btnPR14;
        private System.Windows.Forms.Button btnPR13;
        private System.Windows.Forms.Button btnPR12;
        private System.Windows.Forms.Button btnPR11;
        private System.Windows.Forms.Button btnPR10;
        private System.Windows.Forms.Button btnPR9;
        private System.Windows.Forms.Button btnPR8;
        private System.Windows.Forms.Button btnPR7;
        private System.Windows.Forms.Button btnPR24;
        private System.Windows.Forms.Button btnPR22;
        private System.Windows.Forms.Button btnPR21;
        private System.Windows.Forms.Button btnPR19;
        private System.Windows.Forms.Button btnPR26;
        private System.Windows.Forms.Button btnPR25;
        private System.Windows.Forms.Button btnPRChange;
        private System.Windows.Forms.Button btnPR23;
        private System.Windows.Forms.Label lblPR;
        private System.Windows.Forms.DataGridView dgvRequest;
        private System.Windows.Forms.Button btnRemoveRequest;
        private System.Windows.Forms.Button btnAddRequest;
        private System.Windows.Forms.Label lblUserRequest;
        private System.Windows.Forms.Label lblInfoRequest;
        private System.Windows.Forms.Timer tmrComm5555;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnPrintAdd;
        private System.Windows.Forms.TextBox tbPrintLocation1;
        private System.Windows.Forms.TextBox tbPrintNetName1;
        private System.Windows.Forms.Button btnAddRequestBuffer;
        private System.Windows.Forms.TextBox tbPrintInvNumber1;
        private System.Windows.Forms.CheckBox chckbRemoveRequest;
        private System.Windows.Forms.Label lblPrintInvNumber;
        private System.Windows.Forms.Label lblPrintLocation;
        private System.Windows.Forms.Label lblPrintNetName;
        private System.Windows.Forms.Label lblPrintName;
        private System.Windows.Forms.Label lblPrintBuffer;
        private System.Windows.Forms.CheckBox chckbMyRequest;
        private System.Windows.Forms.Button btnPrintRemove;
        public System.Windows.Forms.Button btnPR1;
        public System.Windows.Forms.Button btnPR20;
        private System.Windows.Forms.Button btnPrintPrinting;
        private System.Windows.Forms.ToolStripMenuItem toDoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteAccsessToolStripMenuItem;
        public System.Windows.Forms.Timer tmrServicePB;
        private System.Windows.Forms.ToolStripMenuItem toolStripDB;
        private System.Windows.Forms.ToolStripMenuItem toolStripDBCheckCon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripDBInvertCon;
        private System.Windows.Forms.TabPage tabPageService;
        private System.Windows.Forms.TabPage tabPageDBList;
        public System.Windows.Forms.NumericUpDown numPingTimeOut;
        public System.Windows.Forms.NumericUpDown numPingProgress;
        public System.Windows.Forms.ProgressBar pbPingProgress;
        private System.Windows.Forms.Label lblPingTimeOut;
        private System.Windows.Forms.Label lblPingSuccess;
        public System.Windows.Forms.ListBox lbPingTimeOut;
        public System.Windows.Forms.ListBox lbPingSuccess;
        private System.Windows.Forms.Button btnSrvcChange;
        private System.Windows.Forms.CheckBox chckbServiceSorted;
        private System.Windows.Forms.Label lblShare;
        private System.Windows.Forms.Label lblRDP;
        public System.Windows.Forms.ListBox lbShare;
        public System.Windows.Forms.ListBox lbRDP;
        public System.Windows.Forms.Button btnRefreshPing;
        public System.Windows.Forms.CustomTabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAddRequest;
        private System.Windows.Forms.Button btnCartPaper;
        private System.Windows.Forms.Button btnRemoveProg;
        private System.Windows.Forms.Button btnAddProg;
        private System.Windows.Forms.Label lblAddRequestDB;
        private System.Windows.Forms.Button btnAddRequestDB;
        private System.Windows.Forms.GroupBox gbAddRequest;
        private System.Windows.Forms.RadioButton rdbtnAddRequest3;
        private System.Windows.Forms.RadioButton rdbtnAddRequest4;
        private System.Windows.Forms.RadioButton rdbtnAddRequest2;
        private System.Windows.Forms.RadioButton rdbtnAddRequest1;
        private System.Windows.Forms.ListBox lbProgList;
        private MyTextBox tbAddProg;
        private MyTextBox tbAddFIORequest;
        private System.Windows.Forms.Button btnMassRequest;
        public System.Windows.Forms.TextBox tbPrintName1;
        public System.Windows.Forms.DataGridView dgvPrinters;
        private System.Windows.Forms.ToolStripMenuItem toolStripExcel;
        public System.Windows.Forms.TabPage tabPagePrinters;
        private MyTextBox tbPrintInvNumber;
        private MyTextBox tbPrintLocation;
        private MyTextBox tbPrintNetName;
        private MyTextBox tbPrintName;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        public System.Windows.Forms.TabPage tabPageProfRab;
        private System.Windows.Forms.Label lblPingTimeTimeOut;
        private System.Windows.Forms.Label lblPingTimeRefresh;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnMSTSCstart;
        private MyTextBox tbMSTSCadress;
        private MyTextBox tbMSTSCpass;
        private MyTextBox tbMSTSClogin;
        private System.Windows.Forms.Label lblMSTSC;
        private MyTextBox tbCyclePingAdress;
        private System.Windows.Forms.Button btnCyclePingStart;
        private System.Windows.Forms.ListBox lbCyclePing;
        public System.Windows.Forms.Button btnCyclePingStop;
        private System.Windows.Forms.Button btnPrintChange;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClearAllRequest;
        private MyTextBox tbAddRequest;
        private MyTextBox tbPrefixRequest;
        private System.Windows.Forms.CheckBox chkbPrefixShow;
        private System.Windows.Forms.ToolStripMenuItem toolStripAbout;
    }
}

