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
            this.tbRDPName = new System.Windows.Forms.TextBox();
            this.tbShareName = new System.Windows.Forms.TextBox();
            this.lblRDP = new System.Windows.Forms.Label();
            this.lblShare = new System.Windows.Forms.Label();
            this.tbRDPTitle = new System.Windows.Forms.TextBox();
            this.tbShareTitle = new System.Windows.Forms.TextBox();
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
            // tbRDPName
            // 
            this.tbRDPName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbRDPName.Location = new System.Drawing.Point(11, 417);
            this.tbRDPName.MaxLength = 100;
            this.tbRDPName.Name = "tbRDPName";
            this.tbRDPName.Size = new System.Drawing.Size(106, 20);
            this.tbRDPName.TabIndex = 1;
            this.tbRDPName.Text = "Адрес";
            this.tbRDPName.Click += new System.EventHandler(this.tbRDPName_Click);
            this.tbRDPName.Leave += new System.EventHandler(this.tbRDPName_Leave);
            // 
            // tbShareName
            // 
            this.tbShareName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbShareName.Location = new System.Drawing.Point(252, 417);
            this.tbShareName.MaxLength = 255;
            this.tbShareName.Name = "tbShareName";
            this.tbShareName.Size = new System.Drawing.Size(105, 20);
            this.tbShareName.TabIndex = 6;
            this.tbShareName.Text = "Адрес";
            this.tbShareName.Click += new System.EventHandler(this.tbRDPName_Click);
            this.tbShareName.Leave += new System.EventHandler(this.tbRDPName_Leave);
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
            // tbRDPTitle
            // 
            this.tbRDPTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbRDPTitle.Location = new System.Drawing.Point(123, 417);
            this.tbRDPTitle.MaxLength = 50;
            this.tbRDPTitle.Name = "tbRDPTitle";
            this.tbRDPTitle.Size = new System.Drawing.Size(101, 20);
            this.tbRDPTitle.TabIndex = 2;
            this.tbRDPTitle.Text = "Наименование";
            this.tbRDPTitle.Click += new System.EventHandler(this.tbRDPName_Click);
            this.tbRDPTitle.Leave += new System.EventHandler(this.tbRDPName_Leave);
            // 
            // tbShareTitle
            // 
            this.tbShareTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbShareTitle.Location = new System.Drawing.Point(363, 417);
            this.tbShareTitle.MaxLength = 50;
            this.tbShareTitle.Name = "tbShareTitle";
            this.tbShareTitle.Size = new System.Drawing.Size(102, 20);
            this.tbShareTitle.TabIndex = 7;
            this.tbShareTitle.Text = "Наименование";
            this.tbShareTitle.Click += new System.EventHandler(this.tbRDPName_Click);
            this.tbShareTitle.Leave += new System.EventHandler(this.tbRDPName_Leave);
            // 
            // SrvcChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 485);
            this.Controls.Add(this.tbShareTitle);
            this.Controls.Add(this.tbRDPTitle);
            this.Controls.Add(this.lblShare);
            this.Controls.Add(this.lblRDP);
            this.Controls.Add(this.tbShareName);
            this.Controls.Add(this.tbRDPName);
            this.Controls.Add(this.btnShareRmv);
            this.Controls.Add(this.btnShareAdd);
            this.Controls.Add(this.btnRDPRmv);
            this.Controls.Add(this.btnRDPAdd);
            this.Controls.Add(this.lbShare);
            this.Controls.Add(this.lbRDP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(493, 524);
            this.MinimumSize = new System.Drawing.Size(493, 524);
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
        private System.Windows.Forms.TextBox tbRDPName;
        private System.Windows.Forms.TextBox tbShareName;
        private System.Windows.Forms.Label lblRDP;
        private System.Windows.Forms.Label lblShare;
        private System.Windows.Forms.TextBox tbRDPTitle;
        private System.Windows.Forms.TextBox tbShareTitle;
    }
}