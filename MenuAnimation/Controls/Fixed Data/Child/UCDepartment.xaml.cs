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
            if (LevelRow.TypeOfBranch != branchs.TypeOfBranch)
            {
                try
            {
                    Branch DepartmentRow = DGDepartmentView.SelectedItem as Branch;

                    Branch departments = (from p in dataContext.Branches
                                      where p.Id == DepartmentRow.Id
                                      select p).Single();
                departments.TypeOfBranch = DepartmentRow.TypeOfBranch;
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

        private void BTNRemove_Click(object sender, RoutedEventArgs e)
        {
            CollegeContext db = new CollegeContext();
            Branch branchRow = DGDepartmentView.SelectedItem as Branch;

            try
            {
                Branch levels = (from p in db.Branches
                                 where p.Id == branchRow.Id
                                 select p).Single();
                try { 
                db.Branches.Remove(levels);
                db.SaveChanges();
                loadData();
                MessageBox.Show("تم حذف الصف بنجاح");

                }
                catch (Exception) { MessageBox.Show("برجاء حذف الاشياء المتعلقة بهذا الصف حتي يتم حذفة"); }

            }
            catch (Exception) { MessageBox.Show("برجاء اختيار العنصر حتي يتم الحذف!!"); }

        }
        private void BTNRemoveAll_Click_1(object sender, RoutedEventArgs e)
        {
            CollegeContext cd = new CollegeContext();
           
                MessageBoxResult result = MessageBox.Show("هل انت متأكد من أنك تريد حذف الكل؟؟", "حذف الكل", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                try
                {


                    cd.Branches.RemoveRange(cd.Branches);

                    cd.SaveChanges();
                    loadData();

                    MessageBox.Show("تم مسح كل البيانات");
                }
                catch (Exception) { MessageBox.Show("برجاء حذف الاشياء المتعلقة بهذا الصف حتي يتم حذفة"); }
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
                          where p.TypeOfBranch == TBNameDepartment.Text
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
                        TypeOfBranch = TBNameDepartment.Text
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
