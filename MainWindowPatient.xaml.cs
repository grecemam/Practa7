using DentalClinic.DentalClinicDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DentalClinic
{
    /// <summary>
    /// Логика взаимодействия для MainWindowPatient.xaml
    /// </summary>
    public partial class MainWindowPatient : Window
    {
        public PatientsTableAdapter patientsTableAdapter = new PatientsTableAdapter();
        public int RoleID;
        public string Login;
        public int PatientId;
        public MainWindowPatient(int roleID, string login)
        {
            InitializeComponent();
            RoleID = roleID;
            Login = login;
            GetInfo();
        }
        private void GetInfo() 
        {
            var result = patientsTableAdapter.GetPatientInfoByRoleId(RoleID, Login);
            if (result != null && result.Rows.Count > 0)
            {
                var row = result.Rows[0];
                NamePatient.Text = $"Договор: {row["name"]}";
                PatientId = Convert.ToInt32(row["patient_id"]);
                MainFrame.Navigate(new AppointmentsClientPage(PatientId));
            }
        }

        private void TextBlock_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new CardAppointmentsPage(PatientId));
        }

        private void TextBlock_MouseLeftButtonUp_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new AppointmentsClientPage(PatientId));
        }
    }
}
