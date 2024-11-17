using AutoPartsApp.AppDate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    /// Логика взаимодействия для ClientsPage.xaml
    /// </summary>
    public partial class ClientsPage : Page
    {
        Users curUsers = Rights.curUser;
        public ClientsPage()
        {
            InitializeComponent();
            var client = Connect.GetCont().Clients.ToList();
            ClientsLV.ItemsSource = client;
        }

        private void searchTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            ClientsLV.ItemsSource = Connect.context.Clients.Where(x => x.SurnameClient.StartsWith(searchTxt.Text)).ToList();
        }            

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }

        private void addClient_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new AddClientPage(null));
        }

        private void delClient_Click(object sender, RoutedEventArgs e)
        {
            var delClients = ClientsLV.SelectedItems.Cast<Clients>().ToList();
            foreach (var delClient in delClients)
            {
                if (Connect.context.Sales.Any(x => x.IdClient == delClient.IdClient) ||
                    Connect.context.Orders.Any(x => x.IdClient == delClient.IdClient))
                {
                    MessageBox.Show("Данные используются в другой таблице", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (MessageBox.Show($"Удалить {delClients.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Connect.context.Clients.RemoveRange(delClients);
                }
                try
                {
                    Connect.context.SaveChanges();
                    ClientsLV.ItemsSource = Connect.context.Clients.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                var sale = Connect.GetCont().Clients.ToList();
                ClientsLV.ItemsSource = sale;
            }
        }

        private void updateClient_Click(object sender, RoutedEventArgs e)
        {
            var client = Connect.GetCont().Clients.ToList();
            ClientsLV.ItemsSource = client;
        }

        private void reportClient_Click(object sender, RoutedEventArgs e)
        {
            Excel.Application app = new Excel.Application()
            {
                Visible = true,
                SheetsInNewWorkbook = 1
            };
            Excel.Workbook workbook = app.Workbooks.Add(Type.Missing); app.DisplayAlerts = false;
            Excel.Worksheet sheet = (Excel.Worksheet)app.Worksheets.get_Item(1);
            sheet.Name = "Клиенты";
            sheet.Cells[1, 1] = "Id клиента"; sheet.Cells[1, 2] = "Имя клиента"; sheet.Cells[1, 3] = "Фамилия клиента"; sheet.Cells[1, 4] = "Адрес";
            sheet.Cells[1, 5] = "Телефон";
            var currentRow = 2;
            var clients = Connect.context.Clients.ToList();
            foreach (var item in clients)
            {
                sheet.Cells[currentRow, 1] = item.IdClient;
                sheet.Cells[currentRow, 2] = item.NameClient;
                sheet.Cells[currentRow, 3] = item.SurnameClient;
                sheet.Cells[currentRow, 4] = item.Addres;
                sheet.Cells[currentRow, 5] = item.Phone;
                currentRow++;
                Excel.Range range2 = sheet.get_Range("A1", "E1048576"); range2.Cells.Font.Name = "TimesNewRoman"; range2.Cells.Font.Size = 14;
                range2.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                sheet.Columns.ColumnWidth = 48;
                Excel.Range range3 = sheet.get_Range("A1", "E1"); range3.Cells.Font.Name = "TimesNewRoman"; range3.Cells.Font.Size = 14; range3.Cells.Font.Bold = true;
                range3.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                Excel.Borders borders1 = range2.Borders;
                borders1.LineStyle = Excel.XlLineStyle.xlContinuous;
                borders1.Weight = 2d;
            }
        }          

        private void editClientBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new AddClientPage((sender as Button).DataContext as Clients));
        }

        public void UpdateButtonAccess(Users users)
        {
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateButtonAccess(Rights.curUser);
        }

    }
}
