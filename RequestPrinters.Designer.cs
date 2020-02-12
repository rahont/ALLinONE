namespace ALLinONE
{
    partial class RequestPrinters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestPrinters));
            this.dgvRequestPrint = new System.Windows.Forms.DataGridView();
            this.btnAddRequestPrint = new System.Windows.Forms.Button();
            this.lblRequestPrint = new System.Windows.Forms.Label();
            this.tmrComm5555 = new System.Windows.Forms.Timer(this.components);
            this.rdbtnReplace = new System.Windows.Forms.RadioButton();
            this.rdbtnPaper = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chckbColor = new System.Windows.Forms.CheckBox();
            this.rdbtnYellow = new System.Windows.Forms.RadioButton();
            this.rdbtnBlue = new System.Windows.Forms.RadioButton();
            this.rdbtnRed = new System.Windows.Forms.RadioButton();
            this.rdbtnBlack = new System.Windows.Forms.RadioButton();
            this.rdbtnPaperRoll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestPrint)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRequestPrint
            // 
            this.dgvRequestPrint.AllowUserToAddRows = false;
            this.dgvRequestPrint.AllowUserToDeleteRows = false;
            this.dgvRequestPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRequestPrint.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRequestPrint.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRequestPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestPrint.Location = new System.Drawing.Point(1, 0);
            this.dgvRequestPrint.MultiSelect = false;
            this.dgvRequestPrint.Name = "dgvRequestPrint";
            this.dgvRequestPrint.ReadOnly = true;
            this.dgvRequestPrint.RowHeadersVisible = false;
            this.dgvRequestPrint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequestPrint.Size = new System.Drawing.Size(543, 456);
            this.dgvRequestPrint.TabIndex = 0;
            this.dgvRequestPrint.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequestPrint_CellDoubleClick);
            // 
            // btnAddRequestPrint
            // 
            this.btnAddRequestPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRequestPrint.Location = new System.Drawing.Point(420, 462);
            this.btnAddRequestPrint.Name = "btnAddRequestPrint";
            this.btnAddRequestPrint.Size = new System.Drawing.Size(113, 23);
            this.btnAddRequestPrint.TabIndex = 1;
            this.btnAddRequestPrint.Text = "Закинуть в БД";
            this.btnAddRequestPrint.UseVisualStyleBackColor = true;
            this.btnAddRequestPrint.Click += new System.EventHandler(this.btnAddRequestPrint_Click);
            // 
            // lblRequestPrint
            // 
            this.lblRequestPrint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRequestPrint.Enabled = false;
            this.lblRequestPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRequestPrint.Location = new System.Drawing.Point(0, 557);
            this.lblRequestPrint.Name = "lblRequestPrint";
            this.lblRequestPrint.Size = new System.Drawing.Size(545, 19);
            this.lblRequestPrint.TabIndex = 2;
            this.lblRequestPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrComm5555
            // 
            this.tmrComm5555.Interval = 5555;
            this.tmrComm5555.Tick += new System.EventHandler(this.tmrComm5555_Tick);
            // 
            // rdbtnReplace
            // 
            this.rdbtnReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbtnReplace.AutoSize = true;
            this.rdbtnReplace.Checked = true;
            this.rdbtnReplace.Location = new System.Drawing.Point(12, 465);
            this.rdbtnReplace.Name = "rdbtnReplace";
            this.rdbtnReplace.Size = new System.Drawing.Size(122, 17);
            this.rdbtnReplace.TabIndex = 5;
            this.rdbtnReplace.TabStop = true;
            this.rdbtnReplace.Text = "Замена картриджа";
            this.rdbtnReplace.UseVisualStyleBackColor = true;
            // 
            // rdbtnPaper
            // 
            this.rdbtnPaper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbtnPaper.AutoSize = true;
            this.rdbtnPaper.Location = new System.Drawing.Point(153, 465);
            this.rdbtnPaper.Name = "rdbtnPaper";
            this.rdbtnPaper.Size = new System.Drawing.Size(132, 17);
            this.rdbtnPaper.TabIndex = 6;
            this.rdbtnPaper.Text = "Устранение замятия";
            this.rdbtnPaper.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chckbColor);
            this.groupBox1.Controls.Add(this.rdbtnYellow);
            this.groupBox1.Controls.Add(this.rdbtnBlue);
            this.groupBox1.Controls.Add(this.rdbtnRed);
            this.groupBox1.Controls.Add(this.rdbtnBlack);
            this.groupBox1.Location = new System.Drawing.Point(66, 488);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 61);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // chckbColor
            // 
            this.chckbColor.AutoSize = true;
            this.chckbColor.Location = new System.Drawing.Point(6, 13);
            this.chckbColor.Name = "chckbColor";
            this.chckbColor.Size = new System.Drawing.Size(163, 17);
            this.chckbColor.TabIndex = 4;
            this.chckbColor.Text = "Желаешь добавить цвета?";
            this.chckbColor.UseVisualStyleBackColor = true;
            // 
            // rdbtnYellow
            // 
            this.rdbtnYellow.AutoSize = true;
            this.rdbtnYellow.Location = new System.Drawing.Point(259, 37);
            this.rdbtnYellow.Name = "rdbtnYellow";
            this.rdbtnYellow.Size = new System.Drawing.Size(67, 17);
            this.rdbtnYellow.TabIndex = 3;
            this.rdbtnYellow.Text = "Желтый";
            this.rdbtnYellow.UseVisualStyleBackColor = true;
            // 
            // rdbtnBlue
            // 
            this.rdbtnBlue.AutoSize = true;
            this.rdbtnBlue.Location = new System.Drawing.Point(197, 37);
            this.rdbtnBlue.Name = "rdbtnBlue";
            this.rdbtnBlue.Size = new System.Drawing.Size(56, 17);
            this.rdbtnBlue.TabIndex = 2;
            this.rdbtnBlue.Text = "Синий";
            this.rdbtnBlue.UseVisualStyleBackColor = true;
            // 
            // rdbtnRed
            // 
            this.rdbtnRed.AutoSize = true;
            this.rdbtnRed.Location = new System.Drawing.Point(121, 37);
            this.rdbtnRed.Name = "rdbtnRed";
            this.rdbtnRed.Size = new System.Drawing.Size(70, 17);
            this.rdbtnRed.TabIndex = 1;
            this.rdbtnRed.Text = "Красный";
            this.rdbtnRed.UseVisualStyleBackColor = true;
            // 
            // rdbtnBlack
            // 
            this.rdbtnBlack.AutoSize = true;
            this.rdbtnBlack.Checked = true;
            this.rdbtnBlack.Location = new System.Drawing.Point(50, 37);
            this.rdbtnBlack.Name = "rdbtnBlack";
            this.rdbtnBlack.Size = new System.Drawing.Size(65, 17);
            this.rdbtnBlack.TabIndex = 0;
            this.rdbtnBlack.TabStop = true;
            this.rdbtnBlack.Text = "Черный";
            this.rdbtnBlack.UseVisualStyleBackColor = true;
            // 
            // rdbtnPaperRoll
            // 
            this.rdbtnPaperRoll.AutoSize = true;
            this.rdbtnPaperRoll.Location = new System.Drawing.Point(307, 465);
            this.rdbtnPaperRoll.Name = "rdbtnPaperRoll";
            this.rdbtnPaperRoll.Size = new System.Drawing.Size(94, 17);
            this.rdbtnPaperRoll.TabIndex = 8;
            this.rdbtnPaperRoll.TabStop = true;
            this.rdbtnPaperRoll.Text = "Рулон бумаги";
            this.rdbtnPaperRoll.UseVisualStyleBackColor = true;
            // 
            // RequestPrinters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 576);
            this.Controls.Add(this.rdbtnPaperRoll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdbtnPaper);
            this.Controls.Add(this.rdbtnReplace);
            this.Controls.Add(this.lblRequestPrint);
            this.Controls.Add(this.btnAddRequestPrint);
            this.Controls.Add(this.dgvRequestPrint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(561, 615);
            this.Name = "RequestPrinters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заявки по принтерам";
            this.Load += new System.EventHandler(this.RequestPrinters_Load);
            this.ResizeEnd += new System.EventHandler(this.RequestPrinters_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestPrint)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRequestPrint;
        private System.Windows.Forms.Button btnAddRequestPrint;
        private System.Windows.Forms.Label lblRequestPrint;
        private System.Windows.Forms.Timer tmrComm5555;
        private System.Windows.Forms.RadioButton rdbtnReplace;
        private System.Windows.Forms.RadioButton rdbtnPaper;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chckbColor;
        private System.Windows.Forms.RadioButton rdbtnYellow;
        private System.Windows.Forms.RadioButton rdbtnBlue;
        private System.Windows.Forms.RadioButton rdbtnRed;
        private System.Windows.Forms.RadioButton rdbtnBlack;
        private System.Windows.Forms.RadioButton rdbtnPaperRoll;
    }
}