
namespace ALLinONE
{
    partial class MassRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MassRequest));
            this.chckbListSort = new System.Windows.Forms.CheckBox();
            this.btnResetProgList = new System.Windows.Forms.Button();
            this.lblValue = new System.Windows.Forms.Label();
            this.btnAddDB = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbProgList = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tmr3333 = new System.Windows.Forms.Timer(this.components);
            this.tbFIO = new ALLinONE.MyTextBox();
            this.tbAddProg = new ALLinONE.MyTextBox();
            this.SuspendLayout();
            // 
            // chckbListSort
            // 
            this.chckbListSort.AutoSize = true;
            this.chckbListSort.Location = new System.Drawing.Point(328, 175);
            this.chckbListSort.Name = "chckbListSort";
            this.chckbListSort.Size = new System.Drawing.Size(125, 17);
            this.chckbListSort.TabIndex = 17;
            this.chckbListSort.Text = "Сортировка списка";
            this.chckbListSort.UseVisualStyleBackColor = true;
            this.chckbListSort.CheckedChanged += new System.EventHandler(this.chckbListSort_CheckedChanged);
            // 
            // btnResetProgList
            // 
            this.btnResetProgList.Location = new System.Drawing.Point(328, 207);
            this.btnResetProgList.Name = "btnResetProgList";
            this.btnResetProgList.Size = new System.Drawing.Size(83, 38);
            this.btnResetProgList.TabIndex = 16;
            this.btnResetProgList.Text = "Вернуть список ПО";
            this.btnResetProgList.UseVisualStyleBackColor = true;
            this.btnResetProgList.Click += new System.EventHandler(this.btnResetProgList_Click);
            // 
            // lblValue
            // 
            this.lblValue.Enabled = false;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblValue.Location = new System.Drawing.Point(334, 81);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(254, 64);
            this.lblValue.TabIndex = 15;
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddDB
            // 
            this.btnAddDB.Location = new System.Drawing.Point(414, 48);
            this.btnAddDB.Name = "btnAddDB";
            this.btnAddDB.Size = new System.Drawing.Size(95, 27);
            this.btnAddDB.TabIndex = 14;
            this.btnAddDB.Text = "Закинуть в БД";
            this.btnAddDB.UseVisualStyleBackColor = true;
            this.btnAddDB.Click += new System.EventHandler(this.btnAddDB_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(337, 378);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbProgList
            // 
            this.lbProgList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbProgList.FormattingEnabled = true;
            this.lbProgList.ItemHeight = 18;
            this.lbProgList.Location = new System.Drawing.Point(12, 12);
            this.lbProgList.Name = "lbProgList";
            this.lbProgList.Size = new System.Drawing.Size(310, 418);
            this.lbProgList.TabIndex = 10;
            this.lbProgList.DoubleClick += new System.EventHandler(this.lbProgList_DoubleClick);
            this.lbProgList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbProgList_KeyDown);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(337, 407);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tmr3333
            // 
            this.tmr3333.Interval = 3333;
            this.tmr3333.Tick += new System.EventHandler(this.tmr3333_Tick);
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(337, 22);
            this.tbFIO.MaximumSize = new System.Drawing.Size(1000, 20);
            this.tbFIO.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(251, 20);
            this.tbFIO.TabIndex = 18;
            this.tbFIO.TextMaxLength = 100;
            this.tbFIO.TextTitle = "ФИО и номер кабинета или Имя ПК";
            this.tbFIO.KeyDownEvent += new System.Windows.Forms.KeyEventHandler(this.tbFIO_KeyDownEvent);
            // 
            // tbAddProg
            // 
            this.tbAddProg.Location = new System.Drawing.Point(337, 352);
            this.tbAddProg.MaximumSize = new System.Drawing.Size(1000, 20);
            this.tbAddProg.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbAddProg.Name = "tbAddProg";
            this.tbAddProg.Size = new System.Drawing.Size(251, 20);
            this.tbAddProg.TabIndex = 11;
            this.tbAddProg.TextMaxLength = 100;
            this.tbAddProg.TextTitle = "Установить/Настроить *Название ПО*";
            this.tbAddProg.KeyDownEvent += new System.Windows.Forms.KeyEventHandler(this.tbAddProg_KeyDownEvent);
            // 
            // MassRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 437);
            this.Controls.Add(this.tbFIO);
            this.Controls.Add(this.tbAddProg);
            this.Controls.Add(this.chckbListSort);
            this.Controls.Add(this.btnResetProgList);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.btnAddDB);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbProgList);
            this.Controls.Add(this.btnRemove);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(616, 476);
            this.MinimumSize = new System.Drawing.Size(616, 476);
            this.Name = "MassRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Массовые заявки";
            this.Load += new System.EventHandler(this.MassRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MyTextBox tbAddProg;
        private System.Windows.Forms.CheckBox chckbListSort;
        private System.Windows.Forms.Button btnResetProgList;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Button btnAddDB;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.ListBox lbProgList;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Timer tmr3333;
        private MyTextBox tbFIO;
    }
}