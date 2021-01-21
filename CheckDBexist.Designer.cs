
namespace ALLinONE
{
    partial class CheckDBexist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckDBexist));
            this.tbPathFileDB = new ALLinONE.MyTextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCreateDB = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // tbPathFileDB
            // 
            this.tbPathFileDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPathFileDB.Location = new System.Drawing.Point(0, 0);
            this.tbPathFileDB.MaximumSize = new System.Drawing.Size(1000, 20);
            this.tbPathFileDB.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbPathFileDB.Name = "tbPathFileDB";
            this.tbPathFileDB.Size = new System.Drawing.Size(387, 20);
            this.tbPathFileDB.TabIndex = 1;
            this.tbPathFileDB.TextMaxLength = 1024;
            this.tbPathFileDB.TextTitle = "Путь к БД/Имя новой БД";
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(325, 0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(62, 20);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Выбрать";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCreateDB
            // 
            this.btnCreateDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateDB.Location = new System.Drawing.Point(288, 26);
            this.btnCreateDB.Name = "btnCreateDB";
            this.btnCreateDB.Size = new System.Drawing.Size(93, 45);
            this.btnCreateDB.TabIndex = 3;
            this.btnCreateDB.Text = "Создать пустую БД";
            this.btnCreateDB.UseVisualStyleBackColor = true;
            this.btnCreateDB.Click += new System.EventHandler(this.btnCreateDB_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(6, 26);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(87, 45);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Подтвердить выбор";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = ".db";
            this.openFileDialog.Filter = "File DB|*.db|All Files|*.*";
            this.openFileDialog.Title = "Выбери файл БД";
            // 
            // CheckDBexist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 76);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCreateDB);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.tbPathFileDB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1078, 115);
            this.MinimumSize = new System.Drawing.Size(403, 115);
            this.Name = "CheckDBexist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Проверка файла БД";
            this.ResumeLayout(false);

        }

        #endregion
        private MyTextBox tbPathFileDB;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCreateDB;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}