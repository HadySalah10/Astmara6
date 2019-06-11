using Data.Context;
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
        string codee;
        int? Academee;
        public void loadDataCombo()
        {
            CollegeContext cd = new CollegeContext();

            var branchs = (from p in cd.Branches
                           select p).ToList();

            BranchesComboBox.ItemsSource = branchs;
        }
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
            loadDataCombo();



        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
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
        {  try
            {
                if (TBCode.Text != "" || TBNameCourse.Text != "" || TBPaper.Text != "" || TBVirtual.Text != "" || TBExprement.Text != "" ||
                    TBCode.Text != " " || TBNameCourse.Text != " " || TBPaper.Text != " " || TBVirtual.Text != " " || TBExprement.Text != " "
                   || TBCode.Text != "  " || TBNameCourse.Text != "  " || TBPaper.Text != "  " || TBVirtual.Text != "  " || TBExprement.Text != "  "
                   || TBCode.Text != "   " || TBNameCourse.Text != "   " || TBPaper.Text != "   " || TBVirtual.Text != "   " || TBExprement.Text != "   "
                        )
                {
                    codee = TBCode.Text;
                    Academee = int.Parse(TBPaper.Text);

                    CollegeContext db = new CollegeContext();
                    
                    Branch BranchesCB = BranchesComboBox.SelectedItem as Branch;
                    var result = (from p in db.Subjects
                                  where p.Name == TBNameCourse.Text
                                  select p).SingleOrDefault();
                    var result1 = (from p in db.Subjects
                                   where p.Code == TBCode.Text
                                   select p).SingleOrDefault();
                    if (result == null)
                    {
                        if (result1 == null)
                        {
                            if (!String.IsNullOrEmpty(TBExprement.Text))
                            {
                                db.Subjects.Add(new Subject()
                                {
                                    Code = codee,
                                    Name = TBNameCourse.Text,
                                    Academic = Academee,
                                    Exprement = Expremente,
                                    TotalHours = TotalHour

                            });
                                db.SaveChanges();
                                loadData();

                            }
                            else if (!String.IsNullOrEmpty(TBVirtual.Text))
                            {
                                db.Subjects.Add(new Subject()
                                {
                                    Code = codee,
                                    Name = TBNameCourse.Text,
                                    Academic = Academee,
                                    Virtual = Virtuale,
                                    TotalHours = TotalHour
                          

                        });
                            db.SaveChanges();
                            loadData();
                                loadData();

                                MessageBox.Show("تم حفظ العملية بنجاح");

                            }
                            else if(String.IsNullOrEmpty(TBExprement.Text))
                            {
                                TBVirtual.IsReadOnly = false;

                            }
                            else if (String.IsNullOrEmpty(TBVirtual.Text))
                            {
                                TBVirtual.IsReadOnly = false;

                            }

                            TBExprement.Text = null;
                            TBVirtual.Text = null;
                            Expremente = null;
                            Virtuale = null;
                            for (int i = 0; i < 6; i++)
                            {

                                int id1 = (from record in db.Subjects orderby record.Id descending select record.Id).First();

                            db.SubjectTeacherLoads.Add(new SubjectTeacherLoad()
                            {
                                IdBranch = BranchesCB.Id,
                                IdSubject = id1

                            });
                            }
                            db.SaveChanges();
                            loadData();

                            MessageBox.Show("تم حفظ العملية بنجاح");


                           
                        
                            

                         
                        }
                        else
                        {
                            MessageBox.Show("الكود موجود مسبقا!!");


                        }
                    }
                    else
                    {
                        MessageBox.Show("الاسم موجود مسبقا!!");

                    }
                }
                else { MessageBox.Show("برجاء ادخال كافة المعلومات"); }
            }
            catch (Exception)
            {
                MessageBox.Show("  حدث خطب ما اعد مرة اخري  !! ");
            }
        }

        private void SubjectsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TBVirtual_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(TBVirtual.Text))
                {
                    TBExprement.IsReadOnly = true;
                    Virtuale = int.Parse(TBVirtual.Text);

                    TotalHour =
                    int.Parse(TBPaper.Text)
                    + int.Parse(TBVirtual.Text)-1;

                }
                else
                {
                    TBExprement.IsReadOnly = false;

                }
            }
            catch (Exception) {
                TBVirtual.Text = "";

                MessageBox.Show("برجاء ادخال عدد ساعات النظري اولا !!"); }



        }

        private void TBExprement_TextChanged(object sender, TextChangedEventArgs e)
        {

            try { 
           
                if (!String.IsNullOrEmpty(TBExprement.Text))
                {
                    TBVirtual.IsReadOnly = true;
                    Expremente = int.Parse(TBExprement.Text);
                    TotalHour =
                     int.Parse(TBPaper.Text)
                    + int.Parse(TBExprement.Text)-1;


                }
                else
                {
                    TBVirtual.IsReadOnly = false;

                }
            }
            catch (Exception) {
                TBExprement.Text = "";
                MessageBox.Show("برجاء ادخال عدد ساعات النظري اولا !!"); }




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
            
     

        private void BTNEdit_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {

                CollegeContext dataContext = new CollegeContext();
                Subject CoursesRow = DGCoursesView.SelectedItem as Subject;
                Subject subjects = (from p in dataContext.Subjects
                                    where p.Id == CoursesRow.Id
                                    select p).Single();
                subjects.Name = CoursesRow.Name;
                subjects.Code = CoursesRow.Code;
                subjects.Academic = CoursesRow.Academic;
                subjects.Virtual = CoursesRow.Virtual;
                    subjects.Exprement = CoursesRow.Exprement;
                if (CoursesRow.Name!= subjects.Name&& CoursesRow.Code != subjects.Code && CoursesRow.Academic != subjects.Academic &&
                    CoursesRow.Virtual != subjects.Virtual && CoursesRow.Exprement != subjects.Exprement && CoursesRow.TotalHours != subjects.TotalHours ) {
                    if (DGCoursesView.SelectedCells.Count > 0)
                    {
                        if (CoursesRow.Virtual == null)
                        {
                            subjects.TotalHours = CoursesRow.Exprement + CoursesRow.Academic;
                            dataContext.SaveChanges();
                            loadData();
                            MessageBox.Show("تم تعديل الصف بنجاح");

                        }
                        else if (CoursesRow.Exprement == null)
                        {
                            subjects.TotalHours = CoursesRow.Virtual + CoursesRow.Academic;
                            dataContext.SaveChanges();
                            loadData();
                            MessageBox.Show("تم تعديل الصف بنجاح");
                        }
                        else { MessageBox.Show("لم يتم حفظ التعديل !! لحدوث خطأ ما");
                            loadData();

                        }

                    } }
                else
                {
                    MessageBox.Show("لم يتم تعديل اي شيْ");
                }
                   
                } 
            catch (Exception )
            {
                MessageBox.Show("برجاء اختيار العنصر المراد تعديلة !!");
                return;
            }
        }

        private void BTNRemove_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {

                CollegeContext cd = new CollegeContext();
                Subject SubjectRow = DGCoursesView.SelectedItem as Subject;

                Subject subjects = (from p in cd.Subjects
                                    where p.Id == SubjectRow.Id
                                    select p).Single();
                cd.Subjects.Remove(subjects);
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

                cd.Subjects.RemoveRange(cd.Subjects);

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
        private void NumberValidationTextBox3(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            ////can't write but numbers for TBNameCourse
            //Regex regex = new Regex("[^ء-ي]+");
            //e.Handled = regex.IsMatch(e.Text);

        }
        private void TBNameCourse_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
