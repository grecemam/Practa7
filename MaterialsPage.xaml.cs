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
    /// Логика взаимодействия для MaterialsPage.xaml
    /// </summary>
    public partial class MaterialsPage : Page
    {
        private readonly MaterialsTableAdapter materialsTableAdapter = new MaterialsTableAdapter();

        public MaterialsPage()
        {
            InitializeComponent();
            LoadMaterials();
        }
        private void LoadMaterials(string searchText = "", DateTime? bestBeforeDate = null)
        {
            try
            {
                if (string.IsNullOrEmpty(searchText) && !bestBeforeDate.HasValue)
                {
                    // Загружаем все данные, если нет фильтров
                    MaterialsDataGrid.ItemsSource = materialsTableAdapter.GetData();
                }
                else
                {
                    // Фильтруем по названию и дате
                    MaterialsDataGrid.ItemsSource = materialsTableAdapter.GetFilteredMaterialsAndSuppliers(
                        bestBeforeDate.HasValue ? (int?)(bestBeforeDate.Value - DateTime.Now).TotalDays : null,
                        string.IsNullOrEmpty(searchText) ? null : $"%{searchText}%"
                        );

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RefreshData_Click(object sender, RoutedEventArgs e)
        {
            LoadMaterials();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }

        private void ApplyFilter_Click(object sender, RoutedEventArgs e)
        {
            string searchText = SearchTextBox.Text.Trim();
            DateTime? bestBeforeDate = BestBeforeDatePicker.SelectedDate;

            LoadMaterials(searchText, bestBeforeDate);
        }
    }
}
