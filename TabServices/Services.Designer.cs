
namespace ALLinONE.TabServices
{
    partial class Services
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCyclePingStop = new System.Windows.Forms.Button();
            this.lbCyclePing = new System.Windows.Forms.ListBox();
            this.btnCyclePingStart = new System.Windows.Forms.Button();
            this.btnMSTSCstart = new System.Windows.Forms.Button();
            this.lblPingTimeTimeOut = new System.Windows.Forms.Label();
            this.lblPingTimeRefresh = new System.Windows.Forms.Label();
            this.numPingTimeOut = new System.Windows.Forms.NumericUpDown();
            this.numPingProgress = new System.Windows.Forms.NumericUpDown();
            this.pbPingProgress = new System.Windows.Forms.ProgressBar();
            this.lblPingTimeOut = new System.Windows.Forms.Label();
            this.lblPingSuccess = new System.Windows.Forms.Label();
            this.lbPingTimeOut = new System.Windows.Forms.ListBox();
            this.lbPingSuccess = new System.Windows.Forms.ListBox();
            this.btnSrvcChange = new System.Windows.Forms.Button();
            this.lblShare = new System.Windows.Forms.Label();
            this.lblRDP = new System.Windows.Forms.Label();
            this.lbShare = new System.Windows.Forms.ListBox();
            this.lbRDP = new System.Windows.Forms.ListBox();
            this.pnlShareRDP = new System.Windows.Forms.Panel();
            this.chckbServiceSorted = new System.Windows.Forms.CheckBox();
            this.pnlPing = new System.Windows.Forms.Panel();
            this.btnRefreshPing = new System.Windows.Forms.Button();
            this.pnlMSTSC = new System.Windows.Forms.Panel();
            this.pnlCyclePing = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tbCyclePingAdress = new ALLinONE.MyTextBox();
            this.tbMSTSClogin = new ALLinONE.MyTextBox();
            this.tbMSTSCpass = new ALLinONE.MyTextBox();
            this.tbMSTSCadress = new ALLinONE.MyTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPingTimeOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPingProgress)).BeginInit();
            this.pnlShareRDP.SuspendLayout();
            this.pnlPing.SuspendLayout();
            this.pnlMSTSC.SuspendLayout();
            this.pnlCyclePing.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCyclePingStop
            // 
            this.btnCyclePingStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCyclePingStop.Location = new System.Drawing.Point(203, 2);
            this.btnCyclePingStop.Name = "btnCyclePingStop";
            this.btnCyclePingStop.Size = new System.Drawing.Size(42, 21);
            this.btnCyclePingStop.TabIndex = 63;
            this.btnCyclePingStop.Text = "Стоп";
            this.btnCyclePingStop.UseVisualStyleBackColor = true;
            this.btnCyclePingStop.Click += new System.EventHandler(this.btnCyclePingStop_Click);
            // 
            // lbCyclePing
            // 
            this.lbCyclePing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCyclePing.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbCyclePing.FormattingEnabled = true;
            this.lbCyclePing.Location = new System.Drawing.Point(3, 29);
            this.lbCyclePing.Name = "lbCyclePing";
            this.lbCyclePing.Size = new System.Drawing.Size(242, 121);
            this.lbCyclePing.TabIndex = 64;
            this.lbCyclePing.TabStop = false;
            this.lbCyclePing.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbCyclePing_DrawItem);
            this.lbCyclePing.Leave += new System.EventHandler(this.lbRDP_Leave);
            // 
            // btnCyclePingStart
            // 
            this.btnCyclePingStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCyclePingStart.Location = new System.Drawing.Point(150, 2);
            this.btnCyclePingStart.Name = "btnCyclePingStart";
            this.btnCyclePingStart.Size = new System.Drawing.Size(44, 22);
            this.btnCyclePingStart.TabIndex = 62;
            this.btnCyclePingStart.Text = "Старт";
            this.btnCyclePingStart.UseVisualStyleBackColor = true;
            this.btnCyclePingStart.Click += new System.EventHandler(this.btnCyclePingStart_Click);
            // 
            // btnMSTSCstart
            // 
            this.btnMSTSCstart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMSTSCstart.Location = new System.Drawing.Point(178, 2);
            this.btnMSTSCstart.Name = "btnMSTSCstart";
            this.btnMSTSCstart.Size = new System.Drawing.Size(68, 47);
            this.btnMSTSCstart.TabIndex = 60;
            this.btnMSTSCstart.Text = "Запустить RDP";
            this.btnMSTSCstart.UseVisualStyleBackColor = true;
            this.btnMSTSCstart.Click += new System.EventHandler(this.btnMSTSCstart_Click);
            // 
            // lblPingTimeTimeOut
            // 
            this.lblPingTimeTimeOut.AutoSize = true;
            this.lblPingTimeTimeOut.Location = new System.Drawing.Point(193, 239);
            this.lblPingTimeTimeOut.Name = "lblPingTimeTimeOut";
            this.lblPingTimeTimeOut.Size = new System.Drawing.Size(88, 13);
            this.lblPingTimeTimeOut.TabIndex = 72;
            this.lblPingTimeTimeOut.Text = "Таймаут пакета";
            this.toolTip.SetToolTip(this.lblPingTimeTimeOut, "В милисекундах");
            // 
            // lblPingTimeRefresh
            // 
            this.lblPingTimeRefresh.AccessibleDescription = "";
            this.lblPingTimeRefresh.AutoSize = true;
            this.lblPingTimeRefresh.Location = new System.Drawing.Point(3, 240);
            this.lblPingTimeRefresh.Name = "lblPingTimeRefresh";
            this.lblPingTimeRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPingTimeRefresh.Size = new System.Drawing.Size(94, 13);
            this.lblPingTimeRefresh.TabIndex = 71;
            this.lblPingTimeRefresh.Text = "Обновлять через";
            this.toolTip.SetToolTip(this.lblPingTimeRefresh, "В секундах");
            // 
            // numPingTimeOut
            // 
            this.numPingTimeOut.Location = new System.Drawing.Point(150, 237);
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
            this.numPingTimeOut.TabIndex = 55;
            this.toolTip.SetToolTip(this.numPingTimeOut, "В милисекундах");
            this.numPingTimeOut.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // numPingProgress
            // 
            this.numPingProgress.Location = new System.Drawing.Point(104, 237);
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
            this.numPingProgress.TabIndex = 54;
            this.toolTip.SetToolTip(this.numPingProgress, "В секундах");
            this.numPingProgress.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numPingProgress.ValueChanged += new System.EventHandler(this.numPingProgress_ValueChanged);
            // 
            // pbPingProgress
            // 
            this.pbPingProgress.Location = new System.Drawing.Point(10, 263);
            this.pbPingProgress.Maximum = 10000;
            this.pbPingProgress.Name = "pbPingProgress";
            this.pbPingProgress.Size = new System.Drawing.Size(242, 20);
            this.pbPingProgress.TabIndex = 70;
            // 
            // lblPingTimeOut
            // 
            this.lblPingTimeOut.AutoSize = true;
            this.lblPingTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPingTimeOut.Location = new System.Drawing.Point(171, 4);
            this.lblPingTimeOut.Name = "lblPingTimeOut";
            this.lblPingTimeOut.Size = new System.Drawing.Size(92, 15);
            this.lblPingTimeOut.TabIndex = 69;
            this.lblPingTimeOut.Text = "Не доступны";
            // 
            // lblPingSuccess
            // 
            this.lblPingSuccess.AutoSize = true;
            this.lblPingSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPingSuccess.Location = new System.Drawing.Point(33, 4);
            this.lblPingSuccess.Name = "lblPingSuccess";
            this.lblPingSuccess.Size = new System.Drawing.Size(72, 15);
            this.lblPingSuccess.TabIndex = 68;
            this.lblPingSuccess.Text = "Доступны";
            // 
            // lbPingTimeOut
            // 
            this.lbPingTimeOut.ForeColor = System.Drawing.Color.Maroon;
            this.lbPingTimeOut.FormattingEnabled = true;
            this.lbPingTimeOut.Location = new System.Drawing.Point(150, 21);
            this.lbPingTimeOut.Name = "lbPingTimeOut";
            this.lbPingTimeOut.Size = new System.Drawing.Size(135, 212);
            this.lbPingTimeOut.Sorted = true;
            this.lbPingTimeOut.TabIndex = 53;
            this.lbPingTimeOut.Leave += new System.EventHandler(this.lbRDP_Leave);
            // 
            // lbPingSuccess
            // 
            this.lbPingSuccess.ForeColor = System.Drawing.Color.Green;
            this.lbPingSuccess.FormattingEnabled = true;
            this.lbPingSuccess.Location = new System.Drawing.Point(3, 21);
            this.lbPingSuccess.Name = "lbPingSuccess";
            this.lbPingSuccess.Size = new System.Drawing.Size(135, 212);
            this.lbPingSuccess.Sorted = true;
            this.lbPingSuccess.TabIndex = 52;
            this.lbPingSuccess.Leave += new System.EventHandler(this.lbRDP_Leave);
            // 
            // btnSrvcChange
            // 
            this.btnSrvcChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSrvcChange.Location = new System.Drawing.Point(429, 449);
            this.btnSrvcChange.Name = "btnSrvcChange";
            this.btnSrvcChange.Size = new System.Drawing.Size(113, 37);
            this.btnSrvcChange.TabIndex = 65;
            this.btnSrvcChange.Text = "Может нам что-то поменять?";
            this.toolTip.SetToolTip(this.btnSrvcChange, "Здесь можно добавить или удалить адреса");
            this.btnSrvcChange.UseVisualStyleBackColor = true;
            this.btnSrvcChange.Click += new System.EventHandler(this.btnSrvcChange_Click);
            // 
            // lblShare
            // 
            this.lblShare.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblShare.AutoSize = true;
            this.lblShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShare.Location = new System.Drawing.Point(367, 3);
            this.lblShare.Name = "lblShare";
            this.lblShare.Size = new System.Drawing.Size(57, 20);
            this.lblShare.TabIndex = 67;
            this.lblShare.Text = "Share";
            // 
            // lblRDP
            // 
            this.lblRDP.AutoSize = true;
            this.lblRDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRDP.Location = new System.Drawing.Point(99, 4);
            this.lblRDP.Name = "lblRDP";
            this.lblRDP.Size = new System.Drawing.Size(46, 20);
            this.lblRDP.TabIndex = 66;
            this.lblRDP.Text = "RDP";
            // 
            // lbShare
            // 
            this.lbShare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbShare.FormattingEnabled = true;
            this.lbShare.ItemHeight = 18;
            this.lbShare.Location = new System.Drawing.Point(263, 26);
            this.lbShare.Name = "lbShare";
            this.lbShare.Size = new System.Drawing.Size(273, 166);
            this.lbShare.Sorted = true;
            this.lbShare.TabIndex = 50;
            this.lbShare.DoubleClick += new System.EventHandler(this.lbShare_DoubleClick);
            this.lbShare.Leave += new System.EventHandler(this.lbRDP_Leave);
            // 
            // lbRDP
            // 
            this.lbRDP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRDP.FormattingEnabled = true;
            this.lbRDP.ItemHeight = 18;
            this.lbRDP.Location = new System.Drawing.Point(3, 26);
            this.lbRDP.Name = "lbRDP";
            this.lbRDP.Size = new System.Drawing.Size(254, 166);
            this.lbRDP.Sorted = true;
            this.lbRDP.TabIndex = 49;
            this.lbRDP.DoubleClick += new System.EventHandler(this.lbRDP_DoubleClick);
            this.lbRDP.Leave += new System.EventHandler(this.lbRDP_Leave);
            // 
            // pnlShareRDP
            // 
            this.pnlShareRDP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlShareRDP.Controls.Add(this.lbRDP);
            this.pnlShareRDP.Controls.Add(this.lblRDP);
            this.pnlShareRDP.Controls.Add(this.lbShare);
            this.pnlShareRDP.Controls.Add(this.lblShare);
            this.pnlShareRDP.Location = new System.Drawing.Point(3, 1);
            this.pnlShareRDP.Name = "pnlShareRDP";
            this.pnlShareRDP.Size = new System.Drawing.Size(539, 197);
            this.pnlShareRDP.TabIndex = 75;
            // 
            // chckbServiceSorted
            // 
            this.chckbServiceSorted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chckbServiceSorted.AutoSize = true;
            this.chckbServiceSorted.Checked = true;
            this.chckbServiceSorted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckbServiceSorted.Location = new System.Drawing.Point(297, 201);
            this.chckbServiceSorted.Name = "chckbServiceSorted";
            this.chckbServiceSorted.Size = new System.Drawing.Size(91, 17);
            this.chckbServiceSorted.TabIndex = 79;
            this.chckbServiceSorted.Text = "Сортировать";
            this.toolTip.SetToolTip(this.chckbServiceSorted, "Сортировать по имени боксы с RDP и шарой");
            this.chckbServiceSorted.UseVisualStyleBackColor = true;
            this.chckbServiceSorted.CheckedChanged += new System.EventHandler(this.chckbServiceSorted_CheckedChanged);
            // 
            // pnlPing
            // 
            this.pnlPing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlPing.Controls.Add(this.lbPingSuccess);
            this.pnlPing.Controls.Add(this.lbPingTimeOut);
            this.pnlPing.Controls.Add(this.lblPingSuccess);
            this.pnlPing.Controls.Add(this.lblPingTimeOut);
            this.pnlPing.Controls.Add(this.pbPingProgress);
            this.pnlPing.Controls.Add(this.numPingProgress);
            this.pnlPing.Controls.Add(this.numPingTimeOut);
            this.pnlPing.Controls.Add(this.btnRefreshPing);
            this.pnlPing.Controls.Add(this.lblPingTimeRefresh);
            this.pnlPing.Controls.Add(this.lblPingTimeTimeOut);
            this.pnlPing.Location = new System.Drawing.Point(3, 201);
            this.pnlPing.Name = "pnlPing";
            this.pnlPing.Size = new System.Drawing.Size(288, 285);
            this.pnlPing.TabIndex = 76;
            // 
            // btnRefreshPing
            // 
            this.btnRefreshPing.BackgroundImage = global::ALLinONE.Properties.Resources.refresh_arrow_icon_131504;
            this.btnRefreshPing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefreshPing.Location = new System.Drawing.Point(257, 262);
            this.btnRefreshPing.Name = "btnRefreshPing";
            this.btnRefreshPing.Size = new System.Drawing.Size(22, 22);
            this.btnRefreshPing.TabIndex = 56;
            this.toolTip.SetToolTip(this.btnRefreshPing, "Ручной запуск пинга");
            this.btnRefreshPing.UseVisualStyleBackColor = true;
            this.btnRefreshPing.Click += new System.EventHandler(this.btnRefreshPing_Click);
            // 
            // pnlMSTSC
            // 
            this.pnlMSTSC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMSTSC.Controls.Add(this.tbMSTSClogin);
            this.pnlMSTSC.Controls.Add(this.tbMSTSCpass);
            this.pnlMSTSC.Controls.Add(this.tbMSTSCadress);
            this.pnlMSTSC.Controls.Add(this.btnMSTSCstart);
            this.pnlMSTSC.Location = new System.Drawing.Point(294, 220);
            this.pnlMSTSC.Name = "pnlMSTSC";
            this.pnlMSTSC.Size = new System.Drawing.Size(248, 51);
            this.pnlMSTSC.TabIndex = 77;
            // 
            // pnlCyclePing
            // 
            this.pnlCyclePing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCyclePing.Controls.Add(this.tbCyclePingAdress);
            this.pnlCyclePing.Controls.Add(this.btnCyclePingStart);
            this.pnlCyclePing.Controls.Add(this.lbCyclePing);
            this.pnlCyclePing.Controls.Add(this.btnCyclePingStop);
            this.pnlCyclePing.Location = new System.Drawing.Point(294, 284);
            this.pnlCyclePing.Name = "pnlCyclePing";
            this.pnlCyclePing.Size = new System.Drawing.Size(248, 156);
            this.pnlCyclePing.TabIndex = 78;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(329, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 79;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCyclePingAdress
            // 
            this.tbCyclePingAdress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCyclePingAdress.Location = new System.Drawing.Point(3, 3);
            this.tbCyclePingAdress.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbCyclePingAdress.Name = "tbCyclePingAdress";
            this.tbCyclePingAdress.PasswordChar = '\0';
            this.tbCyclePingAdress.Size = new System.Drawing.Size(141, 20);
            this.tbCyclePingAdress.TabIndex = 61;
            this.tbCyclePingAdress.TextMaxLength = 1024;
            this.tbCyclePingAdress.TextTitle = "IP-адрес или DNS-имя";
            this.tbCyclePingAdress.KeyDownEvent += new System.Windows.Forms.KeyEventHandler(this.tbCyclePingAdress_KeyDownEvent);
            // 
            // tbMSTSClogin
            // 
            this.tbMSTSClogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMSTSClogin.Location = new System.Drawing.Point(3, 3);
            this.tbMSTSClogin.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbMSTSClogin.Name = "tbMSTSClogin";
            this.tbMSTSClogin.PasswordChar = '\0';
            this.tbMSTSClogin.Size = new System.Drawing.Size(75, 20);
            this.tbMSTSClogin.TabIndex = 57;
            this.tbMSTSClogin.TextMaxLength = 1024;
            this.tbMSTSClogin.TextTitle = "Логин (опционально)";
            this.tbMSTSClogin.KeyDownEvent += new System.Windows.Forms.KeyEventHandler(this.tbMSTSCadress_KeyDownEvent);
            // 
            // tbMSTSCpass
            // 
            this.tbMSTSCpass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMSTSCpass.Location = new System.Drawing.Point(85, 3);
            this.tbMSTSCpass.MaximumSize = new System.Drawing.Size(1000, 20);
            this.tbMSTSCpass.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbMSTSCpass.Name = "tbMSTSCpass";
            this.tbMSTSCpass.PasswordChar = '*';
            this.tbMSTSCpass.Size = new System.Drawing.Size(87, 20);
            this.tbMSTSCpass.TabIndex = 58;
            this.tbMSTSCpass.TextMaxLength = 1024;
            this.tbMSTSCpass.TextTitle = "Пароль (опц.)";
            this.tbMSTSCpass.KeyDownEvent += new System.Windows.Forms.KeyEventHandler(this.tbMSTSCadress_KeyDownEvent);
            // 
            // tbMSTSCadress
            // 
            this.tbMSTSCadress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMSTSCadress.Location = new System.Drawing.Point(3, 28);
            this.tbMSTSCadress.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbMSTSCadress.Name = "tbMSTSCadress";
            this.tbMSTSCadress.PasswordChar = '\0';
            this.tbMSTSCadress.Size = new System.Drawing.Size(169, 20);
            this.tbMSTSCadress.TabIndex = 59;
            this.tbMSTSCadress.TextMaxLength = 1024;
            this.tbMSTSCadress.TextTitle = "IP-адрес или DNS-имя";
            this.tbMSTSCadress.KeyDownEvent += new System.Windows.Forms.KeyEventHandler(this.tbMSTSCadress_KeyDownEvent);
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chckbServiceSorted);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlCyclePing);
            this.Controls.Add(this.pnlMSTSC);
            this.Controls.Add(this.btnSrvcChange);
            this.Controls.Add(this.pnlPing);
            this.Controls.Add(this.pnlShareRDP);
            this.MinimumSize = new System.Drawing.Size(545, 489);
            this.Name = "Services";
            this.Size = new System.Drawing.Size(545, 489);
            this.Load += new System.EventHandler(this.Services_Load);
            this.VisibleChanged += new System.EventHandler(this.Services_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numPingTimeOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPingProgress)).EndInit();
            this.pnlShareRDP.ResumeLayout(false);
            this.pnlShareRDP.PerformLayout();
            this.pnlPing.ResumeLayout(false);
            this.pnlPing.PerformLayout();
            this.pnlMSTSC.ResumeLayout(false);
            this.pnlCyclePing.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnCyclePingStop;
        private System.Windows.Forms.ListBox lbCyclePing;
        private System.Windows.Forms.Button btnCyclePingStart;
        private MyTextBox tbCyclePingAdress;
        private System.Windows.Forms.Button btnMSTSCstart;
        private MyTextBox tbMSTSCadress;
        private MyTextBox tbMSTSCpass;
        private MyTextBox tbMSTSClogin;
        private System.Windows.Forms.Label lblPingTimeTimeOut;
        private System.Windows.Forms.Label lblPingTimeRefresh;
        public System.Windows.Forms.NumericUpDown numPingTimeOut;
        public System.Windows.Forms.NumericUpDown numPingProgress;
        public System.Windows.Forms.ProgressBar pbPingProgress;
        private System.Windows.Forms.Label lblPingTimeOut;
        private System.Windows.Forms.Label lblPingSuccess;
        public System.Windows.Forms.ListBox lbPingTimeOut;
        public System.Windows.Forms.ListBox lbPingSuccess;
        private System.Windows.Forms.Button btnSrvcChange;
        private System.Windows.Forms.Label lblShare;
        private System.Windows.Forms.Label lblRDP;
        public System.Windows.Forms.ListBox lbShare;
        public System.Windows.Forms.ListBox lbRDP;
        private System.Windows.Forms.Panel pnlShareRDP;
        private System.Windows.Forms.Panel pnlPing;
        private System.Windows.Forms.Panel pnlMSTSC;
        public System.Windows.Forms.Button btnRefreshPing;
        private System.Windows.Forms.Panel pnlCyclePing;
        private System.Windows.Forms.CheckBox chckbServiceSorted;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
