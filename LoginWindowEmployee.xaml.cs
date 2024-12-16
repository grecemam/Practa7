using DentalClinic.DentalClinicDBDataSetTableAdapters;
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
    /// Логика взаимодействия для LoginWindowEmployee.xaml
    /// </summary>
    public partial class LoginWindowEmployee : Window
    {
        public LoginDetailsTableAdapter loginDetailsTableAdapter = new LoginDetailsTableAdapter();
        public LoginWindowEmployee()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(EmployeeNumberTextBox.Text) || string.IsNullOrWhiteSpace(PasswordBox.Password))
                {
                    MessageBox.Show("Заполните оба поля!");
                    return;
                }
                string username = EmployeeNumberTextBox.Text;
                string password = PasswordBox.Password;

                int? result = null;
                int? role_id = null;
                int? employee_id = null;

                using (LoginDetailsTableAdapter adapter = new LoginDetailsTableAdapter())
                {
                    adapter.LoginProcedure(username, password, ref result, ref role_id, ref employee_id);

                    if (result.HasValue && result.Value == 1)
                    {
                        if (role_id.HasValue)
                        {
                            if (role_id.Value == 1)
                            {
                                employee_id = role_id.Value;
                                MainWindowAdmin mainWindowAdmin = new MainWindowAdmin(/*employee_id.Value*/);
                                mainWindowAdmin.Show();
                            }
                            else
                            {
                                MainWindowDoctor mainWindowDoctor = new MainWindowDoctor(employee_id.Value);
                                mainWindowDoctor.Show();
                            }

                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Роль пользователя не определена!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный номер или пароль!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
