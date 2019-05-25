using Data.Context;
using System.Windows;
using System.Windows.Controls;
using System.Linq;
using Data.Entities;
using System;
using System.Text.RegularExpressions;
using System.Windows.Data;
using System.Collections.Generic;
using Astmara6.Controls.Fixed_Data.Edit;

namespace Astmara6Con.Controls
{
    /// <summary>
    /// Interaction logic for majors.xaml
    /// </summary>
    public partial class UCMajors : UserControl
    {
        public void loadData()
        {
            CollegeContext cd = new CollegeContext();

            var query = (from p1 in cd.Branches
                                        join f1 in cd.Sections on p1.Id equals f1.IdBranch
                                        select new { p1.TypeOfBranch, f1.Name }).ToList();
             
   
    
          

                 
            //var query = (from p1 in cd.Sections   
            //              from f1 in cd.Branches

            //                    where f1.Id ==p1.IdBranch

            //             select p1.Name).ToList();
            //IEnumerable<Section,> drew = (
            //                          from p in cd.Sections
            //                          from f in cd.Branches
            //                          where
            //                            f.Id == p.IdBranch
            //                          select p.Name )
            //                           .Union(from d  in cd.Branches

            //                                  select d.TypeOfBranch);



            //var query = (from p in cd.Levels
            //              select p).ToList();
            DGMajorsView.ItemsSource = query;
        }
        public void TakeDataFromCombo()
        {
            
           
                CollegeContext cd = new CollegeContext();
                Branch SectionCB = CBNameDepartment.SelectedItem as Branch;
                CollegeContext db = new CollegeContext();

                var result = (from p in db.Sections
                              where p.Name == TBNameMajors.Text
                              select p).SingleOrDefault();
                if (result == null)
                {
                    if (TBNameMajors.Text == "" || TBNameMajors.Text == " " || TBNameMajors.Text == "  " || TBNameMajors.Text == "   " || TBNameMajors.Text == "    ")
                    {
                        MessageBox.Show("انت لم تدخل شيئا!!");

                    }
                    else
                    {
                                          

                        cd.Sections.Add(new Section()
                        {
                            IdBranch = SectionCB.Id,
                            Name = TBNameMajors.Text
                        });
                        cd.SaveChanges();
                        loadData();
                        MessageBox.Show("تم حفظ البيانات بنجاح ");
                    }
                }
                else
                {
                    MessageBox.Show("الاسم موجود مسبقا!!");

                }
                TBNameMajors.Text = "";
            
        }
        public void loadDataCombo()
        {
            CollegeContext cd = new CollegeContext();

            var branchs = (from p in cd.Branches
                            select p).ToList();

            CBNameDepartment.ItemsSource = branchs;
        }
        string STRNamePage;
        readonly FRMMainWindow Form = Application.Current.Windows[0] as FRMMainWindow;

        public UCMajors()
        {
            InitializeComponent();
            loadDataCombo();
            loadData();
        }

        private void BTNBack_Click(object sender, RoutedEventArgs e)
        {
            Form.gridShow.Children.Clear();
            Form.gridShow.Children.Add(new UCDepartment());
            STRNamePage = "الاقسام";
            Form.ChFormName(STRNamePage);
        }

        private void BTNNext_Click(object sender, RoutedEventArgs e)
        {
            Form.gridShow.Children.Clear();
            Form.gridShow.Children.Add(new UCWorkHours());
            STRNamePage = "النصاب القانوني";
            Form.ChFormName(STRNamePage);
        }

        private void BTNAdd_Click(object sender, RoutedEventArgs e)
        {
            TakeDataFromCombo();

        }

        private void BranchesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BTNEdit_Click(object sender, RoutedEventArgs e)
        {
            Form.gridShow.Children.Clear();
            Form.gridShow.Children.Add(new UCEditMajors());
            STRNamePage = "تعديل الشعب";
            Form.ChFormName(STRNamePage);

           
        }

        //private void BTNRemove_Click_1(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {

        //        CollegeContext cd = new CollegeContext();
        //        Section BranchRow = DGMajorsView.SelectedItem as Section;

        //        Section sections = (from p in cd.Sections
        //                          where p.Id == BranchRow.Id
        //                          select p).SingleOrDefault();
        //        cd.Sections.Remove(sections);
        //        cd.SaveChanges();
        //        loadData();

        //        MessageBox.Show("تم مسح العنصر بنجاح");
        //    }
        //    catch (Exception) { MessageBox.Show("حدث خطب ما برجاء المحاولة مرة أخري"); }

        //}
        //private void BTNRemoveAll_Click_1(object sender, RoutedEventArgs e)
        //{
        //    CollegeContext cd = new CollegeContext();
           


          
        //        MessageBoxResult result = MessageBox.Show("هل انت متأكد من أنك تريد حذف الكل؟؟", "حذف الكل", MessageBoxButton.YesNo, MessageBoxImage.Question);


        //        if (result == MessageBoxResult.Yes)
        //        {

        //            try
        //            {

        //                cd.Branches.RemoveRange(cd.Branches);

        //                cd.SaveChanges();
        //                loadData();

        //                MessageBox.Show("تم مسح كل البيانات");
        //            }
        //            catch (Exception) { MessageBox.Show("حدث خطب ما برجاء المحاولة مرة أخري"); }
        //        }
        //        else if (result == MessageBoxResult.No)
        //        {
        //            MessageBox.Show("لم يتم حذف شئ");

        //        }
        //    }
          
        

        private void CBNameDepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void NumberValidationTextBox(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            //can't write but numbers for TBNameLevels
            Regex regex = new Regex("[^ء-ي]+");
            e.Handled = regex.IsMatch(e.Text);

        }

        private void CBNameDepartment_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DGMajorsView_CurrentCellChanged(object sender, EventArgs e)
        {
          


        }

        private void DGMajorsView_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Binding binding = new Binding();
            binding.Mode = BindingMode.TwoWay;

        }

        private void DGMajorsView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }



}
