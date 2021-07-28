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
                    worksheet.Cells[i + 1, j].Value = (prefix + dgv.Rows[i].Cells[j].Value).Trim();
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

        public static void SaveFormPosition(int x, int y)
        {
            RegistryKey formPos = Registry.CurrentUser.CreateSubKey("SOFTWARE\\All in One");
            formPos.SetValue("PositionX", x);
            formPos.SetValue("PositionY", y);
            formPos.Close();
        }

        /// <summary>
        /// Возвращает номер версии приложения
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>1: Major, 2: Major + Minor, 3: Major + Minor + Build, 4: Major + Minor + Build + Revision</returns>
        public static string AiOVersion(short amount = 2)
        {
            //Присваиваем Major
            string result = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major.ToString();

            if (amount < 1)
                result = ".!. :P";
            else
            {
                if (amount > 1)
                {
                    //Присваиваем Minor
                    result += "." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString();

                    if (amount > 2)
                    {
                        //Присваиваем Build
                        result += "." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Build.ToString();

                        if (amount > 3)
                        {
                            //Присваиваем Revision
                            result += "." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Revision.ToString();
                        }
                    }
                }
            }
            
            return result;
        }

        /// <summary>
        /// Сохраняет запись в реестре
        /// </summary>
        /// <param name="path">Путь (по умолчанию HKCU\SOFTWARE\All in One)</param>
        /// <param name="key">Ключ, которому будем устанавливать значение</param>
        /// <param name="value">Значение, которое устанавливаем</param>
        public static void SaveInRegistry(string key, object value, string path = "SOFTWARE\\All in One")
        {
            RegistryKey registry = Registry.CurrentUser.CreateSubKey(path);
            registry.SetValue(key, value);
            registry.Close();
        }

        /// <summary>
        /// Загружает запись из реестра
        /// </summary>
        /// <param name="path">Путь (по умолчанию HKCU\SOFTWARE\All in One)</param>
        /// <param name="key">Ключ, из которого будем забирать значение</param>
        /// <param name="defaultValue">Значение по умолчанию, если ключ пуст</param>
        /// <returns></returns>
        public static object LoadFromRegistry(string key, object defaultValue, string path = "SOFTWARE\\All in One")
        {
            object result;

            RegistryKey registry = Registry.CurrentUser.CreateSubKey(path);

            result = (Registry.CurrentUser.OpenSubKey(path) != null) ?
                registry.GetValue(key, defaultValue) : "Ошибка в реестре";

            return result;
        }
    }
}