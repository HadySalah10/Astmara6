using Data.Context;
using System.Windows;
using System.Windows.Controls;
using System.Linq;
using Data.Entities;
using System;
using System.Text.RegularExpressions;
using System.Windows.Data;
using Astmara6Con.Controls;


namespace Astmara6.Controls.Fixed_Data.Edit
{
    /// <summary>
    /// Interaction logic for UCEditDoctor.xaml
    /// </summary>
    public partial class UCEditDoctor : UserControl
    {
        public UCEditDoctor()
        {
            InitializeComponent();
        }


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            loadData();

            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
            // 	System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
            // 	System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
        }


        public void loadData()
        {
            CollegeContext cd = new CollegeContext();

            var sections = (from p in cd.Teachers
                            select p).ToList();

            _TeachersDataGrid.ItemsSource = sections;

        }

        private void BTNEdit_Click(object sender, RoutedEventArgs e)
        {
            CollegeContext dataContext = new CollegeContext();
            Teacher doctorRow = _TeachersDataGrid.SelectedItem as Teacher;

            Teacher teachers = (from p in dataContext.Teachers
                                where p.Id == doctorRow.Id
                                select p).Single();


            if (doctorRow.Name != teachers.Name || doctorRow.NickName != teachers.NickName)

            {


                try
                {



                    Teacher teachers1 = (from p in dataContext.Teachers
                                         where p.Id == doctorRow.Id
                                         select p).Single();
                    teachers1.NickName = doctorRow.NickName;
                    teachers1.Name = doctorRow.Name;
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
            try
            {

                CollegeContext cd = new CollegeContext();
                Teacher teacherRow = _TeachersDataGrid.SelectedItem as Teacher;

                Teacher teachers = (from p in cd.Teachers
                                    where p.Id == teacherRow.Id
                                    select p).SingleOrDefault();
                cd.Teachers.Remove(teachers);
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

                    cd.Teachers.RemoveRange(cd.Teachers);

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
        string STRNamePage;
        readonly Astmara6Con.FRMMainWindow Form = Application.Current.Windows[0] as Astmara6Con.FRMMainWindow;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Form.gridShow.Children.Clear();
            Form.gridShow.Children.Add(new UCDoctors());
            STRNamePage = "الدكاترة";
            Form.ChFormName(STRNamePage);
        }
    }
}
