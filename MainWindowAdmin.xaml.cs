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
using System.Windows.Shapes;

namespace DentalClinic
{
    /// <summary>
    /// Логика взаимодействия для MainWindowAdmin.xaml
    /// </summary>
    public partial class MainWindowAdmin : Window
    {
        public int EmployeeID;
        public MainWindowAdmin(/*int employeeID*/)
        {
            InitializeComponent();
            //EmployeeID = employeeID;
        }

        private void CountMaterTb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new MaterialsPage());
        }

        private void EmployeeTb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new EmployeesPage());
        }

        private void RoleTb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void PatientReportsTb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void ServicesReportsTb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new ServicesReportsPage());
        }

        private void ScheduleEmplTb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new ScheduleEmployeesPage());
        }

        private void ScheduleUsersTb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new UsersSchedulePage());
        }
    }
}
