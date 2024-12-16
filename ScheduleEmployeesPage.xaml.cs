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
    /// Логика взаимодействия для ScheduleEmployeesPage.xaml
    /// </summary>
    public partial class ScheduleEmployeesPage : Page
    {
        private readonly ShiftsTableAdapter _shiftsTableAdapter = new ShiftsTableAdapter();
        private readonly WorkDaysTableAdapter _workDaysTableAdapter = new WorkDaysTableAdapter();
        private readonly QueriesTableAdapter _queriesTableAdapter = new QueriesTableAdapter();
        private readonly EmployeeScheduleTableAdapter _employeeScheduleTableAdapter = new EmployeeScheduleTableAdapter();
        public ScheduleEmployeesPage()
        {
            InitializeComponent();
            LoadScheduleData();
        }
        private void LoadScheduleData()
        {
            // Загрузка дней недели
            DayComboBox.ItemsSource = _workDaysTableAdapter.GetData();
            DayComboBox.DisplayMemberPath = "day_name";
            DayComboBox.SelectedValuePath = "day_id";

            // Загрузка смен
            ShiftComboBox.ItemsSource = _shiftsTableAdapter.GetData();
            ShiftComboBox.DisplayMemberPath = "ShiftTime";
            ShiftComboBox.SelectedValuePath = "shift_id";
            LoadSchedule();
        }
        private void LoadSchedule()
        {
            try
            {
                // Получаем данные из хранимой процедуры
                var scheduleData = _employeeScheduleTableAdapter.GetEmployeeSchedule();

                // Привязываем данные к DataGrid
                EmployeesDataGrid.ItemsSource = scheduleData.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки расписания: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void UpdateScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeesDataGrid.SelectedItem is DataRowView selectedEmployee)
            {
                int employeeId = Convert.ToInt32(selectedEmployee["employee_id"]);
                int scheduleId = Convert.ToInt32(selectedEmployee["schedule_id"]);
                int dayId = Convert.ToInt32(DayComboBox.SelectedValue);
                int shiftId = Convert.ToInt32(ShiftComboBox.SelectedValue);

                try
                {
                    _queriesTableAdapter.UpdateEmployeeSchedule(scheduleId, employeeId, dayId, shiftId);
                    StatusTextBlock.Text = "Расписание успешно обновлено.";
                    LoadSchedule();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка обновления", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите сотрудника для изменения расписания.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void EmployeesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EmployeesDataGrid.SelectedItem is DataRowView selectedEmployee)
            {
                var dayName = selectedEmployee["DayName"].ToString();
                DayComboBox.SelectedValue = FindDayIdByName(dayName);
                string selectedShiftTime = selectedEmployee["ShiftTime"].ToString();
                int? shiftId = FindShiftIdByTime(selectedShiftTime);
                if (shiftId.HasValue)
                {
                    ShiftComboBox.SelectedValue = shiftId.Value;
                }
                else
                {
                    MessageBox.Show($"Смена '{selectedShiftTime}' не найдена.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
        private int? FindDayIdByName(string dayName)
        {
            var workDayTable = _workDaysTableAdapter.GetData();
            var postRow = workDayTable.FirstOrDefault(row => row["day_name"].ToString() == dayName);
            return postRow?["day_id"] as int?;
        }
        private int? FindShiftIdByTime(string shiftTime)
        {
            var shiftTable = _shiftsTableAdapter.GetData();
            foreach (DataRow row in shiftTable.Rows)
            {
                string shiftTimeRow = row["ShiftTime"].ToString();
                if (shiftTimeRow == shiftTime)
                {
                    return Convert.ToInt32(row["shift_id"]);
                }
            }
            return null;
        }

    }
}
