
namespace ALLinONE.TabRequests
{
    partial class Requests
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
            this.chkbPrefixShow = new System.Windows.Forms.CheckBox();
            this.btnClearAllRequest = new System.Windows.Forms.Button();
            this.lblInfoRequest = new System.Windows.Forms.Label();
            this.dgvRequest = new System.Windows.Forms.DataGridView();
            this.chckbRemoveRequest = new System.Windows.Forms.CheckBox();
            this.btnAddRequest = new System.Windows.Forms.Button();
            this.btnAddRequestBuffer = new System.Windows.Forms.Button();
            this.btnRemoveRequest = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblUserRequest = new System.Windows.Forms.Label();
            this.btnSaveToExcel = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tbPrefixRequest = new ALLinONE.MyTextBox();
            this.tbAddRequest = new ALLinONE.MyTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // chkbPrefixShow
            // 
            this.chkbPrefixShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkbPrefixShow.AutoSize = true;
            this.chkbPrefixShow.Location = new System.Drawing.Point(3, 322);
            this.chkbPrefixShow.Name = "chkbPrefixShow";
            this.chkbPrefixShow.Size = new System.Drawing.Size(130, 17);
            this.chkbPrefixShow.TabIndex = 20;
            this.chkbPrefixShow.Text = "Показать префиксы";
            this.chkbPrefixShow.UseVisualStyleBackColor = true;
            this.chkbPrefixShow.CheckedChanged += new System.EventHandler(this.chkbPrefixShow_CheckedChanged);
            // 
            // btnClearAllRequest
            // 
            this.btnClearAllRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAllRequest.Location = new System.Drawing.Point(467, 409);
            this.btnClearAllRequest.Name = "btnClearAllRequest";
            this.btnClearAllRequest.Size = new System.Drawing.Size(75, 49);
            this.btnClearAllRequest.TabIndex = 18;
            this.btnClearAllRequest.Text = "Очистить список заявок";
            this.btnClearAllRequest.UseVisualStyleBackColor = true;
            this.btnClearAllRequest.Click += new System.EventHandler(this.btnClearAllRequest_Click);
            // 
            // lblInfoRequest
            // 
            this.lblInfoRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfoRequest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblInfoRequest.Enabled = false;
            this.lblInfoRequest.Location = new System.Drawing.Point(0, 461);
            this.lblInfoRequest.Name = "lblInfoRequest";
            this.lblInfoRequest.Size = new System.Drawing.Size(545, 28);
            this.lblInfoRequest.TabIndex = 16;
            this.lblInfoRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvRequest
            // 
            this.dgvRequest.AllowUserToAddRows = false;
            this.dgvRequest.AllowUserToDeleteRows = false;
            this.dgvRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRequest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRequest.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRequest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequest.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvRequest.Location = new System.Drawing.Point(1, 0);
            this.dgvRequest.MultiSelect = false;
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.ReadOnly = true;
            this.dgvRequest.RowHeadersVisible = false;
            this.dgvRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequest.Size = new System.Drawing.Size(543, 290);
            this.dgvRequest.TabIndex = 9;
            this.dgvRequest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequest_CellClick);
            this.dgvRequest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequest_CellDoubleClick);
            this.dgvRequest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRequest_KeyDown);
            // 
            // chckbRemoveRequest
            // 
            this.chckbRemoveRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chckbRemoveRequest.AutoSize = true;
            this.chckbRemoveRequest.Checked = true;
            this.chckbRemoveRequest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckbRemoveRequest.Location = new System.Drawing.Point(477, 386);
            this.chckbRemoveRequest.Name = "chckbRemoveRequest";
            this.chckbRemoveRequest.Size = new System.Drawing.Size(69, 17);
            this.chckbRemoveRequest.TabIndex = 17;
            this.chckbRemoveRequest.Text = "Удалять";
            this.chckbRemoveRequest.UseVisualStyleBackColor = true;
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddRequest.Location = new System.Drawing.Point(219, 322);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(75, 23);
            this.btnAddRequest.TabIndex = 11;
            this.btnAddRequest.Text = "Добавить";
            this.btnAddRequest.UseVisualStyleBackColor = true;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // btnAddRequestBuffer
            // 
            this.btnAddRequestBuffer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRequestBuffer.Location = new System.Drawing.Point(477, 344);
            this.btnAddRequestBuffer.Name = "btnAddRequestBuffer";
            this.btnAddRequestBuffer.Size = new System.Drawing.Size(65, 36);
            this.btnAddRequestBuffer.TabIndex = 14;
            this.btnAddRequestBuffer.Text = "Закинуть в буфер";
            this.btnAddRequestBuffer.UseVisualStyleBackColor = true;
            this.btnAddRequestBuffer.Click += new System.EventHandler(this.btnAddRequestBuffer_Click);
            // 
            // btnRemoveRequest
            // 
            this.btnRemoveRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveRequest.Location = new System.Drawing.Point(300, 322);
            this.btnRemoveRequest.Name = "btnRemoveRequest";
            this.btnRemoveRequest.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveRequest.TabIndex = 12;
            this.btnRemoveRequest.Text = "Удалить";
            this.btnRemoveRequest.UseVisualStyleBackColor = true;
            this.btnRemoveRequest.Click += new System.EventHandler(this.btnRemoveRequest_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(3, 375);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(100, 13);
            this.lblQuantity.TabIndex = 19;
            this.lblQuantity.Text = "NumberOfRequests";
            // 
            // lblUserRequest
            // 
            this.lblUserRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUserRequest.AutoSize = true;
            this.lblUserRequest.Location = new System.Drawing.Point(3, 353);
            this.lblUserRequest.Name = "lblUserRequest";
            this.lblUserRequest.Size = new System.Drawing.Size(79, 13);
            this.lblUserRequest.TabIndex = 15;
            this.lblUserRequest.Text = "UserNameError";
            // 
            // btnSaveToExcel
            // 
            this.btnSaveToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveToExcel.Location = new System.Drawing.Point(261, 376);
            this.btnSaveToExcel.Name = "btnSaveToExcel";
            this.btnSaveToExcel.Size = new System.Drawing.Size(75, 34);
            this.btnSaveToExcel.TabIndex = 22;
            this.btnSaveToExcel.Text = "Выгрузить в Excel";
            this.btnSaveToExcel.UseVisualStyleBackColor = true;
            this.btnSaveToExcel.Click += new System.EventHandler(this.btnSaveToExcel_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xlsx";
            this.saveFileDialog.Filter = "Excel files|*.xlsx|All files|*.*";
            // 
            // tbPrefixRequest
            // 
            this.tbPrefixRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPrefixRequest.Location = new System.Drawing.Point(0, 296);
            this.tbPrefixRequest.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbPrefixRequest.Name = "tbPrefixRequest";
            this.tbPrefixRequest.PasswordChar = '\0';
            this.tbPrefixRequest.Size = new System.Drawing.Size(100, 20);
            this.tbPrefixRequest.TabIndex = 21;
            this.tbPrefixRequest.TextMaxLength = 1024;
            this.tbPrefixRequest.TextTitle = "Префикс";
            this.tbPrefixRequest._TextChanged += new System.EventHandler(this.tbPrefixRequest__TextChanged);
            // 
            // tbAddRequest
            // 
            this.tbAddRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddRequest.Location = new System.Drawing.Point(106, 296);
            this.tbAddRequest.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbAddRequest.Name = "tbAddRequest";
            this.tbAddRequest.PasswordChar = '\0';
            this.tbAddRequest.Size = new System.Drawing.Size(439, 20);
            this.tbAddRequest.TabIndex = 10;
            this.tbAddRequest.TextMaxLength = 1024;
            this.tbAddRequest.TextTitle = "Тут можно добавлять заявки в список";
            this.tbAddRequest.KeyDownEvent += new System.Windows.Forms.KeyEventHandler(this.tbAddRequest_KeyDownEvent);
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSaveToExcel);
            this.Controls.Add(this.chkbPrefixShow);
            this.Controls.Add(this.tbPrefixRequest);
            this.Controls.Add(this.tbAddRequest);
            this.Controls.Add(this.btnClearAllRequest);
            this.Controls.Add(this.lblInfoRequest);
            this.Controls.Add(this.dgvRequest);
            this.Controls.Add(this.chckbRemoveRequest);
            this.Controls.Add(this.btnAddRequest);
            this.Controls.Add(this.btnAddRequestBuffer);
            this.Controls.Add(this.btnRemoveRequest);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblUserRequest);
            this.MinimumSize = new System.Drawing.Size(545, 489);
            this.Name = "Requests";
            this.Size = new System.Drawing.Size(545, 489);
            this.Load += new System.EventHandler(this.Requests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkbPrefixShow;
        private MyTextBox tbPrefixRequest;
        private MyTextBox tbAddRequest;
        private System.Windows.Forms.Button btnClearAllRequest;
        private System.Windows.Forms.Label lblInfoRequest;
        private System.Windows.Forms.DataGridView dgvRequest;
        private System.Windows.Forms.CheckBox chckbRemoveRequest;
        private System.Windows.Forms.Button btnAddRequest;
        private System.Windows.Forms.Button btnAddRequestBuffer;
        private System.Windows.Forms.Button btnRemoveRequest;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblUserRequest;
        private System.Windows.Forms.Button btnSaveToExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}
