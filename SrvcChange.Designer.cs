namespace ALLinONE
{
    partial class SrvcChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SrvcChange));
            this.lbRDP = new System.Windows.Forms.ListBox();
            this.lbShare = new System.Windows.Forms.ListBox();
            this.btnRDPAdd = new System.Windows.Forms.Button();
            this.btnRDPRmv = new System.Windows.Forms.Button();
            this.btnShareAdd = new System.Windows.Forms.Button();
            this.btnShareRmv = new System.Windows.Forms.Button();
            this.lblRDP = new System.Windows.Forms.Label();
            this.lblShare = new System.Windows.Forms.Label();
            this.lbPing = new System.Windows.Forms.ListBox();
            this.lblPing = new System.Windows.Forms.Label();
            this.btnPingAdd = new System.Windows.Forms.Button();
            this.btnPingRmv = new System.Windows.Forms.Button();
            this.tbPingTitle = new ALLinONE.MyTextBox();
            this.tbPingName = new ALLinONE.MyTextBox();
            this.tbRDPName = new ALLinONE.MyTextBox();
            this.tbRDPTitle = new ALLinONE.MyTextBox();
            this.tbShareName = new ALLinONE.MyTextBox();
            this.tbShareTitle = new ALLinONE.MyTextBox();
            this.SuspendLayout();
            // 
            // lbRDP
            // 
            this.lbRDP.FormattingEnabled = true;
            this.lbRDP.Location = new System.Drawing.Point(11, 43);
            this.lbRDP.Name = "lbRDP";
            this.lbRDP.Size = new System.Drawing.Size(213, 368);
            this.lbRDP.TabIndex = 0;
            this.lbRDP.TabStop = false;
            // 
            // lbShare
            // 
            this.lbShare.FormattingEnabled = true;
            this.lbShare.Location = new System.Drawing.Point(252, 43);
            this.lbShare.Name = "lbShare";
            this.lbShare.Size = new System.Drawing.Size(213, 368);
            this.lbShare.TabIndex = 5;
            this.lbShare.TabStop = false;
            // 
            // btnRDPAdd
            // 
            this.btnRDPAdd.Location = new System.Drawing.Point(42, 451);
            this.btnRDPAdd.Name = "btnRDPAdd";
            this.btnRDPAdd.Size = new System.Drawing.Size(75, 26);
            this.btnRDPAdd.TabIndex = 3;
            this.btnRDPAdd.Text = "Добавить";
            this.btnRDPAdd.UseVisualStyleBackColor = true;
            this.btnRDPAdd.Click += new System.EventHandler(this.BtnRDPAdd_Click);
            // 
            // btnRDPRmv
            // 
            this.btnRDPRmv.Location = new System.Drawing.Point(123, 451);
            this.btnRDPRmv.Name = "btnRDPRmv";
            this.btnRDPRmv.Size = new System.Drawing.Size(75, 26);
            this.btnRDPRmv.TabIndex = 4;
            this.btnRDPRmv.Text = "Удалить";
            this.btnRDPRmv.UseVisualStyleBackColor = true;
            this.btnRDPRmv.Click += new System.EventHandler(this.BtnRDPRmv_Click);
            // 
            // btnShareAdd
            // 
            this.btnShareAdd.Location = new System.Drawing.Point(282, 451);
            this.btnShareAdd.Name = "btnShareAdd";
            this.btnShareAdd.Size = new System.Drawing.Size(75, 26);
            this.btnShareAdd.TabIndex = 8;
            this.btnShareAdd.Text = "Добавить";
            this.btnShareAdd.UseVisualStyleBackColor = true;
            this.btnShareAdd.Click += new System.EventHandler(this.BtnShareAdd_Click);
            // 
            // btnShareRmv
            // 
            this.btnShareRmv.Location = new System.Drawing.Point(363, 451);
            this.btnShareRmv.Name = "btnShareRmv";
            this.btnShareRmv.Size = new System.Drawing.Size(75, 26);
            this.btnShareRmv.TabIndex = 9;
            this.btnShareRmv.Text = "Удалить";
            this.btnShareRmv.UseVisualStyleBackColor = true;
            this.btnShareRmv.Click += new System.EventHandler(this.BtnShareRmv_Click);
            // 
            // lblRDP
            // 
            this.lblRDP.AutoSize = true;
            this.lblRDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRDP.Location = new System.Drawing.Point(98, 13);
            this.lblRDP.Name = "lblRDP";
            this.lblRDP.Size = new System.Drawing.Size(43, 18);
            this.lblRDP.TabIndex = 8;
            this.lblRDP.Text = "RDP";
            // 
            // lblShare
            // 
            this.lblShare.AutoSize = true;
            this.lblShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShare.Location = new System.Drawing.Point(339, 13);
            this.lblShare.Name = "lblShare";
            this.lblShare.Size = new System.Drawing.Size(52, 18);
            this.lblShare.TabIndex = 9;
            this.lblShare.Text = "Share";
            // 
            // lbPing
            // 
            this.lbPing.FormattingEnabled = true;
            this.lbPing.Location = new System.Drawing.Point(492, 43);
            this.lbPing.Name = "lbPing";
            this.lbPing.Size = new System.Drawing.Size(206, 368);
            this.lbPing.TabIndex = 11;
            // 
            // lblPing
            // 
            this.lblPing.AutoSize = true;
            this.lblPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPing.Location = new System.Drawing.Point(574, 13);
            this.lblPing.Name = "lblPing";
            this.lblPing.Size = new System.Drawing.Size(41, 18);
            this.lblPing.TabIndex = 14;
            this.lblPing.Text = "Ping";
            // 
            // btnPingAdd
            // 
            this.btnPingAdd.Location = new System.Drawing.Point(517, 451);
            this.btnPingAdd.Name = "btnPingAdd";
            this.btnPingAdd.Size = new System.Drawing.Size(75, 26);
            this.btnPingAdd.TabIndex = 15;
            this.btnPingAdd.Text = "Добавить";
            this.btnPingAdd.UseVisualStyleBackColor = true;
            this.btnPingAdd.Click += new System.EventHandler(this.btnPingAdd_Click);
            // 
            // btnPingRmv
            // 
            this.btnPingRmv.Location = new System.Drawing.Point(598, 451);
            this.btnPingRmv.Name = "btnPingRmv";
            this.btnPingRmv.Size = new System.Drawing.Size(75, 26);
            this.btnPingRmv.TabIndex = 16;
            this.btnPingRmv.Text = "Удалить";
            this.btnPingRmv.UseVisualStyleBackColor = true;
            this.btnPingRmv.Click += new System.EventHandler(this.btnPingRmv_Click);
            // 
            // tbPingTitle
            // 
            this.tbPingTitle.Location = new System.Drawing.Point(598, 417);
            this.tbPingTitle.MaximumSize = new System.Drawing.Size(1000, 20);
            this.tbPingTitle.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbPingTitle.Name = "tbPingTitle";
            this.tbPingTitle.Size = new System.Drawing.Size(100, 20);
            this.tbPingTitle.TabIndex = 13;
            this.tbPingTitle.TextMaxLength = 100;
            this.tbPingTitle.TextTitle = "Наименование";
            // 
            // tbPingName
            // 
            this.tbPingName.Location = new System.Drawing.Point(492, 417);
            this.tbPingName.MaximumSize = new System.Drawing.Size(1000, 20);
            this.tbPingName.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbPingName.Name = "tbPingName";
            this.tbPingName.Size = new System.Drawing.Size(100, 20);
            this.tbPingName.TabIndex = 12;
            this.tbPingName.TextMaxLength = 255;
            this.tbPingName.TextTitle = "Адрес";
            // 
            // tbRDPName
            // 
            this.tbRDPName.Location = new System.Drawing.Point(11, 417);
            this.tbRDPName.MaximumSize = new System.Drawing.Size(1000, 20);
            this.tbRDPName.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbRDPName.Name = "tbRDPName";
            this.tbRDPName.Size = new System.Drawing.Size(106, 20);
            this.tbRDPName.TabIndex = 17;
            this.tbRDPName.TextMaxLength = 1024;
            this.tbRDPName.TextTitle = "Адрес";
            // 
            // tbRDPTitle
            // 
            this.tbRDPTitle.Location = new System.Drawing.Point(123, 417);
            this.tbRDPTitle.MaximumSize = new System.Drawing.Size(1000, 20);
            this.tbRDPTitle.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbRDPTitle.Name = "tbRDPTitle";
            this.tbRDPTitle.Size = new System.Drawing.Size(101, 20);
            this.tbRDPTitle.TabIndex = 18;
            this.tbRDPTitle.TextMaxLength = 1024;
            this.tbRDPTitle.TextTitle = "Наименование";
            // 
            // tbShareName
            // 
            this.tbShareName.Location = new System.Drawing.Point(252, 417);
            this.tbShareName.MaximumSize = new System.Drawing.Size(1000, 20);
            this.tbShareName.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbShareName.Name = "tbShareName";
            this.tbShareName.Size = new System.Drawing.Size(105, 20);
            this.tbShareName.TabIndex = 19;
            this.tbShareName.TextMaxLength = 1024;
            this.tbShareName.TextTitle = "Адрес";
            // 
            // tbShareTitle
            // 
            this.tbShareTitle.Location = new System.Drawing.Point(363, 417);
            this.tbShareTitle.MaximumSize = new System.Drawing.Size(1000, 20);
            this.tbShareTitle.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbShareTitle.Name = "tbShareTitle";
            this.tbShareTitle.Size = new System.Drawing.Size(102, 20);
            this.tbShareTitle.TabIndex = 20;
            this.tbShareTitle.TextMaxLength = 1024;
            this.tbShareTitle.TextTitle = "Наименование";
            // 
            // SrvcChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 485);
            this.Controls.Add(this.tbShareTitle);
            this.Controls.Add(this.tbShareName);
            this.Controls.Add(this.tbRDPTitle);
            this.Controls.Add(this.tbRDPName);
            this.Controls.Add(this.btnPingRmv);
            this.Controls.Add(this.btnPingAdd);
            this.Controls.Add(this.lblPing);
            this.Controls.Add(this.tbPingTitle);
            this.Controls.Add(this.tbPingName);
            this.Controls.Add(this.lbPing);
            this.Controls.Add(this.lblShare);
            this.Controls.Add(this.lblRDP);
            this.Controls.Add(this.btnShareRmv);
            this.Controls.Add(this.btnShareAdd);
            this.Controls.Add(this.btnRDPRmv);
            this.Controls.Add(this.btnRDPAdd);
            this.Controls.Add(this.lbShare);
            this.Controls.Add(this.lbRDP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(16, 524);
            this.Name = "SrvcChange";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "РэДэПэ и шара";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SrvcChange_FormClosing);
            this.Load += new System.EventHandler(this.SrvcChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbRDP;
        private System.Windows.Forms.ListBox lbShare;
        private System.Windows.Forms.Button btnRDPAdd;
        private System.Windows.Forms.Button btnRDPRmv;
        private System.Windows.Forms.Button btnShareAdd;
        private System.Windows.Forms.Button btnShareRmv;
        private System.Windows.Forms.Label lblRDP;
        private System.Windows.Forms.Label lblShare;
        private System.Windows.Forms.ListBox lbPing;
        private MyTextBox tbPingName;
        private MyTextBox tbPingTitle;
        private System.Windows.Forms.Label lblPing;
        private System.Windows.Forms.Button btnPingAdd;
        private System.Windows.Forms.Button btnPingRmv;
        private MyTextBox tbRDPName;
        private MyTextBox tbRDPTitle;
        private MyTextBox tbShareName;
        private MyTextBox tbShareTitle;
    }
}