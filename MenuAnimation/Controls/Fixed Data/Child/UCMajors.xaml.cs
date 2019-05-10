using Data.Context;
using System.Windows;
using System.Windows.Controls;
using System.Linq;
using Data.Entities;
using System;
using System.Text.RegularExpressions;

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

            var sections = (from p in cd.Sections
                            select p).ToList();
            var branchs = (from p in cd.Branches
                           select p).ToList();

            DGMajorsView.ItemsSource = sections;
            DGMajorsView.ItemsSource = branchs;
        }
        public void TakeDataFromCombo()
        {
            if (CBNameDepartment.SelectedItem == null)
            {
                MessageBox.Show("يرجي ادخال  القسم");
            }
            else
            {
                CollegeContext cd = new CollegeContext();
                Section SectionCB = CBNameDepartment.SelectedItem as Section;
                CollegeContext db = new CollegeContext();

                var result = (from p in db.Branches
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
                        Branch branchs = (from p in cd.Branches
                                            where p.Id == SectionCB.Id
                                            select p).Single();

                        cd.Sections.Add(new Section()
                        {
                            Id = SectionCB.Id,
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
        //    CollegeContext dataContext = new CollegeContext();
        //    Branch DepartmentRow = DGMajorsView.SelectedItem as Branch;
        //    Branch levels = (from p in dataContext.Branches
        //                     where p.Id == DepartmentRow.Id
        //                     select p).Single();
            //if (DepartmentRow.Name != levels.Name)
            //{

            //    try
            //    {



            //        Branch departments = (from p in dataContext.Branches
            //                              where p.Id == DepartmentRow.Id
            //                              select p).Single();
            //        departments.Name = DepartmentRow.Name;
            //        dataContext.SaveChanges();
            //        loadData();


            //        MessageBox.Show("تم تعديل الصف بنجاح");

            //    }
            //    catch (Exception Ex)
            //    {
            //        MessageBox.Show(Ex.Message);
            //        return;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("لم يتم تعديل اي شئ برجاء عدل حتي يتم الحفظ!!");

            //}
        }

        private void BTNRemove_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {

                CollegeContext cd = new CollegeContext();
                Branch BranchRow = DGMajorsView.SelectedItem as Branch;

                Branch branchs = (from p in cd.Branches
                                  where p.Id == BranchRow.Id
                                  select p).Single();
                cd.Branches.Remove(branchs);
                cd.SaveChanges();
                loadData();

                MessageBox.Show("تم مسح العنصر بنجاح");
            }
            catch (Exception) { MessageBox.Show("حدث خطب ما برجاء المحاولة مرة أخري"); }

        }
        private void BTNRemoveAll_Click_1(object sender, RoutedEventArgs e)
        {
            CollegeContext cd = new CollegeContext();
            Level LevelRow = DGMajorsView.SelectedItem as Level;


            //var result1 = (from p in cd.Branches
            //               where p.Name == null
            //               select p);
            //if (result1 != null)
            //{
            //    MessageBoxResult result = MessageBox.Show("هل انت متأكد من أنك تريد حذف الكل؟؟", "حذف الكل", MessageBoxButton.YesNo, MessageBoxImage.Question);


            //    if (result == MessageBoxResult.Yes)
            //    {

            //        try
            //        {

            //            cd.Branches.RemoveRange(cd.Branches);

            //            cd.SaveChanges();
            //            loadData();

            //            MessageBox.Show("تم مسح كل البيانات");
            //        }
            //        catch (Exception) { MessageBox.Show("حدث خطب ما برجاء المحاولة مرة أخري"); }
            //    }
            //    else if (result == MessageBoxResult.No)
            //    {
            //        MessageBox.Show("لم يتم حذف شئ");

            //    }
            //}
            //else
            //{
            //    MessageBox.Show("لا يوجد بيانات لحذفها");


            //}
        }

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
    }



}
