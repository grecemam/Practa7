using DentalClinic.DentalClinicDBDataSetTableAdapters;
using System;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DentalClinic
{
    /// <summary>
    /// Логика взаимодействия для EmployeesPage.xaml
    /// </summary>
    public partial class EmployeesPage : Page
    {
        private readonly EmployeesTableAdapter _employeesTableAdapter = new EmployeesTableAdapter();

        public EmployeesPage()
        {
            InitializeComponent();
            LoadEmployees();
            LoadFilters();
        }
        private void LoadEmployees(string searchQuery = null, string post = null, string specialization = null, string role = null)
        {
            try
            {
                // Получение данных из TableAdapter с учетом фильтров
                var employeesTable = _employeesTableAdapter.GetEmployeesWithDetails(searchQuery, post, specialization, role);
                EmployeesDataGrid.ItemsSource = employeesTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void LoadFilters()
        {
            var postTableAdapter = new PostTableAdapter();
            var specializationTableAdapter = new SpecializationsTableAdapter();
            var roleTableAdapter = new RoleTableAdapter();

            PostFilterComboBox.ItemsSource = postTableAdapter.GetData();
            PostComboBox.ItemsSource = postTableAdapter.GetData();
            PostFilterComboBox.DisplayMemberPath = "name";
            PostFilterComboBox.SelectedValuePath = "name";
            PostComboBox.DisplayMemberPath = "name";
            PostComboBox.SelectedValuePath = "post_id";

            SpecializationFilterComboBox.ItemsSource = specializationTableAdapter.GetData();
            SpecializationComboBox.ItemsSource = specializationTableAdapter.GetData();
            SpecializationFilterComboBox.DisplayMemberPath = "name";
            SpecializationFilterComboBox.SelectedValuePath = "name";
            SpecializationComboBox.DisplayMemberPath = "name";
            SpecializationComboBox.SelectedValuePath = "specialization_id";

            RoleFilterComboBox.ItemsSource = roleTableAdapter.GetData();
            RolesComboBox.ItemsSource = roleTableAdapter.GetData();
            RoleFilterComboBox.DisplayMemberPath = "name";
            RoleFilterComboBox.SelectedValuePath = "name";
            RolesComboBox.DisplayMemberPath = "name";
            RolesComboBox.SelectedValuePath = "role_id";
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string fullName = FullNameTextBox.Text.Trim();

                string[] nameParts = fullName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string lastName = nameParts.Length > 0 ? nameParts[0] : string.Empty;
                string name = nameParts.Length > 1 ? nameParts[1] : string.Empty;
                string patronymic = nameParts.Length > 2 ? nameParts[2] : null;

                string contactDetails = ContactTextBox.Text.Trim();
                int postId = Convert.ToInt32(PostComboBox.SelectedValue);
                int? specializationId = SpecializationComboBox.SelectedValue != null
                                        ? (int?)Convert.ToInt32(SpecializationComboBox.SelectedValue)
                                        : null;
                int? experience = !string.IsNullOrEmpty(ExperienceTextBox.Text.Trim())
                                  ? (int?)Convert.ToInt32(ExperienceTextBox.Text.Trim())
                                  : null;

                _employeesTableAdapter.InsertQuery(name, lastName, patronymic, contactDetails, postId, specializationId, experience);

                MessageBox.Show("Сотрудник успешно добавлен!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

                ClearForm();

                LoadEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EditEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            // Проверяем, выбран ли работник в таблице
            if (!(EmployeesDataGrid.SelectedItem is DataRowView selectedEmployee))
            {
                MessageBox.Show("Пожалуйста, выберите работника для редактирования.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Получаем ID выбранного работника
            int employeeId = Convert.ToInt32(selectedEmployee["ID"]);

            try
            {
                string fullName = FullNameTextBox.Text.Trim();

                string[] nameParts = fullName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string lastName = nameParts.Length > 0 ? nameParts[0] : string.Empty;
                string name = nameParts.Length > 1 ? nameParts[1] : string.Empty;
                string patronymic = nameParts.Length > 2 ? nameParts[2] : null;

                string contactDetails = ContactTextBox.Text.Trim();
                int postId = Convert.ToInt32(PostComboBox.SelectedValue);
                int? specializationId = SpecializationComboBox.SelectedValue != null
                                        ? (int?)Convert.ToInt32(SpecializationComboBox.SelectedValue)
                                        : null;
                int? experience = !string.IsNullOrEmpty(ExperienceTextBox.Text.Trim())
                                  ? (int?)Convert.ToInt32(ExperienceTextBox.Text.Trim())
                                  : null;

                // Вызываем метод обновления данных
                _employeesTableAdapter.UpdateEmployee(
                    employeeId,
                    name,
                    lastName,
                    patronymic,
                    contactDetails,
                    Convert.ToInt32(PostComboBox.SelectedValue),
                    SpecializationComboBox.SelectedValue == null ? (int?)null : Convert.ToInt32(SpecializationComboBox.SelectedValue),
                    string.IsNullOrWhiteSpace(ExperienceTextBox.Text) ? (int?)null : Convert.ToInt32(ExperienceTextBox.Text)
                );

                MessageBox.Show("Данные успешно обновлены.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

                // Обновляем данные в таблице после изменения
                LoadEmployees();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void EmployeesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EmployeesDataGrid.SelectedItem is DataRowView selectedRow)
            {
                FullNameTextBox.Text = selectedRow["full_name"].ToString();
                ContactTextBox.Text = selectedRow["contact_details"].ToString();
                ExperienceTextBox.Text = selectedRow["experience"].ToString();
                string postName = selectedRow["post"].ToString();
                string roleName = selectedRow["role"].ToString();
                string specializationName = selectedRow["specialization"].ToString();

                PostComboBox.SelectedValue = FindPostIdByName(postName);
                SpecializationComboBox.SelectedValue = FindSpecializationIdByName(specializationName);
                RolesComboBox.SelectedValue = FindRoleIdByName(roleName);

            }
        }
        private void ClearForm()
        {
            FullNameTextBox.Text = string.Empty;
            ContactTextBox.Text = string.Empty;
            PostComboBox.SelectedIndex = -1;
            SpecializationComboBox.SelectedIndex = -1;
            ExperienceTextBox.Text = string.Empty;
        }
        private int? FindPostIdByName(string postName)
        {
            var postTable = new PostTableAdapter().GetData();
            var postRow = postTable.FirstOrDefault(row => row["name"].ToString() == postName);
            return postRow?["post_id"] as int?;
        }
        private int? FindRoleIdByName(string roleName)
        {
            var roleTable = new RoleTableAdapter().GetData();
            var roleRow = roleTable.FirstOrDefault(row => row["name"].ToString() == roleName);
            return roleRow?["role_id"] as int?;
        }

        private int? FindSpecializationIdByName(string specializationName)
        {
            var specializationTable = new SpecializationsTableAdapter().GetData();
            var specializationRow = specializationTable.FirstOrDefault(row => row["name"].ToString() == specializationName);
            return specializationRow?["specialization_id"] as int?;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchQuery = string.IsNullOrWhiteSpace(SearchTextBox.Text) ? null : $"%{SearchTextBox.Text}%";
            string post = PostFilterComboBox.SelectedValue?.ToString();
            string specialization = SpecializationFilterComboBox.SelectedValue?.ToString();
            string role = RoleFilterComboBox.SelectedValue?.ToString();

            LoadEmployees(searchQuery, post, specialization, role);
        }
    }
}
