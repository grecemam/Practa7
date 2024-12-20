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
    /// Логика взаимодействия для UsersSchedulePage.xaml
    /// </summary>
    public partial class UsersSchedulePage : Page
    {
        private readonly AppointmentsTableAdapter appointmentsTableAdapter = new AppointmentsTableAdapter();
        private readonly EmployeesTableAdapter employeesTableAdapter = new EmployeesTableAdapter();
        private readonly AppointmentStatusTableAdapter appointmentStatusTableAdapter = new AppointmentStatusTableAdapter();
        private readonly EmployeeScheduleTableAdapter employeeScheduleTableAdapter = new EmployeeScheduleTableAdapter();
        private readonly QueriesTableAdapter queriesTableAdapter = new QueriesTableAdapter();
        public UsersSchedulePage()
        {
            InitializeComponent();
            LoadAppointments();
            LoadData();
        }
        private void UpdateAppointmentButton_Click(object sender, RoutedEventArgs e)
        {
            if (AppointmentsDataGrid.SelectedItem is DataRowView selectedAppointment)
            {
                int appointmentID = Convert.ToInt32(selectedAppointment["appointment_id"]);
                var appointmentDate = AppointmentDatePicker.SelectedDate;
                var appointmentTime = TimeSpan.Parse(AppointmentTimeComboBox.SelectedValue.ToString());
                var status = Convert.ToInt32(StatusComboBox.SelectedValue);
                queriesTableAdapter.UpdateAppointment(appointmentID, appointmentDate, appointmentTime, status, null, null);
                MessageBox.Show("Все супер");
            }
        }

        private void CancelAppointmentButton_Click(object sender, RoutedEventArgs e)
        {
            // Логика отмены записи
        }

        private void AppointmentsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AppointmentsDataGrid.SelectedItem is DataRowView selectedAppointment)
            {
                if (selectedAppointment["status"].ToString() == "Завершено")
                {
                    StatusComboBox.IsEnabled = false;
                    AppointmentDatePicker.IsEnabled = false;
                    DoctorsComboBox.IsEnabled = false;
                    AppointmentTimeComboBox.IsEnabled = false;
                    UpdateAppointment.IsEnabled = false;
                    CancelAppointment.IsEnabled = false;
                }
                var status = selectedAppointment["status"].ToString();
                StatusComboBox.SelectedValue = FindStatusIdByName(status);
                if (DateTime.TryParse(selectedAppointment["appointment_date"].ToString(), out DateTime appointmentDate))
                {
                    AppointmentDatePicker.SelectedDate = appointmentDate;
                }
                var doctor = selectedAppointment["DoctorName"].ToString();
                DoctorsComboBox.SelectedValue = FindDoctorIdByName(doctor);
                LoadAvailableSlots(Convert.ToInt32(DoctorsComboBox.SelectedValue), appointmentDate);
                if (selectedAppointment["appointment_time"] != DBNull.Value &&
                    TimeSpan.TryParse(selectedAppointment["appointment_time"].ToString(), out TimeSpan appointmentTime))
                {
                    AppointmentTimeComboBox.SelectedValue = appointmentTime.ToString();
                }
            }
        }
        private void LoadAppointments()
        {
            var appointmentsData = appointmentsTableAdapter.GetAppointments(null, null, null);
            AppointmentsDataGrid.ItemsSource = appointmentsData.DefaultView;
        }
        private void LoadData()
        {
            var doctors = employeesTableAdapter.GetEmployeesWithDetails(null, null, null, "Врач");
            DoctorsComboBox.ItemsSource = doctors;
            DoctorsComboBox.DisplayMemberPath = "full_name";
            DoctorsComboBox.SelectedValuePath = "ID";

            var status = appointmentStatusTableAdapter.GetData();
            StatusComboBox.ItemsSource = status;
            StatusComboBox.DisplayMemberPath = "status_name";
            StatusComboBox.SelectedValuePath = "status_id";
        }
        private int? FindStatusIdByName(string statusName)
        {
            var statusTable = appointmentStatusTableAdapter.GetData();
            var postRow = statusTable.FirstOrDefault(row => row["status_name"].ToString() == statusName);
            return postRow?["status_id"] as int?;
        }
        private int? FindDoctorIdByName(string doctorName)
        {
            var doctorsTable = employeesTableAdapter.GetEmployeesWithDetails(null, null, null, "Врач");
            var postRow = doctorsTable.FirstOrDefault(row => row["full_name"].ToString() == doctorName);
            return postRow?["ID"] as int?;
        }
        private void LoadAvailableSlots(int doctorId, DateTime appointmentDate)
        {
            try
            {
                var slotsData = employeeScheduleTableAdapter.GetAvailableSlots(doctorId, appointmentDate);

                var timeSlots = slotsData.AsEnumerable()
                                         .Select(row => TimeSpan.Parse(row["available_time"].ToString()))
                                         .ToList();

                AppointmentTimeComboBox.ItemsSource = timeSlots;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки времени: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AppointmentDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if(AppointmentDatePicker.SelectedDate != null && DoctorsComboBox.SelectedValue != null)
            {
                LoadAvailableSlots(Convert.ToInt32(DoctorsComboBox.SelectedValue), Convert.ToDateTime(AppointmentDatePicker.SelectedDate));
            }
        }
    }
}
