namespace ALLinONE
{
    partial class PRChangeButton
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRChangeButton));
            this.lbList = new System.Windows.Forms.ListBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSave = new System.Windows.Forms.Label();
            this.lblBtnValue = new System.Windows.Forms.Label();
            this.lblBtnName = new System.Windows.Forms.Label();
            this.tmrComm3333 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbList
            // 
            this.lbList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbList.FormattingEnabled = true;
            this.lbList.Location = new System.Drawing.Point(0, 0);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(194, 389);
            this.lbList.TabIndex = 0;
            this.lbList.SelectedIndexChanged += new System.EventHandler(this.LbList_SelectedIndexChanged);
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Location = new System.Drawing.Point(45, 23);
            this.tbName.MaxLength = 32;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(198, 20);
            this.tbName.TabIndex = 1;
            this.tbName.Text = "Выбери кнопку";
            // 
            // tbValue
            // 
            this.tbValue.Enabled = false;
            this.tbValue.Location = new System.Drawing.Point(6, 79);
            this.tbValue.MaxLength = 1024;
            this.tbValue.Multiline = true;
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(275, 218);
            this.tbValue.TabIndex = 2;
            this.tbValue.Text = "Для разблокировки поля - выбери кнопку";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 34);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(156, 313);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 34);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Отчистить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 389);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSave);
            this.panel2.Controls.Add(this.lblBtnValue);
            this.panel2.Controls.Add(this.lblBtnName);
            this.panel2.Controls.Add(this.tbName);
            this.panel2.Controls.Add(this.tbValue);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(194, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 389);
            this.panel2.TabIndex = 6;
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSave.Location = new System.Drawing.Point(26, 354);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(233, 24);
            this.lblSave.TabIndex = 7;
            this.lblSave.Text = "Изменения сохранены";
            this.lblSave.Visible = false;
            // 
            // lblBtnValue
            // 
            this.lblBtnValue.AutoSize = true;
            this.lblBtnValue.Location = new System.Drawing.Point(115, 60);
            this.lblBtnValue.Name = "lblBtnValue";
            this.lblBtnValue.Size = new System.Drawing.Size(55, 13);
            this.lblBtnValue.TabIndex = 6;
            this.lblBtnValue.Text = "Значение";
            // 
            // lblBtnName
            // 
            this.lblBtnName.AutoSize = true;
            this.lblBtnName.Location = new System.Drawing.Point(109, 6);
            this.lblBtnName.Name = "lblBtnName";
            this.lblBtnName.Size = new System.Drawing.Size(68, 13);
            this.lblBtnName.TabIndex = 5;
            this.lblBtnName.Text = "Имя кнопки";
            this.lblBtnName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrComm3333
            // 
            this.tmrComm3333.Interval = 3333;
            this.tmrComm3333.Tick += new System.EventHandler(this.tmrComm3333_Tick);
            // 
            // PRChangeButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 389);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(497, 700);
            this.MinimumSize = new System.Drawing.Size(497, 394);
            this.Name = "PRChangeButton";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменение кнопок";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PRChangeButton_FormClosing);
            this.Load += new System.EventHandler(this.PRChangeButton_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBtnValue;
        private System.Windows.Forms.Label lblBtnName;
        private System.Windows.Forms.Timer tmrComm3333;
        private System.Windows.Forms.Label lblSave;
    }
}