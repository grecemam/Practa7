using DentalClinic.DentalClinicDBDataSetTableAdapters;
using MaterialDesignThemes.Wpf;
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
using FontAwesome.WPF;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DentalClinic
{
    /// <summary>
    /// Логика взаимодействия для MakeAppointmentPage.xaml
    /// </summary>
    public partial class MakeAppointmentPage : Page
    {
        private readonly int PatientId;
        public SpecializationsTableAdapter specializationsTableAdapter;
        public FreeServicesTableAdapter freeServicesTableAdapter;
        public PreventiveServicesTableAdapter preventiveServicesTableAdapter;
        public SurgicalServicesTableAdapter surgicalServicesTableAdapter;
        public MakeAppointmentPage(int patientId)
        {
            InitializeComponent();
            specializationsTableAdapter = new SpecializationsTableAdapter();
            freeServicesTableAdapter = new FreeServicesTableAdapter();
            preventiveServicesTableAdapter = new PreventiveServicesTableAdapter();
            surgicalServicesTableAdapter = new SurgicalServicesTableAdapter();
            PatientId = patientId;
            LoadSpecializations();
            LoadFreeServices();
            LoadPreventiveServices();
            LoadSurgicalServices();
        }
        private void LoadSpecializations()
        {

            foreach (DataRow row in specializationsTableAdapter.GetData())
            {
                int specializationId = (int)row["specialization_id"];
                string specializationName = row["name"].ToString();
                PackIconKind iconKind;

                switch (specializationName)
                {
                    case "Стоматология":
                        iconKind = PackIconKind.ToothOutline;
                        break;
                    case "Детская стоматология":
                        iconKind = PackIconKind.TeddyBear;
                        break;
                    case "Хирургия":
                        iconKind = PackIconKind.Needle;
                        break;
                    case "Пародонтология":
                        iconKind = PackIconKind.Toothbrush;
                        break;
                    case "Ортодонтия":
                        iconKind = PackIconKind.Pill;
                        break;
                    default:
                        iconKind = PackIconKind.Help;
                        break;
                }


                Button specializationButton = new Button
                {
                    Width = 180,
                    Height = 60,
                    Margin = new Thickness(10),
                    FontFamily = new FontFamily("Ubuntu"),
                    Content = new StackPanel
                    {
                        Orientation = Orientation.Vertical,
                        HorizontalAlignment = HorizontalAlignment.Center,
                        Children =
                        {
                            new PackIcon
                            {
                                Kind = iconKind,
                                Width = 24,
                                Height = 24,
                                HorizontalAlignment = HorizontalAlignment.Center,
                            },
                            new TextBlock
                            {
                                Text = specializationName,
                                FontSize = 11,
                                TextAlignment = TextAlignment.Center,
                            }
                        }
                    },
                    Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0A1129")),
                    BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0A1129"))
                };
                specializStack.Children.Add(specializationButton);
            }
        }
      
        private void LoadFreeServices()
        {
            foreach (DataRow row in freeServicesTableAdapter.GetData())
            {
                int specializationId = (int)row["service_id"];
                string serviceName = row["name"].ToString();
                string description = row["description"].ToString();
                PackIconKind iconKind;

                switch (serviceName)
                {
                    case "Консультация по гигиене полости рта":
                        iconKind = PackIconKind.Tooth;
                        break;
                    case "Осмотр полости рта":
                        iconKind = PackIconKind.Tooth;
                        break;
                    case "Составление плана лечения":
                        iconKind = PackIconKind.Check;
                        break;
                    case "Экстренная консультация":
                        iconKind = PackIconKind.Medicine;
                        break;
                    default:
                        iconKind = PackIconKind.Heart;
                        break;
                }


                Button serviceButton = new Button
                {
                    Width = 255,
                    Height = 80,
                    Margin = new Thickness(10),
                    FontFamily = new FontFamily("Ubuntu"),
                    Content = new StackPanel
                    {
                        Orientation = Orientation.Vertical,
                        HorizontalAlignment = HorizontalAlignment.Center,
                        Children =
                        {
                            new PackIcon
                            {
                                Kind = iconKind,
                                Width = 24,
                                Height = 24,
                                Margin = new Thickness(0,0,0,3),
                                HorizontalAlignment = HorizontalAlignment.Center,
                            },
                            new TextBlock
                            {
                                Text = serviceName,
                                FontSize = 11,
                                TextWrapping = TextWrapping.Wrap,
                                FontWeight = FontWeights.Bold,
                                Margin = new Thickness(0,0,0,5),
                                FontFamily = new FontFamily("Ubuntu"),
                                TextAlignment = TextAlignment.Center,
                            },
                            new TextBlock
                            {
                                Text = description,
                                FontSize = 11,
                                TextWrapping = TextWrapping.Wrap,
                                FontFamily = new FontFamily("Ubuntu"),
                                TextAlignment = TextAlignment.Center,
                            }
                        }
                    },
                    Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0A1129")),
                    BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0A1129")),
                    Tag = specializationId
                };
                serviceButton.Click += SpecializationButton_Click;
                stackFreeServ.Children.Add(serviceButton);
            }
        }
        private void LoadPreventiveServices()
        {
            foreach (DataRow row in preventiveServicesTableAdapter.GetData())
            {
                int serviceId = (int)row["service_id"];
                string serviceName = row["name"].ToString();
                decimal price = (decimal)row["price"];

                Button serviceButton = new Button
                {
                    Width = 180,
                    Height = 60,
                    Margin = new Thickness(10),
                    FontFamily = new FontFamily("Ubuntu"),
                    Content = new StackPanel
                    {
                        Orientation = Orientation.Vertical,
                        HorizontalAlignment = HorizontalAlignment.Center,
                        Children =
                        {
                            new TextBlock
                            {
                                Text = serviceName,
                                FontSize = 11,
                                FontWeight = FontWeights.Bold,
                                TextWrapping = TextWrapping.Wrap,
                                TextAlignment = TextAlignment.Center,
                            },
                            new TextBlock
                            {
                                Text = price.ToString(),
                                FontSize = 11,
                                TextAlignment = TextAlignment.Center,
                            }
                        }
                    },
                    Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0A1129")),
                    BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0A1129")),
                    Tag = serviceId
                };
                serviceButton.Click += SpecializationButton_Click;
                stackProfil.Children.Add(serviceButton);
            }
        }
        private void SpecializationButton_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            int serviceId = Convert.ToInt32(clickedButton.Tag);
            ChooseSpecialistPage chooseSpecialistPage = new ChooseSpecialistPage(serviceId, PatientId);
            NavigationService.Navigate(chooseSpecialistPage);
        }
        private void LoadSurgicalServices()
        {
            foreach (DataRow row in surgicalServicesTableAdapter.GetData())
            {
                int serviceId = (int)row["service_id"];
                string serviceName = row["name"].ToString();
                decimal price = (decimal)row["price"];

                Button serviceButton = new Button
                {
                    Width = 180,
                    Height = 60,
                    Margin = new Thickness(10),
                    FontFamily = new FontFamily("Ubuntu"),
                    Content = new StackPanel
                    {
                        Orientation = Orientation.Vertical,
                        HorizontalAlignment = HorizontalAlignment.Center,
                        Children =
                        {
                            new TextBlock
                            {
                                Text = serviceName,
                                FontSize = 11,
                                FontWeight = FontWeights.Bold,
                                TextWrapping = TextWrapping.Wrap,
                                TextAlignment = TextAlignment.Center,
                            },
                            new TextBlock
                            {
                                Text = price.ToString(),
                                FontSize = 11,
                                TextAlignment = TextAlignment.Center,
                            }
                        }
                    },
                    Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0A1129")),
                    BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0A1129")),
                    Tag = serviceId
                };
                serviceButton.Click += SpecializationButton_Click;
                stackSurg.Children.Add(serviceButton);
            }
        }
    }
}
