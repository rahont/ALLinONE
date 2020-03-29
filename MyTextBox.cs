using System;
using System.Windows.Forms;

namespace ALLinONE
{
    public partial class MyTextBox : UserControl
    {
        public MyTextBox()
        {
            InitializeComponent();
        }

        public string TextTitle
        {
            get => lbl.Text;
            set
            {
                lbl.Text = value;
                Refresh();
            }
        }

        public int TextMaxLength
        {
            get => tb.MaxLength;
            set { tb.MaxLength = value; }
        }

        public override string Text
        {
            get => tb.Text;
            set { tb.Text = value; }
        }

        public int TextLength
        {
            get => tb.TextLength;
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (tb.TextLength > 0)
                lbl.Visible = false;
            else lbl.Visible = true;
        }

        private void lbl_Click(object sender, EventArgs e)
        {
            tb.Focus();
        }
    }
}
