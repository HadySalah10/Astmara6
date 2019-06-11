using Data.Context;
using System;
using System.Windows.Controls;
using System.Linq;
using Data.Entities;
using System.Collections.Generic;

namespace Astmara6.Controls.Print_Data.Child
{
    /// <summary>
    /// Interaction logic for UCIstimaraBAssistants.xaml
    /// </summary>
    public partial class UCIstimaraBAssistants : UserControl
    {
        List<DGItem> dGItems;

        public UCIstimaraBAssistants()
        {
            InitializeComponent();
            loadDataComboTypeOfSection();
        }
        public class DGItem
        {
            public String Name { get; set; }
            public String Rank { get; set; }
            public int? HoursOfquerm { get; set; }
            public String Namesub { get; set; }
            public String level { get; set; }
            public int? Academic { get; set; }
            public int? Virtual { get; set; }
            public int? Exprement { get; set; }

        }
        public void loadDataComboTypeOfSection()
        {
            try
            {
                CollegeContext cd = new CollegeContext();

                var branchs = (from p in cd.Branches
                               select p).ToList();

                _BranchesComboBox.ItemsSource = branchs;
            }
            catch (Exception) { };
        }
        public void loadDataComboTeachers()
        {

            //دكاتره
            CollegeContext cd = new CollegeContext();
            Branch BranchCB = _BranchesComboBox.SelectedItem as Branch;
            var query = cd.SubjectTeacherLoads.Where(x => x.IdBranch == BranchCB.Id).Select(x => x.Teacher);
            // علي حسب ال id بتاع id works 
            // عشان كده لازم ادخل المعيدين مثلا الاول وبعد كده الدكاتره او العكس 
            _TeachersComboBox.ItemsSource = query.Where(u => u.WorkHour.HoursOfQuorum > 36).ToList();

        }
        public void loadDatagrid()
        {
            CollegeContext cd = new CollegeContext();
            Teacher teaherCB = _TeachersComboBox.SelectedItem as Teacher;

            //الاسم والدرجه والنصب القنوني

            var query = (from sc in cd.SubjectTeachers
                         join s in cd.Subjects on sc.IdSubject equals s.Id
                         join t in cd.Teachers on sc.IdTeacher equals t.Id
                         join wh in cd.WorkHours on t.IdWorkHours equals wh.Id
                         join b in cd.Branches on sc.IdBranch equals b.Id
                         where sc.IdTeacher== teaherCB.Id
                          
                         select new DGItem
                         {
                             Name = t.Name,
                             Rank = wh.Rank,
                             HoursOfquerm = wh.HoursOfQuorum,
                             Namesub = s.Name,
                             Academic = sc.hoursAca,
                             Virtual = sc.hoursVirt, 
                             Exprement = sc.hoursExp,
                                     
                         } ).ToList().Distinct().ToList();
            dGItems = query;


            IstmaraB.ItemsSource = query;

        }
        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            IstmaraB.SelectAll();

        }

        private void GenerateExcelFile(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void _BranchesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            loadDataComboTeachers();

        }

        private void _TeachersComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_TeachersComboBox.Text != "")
            {
                loadDatagrid();


            }
        }
    }
}
