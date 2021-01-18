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

        //Событие KeyDown для UserControl
        public event KeyEventHandler KeyDownEvent;
        //Событие Click для UserControl
        public event EventHandler _ClickEvent;

        private void tb_TextChanged(object sender, EventArgs e)
        {
            //if (tb.TextLength > 0)
            //    lbl.Visible = false;
            //else lbl.Visible = true;
            lbl.Visible = (tb.TextLength <= 0);
        }

        private void lbl_Click(object sender, EventArgs e)
        {
            tb.Focus();
            _ClickEvent?.Invoke(sender, e);
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            KeyDownEvent?.Invoke(sender, e);
            //if (KeyDownEvent != null)
            //    KeyDownEvent(sender, e);
        }

        private void tb_Click(object sender, EventArgs e)
        {
            _ClickEvent?.Invoke(sender, e);
        }
    }
}
