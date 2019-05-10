using Data.Context;
using Data.Entities;
using System.Windows;
using System.Windows.Controls;
using System.Linq;
using System;
using System.Text.RegularExpressions;

namespace Astmara6Con.Controls
{
    /// <summary>
    /// Interaction logic for work_hours.xaml
    /// </summary>
    public partial class UCWorkHours : UserControl
    {
        bool PaperOrVirtual;
        string STRNamePage;
        readonly FRMMainWindow Form = Application.Current.Windows[0] as FRMMainWindow;
        public void loadData()
        {
            CollegeContext cd = new CollegeContext();

            var workhours = (from p in cd.WorkHours
                            select p).ToList();

            DGWorkHoursView.ItemsSource = workhours;
        }

        public UCWorkHours()
        {
            InitializeComponent();
            loadData();
            Paper.IsChecked = true;
        }


        private void BTNBack_Click(object sender, RoutedEventArgs e)
        {
            Form.gridShow.Children.Clear();
            Form.gridShow.Children.Add(new UCCourses());
            STRNamePage = "المواد";
            Form.ChFormName(STRNamePage);
        }

        private void BTNNext_Click(object sender, RoutedEventArgs e)
        {
            Form.gridShow.Children.Clear();
            Form.gridShow.Children.Add(new UCDoctors());
            STRNamePage = "الدكاترة";
            Form.ChFormName(STRNamePage);
        }

        private void TBRank_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BTNRemove_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {

                CollegeContext cd = new CollegeContext();
                WorkHour WorkHourRow = DGWorkHoursView.SelectedItem as WorkHour;

                WorkHour workhours = (from p in cd.WorkHours
                                    where p.Id == WorkHourRow.Id
                                    select p).Single();
                cd.WorkHours.Remove(workhours);
                cd.SaveChanges();
                loadData();

                MessageBox.Show("تم مسح العنصر بنجاح");
            }
            catch (Exception) { MessageBox.Show("حدث خطب ما برجاء المحاولة مرة أخري"); }

        }

        private void BTNEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CollegeContext dataContext = new CollegeContext();
                WorkHour WorkHourRow = DGWorkHoursView.SelectedItem as WorkHour;

                WorkHour workhours = (from p in dataContext.WorkHours
                                       where p.Id == WorkHourRow.Id
                                       select p).Single();
                workhours.Rank = WorkHourRow.Rank;
                workhours.HoursOfQuorum = WorkHourRow.HoursOfQuorum;

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

        private void BTNRemoveAll_Click_1(object sender, RoutedEventArgs e)
        {
            CollegeContext cd = new CollegeContext();
          
                MessageBoxResult result = MessageBox.Show("هل انت متأكد من أنك تريد حذف الكل؟؟", "حذف الكل", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
            try
            {

                cd.WorkHours.RemoveRange(cd.WorkHours);

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

       

        private void BTNAdd_Click_1(object sender, RoutedEventArgs e)
        {

            CollegeContext dc = new CollegeContext();

            var result = (from p in dc.WorkHours
                          where p.Rank == TBRank.Text 
                          select p).SingleOrDefault();
           
            if (result == null)
            {
                
                    if (TBRank.Text == "" || TBRank.Text == " " || TBRank.Text == "  " || TBRank.Text == "   " || TBRank.Text == "    " || TBRank.Text == "     "||
                        TBHoursOfQuorum.Text == "" || TBHoursOfQuorum.Text == " " || TBHoursOfQuorum.Text == "  " || TBHoursOfQuorum.Text == "   " || TBHoursOfQuorum.Text == "    " || TBHoursOfQuorum.Text == "     ")
                    {
                        
                        MessageBox.Show("برجاء ادخال كافة البيانات!!");
                    }
                    else
                    {
                        // paper = true and virtual false in database
                        if (Paper.IsChecked == true)
                        {
                            PaperOrVirtual = true;

                        }
                        else if (Virtual.IsChecked == true)
                        {
                            PaperOrVirtual = false;

                        }

                        CollegeContext db = new CollegeContext();
                        db.WorkHours.Add(new WorkHour()
                        {
                            Rank = TBRank.Text,
                            HoursOfQuorum = int.Parse(TBHoursOfQuorum.Text),

                            AcademicOrVirtual = PaperOrVirtual


                        });
                        db.SaveChanges();
                        loadData();
                        MessageBox.Show("تم حفظ العملية بنجاح");
                        TBRank.Text = "";
                        TBHoursOfQuorum.Text = "";
                    }
                }
            else
            {
                MessageBox.Show("الاسم موجود مسبقا!!");

            }



        }
        private void NumberValidationTextBox(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            //can't write but numbers for TBRank
            Regex regex = new Regex("[^ء-ي]+");
            e.Handled = regex.IsMatch(e.Text);

        }
        private void NumberValidationTextBox1(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            //can't write but numbers for TBNameDepartment
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);

        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
