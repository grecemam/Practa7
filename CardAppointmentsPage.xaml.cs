using DentalClinic.DentalClinicDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
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
    /// Логика взаимодействия для CardAppointmentsPage.xaml
    /// </summary>
    public partial class CardAppointmentsPage : Page
    {
        private readonly PatientsTableAdapter patientsTableAdapter;
        public int PatientID;
        public CardAppointmentsPage(int patientID)
        {
            InitializeComponent();
            patientsTableAdapter = new PatientsTableAdapter();
            PatientID = patientID;
            AppointmentsListView.ItemsSource = patientsTableAdapter.GetMedicalCard(patientID);
            DataContext = this;
        }

        private void AppointmentsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedRow = (DataRowView)AppointmentsListView.SelectedItem;
            if (selectedRow != null)
            {
                NameAppoinment.Text = selectedRow["service_name"].ToString();
                DoctorTxb.Text = selectedRow["doctor_name"].ToString();
                AppointmentDateTextBlock.Text = ((DateTime)selectedRow["appointment_date"]).ToString("dd.MM.yyyy");
                AppointmentTimeTextBlock.Text = ((TimeSpan)selectedRow["appointment_time"]).ToString(@"hh\:mm");
                DiagnosisTextBlock.Text = selectedRow["diagnosis"].ToString();
                // Получение ID приема
                int appointmentId = Convert.ToInt32(selectedRow["appointment_id"]);

                // Получение рецептов для выбранного приема
                LoadPrescriptions(appointmentId);
            }
        }
        private void LoadPrescriptions(int appointmentId)
        {
            DataTable prescriptionsTable = patientsTableAdapter.GetMedicalCard(PatientID);

            // Фильтруем рецепты по выбранному ID приема
            var prescriptions = prescriptionsTable.AsEnumerable()
                .Where(row => Convert.ToInt32(row["appointment_id"]) == appointmentId)
                .Select(row => new Prescription
                {
                    Medication = row["medication"]?.ToString(),
                    Dosage = row["dosage"]?.ToString(),
                    Duration = row["duration"]?.ToString(),
                    Comments = row["prescription_comments"]?.ToString()
                })
                .Where(p => !string.IsNullOrWhiteSpace(p.Medication) ||  // Проверяем, чтобы хотя бы одно поле было не пустым
                            !string.IsNullOrWhiteSpace(p.Dosage) ||
                            !string.IsNullOrWhiteSpace(p.Duration) ||
                            !string.IsNullOrWhiteSpace(p.Comments))
                .ToList();

            // Проверяем, есть ли валидные рецепты
            if (prescriptions.Any())
            {
                PrescriptionsListView.ItemsSource = prescriptions;
                PrescriptionsListView.Visibility = Visibility.Visible; // Показываем список
                RecipesTxb.Visibility = Visibility.Visible; // Показываем заголовок
            }
            else
            {
                PrescriptionsListView.ItemsSource = null;
                PrescriptionsListView.Visibility = Visibility.Collapsed; // Скрываем список
                RecipesTxb.Visibility = Visibility.Collapsed; // Скрываем заголовок
            }
        }
    }
    public class Prescription
    {
        public string Medication { get; set; }
        public string Dosage { get; set; }
        public string Duration { get; set; }
        public string Comments { get; set; }
    }
    public class DateToLocalizedStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime date)
            {
                return date.ToString("d MMMM yyyy 'г.'", new CultureInfo("ru-RU"));
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
