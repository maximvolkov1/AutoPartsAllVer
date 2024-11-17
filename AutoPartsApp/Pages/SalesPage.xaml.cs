using AutoPartsApp.AppDate;
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
using Excel = Microsoft.Office.Interop.Excel;

namespace AutoPartsApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для SalesPage.xaml
    /// </summary>
    public partial class SalesPage : Page
    {
        public SalesPage()
        {
            InitializeComponent();
            var sale = Connect.GetCont().Sales.ToList();
            SalesLV.ItemsSource = sale;
        }

        private void editSaleBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new AddSalePage((sender as Button).DataContext as Sales));
        }

        private void addSale_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new AddSalePage(null));
        }

        private void delSale_Click(object sender, RoutedEventArgs e)
        {
            var delSales = SalesLV.SelectedItems.Cast<Sales>().ToList();
            if (MessageBox.Show($"Удалить {delSales.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Connect.context.Sales.RemoveRange(delSales);
            }
            try
            {
                Connect.context.SaveChanges();
                SalesLV.ItemsSource = Connect.context.Sales.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            var sale = Connect.GetCont().Sales.ToList();
            SalesLV.ItemsSource = sale;
        }

        private void updateSale_Click(object sender, RoutedEventArgs e)
        {
            var sale = Connect.GetCont().Sales.ToList();
            SalesLV.ItemsSource = sale;
        }

        private void reportSale_Click(object sender, RoutedEventArgs e)
        {
            Excel.Application app = new Excel.Application()
            {
                Visible = true,
                SheetsInNewWorkbook = 1
            };
            Excel.Workbook workbook = app.Workbooks.Add(Type.Missing); app.DisplayAlerts = false;
            Excel.Worksheet sheet = (Excel.Worksheet)app.Worksheets.get_Item(1);
            sheet.Name = "Продажи";
            sheet.Cells[1, 1] = "Id продажи"; sheet.Cells[1, 3] = "Автозапчасть"; sheet.Cells[1, 2] = "ФИО продавца"; sheet.Cells[1, 4] = "Клиент";
            sheet.Cells[1, 5] = "Дата продажи"; sheet.Cells[1, 6] = "Количество"; sheet.Cells[1, 7] = "Цена";
            var currentRow = 2;
            var orders = Connect.context.Sales.ToList();
            foreach (var item in orders)
            {
                sheet.Cells[currentRow, 1] = item.IdSale;
                sheet.Cells[currentRow, 2] = item.Sellers.FIO;
                sheet.Cells[currentRow, 3] = item.AutoParts.NameAutoParts;
                sheet.Cells[currentRow, 4] = item.Clients.SurnameClient;
                sheet.Cells[currentRow, 5] = item.DateSale;
                sheet.Cells[currentRow, 6] = item.Quantity;
                sheet.Cells[currentRow, 7] = item.Price;
                currentRow++;
                Excel.Range range2 = sheet.get_Range("A1", "H1048576"); range2.Cells.Font.Name = "TimesNewRoman"; range2.Cells.Font.Size = 14;
                range2.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                sheet.Columns.ColumnWidth = 48;
                Excel.Range range3 = sheet.get_Range("A1", "H1"); range3.Cells.Font.Name = "TimesNewRoman"; range3.Cells.Font.Size = 14; range3.Cells.Font.Bold = true;
                range3.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                Excel.Borders borders1 = range2.Borders;
                borders1.LineStyle = Excel.XlLineStyle.xlContinuous;
                borders1.Weight = 2d;
            }
        }

        private void searchTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            SalesLV.ItemsSource = Connect.context.Sales.Where(x => x.IdSale.ToString().StartsWith(searchTxt.Text)).ToList();
        }

        private void СDatepkr_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (СDatepkr.SelectedDate.HasValue && PoDatepkr.SelectedDate.HasValue)
            {
                DateTime startDate = СDatepkr.SelectedDate.Value;
                DateTime endDate = PoDatepkr.SelectedDate.Value;
                FilterData(startDate, endDate);
            }
        }

        private void FilterData(DateTime startDate, DateTime endDate)
        {
            var filteredSales = Connect.context.Sales
                .Where(o => o.DateSale >= startDate && o.DateSale <= endDate)
                .ToList();
            SalesLV.ItemsSource = filteredSales;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }

        private async void calcSale_Click(object sender, RoutedEventArgs e)
        {
            var orders = await Task.Run(() => Connect.context.Sales.Select(x => new
            {
                x.IdSale,
                x.IdAutoPart,
                x.IdSeller,
                x.IdClient,
                x.DateSale,
                x.Price,
                x.Quantity,
                TotalCost = x.Price * x.Quantity
            }).ToList());
            SalesLV.ItemsSource = orders;
        }

        private async void selectSale_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new SaleSelectPage());
        }
    }
}
