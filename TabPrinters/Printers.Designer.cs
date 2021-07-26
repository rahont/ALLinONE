
namespace ALLinONE.TabPrinters
{
    partial class Printers
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
            this.btnPrintChange = new System.Windows.Forms.Button();
            this.dgvPrinters = new System.Windows.Forms.DataGridView();
            this.btnPrintRemove = new System.Windows.Forms.Button();
            this.tbPrintName = new System.Windows.Forms.TextBox();
            this.lblPrintBuffer = new System.Windows.Forms.Label();
            this.tbPrintNetName = new System.Windows.Forms.TextBox();
            this.lblPrintInvNumber = new System.Windows.Forms.Label();
            this.tbPrintLocation = new System.Windows.Forms.TextBox();
            this.lblPrintLocation = new System.Windows.Forms.Label();
            this.btnPrintAdd = new System.Windows.Forms.Button();
            this.lblPrintNetName = new System.Windows.Forms.Label();
            this.tbPrintInvNumber = new System.Windows.Forms.TextBox();
            this.lblPrintName = new System.Windows.Forms.Label();
            this.btnSaveToExcel = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinters)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrintChange
            // 
            this.btnPrintChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintChange.Location = new System.Drawing.Point(467, 434);
            this.btnPrintChange.Name = "btnPrintChange";
            this.btnPrintChange.Size = new System.Drawing.Size(75, 23);
            this.btnPrintChange.TabIndex = 22;
            this.btnPrintChange.Text = "Изменить";
            this.btnPrintChange.UseVisualStyleBackColor = true;
            this.btnPrintChange.Click += new System.EventHandler(this.btnPrintChange_Click);
            // 
            // dgvPrinters
            // 
            this.dgvPrinters.AllowUserToAddRows = false;
            this.dgvPrinters.AllowUserToDeleteRows = false;
            this.dgvPrinters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrinters.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPrinters.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPrinters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPrinters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrinters.Location = new System.Drawing.Point(0, 0);
            this.dgvPrinters.MultiSelect = false;
            this.dgvPrinters.Name = "dgvPrinters";
            this.dgvPrinters.ReadOnly = true;
            this.dgvPrinters.RowHeadersVisible = false;
            this.dgvPrinters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrinters.Size = new System.Drawing.Size(545, 399);
            this.dgvPrinters.TabIndex = 17;
            this.dgvPrinters.TabStop = false;
            this.dgvPrinters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrinters_CellClick);
            this.dgvPrinters.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPrinters_KeyDown);
            // 
            // btnPrintRemove
            // 
            this.btnPrintRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintRemove.Location = new System.Drawing.Point(467, 463);
            this.btnPrintRemove.Name = "btnPrintRemove";
            this.btnPrintRemove.Size = new System.Drawing.Size(75, 23);
            this.btnPrintRemove.TabIndex = 23;
            this.btnPrintRemove.Text = "Удалить";
            this.btnPrintRemove.UseVisualStyleBackColor = true;
            this.btnPrintRemove.Click += new System.EventHandler(this.btnPrintRemove_Click);
            // 
            // tbPrintName
            // 
            this.tbPrintName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPrintName.Location = new System.Drawing.Point(3, 445);
            this.tbPrintName.MaxLength = 100;
            this.tbPrintName.Name = "tbPrintName";
            this.tbPrintName.Size = new System.Drawing.Size(100, 20);
            this.tbPrintName.TabIndex = 16;
            this.tbPrintName.Click += new System.EventHandler(this.tbPrintName_Click);
            // 
            // lblPrintBuffer
            // 
            this.lblPrintBuffer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrintBuffer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrintBuffer.Enabled = false;
            this.lblPrintBuffer.Location = new System.Drawing.Point(3, 468);
            this.lblPrintBuffer.Name = "lblPrintBuffer";
            this.lblPrintBuffer.Size = new System.Drawing.Size(48, 18);
            this.lblPrintBuffer.TabIndex = 28;
            // 
            // tbPrintNetName
            // 
            this.tbPrintNetName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPrintNetName.Location = new System.Drawing.Point(115, 445);
            this.tbPrintNetName.MaxLength = 50;
            this.tbPrintNetName.Name = "tbPrintNetName";
            this.tbPrintNetName.Size = new System.Drawing.Size(100, 20);
            this.tbPrintNetName.TabIndex = 18;
            this.tbPrintNetName.Click += new System.EventHandler(this.tbPrintName_Click);
            // 
            // lblPrintInvNumber
            // 
            this.lblPrintInvNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrintInvNumber.AutoSize = true;
            this.lblPrintInvNumber.Location = new System.Drawing.Point(350, 426);
            this.lblPrintInvNumber.Name = "lblPrintInvNumber";
            this.lblPrintInvNumber.Size = new System.Drawing.Size(76, 13);
            this.lblPrintInvNumber.TabIndex = 27;
            this.lblPrintInvNumber.Text = "Инвентарный";
            // 
            // tbPrintLocation
            // 
            this.tbPrintLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPrintLocation.Location = new System.Drawing.Point(227, 445);
            this.tbPrintLocation.MaxLength = 20;
            this.tbPrintLocation.Name = "tbPrintLocation";
            this.tbPrintLocation.Size = new System.Drawing.Size(100, 20);
            this.tbPrintLocation.TabIndex = 19;
            this.tbPrintLocation.Click += new System.EventHandler(this.tbPrintName_Click);
            // 
            // lblPrintLocation
            // 
            this.lblPrintLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrintLocation.AutoSize = true;
            this.lblPrintLocation.Location = new System.Drawing.Point(236, 426);
            this.lblPrintLocation.Name = "lblPrintLocation";
            this.lblPrintLocation.Size = new System.Drawing.Size(82, 13);
            this.lblPrintLocation.TabIndex = 26;
            this.lblPrintLocation.Text = "Расположение";
            // 
            // btnPrintAdd
            // 
            this.btnPrintAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintAdd.Location = new System.Drawing.Point(467, 405);
            this.btnPrintAdd.Name = "btnPrintAdd";
            this.btnPrintAdd.Size = new System.Drawing.Size(75, 23);
            this.btnPrintAdd.TabIndex = 21;
            this.btnPrintAdd.Text = "Добавить";
            this.btnPrintAdd.UseVisualStyleBackColor = true;
            this.btnPrintAdd.Click += new System.EventHandler(this.btnPrintAdd_Click);
            // 
            // lblPrintNetName
            // 
            this.lblPrintNetName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrintNetName.AutoSize = true;
            this.lblPrintNetName.Location = new System.Drawing.Point(129, 426);
            this.lblPrintNetName.Name = "lblPrintNetName";
            this.lblPrintNetName.Size = new System.Drawing.Size(72, 13);
            this.lblPrintNetName.TabIndex = 25;
            this.lblPrintNetName.Text = "Сетевое имя";
            // 
            // tbPrintInvNumber
            // 
            this.tbPrintInvNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPrintInvNumber.Location = new System.Drawing.Point(339, 445);
            this.tbPrintInvNumber.MaxLength = 15;
            this.tbPrintInvNumber.Name = "tbPrintInvNumber";
            this.tbPrintInvNumber.Size = new System.Drawing.Size(100, 20);
            this.tbPrintInvNumber.TabIndex = 20;
            this.tbPrintInvNumber.Click += new System.EventHandler(this.tbPrintName_Click);
            // 
            // lblPrintName
            // 
            this.lblPrintName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrintName.AutoSize = true;
            this.lblPrintName.Location = new System.Drawing.Point(10, 426);
            this.lblPrintName.Name = "lblPrintName";
            this.lblPrintName.Size = new System.Drawing.Size(83, 13);
            this.lblPrintName.TabIndex = 24;
            this.lblPrintName.Text = "Наименование";
            // 
            // btnSaveToExcel
            // 
            this.btnSaveToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveToExcel.Location = new System.Drawing.Point(386, 452);
            this.btnSaveToExcel.Name = "btnSaveToExcel";
            this.btnSaveToExcel.Size = new System.Drawing.Size(75, 34);
            this.btnSaveToExcel.TabIndex = 29;
            this.btnSaveToExcel.Text = "Выгрузить в Excel";
            this.btnSaveToExcel.UseVisualStyleBackColor = true;
            this.btnSaveToExcel.Click += new System.EventHandler(this.btnSaveToExcel_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xlsx";
            this.saveFileDialog.Filter = "Excel files|*.xlsx|All files|*.*";
            // 
            // Printers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSaveToExcel);
            this.Controls.Add(this.btnPrintChange);
            this.Controls.Add(this.dgvPrinters);
            this.Controls.Add(this.btnPrintRemove);
            this.Controls.Add(this.tbPrintName);
            this.Controls.Add(this.lblPrintBuffer);
            this.Controls.Add(this.tbPrintNetName);
            this.Controls.Add(this.lblPrintInvNumber);
            this.Controls.Add(this.tbPrintLocation);
            this.Controls.Add(this.lblPrintLocation);
            this.Controls.Add(this.btnPrintAdd);
            this.Controls.Add(this.lblPrintNetName);
            this.Controls.Add(this.tbPrintInvNumber);
            this.Controls.Add(this.lblPrintName);
            this.MinimumSize = new System.Drawing.Size(545, 489);
            this.Name = "Printers";
            this.Size = new System.Drawing.Size(545, 489);
            this.Load += new System.EventHandler(this.Printers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrintChange;
        public System.Windows.Forms.DataGridView dgvPrinters;
        private System.Windows.Forms.Button btnPrintRemove;
        public System.Windows.Forms.TextBox tbPrintName;
        private System.Windows.Forms.Label lblPrintBuffer;
        private System.Windows.Forms.TextBox tbPrintNetName;
        private System.Windows.Forms.Label lblPrintInvNumber;
        private System.Windows.Forms.TextBox tbPrintLocation;
        private System.Windows.Forms.Label lblPrintLocation;
        private System.Windows.Forms.Button btnPrintAdd;
        private System.Windows.Forms.Label lblPrintNetName;
        private System.Windows.Forms.TextBox tbPrintInvNumber;
        private System.Windows.Forms.Label lblPrintName;
        private System.Windows.Forms.Button btnSaveToExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}
