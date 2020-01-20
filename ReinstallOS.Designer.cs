namespace ALLinONE
{
    partial class ReinstallOS
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbProgList = new System.Windows.Forms.ListBox();
            this.tbAddProg = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tmr3333 = new System.Windows.Forms.Timer(this.components);
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.btnAddDB = new System.Windows.Forms.Button();
            this.lblValue = new System.Windows.Forms.Label();
            this.btnResetProgList = new System.Windows.Forms.Button();
            this.chckbListSort = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(255, 525);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbProgList
            // 
            this.lbProgList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbProgList.FormattingEnabled = true;
            this.lbProgList.ItemHeight = 18;
            this.lbProgList.Location = new System.Drawing.Point(20, 11);
            this.lbProgList.Name = "lbProgList";
            this.lbProgList.Size = new System.Drawing.Size(310, 508);
            this.lbProgList.TabIndex = 1;
            this.lbProgList.DoubleClick += new System.EventHandler(this.lbProgList_DoubleClick);
            this.lbProgList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbProgList_KeyDown);
            // 
            // tbAddProg
            // 
            this.tbAddProg.Location = new System.Drawing.Point(20, 553);
            this.tbAddProg.MaxLength = 255;
            this.tbAddProg.Name = "tbAddProg";
            this.tbAddProg.Size = new System.Drawing.Size(310, 20);
            this.tbAddProg.TabIndex = 2;
            this.tbAddProg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAddProg_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 580);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tmr3333
            // 
            this.tmr3333.Interval = 3333;
            this.tmr3333.Tick += new System.EventHandler(this.tmr3333_Tick);
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(366, 11);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(235, 20);
            this.tbFIO.TabIndex = 4;
            // 
            // btnAddDB
            // 
            this.btnAddDB.Location = new System.Drawing.Point(435, 49);
            this.btnAddDB.Name = "btnAddDB";
            this.btnAddDB.Size = new System.Drawing.Size(95, 27);
            this.btnAddDB.TabIndex = 5;
            this.btnAddDB.Text = "Закинуть в БД";
            this.btnAddDB.UseVisualStyleBackColor = true;
            this.btnAddDB.Click += new System.EventHandler(this.btnAddDB_Click);
            // 
            // lblValue
            // 
            this.lblValue.Enabled = false;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblValue.Location = new System.Drawing.Point(366, 100);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(235, 64);
            this.lblValue.TabIndex = 6;
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnResetProgList
            // 
            this.btnResetProgList.Location = new System.Drawing.Point(353, 405);
            this.btnResetProgList.Name = "btnResetProgList";
            this.btnResetProgList.Size = new System.Drawing.Size(83, 38);
            this.btnResetProgList.TabIndex = 7;
            this.btnResetProgList.Text = "Вернуть список ПО";
            this.btnResetProgList.UseVisualStyleBackColor = true;
            this.btnResetProgList.Click += new System.EventHandler(this.btnResetProgList_Click);
            // 
            // chckbListSort
            // 
            this.chckbListSort.AutoSize = true;
            this.chckbListSort.Location = new System.Drawing.Point(336, 306);
            this.chckbListSort.Name = "chckbListSort";
            this.chckbListSort.Size = new System.Drawing.Size(125, 17);
            this.chckbListSort.TabIndex = 8;
            this.chckbListSort.Text = "Сортировка списка";
            this.chckbListSort.UseVisualStyleBackColor = true;
            this.chckbListSort.CheckedChanged += new System.EventHandler(this.chckbListSort_CheckedChanged);
            // 
            // ReinstallOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chckbListSort);
            this.Controls.Add(this.btnResetProgList);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.btnAddDB);
            this.Controls.Add(this.tbFIO);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbAddProg);
            this.Controls.Add(this.lbProgList);
            this.Controls.Add(this.btnRemove);
            this.Name = "ReinstallOS";
            this.Size = new System.Drawing.Size(636, 620);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbAddProg;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Timer tmr3333;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.Button btnAddDB;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Button btnResetProgList;
        public System.Windows.Forms.ListBox lbProgList;
        private System.Windows.Forms.CheckBox chckbListSort;
    }
}
