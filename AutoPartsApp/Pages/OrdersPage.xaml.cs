using AutoPartsApp.AppDate;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Button = System.Windows.Controls.Button;
using Excel = Microsoft.Office.Interop.Excel;
using MenuItem = System.Windows.Controls.MenuItem;

namespace AutoPartsApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : System.Windows.Controls.Page
    {
        decimal cost;
        public OrdersPage()
        {
            InitializeComponent();
            statusCbx.ItemsSource = new string[] { "Выполнен", "Отменен" };
            var order = Connect.GetCont().Orders.ToList();
            OrdersLV.ItemsSource = order;
        }

        private void addOrder_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new AddOrderPage(null));
        }

        private void delOrder_Click(object sender, RoutedEventArgs e)
        {
            var delOrder = OrdersLV.SelectedItems.Cast<Orders>().ToList();
            if (MessageBox.Show($"Удалить {delOrder.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Connect.context.Orders.RemoveRange(delOrder);
            }
            try
            {
                Connect.context.SaveChanges();
                OrdersLV.ItemsSource = Connect.context.Orders.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            var order = Connect.GetCont().Orders.ToList();
            OrdersLV.ItemsSource = order;
        }

        private void updateOrder_Click(object sender, RoutedEventArgs e)
        {
            var order = Connect.GetCont().Orders.ToList();
            OrdersLV.ItemsSource = order;
        }

        private void reportOrder_Click(object sender, RoutedEventArgs e)
        {
            Excel.Application app = new Excel.Application()
            {
                Visible = true,
                SheetsInNewWorkbook = 1
            };
            Excel.Workbook workbook = app.Workbooks.Add(Type.Missing); app.DisplayAlerts = false;
            Excel.Worksheet sheet = (Excel.Worksheet)app.Worksheets.get_Item(1);
            sheet.Name = "Заказы";
            sheet.Cells[1, 1] = "Id заказа"; sheet.Cells[1, 2] = "ФИО продавца"; sheet.Cells[1, 3] = "Автозапчасть"; sheet.Cells[1, 4] = "Клиент";
            sheet.Cells[1, 5] = "Дата заказа"; sheet.Cells[1, 6] = "Количество"; sheet.Cells[1, 7] = "Цена";
            sheet.Cells[1, 8] = "Статус";
            var currentRow = 2;
            var orders = Connect.context.Orders.ToList();
            foreach (var item in orders)
            {
                sheet.Cells[currentRow, 1] = item.IdOrder;
                sheet.Cells[currentRow, 2] = item.Sellers.FIO;
                sheet.Cells[currentRow, 3] = item.AutoParts.NameAutoParts;
                sheet.Cells[currentRow, 4] = item.Clients.SurnameClient;
                sheet.Cells[currentRow, 5] = item.DateOrder;
                sheet.Cells[currentRow, 6] = item.Quantity;
                sheet.Cells[currentRow, 7] = item.Price;
                sheet.Cells[currentRow, 8] = item.Stasus;
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

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
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
            var filteredOrders = Connect.context.Orders
                .Where(o => o.DateOrder >= startDate && o.DateOrder <= endDate)
                .ToList();
            OrdersLV.ItemsSource = filteredOrders;
        }

        private void editOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new AddOrderPage((sender as System.Windows.Controls.Button).DataContext as Orders));
        }

        private void searchTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            OrdersLV.ItemsSource = Connect.context.Orders.Where(x => x.IdOrder.ToString().StartsWith(searchTxt.Text)).ToList();
        }

        private void statusCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (statusCbx.SelectedItem != null)
            {
                var selectedStatus = statusCbx.SelectedItem.ToString();
                var filteredOrders = Connect.context.Orders.Where(x => x.Stasus == selectedStatus).ToList();
                OrdersLV.ItemsSource = filteredOrders;
            }
        }

        private async void calcOrder_Click(object sender, RoutedEventArgs e)
        {           
            var orders = await Task.Run(() => Connect.context.Orders.Select(x => new
            {
                x.IdOrder,
                x.IdSeller,
                x.IdAutoPart,
                x.IdClient,
                x.DateOrder,
                x.Stasus,
                x.Price,
                x.Quantity,
                TotalCost = x.Price * x.Quantity
            }).ToList());
            OrdersLV.ItemsSource = orders;          
        }
    }
}
