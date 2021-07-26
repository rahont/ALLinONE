using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLinONE.TabProfRab
{
    class MethodsProfRab
    {
        public void Refresh_btnPR(Control where)
        {
            int count = UseDB.SelectDB("ProfRab", "btn_name").Length;

            for (int i = 1; i <= count; i++)
            {
                try
                {
                    var btn = GetControl(where, "btnPR" + i);   //метод поиска контролов (записывем имя кнопки в переменную)
                    btn.Text = UseDB.SelectDBLike("ProfRab", "btn_title", "btn_name", "btnPR" + i.ToString()); //задаем Text кнопке
                }
                catch (Exception)
                {
                    //MessageBox.Show(ex.Message, "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
        }

        private Control GetControl(Control control, string name)    //метод поиска контролов
        {
            var fetchedControl = control.Controls[name];
            if (fetchedControl == null)
                foreach (Control c in control.Controls)
                {
                    fetchedControl = GetControl(c, name);
                    if (fetchedControl != null)
                        break;
                }
            return fetchedControl;
        }
    }
}