using Microsoft.Win32;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLinONE
{
    static class AiOMethods
    {
        static List<string> listName = new List<string>();
        static List<string> listTitle = new List<string>();

        //Excel
        public static void SaveExcel(DataGridView dgv, string fullPath)
        {
            //Create a new ExcelPackage
            ExcelPackage excelPackage = new ExcelPackage();
            //Set some properties of the Excel document
            excelPackage.Workbook.Properties.Author = Environment.UserName;
            //excelPackage.Workbook.Properties.Title = "Title of Document";
            //excelPackage.Workbook.Properties.Subject = "EPPlus demo export data";
            excelPackage.Workbook.Properties.Created = DateTime.Now;
            //Create the WorkSheet
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet");

            int tmp = 1;
            for (int i = 0; i < dgv.Rows.Count; i++)    //Строки
            {
                for (int j = 1; j < dgv.ColumnCount; j++)   //Столбцы
                {
                    //Добавляем префикс в ячейку с заявками
                    string prefix = ((dgv.Name == "dgvRequest") && (j == 2)) ?
                        (dgv.Rows[i].Cells[1].Value).ToString() + " " : string.Empty;
                    //Сохранение ячейки в файле
                    worksheet.Cells[i + 1, j].Value = prefix + dgv.Rows[i].Cells[j].Value;
                    //Границы для ячеек
                    worksheet.Cells[i + 1, j].Style.Border.BorderAround(ExcelBorderStyle.Thin);

                    tmp = j;
                }
            }

            //Удаляем первый стобец из списка заявок, т.к. он пустой
            if (dgv.Name == "dgvRequest") worksheet.DeleteColumn(1);

            //Выравнимаем ширину ячеек
            for (int i = 1; i <= tmp; i++)
                worksheet.Column(i).AutoFit();

            //Save your file
            FileInfo fi1 = new FileInfo(fullPath);
            try
            {
                excelPackage.SaveAs(fi1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message +"\n\n"+ ex.InnerException.InnerException.Message, "Что случилось?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void RefreshProgList(ListBox lb)
        {
            lb.Items.Clear();
            foreach (var item in UseDB.SelectDB("ProgList", "Name"))
            {
                lb.Items.Add(item);
            }
        }

        public static void LoadPingLB(ProgressBar pb, ListBox lbS, ListBox lbT, NumericUpDown num)
        {
            //Service srvc = new Service();
            //pb.Value = 0;
            //lbS.Items.Clear();
            //lbT.Items.Clear();

            //srvc.LoadLBPing(num.Value, out string[] pingSuccess, out string[] pingFailure);
            //srvc.LoadLBPing(num.Value, lbS, lbT);

            //foreach (var item in pingSuccess)
            //{
            //    if (item == null) continue;
            //    else lbS.Items.Add(item);
            //}

            //foreach (var item in pingFailure)
            //{
            //    if (item == null) continue;
            //    else lbT.Items.Add(item);
            //}
        }

        public static void LoadFormPosition(out int x, out int y)
        {
            RegistryKey formPos = Registry.CurrentUser.CreateSubKey("SOFTWARE\\All in One");

            x = Convert.ToInt32(formPos.GetValue("PositionX", 0));
            y = Convert.ToInt32(formPos.GetValue("PositionX", 0));

            //Location = new Point(Convert.ToInt32(formPos.GetValue("PositionX", Location.X)),
            //    Convert.ToInt32(formPos.GetValue("PositionY", Location.Y)));   //загрузить позицию формы из реестра
            formPos.Close();
        }

        public static void SaveFormPosition(int x, int y)
        {
            RegistryKey formPos = Registry.CurrentUser.CreateSubKey("SOFTWARE\\All in One");
            formPos.SetValue("PositionX", x);
            formPos.SetValue("PositionY", y);
            formPos.Close();
        }
    }
}
