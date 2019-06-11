using Data.Context;
using System;
using System.Windows.Controls;
using System.Linq;
using Data.Entities;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Astmara6.Controls.Print_Data.Child
{
    /// <summary>
    /// Interaction logic for UCIstimaraBDoctors.xaml
    /// </summary>
    public partial class UCIstimaraBDoctors : UserControl
    {
        ObservableCollection<DGItem> myCollection { get; set; }
        List<DGItem> dGItems;

        public UCIstimaraBDoctors()
        {
            InitializeComponent();
            


        }
        public void loadDataComboTypeOfSection()
        {
            try
            {
                CollegeContext cd = new CollegeContext();

                var branchs = (from p in cd.Branches
                               select p).ToList();

                _BranchesComboBox.ItemsSource = branchs;
            }
            catch (Exception) { };
        }
        public class DGItem
        {
            public String Name { get; set; }
            public String Rank { get; set; }
            public int? HoursOfquerm { get; set; }
            public String Namesub { get; set; }
            public String level { get; set; }
            public int? Academic { get; set; }
            public int? Virtual { get; set; }
            public int? Exprement { get; set; }
           
        }
        public void loadDatagrid()
        {
            CollegeContext cd = new CollegeContext();
            Teacher teaherCB = _TeachersComboBox.SelectedItem as Teacher;

            //الاسم والدرجه والنصب القنوني

            var query = (from sc in cd.SubjectTeachers
                         join s in cd.Subjects on sc.IdSubject equals s.Id
                         join t in cd.Teachers on sc.IdTeacher equals t.Id
                         join wh in cd.WorkHours on t.IdWorkHours equals wh.Id
                         join b in cd.Branches on sc.IdBranch equals b.Id
                         where sc.IdTeacher== teaherCB.Id
                          
                         select new DGItem
                         {
                             Name = t.Name,
                             Rank = wh.Rank,
                             HoursOfquerm = wh.HoursOfQuorum,
                             Namesub = s.Name,
                             Academic = sc.hoursAca,
                             Virtual = sc.hoursVirt, 
                             Exprement = sc.hoursExp,
                         } ).ToList().Distinct().ToList();
            dGItems = query;


            IstmaraB.ItemsSource = query;

        }
        public void loadDataComboTeachers()
        {

            //دكاتره
            CollegeContext cd = new CollegeContext();
            Branch BranchCB = _BranchesComboBox.SelectedItem as Branch;
            var query = cd.SubjectTeacherLoads.Where(x => x.IdBranch == BranchCB.Id).Select(x => x.Teacher);
            // علي حسب ال id بتاع id works 
            // عشان كده لازم ادخل المعيدين مثلا الاول وبعد كده الدكاتره او العكس 
            _TeachersComboBox.ItemsSource = query.Where(u => u.WorkHour.HoursOfQuorum <= 36).ToList();

        }
        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            loadDataComboTypeOfSection();
            
            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
            // 	System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
        }

        private void BtnExportData_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void _BranchesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            loadDataComboTeachers();

        }

        private void _TeachersComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_TeachersComboBox.Text != "")
             {
                loadDatagrid();


            }
        }

        private void GenerateExcelFile(object sender, System.Windows.RoutedEventArgs e)
        {
            #region debaga
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            app.WindowState = XlWindowState.xlMaximized;

            Workbook wb = app.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet ws = (Worksheet)wb.Sheets["Sheet1"];
            ws.DisplayRightToLeft = true;


            #region
            ws.Range["A5:k5"].Merge();
            ws.Range["A5:k5"].RowHeight = 37;
            ws.Range["A5:k5"].ColumnWidth = 31.2;
            ws.Range["A5:k5"].Value = "استمارة ب";
            ws.Range["A5:k5"].EntireRow.Font.Bold = true;
            ws.Range["A5:k5"].Font.Size = 14;
            ws.get_Range("A5", "K5").Cells.HorizontalAlignment =
            Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenterAcrossSelection;
            ws.get_Range("A5", "K5").Cells.VerticalAlignment =
            Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

            #endregion
            #region   
            ws.Range["A6", "K6"].Merge();
            ws.Range["A6", "K6"].Value = "         للفصل:      الثانى        للعام الدراسي:      2017    / 2018 ";
            ws.Range["A6", "K6"].ColumnWidth = 20;
            ws.Range["A6", "K6"].EntireRow.Font.Bold = true;
            ws.Range["A6", "K6"].Font.Size = 14;
            ws.get_Range("A6", "K6").Cells.HorizontalAlignment =
             Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenterAcrossSelection;
            ws.get_Range("A6", "K6").Cells.VerticalAlignment =
            Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            #endregion

            #region
            ws.Range["A7:B7", "A8:B8"].Merge();
            ws.Range["A7:B7", "A8:B8"].Value = "الاســــــــــــــم";
            ws.Range["A7:B7", "A8:B8"].ColumnWidth = 7.43;
            ws.Range["A7:B7", "A8:B8"].RowHeight = 41;
            ws.Range["C7:C8"].EntireRow.Font.Bold = true;

            ws.Range["A7: B7", "A8: B8"].Font.Size = 12;
            ws.get_Range("A7: B7", "A8: B8").Cells.HorizontalAlignment =
              Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenterAcrossSelection;
            ws.get_Range("A7: B7", "A8: B8").Cells.VerticalAlignment =
            Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            #endregion
            #region
            ws.Range["C7:C8"].Merge();
            ws.Range["C7:C8"].Value = "الوظيفة\nوالدرجة\n المالية";
            ws.Range["C7:C8"].ColumnWidth = 7;
            ws.Range["C7:C8"].RowHeight = 41;
            ws.Range["C7:C8"].Font.Size = 12;
            ws.Range["C7:C8"].EntireRow.Font.Bold = true;

            ws.get_Range("C7:C8").Cells.HorizontalAlignment =
             Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenterAcrossSelection;
            ws.get_Range("C7:C8").Cells.VerticalAlignment =
            Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            #endregion
            #region

            ws.Range["D7:D8"].Merge();
            ws.Range["D7:D8"].WrapText = true;
            ws.Range["D7:D8"].Style.Orientation = XlOrientation.xlDownward;
            ws.Range["D7:D8"].ColumnWidth = 3.43;
            ws.Range["D7:D8"].RowHeight = 41;
            ws.Range["D7:D8"].Font.Size = 12;
            ws.Range["D7:D8"].EntireRow.Font.Bold = true;
            ws.Range["D7:D8"].Font.Size = 12;
            ws.Range["D7:D8"].Orientation = 90;
            ws.Range["D7:D8"].Value = "النصاب القانوني";
            ws.get_Range("D7:D8").Cells.VerticalAlignment =
            Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            #endregion
            #region

            ws.Range["E7:E8"].Merge();
            ws.Range["E7:E8"].WrapText = true;
            ws.Range["E7:E8"].ColumnWidth = 28;
            ws.Range["E7:E8"].RowHeight = 41;
            ws.Range["E7:E8"].Font.Size = 12;
            ws.Range["E7:E8"].EntireRow.Font.Bold = true;
            ws.Range["E7:E8"].Font.Size = 12;
            ws.Range["E7:E8"].Value = "المواد التي يقوم بتدريسها";
            ws.get_Range("E7:E8").Cells.HorizontalAlignment =
            Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenterAcrossSelection;
            ws.get_Range("E7:E8").Cells.VerticalAlignment =
            Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            #endregion
            #region

            ws.Range["F7:F8"].Merge();
            ws.Range["F7:F8"].Value = "المستوى";
            ws.Range["F7:F8"].ColumnWidth = 23.86;
            ws.Range["F7:F8"].RowHeight = 41;
            ws.Range["F7:F8"].EntireRow.Font.Bold = true;
            ws.Range["F7:F8"].Font.Size = 12;
            ws.get_Range("F7:F8").Cells.HorizontalAlignment =
              Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenterAcrossSelection;
            ws.get_Range("F7:F8").Cells.VerticalAlignment =
            Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            #endregion
            #region

            ws.Range["G7:J7"].Merge();
            ws.Range["G7:J7"].Value = "جملة الساعات";
            ws.Range["G7:J7"].ColumnWidth = 4.43;
            ws.Range["G7:J7"].EntireRow.Font.Bold = true;
            ws.Range["G7:J7"].Font.Size = 12;

            #endregion
            #region
            ws.Range["K7:K7", "K8:K8"].Merge();
            ws.Range["K7:K7", "K8:K8"].Value = "ملاحظات";
            ws.Range["K7:K7", "K8:K8"].ColumnWidth = 7;
            ws.Range["K7:K7", "K8:K8"].EntireRow.Font.Bold = true;
            ws.Range["K7:K7", "K8:K8"].Font.Size = 12;
            ws.get_Range("G7:J7", "K8:K8").Cells.HorizontalAlignment =
           Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenterAcrossSelection;
            ws.get_Range("G7:J7", "K8:K8").Cells.VerticalAlignment =
            Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;


            #endregion
            #region
            ws.Range["G8"].Orientation = 90;
            ws.Range["G8"].Value = "نظري";
            ws.Range["G8"].WrapText = true;
            ws.Range["G8"].EntireRow.Font.Bold = true;
            ws.Range["G8"].Style.Orientation = XlOrientation.xlDownward;


            ws.Range["H8"].Orientation = 90;
            ws.Range["H8"].Value = "عملي";
            ws.Range["H8"].Style.Orientation = XlOrientation.xlDownward;
            ws.Range["H8"].WrapText = true;
            ws.Range["H8"].EntireRow.Font.Bold = true;

            ws.Range["I8"].Orientation = 90;
            ws.Range["I8"].Value = "تمارين";
            ws.Range["I8"].Style.Orientation = XlOrientation.xlDownward;
            ws.Range["I8"].WrapText = true;
            ws.Range["I8"].EntireRow.Font.Bold = true;

            ws.Range["J8"].Orientation = 90;
            ws.Range["J8"].ColumnWidth = 5.29;
            ws.Range["J8"].Value = "مجموع";
            ws.Range["J8"].Style.Orientation = XlOrientation.xlDownward;
            ws.Range["J8"].WrapText = true;
            ws.Range["J8"].EntireRow.Font.Bold = true;

            #endregion
            #region
            ws.get_Range("A6:K6").Borders.LineStyle = XlLineStyle.xlContinuous;
            ws.get_Range("A5:k5").Borders.LineStyle = XlLineStyle.xlContinuous;
            ws.get_Range("A7:B7", "A8:B8").Borders.LineStyle = XlLineStyle.xlContinuous;
            ws.get_Range("C7:C8").Borders.LineStyle = XlLineStyle.xlContinuous;
            ws.get_Range("D7:D8").Borders.LineStyle = XlLineStyle.xlContinuous;
            ws.get_Range("E7:E8").Borders.LineStyle = XlLineStyle.xlContinuous;
            ws.get_Range("F7:F8").Borders.LineStyle = XlLineStyle.xlContinuous;
            ws.get_Range("K7: K7", "K8: K8").Borders.LineStyle = XlLineStyle.xlContinuous;
            ws.get_Range("G8:J8").Borders.LineStyle = XlLineStyle.xlContinuous;
            #endregion
            #endregion
            #region logic
            //add name in excel
            ws.Range["A9:B9"].Merge();
            ws.Range["A9:B9"].Value = dGItems[0].Name;
            ws.get_Range("A9:B9").Cells.HorizontalAlignment =
         Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenterAcrossSelection;
            ws.get_Range("A9:B9").Cells.VerticalAlignment =
            Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

            //add Rank in excel
            ws.Range["C9"].Merge();
            ws.Range["C9"].Value = dGItems[0].Rank;
            ws.get_Range("C9").Cells.HorizontalAlignment =
         Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenterAcrossSelection;
            ws.get_Range("C9").Cells.VerticalAlignment =
            Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            //add hours in excel
            ws.Range["D9"].Merge();
            ws.Range["D9"].Value = dGItems[0].HoursOfquerm;
            ws.get_Range("D9").Cells.HorizontalAlignment =
         Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenterAcrossSelection;
            ws.get_Range("D9").Cells.VerticalAlignment =
            Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            int j = 0;
            for (int i = 9; i < (IstmaraB.SelectedItems.Count) + 9; i++)
            {
                ws.Range["E" + i].Value = dGItems[j].Namesub;
                j++;
                ws.get_Range("E" + i).Cells.HorizontalAlignment =
        Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenterAcrossSelection;
                ws.get_Range("E" + i).Cells.VerticalAlignment =
                Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            }

            int k = 0;
            for (int i = 9; i < (IstmaraB.SelectedItems.Count) + 9; i++)
            {
                ws.Range["G" + i].Value = dGItems[k].Academic;
                k++;
                ws.get_Range("G" + i).Cells.HorizontalAlignment =
        Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenterAcrossSelection;
                ws.get_Range("G" + i).Cells.VerticalAlignment =
                Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            }
            int l = 0;
            for (int i = 9; i < (IstmaraB.SelectedItems.Count) + 9; i++)
            {
                ws.Range["H" + i].Value = dGItems[l].Virtual;
                l++;
                ws.get_Range("H" + i).Cells.HorizontalAlignment =
        Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenterAcrossSelection;
                ws.get_Range("H" + i).Cells.VerticalAlignment =
                Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            }
            int m = 0;
            for (int i = 9; i < (IstmaraB.SelectedItems.Count) + 9; i++)
            {
                ws.Range["I" + i].Value = dGItems[m].Exprement;
                m++;
                ws.get_Range("I" + i).Cells.HorizontalAlignment =
        Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenterAcrossSelection;
                ws.get_Range("I" + i).Cells.VerticalAlignment =
                Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            }
         


            int n = 0;
            int? o = 0;
            for (int i = 9; i < (IstmaraB.SelectedItems.Count) + 9; i++)
            {
                if (dGItems[n].Exprement != null && dGItems[n].Virtual != null && dGItems[n].Academic != null)
                {

                    ws.Range["J" + i].Value = dGItems[n].Academic + dGItems[n].Virtual + dGItems[n].Exprement;
                    o = o + dGItems[n].Academic + dGItems[n].Virtual + dGItems[n].Exprement;
                }
                //2
                else if (dGItems[n].Exprement == null && dGItems[n].Virtual != null && dGItems[n].Academic != null)
                {

                    ws.Range["J" + i].Value = dGItems[n].Academic + dGItems[n].Virtual;
                    o = o + dGItems[n].Academic + dGItems[n].Virtual;

                }
                //3
                else if (dGItems[n].Exprement != null && dGItems[n].Virtual == null && dGItems[n].Academic != null)
                {

                    ws.Range["J" + i].Value = dGItems[n].Academic + dGItems[n].Exprement;
                    o = o + dGItems[n].Academic + dGItems[n].Exprement;


                }
                //4
                else if (dGItems[n].Exprement != null && dGItems[n].Virtual != null && dGItems[n].Academic == null)
                {

                    ws.Range["J" + i].Value = dGItems[n].Exprement + dGItems[n].Virtual;
                    o = o + dGItems[n].Exprement + dGItems[n].Virtual;


                }
                //5
                else if (dGItems[n].Exprement == null && dGItems[n].Virtual == null && dGItems[n].Academic != null)
                {

                    ws.Range["J" + i].Value = dGItems[n].Academic;
                    o = o + dGItems[n].Academic;


                }
                //6
                else if (dGItems[n].Exprement == null && dGItems[n].Virtual != null && dGItems[n].Academic == null)
                {

                    ws.Range["J" + i].Value = dGItems[n].Virtual;
                    o = o + dGItems[n].Virtual;


                }
                //7
                else if (dGItems[n].Exprement != null && dGItems[n].Virtual == null && dGItems[n].Academic == null)
                {

                    ws.Range["J" + i].Value = dGItems[n].Exprement;
                    o = o + dGItems[n].Exprement;


                }
                ws.get_Range("J" + i).Cells.HorizontalAlignment =
Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenterAcrossSelection;
                ws.get_Range("J" + i).Cells.VerticalAlignment =
                Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                n++;

            }




            ws.Range["J" + ((IstmaraB.SelectedItems.Count) + 9)].Value = o;
            ws.get_Range("J" + ((IstmaraB.SelectedItems.Count) + 9)).Cells.HorizontalAlignment =
Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenterAcrossSelection;
            ws.get_Range("J" + ((IstmaraB.SelectedItems.Count) + 9)).Cells.VerticalAlignment =
            Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            //wb.SaveAs("C:\\excel\\ffff.xlsx");

            #endregion
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            IstmaraB.SelectAll();
           

        }
    }
}
