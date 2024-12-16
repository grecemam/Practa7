using DentalClinic.DentalClinicDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace DentalClinic
{
    /// <summary>
    /// Логика взаимодействия для AppointmentsClientPage.xaml
    /// </summary>
    public partial class AppointmentsClientPage : Page
    {
        private int PatientID;
        private readonly AppointmentsTableAdapter _appointmentTableAdapter;
        public AppointmentsClientPage(int patientID)
        {
            InitializeComponent();
            _appointmentTableAdapter = new AppointmentsTableAdapter();
            PatientID = patientID;
            LoadAppointments();
        }
        private void LoadAppointments()
        {
            try
            {
                // Получаем активные приёмы
                DataTable activeAppointmentsDataTable = _appointmentTableAdapter.GetUpcomingAppointmentsForPatient(PatientID);
                if (activeAppointmentsDataTable != null && activeAppointmentsDataTable.Rows.Count > 0)
                {
                    ActiveAppointmentsList.ItemsSource = activeAppointmentsDataTable.DefaultView;
                }
                else
                {
                    ActiveAppointmentsList.Visibility = Visibility.Collapsed;
                    NotApp.Visibility = Visibility.Visible;
                }
                

                //// Получаем архивные приёмы
                DataTable archivedAppointmentsDataTable = _appointmentTableAdapter.GetArchivedAppointmentsForPatient(PatientID);
                if (archivedAppointmentsDataTable != null && archivedAppointmentsDataTable.Rows.Count > 0)
                {
                    ArchivedAppointmentsList.ItemsSource = archivedAppointmentsDataTable.DefaultView;
                }
                else
                {
                    ArchivedAppointmentsList.Visibility = Visibility.Collapsed;
                    NotAppArch.Visibility = Visibility.Visible;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }

        private void MakeAppointmentButton_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is MainWindowPatient parentWindow && parentWindow.MainFrame != null)
            {
                parentWindow.MainFrame.Navigate(new MakeAppointmentPage(PatientID));
            }
        }
    }
}
