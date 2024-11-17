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

namespace AutoPartsApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для SaleSelectPage.xaml
    /// </summary>
    public partial class SaleSelectPage : Page
    {
        public SaleSelectPage()
        {
            InitializeComponent();
            var sales = Connect.context.Sales.Select(x => new
            {
                x.IdSale,
                x.AutoParts.NameAutoParts,
                x.Sellers.FIO,
                x.Clients.SurnameClient,
                x.DateSale,
                x.Price,
                x.Quantity,
                TotalCost = x.Price * x.Quantity
            }).ToList();
            SalesLV.ItemsSource = sales;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }
    }
}
