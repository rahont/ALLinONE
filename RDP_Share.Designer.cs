namespace ALLinONE
{
    partial class RDP_Share
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
            this.chckbServiceSorted = new System.Windows.Forms.CheckBox();
            this.lblShare = new System.Windows.Forms.Label();
            this.lblRDP = new System.Windows.Forms.Label();
            this.lbShare = new System.Windows.Forms.ListBox();
            this.lbRDP = new System.Windows.Forms.ListBox();
            this.btnSrvcChange = new System.Windows.Forms.Button();
            this.lbPingSuccess = new System.Windows.Forms.ListBox();
            this.lbPingTimeOut = new System.Windows.Forms.ListBox();
            this.lblPingSuccess = new System.Windows.Forms.Label();
            this.lblPingTimeOut = new System.Windows.Forms.Label();
            this.pbPingProgress = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.numPingProgress = new System.Windows.Forms.NumericUpDown();
            this.numPingTimeOut = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numPingProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPingTimeOut)).BeginInit();
            this.SuspendLayout();
            // 
            // chckbServiceSorted
            // 
            this.chckbServiceSorted.Checked = true;
            this.chckbServiceSorted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckbServiceSorted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chckbServiceSorted.Location = new System.Drawing.Point(259, 296);
            this.chckbServiceSorted.Name = "chckbServiceSorted";
            this.chckbServiceSorted.Size = new System.Drawing.Size(53, 50);
            this.chckbServiceSorted.TabIndex = 2;
            this.chckbServiceSorted.Text = "Сорт. по имени";
            this.chckbServiceSorted.UseVisualStyleBackColor = true;
            this.chckbServiceSorted.CheckedChanged += new System.EventHandler(this.chckbServiceSorted_CheckedChanged);
            // 
            // lblShare
            // 
            this.lblShare.AutoSize = true;
            this.lblShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShare.Location = new System.Drawing.Point(439, 12);
            this.lblShare.Name = "lblShare";
            this.lblShare.Size = new System.Drawing.Size(57, 20);
            this.lblShare.TabIndex = 11;
            this.lblShare.Text = "Share";
            // 
            // lblRDP
            // 
            this.lblRDP.AutoSize = true;
            this.lblRDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRDP.Location = new System.Drawing.Point(101, 12);
            this.lblRDP.Name = "lblRDP";
            this.lblRDP.Size = new System.Drawing.Size(46, 20);
            this.lblRDP.TabIndex = 10;
            this.lblRDP.Text = "RDP";
            // 
            // lbShare
            // 
            this.lbShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbShare.FormattingEnabled = true;
            this.lbShare.ItemHeight = 18;
            this.lbShare.Location = new System.Drawing.Point(315, 39);
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
            this.lbRDP.Location = new System.Drawing.Point(12, 39);
            this.lbRDP.Name = "lbRDP";
            this.lbRDP.Size = new System.Drawing.Size(242, 310);
            this.lbRDP.Sorted = true;
            this.lbRDP.TabIndex = 0;
            this.lbRDP.DoubleClick += new System.EventHandler(this.lbRDP_DoubleClick);
            this.lbRDP.Leave += new System.EventHandler(this.lbRDP_Leave);
            // 
            // btnSrvcChange
            // 
            this.btnSrvcChange.Location = new System.Drawing.Point(509, 570);
            this.btnSrvcChange.Name = "btnSrvcChange";
            this.btnSrvcChange.Size = new System.Drawing.Size(113, 37);
            this.btnSrvcChange.TabIndex = 6;
            this.btnSrvcChange.TabStop = false;
            this.btnSrvcChange.Text = "Может нам что-то поменять?";
            this.btnSrvcChange.UseVisualStyleBackColor = true;
            this.btnSrvcChange.Click += new System.EventHandler(this.btnSrvcChange_Click);
            // 
            // lbPingSuccess
            // 
            this.lbPingSuccess.FormattingEnabled = true;
            this.lbPingSuccess.Location = new System.Drawing.Point(12, 372);
            this.lbPingSuccess.Name = "lbPingSuccess";
            this.lbPingSuccess.Size = new System.Drawing.Size(135, 186);
            this.lbPingSuccess.Sorted = true;
            this.lbPingSuccess.TabIndex = 3;
            this.lbPingSuccess.Leave += new System.EventHandler(this.lbRDP_Leave);
            // 
            // lbPingTimeOut
            // 
            this.lbPingTimeOut.FormattingEnabled = true;
            this.lbPingTimeOut.Location = new System.Drawing.Point(159, 372);
            this.lbPingTimeOut.Name = "lbPingTimeOut";
            this.lbPingTimeOut.Size = new System.Drawing.Size(135, 186);
            this.lbPingTimeOut.Sorted = true;
            this.lbPingTimeOut.TabIndex = 4;
            this.lbPingTimeOut.Visible = false;
            this.lbPingTimeOut.Leave += new System.EventHandler(this.lbRDP_Leave);
            // 
            // lblPingSuccess
            // 
            this.lblPingSuccess.AutoSize = true;
            this.lblPingSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPingSuccess.Location = new System.Drawing.Point(42, 355);
            this.lblPingSuccess.Name = "lblPingSuccess";
            this.lblPingSuccess.Size = new System.Drawing.Size(72, 15);
            this.lblPingSuccess.TabIndex = 15;
            this.lblPingSuccess.Text = "Доступны";
            // 
            // lblPingTimeOut
            // 
            this.lblPingTimeOut.AutoSize = true;
            this.lblPingTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPingTimeOut.Location = new System.Drawing.Point(180, 355);
            this.lblPingTimeOut.Name = "lblPingTimeOut";
            this.lblPingTimeOut.Size = new System.Drawing.Size(92, 15);
            this.lblPingTimeOut.TabIndex = 16;
            this.lblPingTimeOut.Text = "Не доступны";
            this.lblPingTimeOut.Visible = false;
            // 
            // pbPingProgress
            // 
            this.pbPingProgress.Location = new System.Drawing.Point(31, 590);
            this.pbPingProgress.Name = "pbPingProgress";
            this.pbPingProgress.Size = new System.Drawing.Size(242, 20);
            this.pbPingProgress.TabIndex = 19;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // numPingProgress
            // 
            this.numPingProgress.Location = new System.Drawing.Point(113, 564);
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
            // numPingTimeOut
            // 
            this.numPingTimeOut.Location = new System.Drawing.Point(159, 564);
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
            this.numPingTimeOut.TabIndex = 20;
            this.numPingTimeOut.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // RDP_Share
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numPingTimeOut);
            this.Controls.Add(this.numPingProgress);
            this.Controls.Add(this.pbPingProgress);
            this.Controls.Add(this.lblPingTimeOut);
            this.Controls.Add(this.lblPingSuccess);
            this.Controls.Add(this.lbPingTimeOut);
            this.Controls.Add(this.lbPingSuccess);
            this.Controls.Add(this.btnSrvcChange);
            this.Controls.Add(this.chckbServiceSorted);
            this.Controls.Add(this.lblShare);
            this.Controls.Add(this.lblRDP);
            this.Controls.Add(this.lbShare);
            this.Controls.Add(this.lbRDP);
            this.Name = "RDP_Share";
            this.Size = new System.Drawing.Size(636, 620);
            this.Load += new System.EventHandler(this.RDP_Share_Load);
            this.VisibleChanged += new System.EventHandler(this.RDP_Share_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numPingProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPingTimeOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chckbServiceSorted;
        private System.Windows.Forms.Label lblShare;
        private System.Windows.Forms.Label lblRDP;
        private System.Windows.Forms.ListBox lbRDP;
        private System.Windows.Forms.Button btnSrvcChange;
        public System.Windows.Forms.ListBox lbShare;
        private System.Windows.Forms.ListBox lbPingSuccess;
        private System.Windows.Forms.ListBox lbPingTimeOut;
        private System.Windows.Forms.Label lblPingSuccess;
        private System.Windows.Forms.Label lblPingTimeOut;
        private System.Windows.Forms.ProgressBar pbPingProgress;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown numPingProgress;
        private System.Windows.Forms.NumericUpDown numPingTimeOut;
    }
}
