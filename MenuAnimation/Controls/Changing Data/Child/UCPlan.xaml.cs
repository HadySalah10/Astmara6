
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
            loadDataComboLevels();
            loadDatagrid();
            //loadDataComboSubject();
        }
        private void UserContro1_Loaded(object sender, RoutedEventArgs e)
        {


        }
        public class DGItem
        {
            public String NickName { get; set; }
            public String Code { get; set; }
            public String TypeOfBranch { get; set; }
        }
        public void loadDatagrid()
        {
            CollegeContext cd = new CollegeContext();


            //var query = cd.Teachers
            //    .Where(a => a.WorkHour.HoursOfQuorum>36 )

            //    .Join(cd.SubjectTeachers, a => a.Id, b => b.IdTeacher, (a, b) => a).Select(x=>x.Name);

            var query = (from sc in cd.SubjectTeachers
                         join s in cd.Subjects on sc.IdSubject equals s.Id
                         join t in cd.Teachers on sc.IdTeacher equals t.Id
                         join b in cd.Branches on sc.IdBranch equals b.Id
                         select new DGItem
                         {
                             NickName = t.NickName,
                             Code = s.Code,
                             TypeOfBranch = b.TypeOfBranch
                         }).ToList();

            PlanDG.ItemsSource = query;



        }
        public void loadDataComboLevels()
        {
            CollegeContext cd = new CollegeContext();

            var levels = (from p in cd.Levels
                          select p).ToList();
            _LevelsComboBox.ItemsSource = levels;

        }

        public void loadDataComboTypeOfSection()
        {
            try
            {
                CollegeContext cd = new CollegeContext();

                var branchs = (from p in cd.Branches
                               select p).ToList();

                CBTypeOfBranch.ItemsSource = branchs;
            } catch (Exception) { };
        }

        public void loadDataComboTeachers()
        {

            //دكاتره
            CollegeContext cd = new CollegeContext();
            Branch BranchCB = CBTypeOfBranch.SelectedItem as Branch;
            var query = cd.SubjectTeacherLoads.Where(x => x.IdBranch == BranchCB.Id).Select(x => x.Teacher);
            // علي حسب ال id بتاع id works 
            // عشان كده لازم ادخل المعيدين مثلا الاول وبعد كده الدكاتره او العكس 
            TeachersComboBox.ItemsSource = query.Where(u => u.WorkHour.HoursOfQuorum <= 36).ToList();

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
        public void loadDataComboSubjectcode()
        {

            //مواد
            CollegeContext cd = new CollegeContext();
            Branch BranchCB = CBTypeOfBranch.SelectedItem as Branch;


            //var query = cd.Subjects.Where(x=>x.Id == BranchCB.Id).Select(x => x.Name).ToList();

            var query = cd.SubjectTeacherLoads.Where(x => x.IdBranch == BranchCB.Id).Select(x => x.Subject).ToList();
            var gquery = new Subject[query.Count];
            var had = query;


            _SubjectsComboBox1.ItemsSource = query.ToList().Distinct().ToList();

        }
        public void loadDataComboTeachers1()
        {


            //معيدين
            CollegeContext cd = new CollegeContext();
            Branch SectionCB = CBTypeOfBranch.SelectedItem as Branch;
            var query = cd.SubjectTeacherLoads.Where(x => x.IdBranch == SectionCB.Id).Select(x => x.Teacher);
            // علي حسب ال id بتاع id works 
            // عشان كده لازم ادخل المعيدين مثلا الاول وبعد كده الدكاتره او العكس 
            TeachersComboBox1.ItemsSource = query.Where(u => u.WorkHour.HoursOfQuorum > 36).ToList();

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
           
        }

        private void CBTypeOfSection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            loadDataComboSubjectcode();
            loadDataComboSubject();
            loadDataComboTeachers();
            loadDataComboTeachers1();
        }

        private void TeachersComboBox_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void PlanDG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {


            if (TeachersComboBox.Text != "" && TeachersComboBox1.Text != "" && _SubjectsComboBox.Text != ""
                && _SubjectsComboBox1.Text != "")
            {
                CollegeContext db = new CollegeContext();
                Branch departmentCB = CBTypeOfBranch.SelectedItem as Branch;

                Teacher getIdteach = TeachersComboBox.SelectedItem as Teacher;
                Teacher getIdteach1 = TeachersComboBox1.SelectedItem as Teacher;

                Subject getIdSubject = _SubjectsComboBox.SelectedItem as Subject;
                try
                {
                    var result = (from p in db.SubjectTeachers
                                  where (p.IdBranch == departmentCB.Id && p.IdTeacher == getIdteach.Id) ||
                                  (p.IdBranch == departmentCB.Id && p.IdTeacher == getIdteach1.Id)
                                  select p).SingleOrDefault();
                    if (result == null)
                    {

                        db.SubjectTeachers.Add(new SubjectTeacher()
                        {
                            IdBranch = departmentCB.Id,
                            IdTeacher = getIdteach.Id,
                            IdSubject = getIdSubject.Id

                        });
                        db.SubjectTeachers.Add(new SubjectTeacher()
                        {
                            IdBranch = departmentCB.Id,
                            IdTeacher = getIdteach1.Id,
                            IdSubject = getIdSubject.Id

                        });
                        db.SaveChanges();
                        loadDatagrid();
                        MessageBox.Show("تم الحفظ بنجاح");

                    }

                    else { MessageBox.Show("برجاء اعد المحاولة لقد ادخلت دكتور او معيد لنفس كود الماده اكثر من مره!!"); }
                } catch (Exception ) { MessageBox.Show("حدث خطب ما ....ربما ادخلت نفس القيم !!"); }





            }
            else { MessageBox.Show("برجاء ادخال جميع القيم حتي يتم الحفظ"); }

        }
       
        private void BTNRemove_Click_1(object sender, RoutedEventArgs e)
        {

            CollegeContext cd = new CollegeContext();

            DGItem dataRow = (DGItem)PlanDG.SelectedItem;

            string nickName = dataRow.NickName.ToString();
            string code = dataRow.Code.ToString();
            string typeOfBranch = dataRow.TypeOfBranch.ToString();


            try
            {
                Teacher teach =
                                             (from p in cd.Teachers
                                              where (p.NickName == nickName)
                                              select p).SingleOrDefault();
                Subject sub =
                                            (from p in cd.Subjects
                                             where (p.Code == code)
                                             select p).SingleOrDefault();
                Branch bran =
                                           (from p in cd.Branches
                                            where (p.TypeOfBranch == typeOfBranch)
                                            select p).SingleOrDefault();

                SubjectTeacher subjectTeachers = (from p in cd.SubjectTeachers
                                                  where (p.IdTeacher == teach.Id) &&
                                                  (p.IdSubject == sub.Id) && (p.IdBranch == bran.Id)
                                                  select p).FirstOrDefault();
                cd.SubjectTeachers.Remove(subjectTeachers);
                cd.SaveChanges();
                loadDatagrid();

                MessageBox.Show("تم حذف الصف بنجاح");
            }
            catch (Exception) { MessageBox.Show("برجاء اختيار العنصر حتي يتم الحذف!!"); }

        }

        private void _LevelsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    } }
