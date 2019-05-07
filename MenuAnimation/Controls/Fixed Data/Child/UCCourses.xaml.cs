﻿using Data.Context;
using MenuAnimado1.Controls;
using System.Windows;
using System.Linq;

using System.Windows.Controls;
using Data.Entities;
using System;
using System.Text.RegularExpressions;

namespace Astmara6Con.Controls
{
    /// <summary>
    /// Interaction logic for courses.xaml
    /// </summary>
    public partial class UCCourses : UserControl
    {
        int? TotalHour;
        int? Expremente =null;
        int? Virtuale=null;
        int codee;
        int? Academee;
        public void loadData()
        {
            CollegeContext cd = new CollegeContext();

            var subjects = (from p in cd.Subjects
                            select p).ToList();

            DGCoursesView.ItemsSource = subjects;
        }
        string STRNamePage;
        readonly FRMMainWindow Form = Application.Current.Windows[0] as FRMMainWindow;

        public UCCourses()
        {

            InitializeComponent();
            loadData();
          
            
        }


        private void BTNBack_Click(object sender, RoutedEventArgs e)
        {
            Form.gridShow.Children.Clear();
            Form.gridShow.Children.Add(new UCMajors());
            STRNamePage = "الشعب";
            Form.ChFormName(STRNamePage);
        }

        private void BTNNext_Click(object sender, RoutedEventArgs e)
        {
            Form.gridShow.Children.Clear();
            Form.gridShow.Children.Add(new UCChangingData());
            STRNamePage = "ٍساعات العمل";
            Form.ChFormName(STRNamePage);
        }
        
        private void BTNAdd_Click(object sender, RoutedEventArgs e)
        {
             codee = int.Parse(TBCode.Text);
              Academee = int.Parse(TBPaper.Text);
            
                CollegeContext db = new CollegeContext();
            db.Subjects.Add(new Subject()
            {
                Code = codee,
                Name = TBNameCourse.Text,
                Academic = Academee,

                Exprement = Expremente,
                Virtual = Virtuale,
                TotalHours = TotalHour
                
            });
            db.SaveChanges();
            loadData();
            MessageBox.Show("تم حفظ العملية بنجاح");
            
        }

        private void SubjectsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TBVirtual_TextChanged(object sender, TextChangedEventArgs e)
        {
             if (!String.IsNullOrEmpty(TBVirtual.Text))
            {
                TBExprement.IsReadOnly = true;
              TotalHour  =
            + int.Parse(TBPaper.Text)
            + int.Parse(TBVirtual.Text);
                Virtuale = int.Parse(TBVirtual.Text);
                
            }
            else
            {
                TBExprement.IsReadOnly = false;

            }

        }

        private void TBExprement_TextChanged(object sender, TextChangedEventArgs e)
        {
           


            if (!String.IsNullOrEmpty(TBExprement.Text))
            {
                TBVirtual.IsReadOnly = true;

                TotalHour =
                +int.Parse(TBPaper.Text)
                + int.Parse(TBExprement.Text);
                Expremente = int.Parse(TBExprement.Text);
                TotalHour = Expremente + Academee;


            }
            else
            {
                TBVirtual.IsReadOnly = false;

            }
        }

       

        private void NumberValidationTextBox(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
           //can't write but numbers for TBexprement
                Regex regex = new Regex("[^0-9]+");
                e.Handled = regex.IsMatch(e.Text);
            
        }

        private void NumberValidationTextBox1(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            //can't write but numbers for TBVirtual

            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

     

        private void NumberValidationTextBox2(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            //can't write but numbers for TBPaper
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);

        }

        private void TBPaper_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
