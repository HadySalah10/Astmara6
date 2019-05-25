
using Astmara6Con;
using Astmara6Con.Controls;
using MenuAnimado1.Controls;
using System;
using System.Windows;
using System.Windows.Controls;
using Data.Context;
using System.Linq;
using Data.Entities;
using System.Text.RegularExpressions;
using System.Windows.Data;
using System.Collections.Generic;

namespace Astmara6Con.Controls
{
    /// <summary>
    /// Interaction logic for El5ta.xaml
    /// </summary>
    public partial class UCPlan : UserControl
    {
      
      
        string STRNamePage;
        readonly FRMMainWindow Form = Application.Current.Windows[0] as FRMMainWindow;
        public UCPlan()
        {
            InitializeComponent();
            loadDataComboTypeOfSection();
            loadDataComboTeachers();
            loadDataComboTeachers1();
            loadDataComboSubject();
        }
        public void loadDataComboTypeOfSection()
        {
            try
            {
                CollegeContext cd = new CollegeContext();

                var branchs = (from p in cd.Branches
                               select p).ToList();

                CBTypeOfSection.ItemsSource = branchs;
            } catch (Exception ) { };
        }

        public void loadDataComboTeachers()
        {

            //دكاتره
            CollegeContext cd = new CollegeContext();
            Branch SectionCB = CBTypeOfSection.SelectedItem as Branch;
            var query = cd.SubjectTeachers.Where(x => x.IdBranch == SectionCB.Id).Select(x => x.Teacher);
            // علي حسب ال id بتاع id works 
            // عشان كده لازم ادخل المعيدين مثلا الاول وبعد كده الدكاتره او العكس 
            TeachersComboBox.ItemsSource = query.Where(u => u.WorkHour.HoursOfQuorum<=36).ToList();

        }
        public void loadDataComboSubject()
        {

            ////مواد
            //CollegeContext cd = new CollegeContext();
            //Teacher TeacherCB = TeachersComboBox.SelectedItem as Teacher;
            //var query = cd.SubjectTeachers.Where(x => x.IdTeacher == TeacherCB.Id).Select(x => x.Subject);
            //_SubjectsComboBox.ItemsSource = query.ToList();

        }
        public void loadDataComboTeachers1()
        {
           

            //معيدين
            CollegeContext cd = new CollegeContext();
            Branch SectionCB = CBTypeOfSection.SelectedItem as Branch;
            var query = cd.SubjectTeachers.Where(x => x.IdBranch == SectionCB.Id).Select(x => x.Teacher);
            // علي حسب ال id بتاع id works 
            // عشان كده لازم ادخل المعيدين مثلا الاول وبعد كده الدكاتره او العكس 
            TeachersComboBox1.ItemsSource = query.Where(u => u.WorkHour.HoursOfQuorum>36 ).ToList();

        }




        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Form.gridShow.Children.Clear();
            Form.gridShow.Children.Add(new UCStudentStatement());
            STRNamePage = "بيان الطلاب";
            Form.ChFormName(STRNamePage);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            STRNamePage = "";
            Form.ChFormName(STRNamePage);
            Form.gridShow.Children.Clear();
            Form.gridShow.Children.Add(new UCDataPrint()); 
        }

        private void _TeachersComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            loadDataComboSubject();
        }

        private void CBTypeOfSection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

            loadDataComboTeachers();
            loadDataComboTeachers1();
        }

        private void TeachersComboBox_Loaded(object sender, RoutedEventArgs e)
        {
               
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
