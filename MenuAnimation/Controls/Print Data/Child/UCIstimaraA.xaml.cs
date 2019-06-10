using Microsoft.Office.Interop.Excel;
using System;
using System.Windows;
using System.Windows.Controls;


namespace Astmara6.Controls.Print_Data.Child
{
    /// <summary>
    /// Interaction logic for UCIstimaraA.xaml
    /// </summary>
    public partial class UCIstimaraA : UserControl
    {
        public UCIstimaraA()
        {
            InitializeComponent();
        }
        private void GenerateExcelFile(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            app.WindowState = XlWindowState.xlMaximized;

            Workbook wb = app.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet ws = wb.Worksheets[1];

            DateTime currentDate = DateTime.Now;

            ws.Range["A6:k6"].RowHeight = 20;
            ws.Range["D6"].ColumnWidth = 20;
            ws.Range["E6"].Value = "         للفصل:      الثانى        للعام الدراسي:      2017    / 2018 ";
            ws.Range["A5:k5"].RowHeight = 50;
            ws.Range["D5"].ColumnWidth = 20; 
            ws.Range["D5"].Value = "استمارة ب";
            ws.Range["A8:F8"].RowHeight = 65;
            ws.Range["A8"].ColumnWidth = 15;
            ws.Range["A8"].Value = "الاســــــــــــــم";
     
            ws.get_Range("A1", "A14").Cells.HorizontalAlignment =
               Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenterAcrossSelection;


            ws.Range["B8"].Value = "الوظيفة \n والدرجة  \n المالية";


            ws.Range["C8"].Value = "النصاب  " + "\n القانوني";

            ws.Range["E8"].Value = "المواد التي يقوم بتدريسها";
            ws.Range["F8"].Value = "الفرقة";
            ws.Range["G8:k8"].ColumnWidth = 3;









            //ws.Range["C6"].FormulaLocal = "= A5 + 1";
            //ws.Range["A7"].FormulaLocal = "=SUM(D1:D10)";
            //for (int i = 1; i <= 10; i++)
            //    ws.Range["D" + i].Value = i * 2;

            wb.SaveAs("C:\\excel\\ffff.xlsx");

        }
    }
}
