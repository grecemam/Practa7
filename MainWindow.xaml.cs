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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DentalClinic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public LoginDetailsTableAdapter loginDetailsTableAdapter = new LoginDetailsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ClientNumberTextBox.Text))
                {
                    MessageBox.Show("Номер договора не может быть пустым.");
                    return;
                }
                string username = ClientNumberTextBox.Text;

                int? result = null;
                int? role_id = null;
                int? employee_id = null;

                using (LoginDetailsTableAdapter adapter = new LoginDetailsTableAdapter())
                {
                    adapter.LoginProcedure(username, null, ref result, ref role_id, ref employee_id);

                    if (result.HasValue && result.Value == 1)
                    {
                        MainWindowPatient mainWindowPatient = new MainWindowPatient(role_id.Value, username);
                        mainWindowPatient.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Неверный номер!");
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
            LoginWindowEmployee loginWindowEmployee = new LoginWindowEmployee();
            loginWindowEmployee.Show();
            Close();
        }
    }
}
