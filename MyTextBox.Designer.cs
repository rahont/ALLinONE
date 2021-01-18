namespace ALLinONE
{
    partial class MyTextBox
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
            this.tb = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb.Location = new System.Drawing.Point(0, 0);
            this.tb.MaxLength = 1024;
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(100, 20);
            this.tb.TabIndex = 0;
            this.tb.Click += new System.EventHandler(this.tb_Click);
            this.tb.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.SystemColors.Window;
            this.lbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl.ForeColor = System.Drawing.Color.Gray;
            this.lbl.Location = new System.Drawing.Point(4, 3);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(53, 13);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Your Text";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // MyTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.tb);
            this.MaximumSize = new System.Drawing.Size(1000, 20);
            this.MinimumSize = new System.Drawing.Size(1, 20);
            this.Name = "MyTextBox";
            this.Size = new System.Drawing.Size(100, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label lbl;
    }
}
