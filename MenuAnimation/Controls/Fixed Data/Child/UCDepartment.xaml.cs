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
    /// Interaction logic for department.xaml
    /// </summary>
    public partial class UCDepartment : UserControl
    {
        public void loadData()
        {
            CollegeContext cd = new CollegeContext();

            var branchs = (from p in cd.Branches
                          select p).ToList();

            DGDepartmentView.ItemsSource = branchs;
            TBNameDepartment.Text = "";
        }
        string STRNamePage;
        readonly FRMMainWindow Form = Application.Current.Windows[0] as FRMMainWindow;

        public UCDepartment()
        {
            InitializeComponent();
            loadData();

        }

        private void BTNBack_Click(object sender, RoutedEventArgs e)
        {
            Form.gridShow.Children.Clear();
            Form.gridShow.Children.Add(new UCLevels());
            STRNamePage = "المستويات";
            Form.ChFormName(STRNamePage);
        }

        private void BTNNext_Click(object sender, RoutedEventArgs e)
        {
            Form.gridShow.Children.Clear();
            Form.gridShow.Children.Add(new UCMajors());
            STRNamePage = "الشعب";
            Form.ChFormName(STRNamePage);
        }

        private void BTNEdit_Click(object sender, RoutedEventArgs e)
        {
            CollegeContext dataContext = new CollegeContext();
            Branch LevelRow = DGDepartmentView.SelectedItem as Branch;

            Branch branchs = (from p in dataContext.Branches
                              where p.Id == LevelRow.Id
                            select p).Single();
            if (LevelRow.Name != branchs.Name)
            {
                try
            {
                    Branch DepartmentRow = DGDepartmentView.SelectedItem as Branch;

                    Branch departments = (from p in dataContext.Branches
                                      where p.Id == DepartmentRow.Id
                                      select p).Single();
                departments.Name = DepartmentRow.Name;
                dataContext.SaveChanges();
                loadData();


                MessageBox.Show("تم تعديل الصف بنجاح");

                }
                catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }
            }
            else
            {
                MessageBox.Show("لم يتم تعديل اي شئ برجاء عدل حتي يتم الحفظ!!");

            }
        }

        private void BTNRemove_Click_1(object sender, RoutedEventArgs e)
        {

            CollegeContext cd = new CollegeContext();
            Branch DepartmentRow = DGDepartmentView.SelectedItem as Branch;

            try
            {


                Branch branchs = (from p in cd.Branches
                                    where p.Id == DepartmentRow.Id
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
           
                MessageBoxResult result = MessageBox.Show("هل انت متأكد من أنك تريد حذف الكل؟؟", "حذف الكل", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    try
                    {

                        cd.Sections.RemoveRange(cd.Sections);

                        cd.SaveChanges();
                        loadData();

                        MessageBox.Show("تم مسح كل البيانات");
                    }
                    catch (Exception) { MessageBox.Show("حدث خطب ما برجاء المحاولة مرة أخري"); }
                }
                else if (result == MessageBoxResult.No)
                {
                    MessageBox.Show("لم يتم حذف شئ");

                }
            
            
        }

            private void BTNAdd_Click(object sender, RoutedEventArgs e)
        {
             CollegeContext dc = new CollegeContext();

            var result = (from p in dc.Branches
                          where p.Name == TBNameDepartment.Text
                          select p).SingleOrDefault();
            if (result == null)
            {
                if (TBNameDepartment.Text == "" || TBNameDepartment.Text == " " || TBNameDepartment.Text == "  " || TBNameDepartment.Text == "   " || TBNameDepartment.Text == "    " || TBNameDepartment.Text == "     ")
                {
                    MessageBox.Show("انت لم تدخل شيئا!!");
                }
                else
                {



                    CollegeContext db = new CollegeContext();
                    db.Branches.Add(new Branch()
                    {
                        Name = TBNameDepartment.Text
                    });
                    db.SaveChanges();
                    loadData();
                    MessageBox.Show("تم حفظ العملية بنجاح");
                    TBNameDepartment.Text = "";
                }
            }
            else
            {
                MessageBox.Show("الاسم موجود مسبقا!!");

            }


        }
        private void NumberValidationTextBox(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            //can't write but numbers for TBNameDepartment
            Regex regex = new Regex("[^ء-ي]+");
            e.Handled = regex.IsMatch(e.Text);

        }
       
        private void DGDepartmentView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
