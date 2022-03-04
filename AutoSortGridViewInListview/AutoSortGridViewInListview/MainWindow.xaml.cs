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

namespace AutoSortGridViewInListview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Staff> staffs = new List<Staff>();
        public MainWindow()
        {
            InitializeComponent();
            staffs.Add(new Staff()
            {
                 FirstName="Luan",
                 LastName="Nguyen",
                 DateOfBirth=new DateTime(1993,4,1)
            });
            staffs.Add(new Staff()
            {
                FirstName = "Nam",
                LastName = "Nguyen",
                DateOfBirth = new DateTime(1992, 4, 2)
            });
            staffs.Add(new Staff()
            {
                FirstName = "Huyen",
                LastName = "Nguyen",
                DateOfBirth = new DateTime(1990, 4, 2)
            });
            staffs.Add(new Staff()
            {
                FirstName = "Thai",
                LastName = "Nguyen",
                DateOfBirth = new DateTime(1992, 4, 3)
            });
            this.DataContext = staffs;
        }
    }
}
