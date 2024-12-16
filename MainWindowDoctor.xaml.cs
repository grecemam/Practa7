using DentalClinic.DentalClinicDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace DentalClinic
{
    /// <summary>
    /// Логика взаимодействия для MainWindowDoctor.xaml
    /// </summary>
    public partial class MainWindowDoctor : Window, INotifyPropertyChanged
    {
        public int EmployeeID;
        private readonly AppointmentsTableAdapter appointmentsTableAdapter;
        private readonly QueriesTableAdapter queriesTableAdapter;
        private readonly MaterialsViewTableAdapter materialsViewTableAdapter;
        public List<Material> materialsList;
        private bool _isSessionActive;

        public bool IsSessionActive
        {
            get => _isSessionActive;
            set
            {
                _isSessionActive = value;
                OnPropertyChanged(nameof(IsSessionActive));
            }
        }
        public MainWindowDoctor(int employeeID)
        {
            InitializeComponent();
            EmployeeID = employeeID;
            DataContext = this;
            IsSessionActive = false;
            appointmentsTableAdapter = new AppointmentsTableAdapter();
            materialsViewTableAdapter = new MaterialsViewTableAdapter();
            queriesTableAdapter = new QueriesTableAdapter();
            var appointments = appointmentsTableAdapter.GetAppointmentsByDoctor(employeeID);
            PatientList.ItemsSource = appointments;

        }

        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void PatientList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PatientList.SelectedItem is DataRowView selectedRow)
            {
                patientNameTextBlock.Text = $"Пациент: {selectedRow["patient_name"]}";
                serviceNameTextBlock.Text = $"Приём: {selectedRow["service_name"]}";
                Complaint.Text = selectedRow["complaints"].ToString();
            }
        }

        private void CompleteAppointment_Click(object sender, RoutedEventArgs e)
        {
            // Проверка, что выбран пациент
            if (PatientList.SelectedItem is DataRowView selectedRow)
            {
                // Сбор данных
                int appointmentId = Convert.ToInt32(selectedRow["appointment_id"]);
                int patientId = Convert.ToInt32(selectedRow["patient_id"]);
                string diagnosis = Diagnosis.Text; // Поле для ввода диагноза
                string notes = Notes.Text;

                // Данные для рецепта (если чекбокс активирован)
                string medication = IsRecipe.IsChecked == true ? MedicationName.Text : null;
                string dosage = IsRecipe.IsChecked == true ? Dosage.Text : null;
                string duration = IsRecipe.IsChecked == true ? Duration.Text : null;
                string comments = IsRecipe.IsChecked == true ? Comments.Text : null;

                // Данные для материалов
                var selectedMaterials = materialsList
                    .Where(material => material.IsSelected && material.Quantity > 0)
                    .ToList();

                if (selectedMaterials.Any(material => material.Quantity <= 0))
                {
                    MessageBox.Show("Убедитесь, что количество выбранных материалов больше нуля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                try
                {
                    DataTable materialsTable = new DataTable();
                    materialsTable.Columns.Add("MaterialID", typeof(int));
                    materialsTable.Columns.Add("Quantity", typeof(int));

                    foreach (var material in selectedMaterials)
                    {
                        materialsTable.Rows.Add(GetMaterialIdByName(material.Name), material.Quantity);
                    }
                    queriesTableAdapter.InsertMedicalDataAndRecipes(
                        patientId,
                        diagnosis,
                        notes,
                        appointmentId,
                        medication,
                        dosage,
                        duration,
                        comments,
                        materialsTable);

                    MessageBox.Show("Данные успешно сохранены.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    IsSessionActive = false; // Завершаем сессию
                    selectedRow["status_id"] = 2;
                    PatientList.Items.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите пациента из списка.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
        }
        private int GetMaterialIdByName(string materialName)
        {
            var dataTable = materialsViewTableAdapter.GetData();
            var materialRow = dataTable.AsEnumerable()
                .FirstOrDefault(row => row["name"].ToString() == materialName);

            return materialRow == null
                ? throw new Exception($"Материал с названием '{materialName}' не найден.")
                : Convert.ToInt32(materialRow["material_id"]);
        }

        private void StartAppointment_Click(object sender, RoutedEventArgs e)
        {
            IsSessionActive = true;
            LoadMaterials();
        }

        private void CancelAppointment_Click(object sender, RoutedEventArgs e)
        {

        }
        private void LoadMaterials()
        {
            var dataTable = materialsViewTableAdapter.GetData();

            // Преобразуем DataTable в список объектов Material
            materialsList = dataTable.AsEnumerable()
                .Select(row => new Material
                {
                    Name = row["name"].ToString(),
                    Quantity = Convert.ToInt32(row["quantity_in_stock"]),
                    IsSelected = false // Изначально все элементы не выбраны
                })
                .ToList();

            MaterialsListView.ItemsSource = materialsList;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void IsRecipe_Checked(object sender, RoutedEventArgs e)
        {
            MedicationName.IsEnabled = true;
            Dosage.IsEnabled = true;
            Duration.IsEnabled = true;
            Comments.IsEnabled = true;
            IsRecipe.IsChecked = true;
        }

        private void IsRecipe_Unchecked(object sender, RoutedEventArgs e)
        {
            MedicationName.IsEnabled = false;
            Dosage.IsEnabled = false;
            Duration.IsEnabled = false;
            Comments.IsEnabled = false;
        }
    }
    public class Material
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public bool IsSelected { get; set; }
    }
}
