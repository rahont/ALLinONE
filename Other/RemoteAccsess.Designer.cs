namespace ALLinONE
{
    partial class RemoteAccsess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteAccsess));
            this.lblNameRemotePC = new System.Windows.Forms.Label();
            this.cbListPC = new System.Windows.Forms.ComboBox();
            this.btnLoadListPC = new System.Windows.Forms.Button();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.tbPathPsExec = new System.Windows.Forms.TextBox();
            this.lblPathPsExec = new System.Windows.Forms.Label();
            this.btnBrowsePathPsExec = new System.Windows.Forms.Button();
            this.rbtnServiceOn = new System.Windows.Forms.RadioButton();
            this.rbtnServiceOff = new System.Windows.Forms.RadioButton();
            this.btnServiceCommStart = new System.Windows.Forms.Button();
            this.tbNameService = new System.Windows.Forms.TextBox();
            this.lblNameService = new System.Windows.Forms.Label();
            this.btnRegistryCommStart = new System.Windows.Forms.Button();
            this.tbPathRegistry = new System.Windows.Forms.TextBox();
            this.lblPathRegistry = new System.Windows.Forms.Label();
            this.rbtnRegistryAdd = new System.Windows.Forms.RadioButton();
            this.rbtnRegistryDel = new System.Windows.Forms.RadioButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnServiceStat = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpService = new System.Windows.Forms.TabPage();
            this.lblLogService = new System.Windows.Forms.Label();
            this.tbLogService = new System.Windows.Forms.TextBox();
            this.tpRegistry = new System.Windows.Forms.TabPage();
            this.lblLogRegistry = new System.Windows.Forms.Label();
            this.tbLogRegistry = new System.Windows.Forms.TextBox();
            this.btnRegistryStat = new System.Windows.Forms.Button();
            this.lblKeyRegistry = new System.Windows.Forms.Label();
            this.lblValueRegistry = new System.Windows.Forms.Label();
            this.tbKeyRegistry = new System.Windows.Forms.TextBox();
            this.tbValueRegistry = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tpService.SuspendLayout();
            this.tpRegistry.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNameRemotePC
            // 
            this.lblNameRemotePC.AutoSize = true;
            this.lblNameRemotePC.Location = new System.Drawing.Point(9, 24);
            this.lblNameRemotePC.Name = "lblNameRemotePC";
            this.lblNameRemotePC.Size = new System.Drawing.Size(108, 13);
            this.lblNameRemotePC.TabIndex = 2;
            this.lblNameRemotePC.Text = "Имя удаленного ПК";
            // 
            // cbListPC
            // 
            this.cbListPC.FormattingEnabled = true;
            this.cbListPC.Location = new System.Drawing.Point(12, 40);
            this.cbListPC.Name = "cbListPC";
            this.cbListPC.Size = new System.Drawing.Size(205, 21);
            this.cbListPC.TabIndex = 3;
            // 
            // btnLoadListPC
            // 
            this.btnLoadListPC.Location = new System.Drawing.Point(143, 67);
            this.btnLoadListPC.Name = "btnLoadListPC";
            this.btnLoadListPC.Size = new System.Drawing.Size(74, 38);
            this.btnLoadListPC.TabIndex = 4;
            this.btnLoadListPC.Text = "Загрузить список ПК";
            this.btnLoadListPC.UseVisualStyleBackColor = true;
            this.btnLoadListPC.Click += new System.EventHandler(this.btnLoadListPC_Click);
            // 
            // btnQuestion
            // 
            this.btnQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQuestion.Location = new System.Drawing.Point(524, 3);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(28, 28);
            this.btnQuestion.TabIndex = 5;
            this.btnQuestion.Text = "?";
            this.btnQuestion.UseVisualStyleBackColor = true;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // tbPathPsExec
            // 
            this.tbPathPsExec.Location = new System.Drawing.Point(303, 40);
            this.tbPathPsExec.Name = "tbPathPsExec";
            this.tbPathPsExec.ReadOnly = true;
            this.tbPathPsExec.Size = new System.Drawing.Size(249, 20);
            this.tbPathPsExec.TabIndex = 6;
            // 
            // lblPathPsExec
            // 
            this.lblPathPsExec.AutoSize = true;
            this.lblPathPsExec.Location = new System.Drawing.Point(300, 24);
            this.lblPathPsExec.Name = "lblPathPsExec";
            this.lblPathPsExec.Size = new System.Drawing.Size(85, 13);
            this.lblPathPsExec.TabIndex = 7;
            this.lblPathPsExec.Text = "Путь до PsExec";
            // 
            // btnBrowsePathPsExec
            // 
            this.btnBrowsePathPsExec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrowsePathPsExec.Location = new System.Drawing.Point(553, 39);
            this.btnBrowsePathPsExec.Name = "btnBrowsePathPsExec";
            this.btnBrowsePathPsExec.Size = new System.Drawing.Size(35, 22);
            this.btnBrowsePathPsExec.TabIndex = 8;
            this.btnBrowsePathPsExec.Text = "•••";
            this.btnBrowsePathPsExec.UseVisualStyleBackColor = true;
            this.btnBrowsePathPsExec.Click += new System.EventHandler(this.btnBrowsePathPsExec_Click);
            // 
            // rbtnServiceOn
            // 
            this.rbtnServiceOn.AutoSize = true;
            this.rbtnServiceOn.Checked = true;
            this.rbtnServiceOn.Location = new System.Drawing.Point(70, 64);
            this.rbtnServiceOn.Name = "rbtnServiceOn";
            this.rbtnServiceOn.Size = new System.Drawing.Size(39, 17);
            this.rbtnServiceOn.TabIndex = 9;
            this.rbtnServiceOn.TabStop = true;
            this.rbtnServiceOn.Text = "On";
            this.rbtnServiceOn.UseVisualStyleBackColor = true;
            // 
            // rbtnServiceOff
            // 
            this.rbtnServiceOff.AutoSize = true;
            this.rbtnServiceOff.Location = new System.Drawing.Point(115, 64);
            this.rbtnServiceOff.Name = "rbtnServiceOff";
            this.rbtnServiceOff.Size = new System.Drawing.Size(39, 17);
            this.rbtnServiceOff.TabIndex = 10;
            this.rbtnServiceOff.Text = "Off";
            this.rbtnServiceOff.UseVisualStyleBackColor = true;
            // 
            // btnServiceCommStart
            // 
            this.btnServiceCommStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnServiceCommStart.Location = new System.Drawing.Point(157, 61);
            this.btnServiceCommStart.Name = "btnServiceCommStart";
            this.btnServiceCommStart.Size = new System.Drawing.Size(43, 23);
            this.btnServiceCommStart.TabIndex = 15;
            this.btnServiceCommStart.Text = "→";
            this.btnServiceCommStart.UseVisualStyleBackColor = true;
            this.btnServiceCommStart.Click += new System.EventHandler(this.btnServiceCommStart_Click);
            // 
            // tbNameService
            // 
            this.tbNameService.Location = new System.Drawing.Point(91, 6);
            this.tbNameService.Name = "tbNameService";
            this.tbNameService.Size = new System.Drawing.Size(172, 20);
            this.tbNameService.TabIndex = 14;
            // 
            // lblNameService
            // 
            this.lblNameService.AutoSize = true;
            this.lblNameService.Location = new System.Drawing.Point(7, 9);
            this.lblNameService.Name = "lblNameService";
            this.lblNameService.Size = new System.Drawing.Size(70, 13);
            this.lblNameService.TabIndex = 13;
            this.lblNameService.Text = "Имя Служба";
            // 
            // btnRegistryCommStart
            // 
            this.btnRegistryCommStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegistryCommStart.Location = new System.Drawing.Point(152, 85);
            this.btnRegistryCommStart.Name = "btnRegistryCommStart";
            this.btnRegistryCommStart.Size = new System.Drawing.Size(43, 23);
            this.btnRegistryCommStart.TabIndex = 15;
            this.btnRegistryCommStart.Text = "→";
            this.btnRegistryCommStart.UseVisualStyleBackColor = true;
            this.btnRegistryCommStart.Click += new System.EventHandler(this.btnRegistryCommStart_Click);
            // 
            // tbPathRegistry
            // 
            this.tbPathRegistry.Location = new System.Drawing.Point(43, 6);
            this.tbPathRegistry.Name = "tbPathRegistry";
            this.tbPathRegistry.Size = new System.Drawing.Size(197, 20);
            this.tbPathRegistry.TabIndex = 14;
            // 
            // lblPathRegistry
            // 
            this.lblPathRegistry.AutoSize = true;
            this.lblPathRegistry.Location = new System.Drawing.Point(6, 9);
            this.lblPathRegistry.Name = "lblPathRegistry";
            this.lblPathRegistry.Size = new System.Drawing.Size(31, 13);
            this.lblPathRegistry.TabIndex = 13;
            this.lblPathRegistry.Text = "Путь";
            // 
            // rbtnRegistryAdd
            // 
            this.rbtnRegistryAdd.AutoSize = true;
            this.rbtnRegistryAdd.Checked = true;
            this.rbtnRegistryAdd.Location = new System.Drawing.Point(149, 33);
            this.rbtnRegistryAdd.Name = "rbtnRegistryAdd";
            this.rbtnRegistryAdd.Size = new System.Drawing.Size(44, 17);
            this.rbtnRegistryAdd.TabIndex = 9;
            this.rbtnRegistryAdd.TabStop = true;
            this.rbtnRegistryAdd.Text = "Add";
            this.rbtnRegistryAdd.UseVisualStyleBackColor = true;
            // 
            // rbtnRegistryDel
            // 
            this.rbtnRegistryDel.AutoSize = true;
            this.rbtnRegistryDel.Location = new System.Drawing.Point(199, 33);
            this.rbtnRegistryDel.Name = "rbtnRegistryDel";
            this.rbtnRegistryDel.Size = new System.Drawing.Size(41, 17);
            this.rbtnRegistryDel.TabIndex = 10;
            this.rbtnRegistryDel.Text = "Del";
            this.rbtnRegistryDel.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnServiceStat
            // 
            this.btnServiceStat.Location = new System.Drawing.Point(91, 32);
            this.btnServiceStat.Name = "btnServiceStat";
            this.btnServiceStat.Size = new System.Drawing.Size(109, 23);
            this.btnServiceStat.TabIndex = 16;
            this.btnServiceStat.Text = "Проверить статус";
            this.btnServiceStat.UseVisualStyleBackColor = true;
            this.btnServiceStat.Click += new System.EventHandler(this.btnServiceStat_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpService);
            this.tabControl.Controls.Add(this.tpRegistry);
            this.tabControl.Location = new System.Drawing.Point(12, 111);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(285, 168);
            this.tabControl.TabIndex = 16;
            // 
            // tpService
            // 
            this.tpService.BackColor = System.Drawing.SystemColors.Control;
            this.tpService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpService.Controls.Add(this.lblLogService);
            this.tpService.Controls.Add(this.tbLogService);
            this.tpService.Controls.Add(this.btnServiceStat);
            this.tpService.Controls.Add(this.btnServiceCommStart);
            this.tpService.Controls.Add(this.rbtnServiceOn);
            this.tpService.Controls.Add(this.lblNameService);
            this.tpService.Controls.Add(this.rbtnServiceOff);
            this.tpService.Controls.Add(this.tbNameService);
            this.tpService.Location = new System.Drawing.Point(4, 22);
            this.tpService.Name = "tpService";
            this.tpService.Padding = new System.Windows.Forms.Padding(3);
            this.tpService.Size = new System.Drawing.Size(277, 142);
            this.tpService.TabIndex = 0;
            this.tpService.Text = "Службы";
            // 
            // lblLogService
            // 
            this.lblLogService.AutoSize = true;
            this.lblLogService.Location = new System.Drawing.Point(5, 98);
            this.lblLogService.Name = "lblLogService";
            this.lblLogService.Size = new System.Drawing.Size(74, 13);
            this.lblLogService.TabIndex = 18;
            this.lblLogService.Text = "Путь к логам";
            // 
            // tbLogService
            // 
            this.tbLogService.Location = new System.Drawing.Point(8, 114);
            this.tbLogService.Name = "tbLogService";
            this.tbLogService.Size = new System.Drawing.Size(253, 20);
            this.tbLogService.TabIndex = 17;
            this.tbLogService.Text = "D:\\logService.txt";
            // 
            // tpRegistry
            // 
            this.tpRegistry.BackColor = System.Drawing.SystemColors.Control;
            this.tpRegistry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpRegistry.Controls.Add(this.tbValueRegistry);
            this.tpRegistry.Controls.Add(this.tbKeyRegistry);
            this.tpRegistry.Controls.Add(this.lblValueRegistry);
            this.tpRegistry.Controls.Add(this.lblLogRegistry);
            this.tpRegistry.Controls.Add(this.tbLogRegistry);
            this.tpRegistry.Controls.Add(this.lblKeyRegistry);
            this.tpRegistry.Controls.Add(this.btnRegistryStat);
            this.tpRegistry.Controls.Add(this.btnRegistryCommStart);
            this.tpRegistry.Controls.Add(this.rbtnRegistryDel);
            this.tpRegistry.Controls.Add(this.rbtnRegistryAdd);
            this.tpRegistry.Controls.Add(this.tbPathRegistry);
            this.tpRegistry.Controls.Add(this.lblPathRegistry);
            this.tpRegistry.Location = new System.Drawing.Point(4, 22);
            this.tpRegistry.Name = "tpRegistry";
            this.tpRegistry.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistry.Size = new System.Drawing.Size(277, 142);
            this.tpRegistry.TabIndex = 1;
            this.tpRegistry.Text = "Реестр";
            // 
            // lblLogRegistry
            // 
            this.lblLogRegistry.AutoSize = true;
            this.lblLogRegistry.Location = new System.Drawing.Point(5, 99);
            this.lblLogRegistry.Name = "lblLogRegistry";
            this.lblLogRegistry.Size = new System.Drawing.Size(74, 13);
            this.lblLogRegistry.TabIndex = 20;
            this.lblLogRegistry.Text = "Путь к логам";
            // 
            // tbLogRegistry
            // 
            this.tbLogRegistry.Location = new System.Drawing.Point(8, 115);
            this.tbLogRegistry.Name = "tbLogRegistry";
            this.tbLogRegistry.Size = new System.Drawing.Size(253, 20);
            this.tbLogRegistry.TabIndex = 19;
            this.tbLogRegistry.Text = "D:\\logRegistry.txt";
            // 
            // btnRegistryStat
            // 
            this.btnRegistryStat.Location = new System.Drawing.Point(152, 56);
            this.btnRegistryStat.Name = "btnRegistryStat";
            this.btnRegistryStat.Size = new System.Drawing.Size(109, 23);
            this.btnRegistryStat.TabIndex = 17;
            this.btnRegistryStat.Text = "Проверить статус";
            this.btnRegistryStat.UseVisualStyleBackColor = true;
            // 
            // lblKeyRegistry
            // 
            this.lblKeyRegistry.AutoSize = true;
            this.lblKeyRegistry.Location = new System.Drawing.Point(6, 35);
            this.lblKeyRegistry.Name = "lblKeyRegistry";
            this.lblKeyRegistry.Size = new System.Drawing.Size(33, 13);
            this.lblKeyRegistry.TabIndex = 21;
            this.lblKeyRegistry.Text = "Ключ";
            // 
            // lblValueRegistry
            // 
            this.lblValueRegistry.AutoSize = true;
            this.lblValueRegistry.Location = new System.Drawing.Point(6, 61);
            this.lblValueRegistry.Name = "lblValueRegistry";
            this.lblValueRegistry.Size = new System.Drawing.Size(31, 13);
            this.lblValueRegistry.TabIndex = 22;
            this.lblValueRegistry.Text = "Знач";
            // 
            // tbKeyRegistry
            // 
            this.tbKeyRegistry.Location = new System.Drawing.Point(43, 32);
            this.tbKeyRegistry.Name = "tbKeyRegistry";
            this.tbKeyRegistry.Size = new System.Drawing.Size(100, 20);
            this.tbKeyRegistry.TabIndex = 23;
            // 
            // tbValueRegistry
            // 
            this.tbValueRegistry.Location = new System.Drawing.Point(43, 58);
            this.tbValueRegistry.Name = "tbValueRegistry";
            this.tbValueRegistry.Size = new System.Drawing.Size(100, 20);
            this.tbValueRegistry.TabIndex = 24;
            // 
            // RemoteAccsess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 333);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnBrowsePathPsExec);
            this.Controls.Add(this.lblPathPsExec);
            this.Controls.Add(this.tbPathPsExec);
            this.Controls.Add(this.btnQuestion);
            this.Controls.Add(this.btnLoadListPC);
            this.Controls.Add(this.cbListPC);
            this.Controls.Add(this.lblNameRemotePC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(332, 372);
            this.Name = "RemoteAccsess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Только ни чего не сломай";
            this.Load += new System.EventHandler(this.RemoteAccsess_Load);
            this.tabControl.ResumeLayout(false);
            this.tpService.ResumeLayout(false);
            this.tpService.PerformLayout();
            this.tpRegistry.ResumeLayout(false);
            this.tpRegistry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNameRemotePC;
        private System.Windows.Forms.ComboBox cbListPC;
        private System.Windows.Forms.Button btnLoadListPC;
        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.TextBox tbPathPsExec;
        private System.Windows.Forms.Label lblPathPsExec;
        private System.Windows.Forms.Button btnBrowsePathPsExec;
        private System.Windows.Forms.RadioButton rbtnServiceOn;
        private System.Windows.Forms.RadioButton rbtnServiceOff;
        private System.Windows.Forms.TextBox tbNameService;
        private System.Windows.Forms.Label lblNameService;
        private System.Windows.Forms.Button btnServiceCommStart;
        private System.Windows.Forms.Button btnRegistryCommStart;
        private System.Windows.Forms.TextBox tbPathRegistry;
        private System.Windows.Forms.Label lblPathRegistry;
        private System.Windows.Forms.RadioButton rbtnRegistryAdd;
        private System.Windows.Forms.RadioButton rbtnRegistryDel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnServiceStat;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpService;
        private System.Windows.Forms.TabPage tpRegistry;
        private System.Windows.Forms.Label lblLogService;
        private System.Windows.Forms.TextBox tbLogService;
        private System.Windows.Forms.Button btnRegistryStat;
        private System.Windows.Forms.Label lblLogRegistry;
        private System.Windows.Forms.TextBox tbLogRegistry;
        private System.Windows.Forms.TextBox tbValueRegistry;
        private System.Windows.Forms.TextBox tbKeyRegistry;
        private System.Windows.Forms.Label lblValueRegistry;
        private System.Windows.Forms.Label lblKeyRegistry;
    }
}