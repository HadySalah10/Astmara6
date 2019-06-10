using Data.Context;
using System.Windows;
using System.Windows.Controls;
using System.Linq;
using Data.Entities;
using System;
using System.Text.RegularExpressions;
using System.Windows.Data;
using Astmara6.Controls.Fixed_Data.Edit;

namespace Astmara6Con.Controls
{
    /// <summary>
    /// Interaction logic for docinfo.xaml
    /// </summary>
    public partial class UCDoctors : UserControl
    {
        public void loadData()
        {
            CollegeContext cd = new CollegeContext();
            

            var query = (from p1 in cd.WorkHours
                         join f1 in cd.Teachers on p1.Id equals f1.IdWorkHours
                         select new { p1.Rank,p1.HoursOfQuorum ,f1.Name,f1.NickName }).ToList();

            //var teachers = (from p in cd.Teachers
            //                select p).ToList();
            //var workhours = (from p1 in cd.WorkHours
            //                 join f1 in cd.Teachers on p1.Id equals f1.IdWorkHours
            //                 select new { p1.Rank, p1.HoursOfQuorum }).ToList();


            //DGDoctorsView.ItemsSource = teachers;
            _WorkHoursDataGrid.ItemsSource = query;

        }
        public void loadDataCombodegree()
        {
            CollegeContext cd = new CollegeContext();

            var workHours = (from p in cd.WorkHours
                           select p).ToList();

            degree.ItemsSource = workHours;
        }
        //public void loadDataComboSubject()
        //{
        //    CollegeContext cd = new CollegeContext();

        //    var subjects = (from p in cd.Subjects
        //                    select p).ToList();

        //    _SubjectsComboBox.ItemsSource = subjects;
        //}
        public void loadDataCombodepartment1()
        {
            CollegeContext cd = new CollegeContext();

            var branchs = (from p in cd.Branches
                             select p).ToList();

            department1.ItemsSource = branchs;
        }
        string STRNamePage;
        readonly FRMMainWindow Form = Application.Current.Windows[0] as FRMMainWindow;

        public UCDoctors()
        {
            InitializeComponent();
            loadData();
            loadDataCombodegree();
            loadDataCombodepartment1();
            //loadDataComboSubject();
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Form.gridShow.Children.Clear();
            Form.gridShow.Children.Add(new UCWorkHours());
            STRNamePage = "النصاب القانوني";
            Form.ChFormName(STRNamePage);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
        //    Form.gridShow.Children.Clear();
        //    Form.gridShow.Children.Add(new UCAssistant());
        //    STRNamePage = "المعيدين";
        //    Form.ChFormName(STRNamePage);

        }

    private void Button_AddClick(object sender, RoutedEventArgs e)
        {

            CollegeContext cd = new CollegeContext();
            WorkHour degreeCB = degree.SelectedItem as WorkHour;
        Branch departmentCB = department1.SelectedItem as Branch;
        //Subject SubjectCb = _SubjectsComboBox.SelectedItem as Subject;

        CollegeContext db = new CollegeContext();

            var result = (from p in db.Teachers
                          where p.Name == cou_name.Text
                          select p).SingleOrDefault();
            var result1 = (from p in db.Teachers
                          where p.NickName == cou_nic_name.Text
                          select p).SingleOrDefault();
            if (result == null || result1==null)
            {
                if (cou_name.Text == "" || cou_name.Text == " " || cou_name.Text == "  " || cou_name.Text == "   " || cou_name.Text == "    " ||
                cou_nic_name.Text == "" || cou_nic_name.Text == " " || cou_nic_name.Text == "  " || cou_nic_name.Text == "   " || cou_nic_name.Text == "    ")
                    
                {
                    MessageBox.Show("انت لم تدخل شيئا!!");

                }
                else
                {
                   

                    cd.Teachers.Add(new Teacher()
                    {
                       
                        IdWorkHours = degreeCB.Id,
                        Name = cou_name.Text,
                        NickName=cou_nic_name.Text

                        
                    });
                    cd.SaveChanges();
                    loadData();

                    var getIdteach = (from p in db.Teachers
                                      where cou_name.Text == p.Name
                                      select p.Id).FirstOrDefault();
                    //var getIdsub = (from p in db.Subjects
                    //                where _SubjectsComboBox.Text == p.Name
                    //                select p.Id).SingleOrDefault();

                    SubjectTeacherLoad teachers = (from p in cd.SubjectTeacherLoads
                                    where p.IdBranch == departmentCB.Id && p.IdTeacher==null
                                    select p).FirstOrDefault();
                    teachers.IdTeacher = getIdteach;
                    cd.SaveChanges();
                    loadData();


                    //cd.SubjectTeachers.Add(new SubjectTeacher()
                    //{
                    //    IdBranch = departmentCB.Id,
                    //    IdTeacher = getIdteach,


                    //}) ;

                    MessageBox.Show("تم حفظ البيانات بنجاح ");
                }
            }
            else
            {
                MessageBox.Show("الاسم او اللقب موجود مسبقا!!");

            }
            cou_name.Text = "";
            cou_nic_name.Text = "";


        }


        private void BTNEdit_Click(object sender, RoutedEventArgs e)
        {
            Form.gridShow.Children.Clear();
            Form.gridShow.Children.Add(new UCEditDoctor());
            STRNamePage = "تعديل الدكاترة";
            Form.ChFormName(STRNamePage);

        }

       
       
    }
}
