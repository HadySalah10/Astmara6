using Astmara6Con.Controls;
using Data.Context;
using Data.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
namespace Astmara6Con
{
    /// <summary>
    /// Interaction logic for levels.xaml
    /// </summary>
    public partial class UCLevels : UserControl
    {
        public void loadData()
        {
            CollegeContext cd = new CollegeContext();

            var levels = (from p in cd.Levels
                          select p).ToList();

            DGLevelsView.ItemsSource = levels;
        }


        string STRNamePage;
        readonly FRMMainWindow Form = Application.Current.Windows[0] as FRMMainWindow;
        public UCLevels()
        {
            InitializeComponent();
            loadData();

        }

        private void BTNBack_Click(object sender, RoutedEventArgs e)
        {
            Form.gridShow.Children.Clear();
            Form.gridShow.Children.Add(new UCFixedData());
            STRNamePage = "البيانات الثابتة";
            Form.ChFormName(STRNamePage);
        }

        private void BTNNext_Click(object sender, RoutedEventArgs e)
        {
            Form.gridShow.Children.Clear();
            Form.gridShow.Children.Add(new UCDepartment());
            STRNamePage = "الاقسام";
            Form.ChFormName(STRNamePage);
        }

        private void TBNameLevels_TextChanged(object sender, TextChangedEventArgs e)
        {

        }




        private void BTNAdd_Click_1(object sender, RoutedEventArgs e)
        {
            CollegeContext db = new CollegeContext();

            var result = (from p in db.Levels
                          where p.Name == TBNameLevels.Text
                          select p).SingleOrDefault();
            if (result==null)
            {
                if (TBNameLevels.Text == "" || TBNameLevels.Text == " " || TBNameLevels.Text == "  " || TBNameLevels.Text == "   " || TBNameLevels.Text == "    ")
                {
                    MessageBox.Show("انت لم تدخل شيئا!!");

                }
                else
                {
                    db.Levels.Add(new Level()
                    {
                        Name = TBNameLevels.Text

                    });
                    db.SaveChanges();
                    loadData();
                    MessageBox.Show("تم حفظ العملية بنجاح");
                    TBNameLevels.Text = "";
                }
            }
            else
            {
                MessageBox.Show("الاسم موجود مسبقا!!");

            }
        }
        
        private void BTNEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CollegeContext dataContext = new CollegeContext();
                Level LevelRow = DGLevelsView.SelectedItem as Level;

                Level levels = (from p in dataContext.Levels
                                where p.Id == LevelRow.Id
                                select p).Single();
                if (LevelRow.Name != levels.Name)
                {

                    try
                    {

                        levels.Name = LevelRow.Name;
                        dataContext.SaveChanges();
                        loadData();


                        MessageBox.Show("تم تعديل الصف بنجاح");

                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                        return;
                    }
                    TBNameLevels.Text = "";

                }
                else
                {
                    MessageBox.Show("لم يتم تعديل اي شئ برجاء عدل حتي يتم الحفظ!!");

                }
                        
            }catch(Exception ) {
                MessageBox.Show("برجاء اختر قيمه لتعديلها!!");
                return;
            }
        }

        private void DGLevelsView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }

        private void DGLevelsView_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void BTNRemove_Click_1(object sender, RoutedEventArgs e)
        {
            CollegeContext cd = new CollegeContext();
            Level LevelRow = DGLevelsView.SelectedItem as Level;

            try
            {
               

                Level levels = (from p in cd.Levels
                                where p.Id == LevelRow.Id
                                select p).Single();
                cd.Levels.Remove(levels);
                cd.SaveChanges();
                loadData();

                MessageBox.Show("تم حذف الصف بنجاح");
            }
            catch (Exception) { MessageBox.Show("برجاء اختيار العنصر حتي يتم الحذف!!"); }

        }

        private void BTNRemoveAll_Click_1(object sender, RoutedEventArgs e)
        {
            CollegeContext cd = new CollegeContext();

            {
                MessageBoxResult result = MessageBox.Show("هل انت متأكد من أنك تريد حذف الكل؟؟", "حذف الكل", MessageBoxButton.YesNo, MessageBoxImage.Question);


                if (result == MessageBoxResult.Yes)
                {
                    try
                    {


                        cd.Levels.RemoveRange(cd.Levels);

                        cd.SaveChanges();
                        loadData();

                        MessageBox.Show("كل البيانات حذفت بنجاح");
                    }
                    catch (Exception) { MessageBox.Show("حدث خطب ما برجاء المحاولة مرة أخري"); }
                }
                else if (result == MessageBoxResult.No)
                {
                    MessageBox.Show("لم يتم حذف شئ");

                }
            }
          





        }
        private void NumberValidationTextBox(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            //can't write but numbers for TBNameLevels
            Regex regex = new Regex("[^ء-ي]+");
            e.Handled = regex.IsMatch(e.Text);

        }
        private void TBNameLevels_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
