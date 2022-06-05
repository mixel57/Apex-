using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Apex_
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        public static void openExcel()
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            try
            {
                Excel.Workbooks books = excelApp.Workbooks;
                Excel.Workbook sheet = books.Open(Environment.CurrentDirectory + "\\ApexExcel.ods");
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка открытия файла", "");
            }
        }
    }
}
