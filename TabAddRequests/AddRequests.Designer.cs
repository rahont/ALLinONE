
namespace ALLinONE.TabAddRequests
{
    partial class AddRequests
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
            this.btnMassRequest = new System.Windows.Forms.Button();
            this.btnCartPaper = new System.Windows.Forms.Button();
            this.btnRemoveProg = new System.Windows.Forms.Button();
            this.btnAddProg = new System.Windows.Forms.Button();
            this.lblAddRequestDB = new System.Windows.Forms.Label();
            this.btnAddRequestDB = new System.Windows.Forms.Button();
            this.gbAddRequest = new System.Windows.Forms.GroupBox();
            this.rdbtnAddRequest5 = new System.Windows.Forms.RadioButton();
            this.rdbtnAddRequest3 = new System.Windows.Forms.RadioButton();
            this.rdbtnAddRequest4 = new System.Windows.Forms.RadioButton();
            this.rdbtnAddRequest2 = new System.Windows.Forms.RadioButton();
            this.rdbtnAddRequest1 = new System.Windows.Forms.RadioButton();
            this.lbProgList = new System.Windows.Forms.ListBox();
            this.tbAddFIORequest = new ALLinONE.MyTextBox();
            this.tbAddProg = new ALLinONE.MyTextBox();
            this.gbAddRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMassRequest
            // 
            this.btnMassRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMassRequest.Location = new System.Drawing.Point(428, 321);
            this.btnMassRequest.Name = "btnMassRequest";
            this.btnMassRequest.Size = new System.Drawing.Size(107, 43);
            this.btnMassRequest.TabIndex = 29;
            this.btnMassRequest.Text = "Массовые заявки по ПК";
            this.btnMassRequest.UseVisualStyleBackColor = true;
            this.btnMassRequest.Click += new System.EventHandler(this.btnMassRequest_Click);
            // 
            // btnCartPaper
            // 
            this.btnCartPaper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCartPaper.Location = new System.Drawing.Point(336, 321);
            this.btnCartPaper.Name = "btnCartPaper";
            this.btnCartPaper.Size = new System.Drawing.Size(86, 43);
            this.btnCartPaper.TabIndex = 26;
            this.btnCartPaper.Text = "Картриджи и замятие";
            this.btnCartPaper.UseVisualStyleBackColor = true;
            this.btnCartPaper.Click += new System.EventHandler(this.btnCartPaper_Click);
            // 
            // btnRemoveProg
            // 
            this.btnRemoveProg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveProg.Location = new System.Drawing.Point(287, 455);
            this.btnRemoveProg.Name = "btnRemoveProg";
            this.btnRemoveProg.Size = new System.Drawing.Size(75, 24);
            this.btnRemoveProg.TabIndex = 21;
            this.btnRemoveProg.Text = "Удалить";
            this.btnRemoveProg.UseVisualStyleBackColor = true;
            this.btnRemoveProg.Click += new System.EventHandler(this.btnRemoveProg_Click);
            // 
            // btnAddProg
            // 
            this.btnAddProg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProg.Location = new System.Drawing.Point(460, 456);
            this.btnAddProg.Name = "btnAddProg";
            this.btnAddProg.Size = new System.Drawing.Size(75, 23);
            this.btnAddProg.TabIndex = 22;
            this.btnAddProg.Text = "Добавить";
            this.btnAddProg.UseVisualStyleBackColor = true;
            this.btnAddProg.Click += new System.EventHandler(this.btnAddProg_Click);
            // 
            // lblAddRequestDB
            // 
            this.lblAddRequestDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddRequestDB.Enabled = false;
            this.lblAddRequestDB.Location = new System.Drawing.Point(284, 228);
            this.lblAddRequestDB.Name = "lblAddRequestDB";
            this.lblAddRequestDB.Size = new System.Drawing.Size(251, 78);
            this.lblAddRequestDB.TabIndex = 23;
            this.lblAddRequestDB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddRequestDB
            // 
            this.btnAddRequestDB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddRequestDB.Location = new System.Drawing.Point(370, 187);
            this.btnAddRequestDB.Name = "btnAddRequestDB";
            this.btnAddRequestDB.Size = new System.Drawing.Size(102, 26);
            this.btnAddRequestDB.TabIndex = 25;
            this.btnAddRequestDB.Text = "Закинуть в БД";
            this.btnAddRequestDB.UseVisualStyleBackColor = true;
            this.btnAddRequestDB.Click += new System.EventHandler(this.btnAddRequestDB_Click);
            // 
            // gbAddRequest
            // 
            this.gbAddRequest.Controls.Add(this.rdbtnAddRequest5);
            this.gbAddRequest.Controls.Add(this.rdbtnAddRequest3);
            this.gbAddRequest.Controls.Add(this.rdbtnAddRequest4);
            this.gbAddRequest.Controls.Add(this.rdbtnAddRequest2);
            this.gbAddRequest.Controls.Add(this.rdbtnAddRequest1);
            this.gbAddRequest.Location = new System.Drawing.Point(302, 28);
            this.gbAddRequest.Name = "gbAddRequest";
            this.gbAddRequest.Size = new System.Drawing.Size(223, 114);
            this.gbAddRequest.TabIndex = 24;
            this.gbAddRequest.TabStop = false;
            this.gbAddRequest.Text = "Что будем делать?";
            // 
            // rdbtnAddRequest5
            // 
            this.rdbtnAddRequest5.AutoSize = true;
            this.rdbtnAddRequest5.Location = new System.Drawing.Point(126, 19);
            this.rdbtnAddRequest5.Name = "rdbtnAddRequest5";
            this.rdbtnAddRequest5.Size = new System.Drawing.Size(68, 17);
            this.rdbtnAddRequest5.TabIndex = 5;
            this.rdbtnAddRequest5.Text = "Удалить";
            this.rdbtnAddRequest5.UseVisualStyleBackColor = true;
            // 
            // rdbtnAddRequest3
            // 
            this.rdbtnAddRequest3.AutoSize = true;
            this.rdbtnAddRequest3.Location = new System.Drawing.Point(8, 65);
            this.rdbtnAddRequest3.Name = "rdbtnAddRequest3";
            this.rdbtnAddRequest3.Size = new System.Drawing.Size(74, 17);
            this.rdbtnAddRequest3.TabIndex = 3;
            this.rdbtnAddRequest3.Text = "Обновить";
            this.rdbtnAddRequest3.UseVisualStyleBackColor = true;
            // 
            // rdbtnAddRequest4
            // 
            this.rdbtnAddRequest4.AutoSize = true;
            this.rdbtnAddRequest4.Location = new System.Drawing.Point(8, 88);
            this.rdbtnAddRequest4.Name = "rdbtnAddRequest4";
            this.rdbtnAddRequest4.Size = new System.Drawing.Size(79, 17);
            this.rdbtnAddRequest4.TabIndex = 4;
            this.rdbtnAddRequest4.Text = "Настроить";
            this.rdbtnAddRequest4.UseVisualStyleBackColor = true;
            // 
            // rdbtnAddRequest2
            // 
            this.rdbtnAddRequest2.AutoSize = true;
            this.rdbtnAddRequest2.Location = new System.Drawing.Point(8, 42);
            this.rdbtnAddRequest2.Name = "rdbtnAddRequest2";
            this.rdbtnAddRequest2.Size = new System.Drawing.Size(108, 17);
            this.rdbtnAddRequest2.TabIndex = 2;
            this.rdbtnAddRequest2.Text = "Переустановить";
            this.rdbtnAddRequest2.UseVisualStyleBackColor = true;
            // 
            // rdbtnAddRequest1
            // 
            this.rdbtnAddRequest1.AutoSize = true;
            this.rdbtnAddRequest1.Checked = true;
            this.rdbtnAddRequest1.Location = new System.Drawing.Point(8, 19);
            this.rdbtnAddRequest1.Name = "rdbtnAddRequest1";
            this.rdbtnAddRequest1.Size = new System.Drawing.Size(85, 17);
            this.rdbtnAddRequest1.TabIndex = 1;
            this.rdbtnAddRequest1.TabStop = true;
            this.rdbtnAddRequest1.Text = "Установить";
            this.rdbtnAddRequest1.UseVisualStyleBackColor = true;
            // 
            // lbProgList
            // 
            this.lbProgList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbProgList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbProgList.IntegralHeight = false;
            this.lbProgList.ItemHeight = 15;
            this.lbProgList.Location = new System.Drawing.Point(3, 3);
            this.lbProgList.Name = "lbProgList";
            this.lbProgList.Size = new System.Drawing.Size(269, 483);
            this.lbProgList.Sorted = true;
            this.lbProgList.TabIndex = 20;
            this.lbProgList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbProgList_KeyDown);
            // 
            // tbAddFIORequest
            // 
            this.tbAddFIORequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddFIORequest.Location = new System.Drawing.Point(302, 161);
            this.tbAddFIORequest.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbAddFIORequest.Name = "tbAddFIORequest";
            this.tbAddFIORequest.PasswordChar = '\0';
            this.tbAddFIORequest.Size = new System.Drawing.Size(233, 20);
            this.tbAddFIORequest.TabIndex = 28;
            this.tbAddFIORequest.TextMaxLength = 100;
            this.tbAddFIORequest.TextTitle = "ФИО и любая другая инфа";
            this.tbAddFIORequest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAddFIORequest_KeyDown);
            // 
            // tbAddProg
            // 
            this.tbAddProg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddProg.Location = new System.Drawing.Point(287, 429);
            this.tbAddProg.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbAddProg.Name = "tbAddProg";
            this.tbAddProg.PasswordChar = '\0';
            this.tbAddProg.Size = new System.Drawing.Size(248, 20);
            this.tbAddProg.TabIndex = 27;
            this.tbAddProg.TextMaxLength = 100;
            this.tbAddProg.TextTitle = "Название ПО";
            this.tbAddProg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAddProg_KeyDown);
            // 
            // AddRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMassRequest);
            this.Controls.Add(this.tbAddFIORequest);
            this.Controls.Add(this.tbAddProg);
            this.Controls.Add(this.btnCartPaper);
            this.Controls.Add(this.btnRemoveProg);
            this.Controls.Add(this.btnAddProg);
            this.Controls.Add(this.lblAddRequestDB);
            this.Controls.Add(this.btnAddRequestDB);
            this.Controls.Add(this.gbAddRequest);
            this.Controls.Add(this.lbProgList);
            this.MinimumSize = new System.Drawing.Size(545, 489);
            this.Name = "AddRequests";
            this.Size = new System.Drawing.Size(545, 489);
            this.Load += new System.EventHandler(this.AddRequests_Load);
            this.gbAddRequest.ResumeLayout(false);
            this.gbAddRequest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMassRequest;
        private MyTextBox tbAddFIORequest;
        private MyTextBox tbAddProg;
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
        private System.Windows.Forms.RadioButton rdbtnAddRequest5;
    }
}
