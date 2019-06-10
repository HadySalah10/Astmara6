
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
using Astmara6.Controls.Fixed_Data.Edit;
using System.Collections;
using System.Data;


namespace Astmara6Con.Controls
{
    /// <summary>
    /// Interaction logic for student_inf.xaml
    /// </summary>
    public partial class UCStudentStatement : UserControl
    {
        string STRNamePage;
        readonly FRMMainWindow Form = Application.Current.Windows[0] as FRMMainWindow;
        public UCStudentStatement()
        {
            InitializeComponent();
            loadDatagrid();
            loadDataComboTypeOfBranch();
            loadDataComboSections();
            loadDataComboLevels();
            loadDataComboSubject();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Form.gridShow.Children.Clear();
            Form.gridShow.Children.Add(new UCPlan());
            STRNamePage = "الخطة";
            Form.ChFormName(STRNamePage);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Form.gridShow.Children.Clear();
            Form.gridShow.Children.Add(new UCCourses());
            STRNamePage = "المقرارت";
            Form.ChFormName(STRNamePage);

        }
        public class DGItem
        {
            public String NameSub { get; set; }
            public String TypeOfBranch { get; set; }
            public String Code { get; set; }
            public String NameLev { get; set; }
            public int? NumOfStudent { get; set; }



        }
        public void loadDatagrid()
        {
            CollegeContext cd = new CollegeContext();

            var query = (from sc in cd.StudentStatments
                         
                         join l in cd.Levels on sc.IdLevel equals l.Id
                         join b in cd.Branches on sc.IdBranch equals b.Id
                         join su in cd.Subjects on sc.IdSubject equals su.Id

                         select new DGItem
                         {
                             NameSub = su.Name,
                             TypeOfBranch = b.TypeOfBranch,
                             Code = su.Code,
                             NameLev=l.Name,
                             NumOfStudent = sc.NumberOfStudent
                         }).ToList();

            studentStatmentsDataGrid.ItemsSource = query;



        }
        public void loadDataComboTypeOfBranch()
        {
            try
            {
                CollegeContext cd = new CollegeContext();

                var branchs = (from p in cd.Branches
                               select p).ToList();

                CBTypeOfBranch.ItemsSource = branchs;
            }
            catch (Exception) { };
        }
        public void loadDataComboSections()
        {
           
            try
            {
                CollegeContext cd = new CollegeContext();
            Branch BranchCB = CBTypeOfBranch.SelectedItem as Branch;


                var sections = (from p in cd.Sections
                                where p.IdBranch == BranchCB.Id
                                select p).ToList();

                sectionsComboBox.ItemsSource = sections;
            }
            catch (Exception) { };
        }
        public void loadDataComboLevels()
        {
            CollegeContext cd = new CollegeContext();

            var levels = (from p in cd.Levels
                          select p).ToList();
            LevelsComboBox.ItemsSource = levels;

        }
        public void loadDataComboSubject()
        {

            //مواد
            CollegeContext cd = new CollegeContext();
            Branch BranchCB = CBTypeOfBranch.SelectedItem as Branch;


            //var query = cd.Subjects.Where(x=>x.Id == BranchCB.Id).Select(x => x.Name).ToList();

            var query = cd.SubjectTeacherLoads.Where(x => x.IdBranch == BranchCB.Id).Select(x => x.Subject).ToList();
            var gquery = new Subject[query.Count];
            var had = query;


            _SubjectsComboBox.ItemsSource = query.ToList().Distinct().ToList();

        }
       
        private void department1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void NumberValidationTextBox(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            //can't write but numbers for TBPaper
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void CBTypeOfBranch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            loadDataComboSections();
            loadDataComboSubject();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            if (CBTypeOfBranch.Text != "" && sectionsComboBox.Text != "" && LevelsComboBox.Text != ""
                && _SubjectsComboBox.Text != "" &&  stud_num.Text != "")
            {
                CollegeContext db = new CollegeContext();
                Branch departmentCB = CBTypeOfBranch.SelectedItem as Branch;

                Section getIdSection = sectionsComboBox.SelectedItem as Section;
                Level getIdLevel = LevelsComboBox.SelectedItem as Level;

                Subject getIdSubject = _SubjectsComboBox.SelectedItem as Subject;

                try
                {
                    var result = (from p in db.StudentStatments 
                                  where (p.IdLevel == getIdLevel.Id && p.IdSubject == getIdSubject.Id &&p.IdBranch==departmentCB.Id)
                                  
                                  select p).SingleOrDefault();
                    if (result == null)
                    {

                        db.StudentStatments.Add(new StudentStatment()
                        {
                            IdLevel = getIdLevel.Id,
                            IdBranch = departmentCB.Id,
                            IdSubject = getIdSubject.Id,
                            NumberOfStudent= Int32.Parse(stud_num.Text)

                        });
                      
                        db.SaveChanges();
                        loadDatagrid();
                        MessageBox.Show("تم الحفظ بنجاح");

                    }

                    else { MessageBox.Show("برجاء اعد المحاولة لقد ادخلت ماده موجوده لنفس القسم ونفس المستوي  اكثر من مره!!"); }
                }
                catch (Exception) { MessageBox.Show("حدث خطب ما ....ربما ادخلت نفس القيم !!"); }





            }
            else { MessageBox.Show("برجاء ادخال جميع القيم حتي يتم الحفظ"); }

        }

        private void BTNRemove_Click_1(object sender, RoutedEventArgs e)
        {

            CollegeContext cd = new CollegeContext();

            DGItem dataRow = (DGItem)studentStatmentsDataGrid.SelectedItem;
         

            string NameSub = dataRow.NameSub.ToString();
            string TypeOfBranch = dataRow.TypeOfBranch.ToString();
            string Code = dataRow.Code.ToString();
            string NameLev = dataRow.NameLev.ToString();
            int? NumOfStudent = dataRow.NumOfStudent;




            try
            {
                Subject sub =
                                             (from p in cd.Subjects
                                              where (p.Name == NameSub)
                                              select p).SingleOrDefault();

              
                Branch bran =
                                           (from p in cd.Branches
                                            where (p.TypeOfBranch == TypeOfBranch)
                                            select p).SingleOrDefault();
                Level level =
                                         (from p in cd.Levels
                                          where (p.Name == NameLev)
                                          select p).SingleOrDefault();
                StudentStatment St =
                                       (from p in cd.StudentStatments
                                        where (p.NumberOfStudent == NumOfStudent)
                                        select p).SingleOrDefault();



                StudentStatment studentStatment = (from p in cd.StudentStatments
                                                  where ((p.IdSubject == sub.Id) &&
                                                  (p.IdBranch == bran.Id) && (p.IdLevel == level.Id) && (p.NumberOfStudent == St.NumberOfStudent))
                                                   select p).SingleOrDefault();
                cd.StudentStatments.Remove(studentStatment);
                cd.SaveChanges();
                loadDatagrid();

                MessageBox.Show("تم حذف الصف بنجاح");
            }
            catch (Exception) { MessageBox.Show("برجاء اختيار العنصر حتي يتم الحذف!!"); }
        }
    }
}
