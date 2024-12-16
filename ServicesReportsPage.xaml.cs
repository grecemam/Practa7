using System;
using System.Windows;
using System.Data;
using DentalClinic.DentalClinicDBDataSetTableAdapters;
using System.Windows.Controls;
using LiveCharts.Wpf;
using LiveCharts;
using Microsoft.Win32;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.IO;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Linq;

namespace DentalClinic
{
    /// <summary>
    /// Логика взаимодействия для ServicesReportsPage.xaml
    /// </summary>
    public partial class ServicesReportsPage : Page
    {
        public ServicesTableAdapter servicesTableAdapter = new ServicesTableAdapter();
        public ServicesReportsPage()
        {
            InitializeComponent();
            DataContext = this;
            LoadChartData();
            LoadListData();
        }
        private void LoadChartData()
        {
            var dataTable = servicesTableAdapter.GetServiceReportForChart(null, null);

            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                // Если данных нет, вы можете показать сообщение или скрыть диаграмму
                MessageBox.Show("Нет данных для отображения диаграммы.");
                return;
            }

            var chartSeries = new SeriesCollection();

            foreach (DataRow row in dataTable.Rows)
            {
                string serviceName = row["service_name"].ToString();
                double count = Convert.ToDouble(row["appointment_count"]);

                chartSeries.Add(new PieSeries
                {
                    Title = serviceName,
                    Values = new ChartValues<double> { count },
                    DataLabels = true,  // Включаем отображение данных
                    LabelPoint = value => serviceName  // Отображаем название услуги
                });
            }

            ChartSeries = chartSeries;
        }
        private void LoadListData()
        {
            var dataTable = servicesTableAdapter.GetServiceReportForChart(null, null);
            ServicesDataGrid.ItemsSource = dataTable;
        }

        public SeriesCollection ChartSeries { get; set; }

        private void ExportToPdfButton_Click(object sender, RoutedEventArgs e)
        {
            // Создаем PDF-документ
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Отчет по услугам";

            // Создаем страницу PDF-документа
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Устанавливаем шрифт для текста
            XFont font = new XFont("Times New Roman", 14);

            // Заголовок документа
            gfx.DrawString("Отчет по услугам", font, XBrushes.Black, new XPoint(200, 20));
            var dataTable = servicesTableAdapter.GetServiceReportForChart(null, null);
            var sortedData = dataTable.AsEnumerable()
                              .OrderByDescending(row => row.Field<int>("appointment_count")) // Сортируем по количеству
                              .Take(5); // Берем топ-5
            double yPosition = 50; // Начальная позиция для текста
            foreach (var row in sortedData)
            {
                string serviceName = row["service_name"].ToString();
                int usageCount = row.Field<int>("appointment_count");

                // Выводим данные в PDF
                gfx.DrawString($"Услуга: {serviceName}", font, XBrushes.Black, new XPoint(20, yPosition));
                gfx.DrawString($"Количество использований: {usageCount}", font, XBrushes.Black, new XPoint(20, yPosition + 20));

                yPosition += 40; // Смещение для следующей строки
            }

            // Сохраняем диаграмму как изображение
            var renderTargetBitmap = new RenderTargetBitmap((int)ServicesChart.ActualWidth, (int)ServicesChart.ActualHeight, 96, 96, PixelFormats.Pbgra32);
            renderTargetBitmap.Render(ServicesChart);

            // Преобразуем в MemoryStream
            var encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(renderTargetBitmap));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                ms.Seek(0, SeekOrigin.Begin);

                // Загружаем изображение в PDF
                XImage xImage = XImage.FromStream(ms);
                gfx.DrawImage(xImage, 20, yPosition, 600, 300); // Позиция и размер изображения
            }

            // Сохраняем PDF в файл
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Document (*.pdf)|*.pdf",
                FileName = "ServicesReport.pdf"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                document.Save(saveFileDialog.FileName);
            }
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            LoadChartData();
        }

        private void ViewListButton_Click(object sender, RoutedEventArgs e)
        {
            ChartView.Visibility = Visibility.Collapsed;
            ServicesDataGrid.Visibility = Visibility.Visible;
        }

        private void ShowChartButton_Click(object sender, RoutedEventArgs e)
        {
            ServicesDataGrid.Visibility = Visibility.Collapsed;
            ChartView.Visibility = Visibility.Visible;
        }
    }
}
