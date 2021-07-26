using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLinONE.TabAddRequests
{
    class MethodsAddRequests
    {
        public void RefreshProgList(ListBox lb)
        {
            lb.Items.Clear();
            foreach (var item in UseDB.SelectDB("ProgList", "Name"))
            {
                lb.Items.Add(item);
            }
        }
    }
}