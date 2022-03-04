using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataTemplateGridColumnByCondition
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Student> students = new List<Student>();
            students.Add(new Student("SV1","Luan",9.5));
            students.Add(new Student("SV2", "Nhan", 7.9));
            students.Add(new Student("SV3", "Nam",8));
            students.Add(new Student("SV4", "Ha",5.6));
            students.Add(new Student("SV5", "Binh", 2.9));
            this.DataContext = students;
        }
    }
    public class Student
    {
        public Student(string code, string name, double totalScore)
        {
            Code = code; Name = name; TotalScore = totalScore;
        }
        public string Code { get; set; }
        public string Name { get; set; }
        public double TotalScore { get; set; }
    }
    public class StudentTemplateSelector : DataTemplateSelector
    {
        public DataTemplate BadTemplate

        { get; set; }
        public DataTemplate MediumTemplate

        { get; set; }
        public DataTemplate GoodTemplate

        { get; set; }
        public DataTemplate ExcellentTemplate
        {
            get; set;
        }
        public override DataTemplate SelectTemplate(object item, DependencyObject container)

        {

            Student student = item as Student;
            if (student != null)

            {

                if (student.TotalScore >= 9)

                    return ExcellentTemplate;

                else if (student.TotalScore >= 8)

                    return GoodTemplate;
                else if (student.TotalScore >= 5)
                    return MediumTemplate;
                else return BadTemplate;
            }

            else

                return base.SelectTemplate(item, container);

        }
    }
}
