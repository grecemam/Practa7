using DentalClinic.DentalClinicDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Логика взаимодействия для ChooseSpecialistPage.xaml
    /// </summary>
    public partial class ChooseSpecialistPage : Page
    {
        private readonly int ServiceId;
        private readonly int PatientId;
        private readonly DataTable scheduleData;
        private readonly EmployeesTableAdapter employeesTableAdapter;
        private readonly AppointmentsTableAdapter appointmentsTableAdapter;
        private IGrouping<dynamic, DataRow> selectedDoctor; // Поле для хранения выбранного врача
        private readonly EmployeeScheduleTableAdapter employeeScheduleTableAdapter;
        private Button selectedDateButton = null;
        private Button selectedTimeButton = null;


        public ChooseSpecialistPage(int serviceId, int patientId)
        {
            InitializeComponent();
            ServiceId = serviceId;
            PatientId = patientId;
            employeesTableAdapter = new EmployeesTableAdapter();
            employeeScheduleTableAdapter = new EmployeeScheduleTableAdapter();
            appointmentsTableAdapter = new AppointmentsTableAdapter();
            scheduleData = employeesTableAdapter.GetSpecialistsByService(serviceId);
            specName.Text = "Выбор специалиста";
            LoadDoctorSchedule(); // Загрузка расписания врачей
            InitializeWeekGrids(); // Инициализация недели
        }
        private void InitializeWeekGrids()
        {
            DateTime today = DateTime.Today;

            for (int i = 0; i < 7; i++)
            {
                DateTime currentDay = today.AddDays(i);
                Button dayButton = CreateDayButton(currentDay);
                dayButton.Click += DayButton_Click;
                CurrentWeekGrid.Children.Add(dayButton);
            }

            for (int i = 0; i < 7; i++)
            {
                DateTime nextWeekDay = today.AddDays(i + 7);
                Button dayButton = CreateDayButton(nextWeekDay);
                dayButton.Click += DayButton_Click;
                NextWeekGrid.Children.Add(dayButton);
            }
        }
        private void DayButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button dayButton && dayButton.Tag is DateTime selectedDay && selectedDoctor != null)
            {
                if (selectedDateButton != null)
                {
                    selectedDateButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#102774"));
                }

                dayButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0A1129"));
                selectedDateButton = dayButton;

                morningPanel.Children.Clear();
                dayPanel.Children.Clear();
                eveningPanel.Children.Clear();

                DisplayDoctorScheduleForDay(selectedDay, selectedDoctor);
            }
        }
        private Button CreateDayButton(DateTime day)
        {
            Button dayButton = new Button
            {
                Content = day.ToString("ddd, dd MMM"),
                Margin = new Thickness(5),
                Background = Brushes.LightGray,
                BorderBrush = Brushes.LightGray,
                FontSize = 11,
                Tag = day // Сохраняем дату в Tag для использования при нажатии
            };

            return dayButton;
        }

        // Метод загрузки расписания врачей
        public void LoadDoctorSchedule()
        {
            specialistListPanel.Children.Clear(); // Очищаем панель перед добавлением новых врачей

            // Группируем данные по врачам
            var doctors = scheduleData.AsEnumerable()
                                      .GroupBy(row => new
                                      {
                                          EmployeeId = row.Field<int>("employee_id"),
                                          DoctorName = row.Field<string>("doctor_name"),
                                          Specialization = row.Field<string>("specialization")
                                      });

            foreach (var doctor in doctors)
            {
                // Создаем текстовый блок для имени врача
                TextBlock doctorNameText = new TextBlock
                {
                    Text = doctor.Key.DoctorName,
                    FontWeight = FontWeights.Bold,
                    TextAlignment = TextAlignment.Center,
                    FontSize = 14
                };

                // Находим ближайший доступный день врача
                string nextAvailableDay = GetNextAvailableDay(doctor);
                doctorNameText.Text += $"\nБлижайшая дата: {nextAvailableDay}";

                specialistListPanel.Children.Add(doctorNameText);

                // Обработка клика по имени врача для отображения расписания
                doctorNameText.MouseLeftButtonUp += (sender, args) =>
                {
                    selectedDoctor = doctor; // Сохраняем выбранного врача
                    SpecName.Text = doctor.Key.DoctorName;
                    DisplayDoctorSchedule(doctor);
                };
            }
        }

        // Метод отображения расписания врача
        private void DisplayDoctorSchedule(IGrouping<dynamic, DataRow> doctor)
        {
            // Очищаем панели и загружаем новое расписание
            morningPanel.Children.Clear();
            dayPanel.Children.Clear();
            eveningPanel.Children.Clear();

            // Загружаем доступные дни недели
            DateTime today = DateTime.Today;
            var doctorDays = doctor.Select(row => row.Field<string>("work_day").ToLower()).ToList();

            // Окрашиваем дни на текущей неделе
            UpdateWeekGridColors(CurrentWeekGrid, doctorDays, today);

            // Окрашиваем дни на следующей неделе
            UpdateWeekGridColors(NextWeekGrid, doctorDays, today.AddDays(7));

        }
        private void UpdateWeekGridColors(UniformGrid weekGrid, List<string> doctorDays, DateTime startDate)
        {
            for (int i = 0; i < 7; i++)
            {
                DateTime currentDay = startDate.AddDays(i);
                string dayOfWeek = currentDay.ToString("dddd", new CultureInfo("ru-RU")).ToLower();

                foreach (Button dayButton in weekGrid.Children.OfType<Button>())
                {
                    if (dayButton.Tag is DateTime buttonDate && buttonDate.Date == currentDay.Date)
                    {
                        if (doctorDays.Contains(dayOfWeek))
                        {
                            dayButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#102774"));
                            dayButton.Foreground = Brushes.White;
                            dayButton.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0A1129"));
                        }
                        else
                        {
                            dayButton.Background = Brushes.LightGray;
                            dayButton.BorderBrush = Brushes.LightGray;
                            dayButton.Foreground = Brushes.DarkGray;
                        }
                    }
                }
            }
        }
        private string GetNextAvailableDay(IGrouping<dynamic, DataRow> doctor)
        {
            DateTime today = DateTime.Today;
            var doctorDays = doctor.Select(row => row.Field<string>("work_day").ToLower()).ToList();

            for (int i = 0; i < 7; i++) // Проверяем ближайшие 7 дней
            {
                DateTime currentDay = today.AddDays(i);
                string dayOfWeek = currentDay.ToString("dddd", new CultureInfo("ru-RU")).ToLower();

                if (doctorDays.Contains(dayOfWeek)) // Если врач работает в этот день
                {
                    if (currentDay == today.AddDays(1))
                    {
                        return "Завтра";
                    }
                    if(currentDay == today)
                    {
                        return "Сегодня";
                    }
                    return currentDay.ToString("ddd, dd MMM");
                }
            }

            return "Нет доступных дней"; // Если нет доступных дней, возвращаем это сообщение
        }

        private void DisplayDoctorScheduleForDay(DateTime day, IGrouping<dynamic, DataRow> doctor)
        {
            morningPanel.Children.Clear();
            dayPanel.Children.Clear();
            eveningPanel.Children.Clear();
            var availableSlotsTable = employeeScheduleTableAdapter.GetAvailableSlots(doctor.Key.EmployeeId, day);


            foreach (DataRow row in availableSlotsTable.Rows)
            {
                TimeSpan slotTime = (TimeSpan)row["available_time"];

                // Разделяем временные интервалы по времени суток
                if (slotTime < new TimeSpan(12, 0, 0))
                    AddTimeSlotToPanel(morningPanel, slotTime);
                else if (slotTime < new TimeSpan(16, 0, 0))
                    AddTimeSlotToPanel(dayPanel, slotTime);
                else
                    AddTimeSlotToPanel(eveningPanel, slotTime);
            }

        }
        private void AddTimeSlotToPanel(WrapPanel panel, TimeSpan slotTime)
        {
            Button timeButton = new Button
            {
                Content = slotTime.ToString(@"hh\:mm"),
                Width = 80,
                Margin = new Thickness(5),
                Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#102774")),
                Foreground = Brushes.White,
                BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0A1129")),
                HorizontalAlignment = HorizontalAlignment.Left
            };
            timeButton.Click += TimeButton_Click;
            panel.Children.Add(timeButton);
        }
        private void TimeButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button timeButton)
            {
                if (selectedTimeButton != null)
                {
                    selectedTimeButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#102774"));
                }

                timeButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0A1129"));
                selectedTimeButton = timeButton;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MakeAppointmentPage makeAppointmentPage = new MakeAppointmentPage(PatientId);
            NavigationService.Navigate(makeAppointmentPage);
        }

        private void ScheduleAppointmentButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedDoctor == null || selectedDateButton == null || selectedTimeButton == null)
            {
                MessageBox.Show("Пожалуйста, выберите врача, дату и время приема.");
                return;
            }

            DateTime selectedDate = ((DateTime)selectedDateButton.Tag).Date;
            TimeSpan selectedTime = TimeSpan.Parse(selectedTimeButton.Content.ToString());

            int doctorId = selectedDoctor.Key.EmployeeId;
            int statusId = 1;
            int serviceId = ServiceId;
            try
            {
                appointmentsTableAdapter.ScheduleAppointment(PatientId, doctorId, selectedDate, selectedTime, statusId, serviceId);
                MessageBox.Show("Вы успешно записаны на приём!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при записи: " + ex.ToString());
            }
        }
    }
}
