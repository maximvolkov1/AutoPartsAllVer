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
    /// Логика взаимодействия для SellersPage.xaml
    /// </summary>
    public partial class SellersPage : Page
    {
        public SellersPage()
        {
            InitializeComponent();
            var seller = Connect.GetCont().Sellers.ToList();
            SellerLV.ItemsSource = seller;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }

        private void editSellerBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new AddSellerPage((sender as Button).DataContext as Sellers));
        }

        private void addSeller_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new AddSellerPage(null));
        }

        private void delSeller_Click(object sender, RoutedEventArgs e)
        {
            var delSellers = SellerLV.SelectedItems.Cast<Sellers>().ToList();
            foreach (var delSeller in delSellers)
            {
                if (Connect.context.Sales.Any(x => x.IdSeller == delSeller.IdSeller) ||
                    Connect.context.Orders.Any(x => x.IdSeller == delSeller.IdSeller))
                {
                    MessageBox.Show("Данные используются в другой таблице", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (MessageBox.Show($"Удалить {delSellers.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Connect.context.Sellers.RemoveRange(delSellers);
                }
                try
                {
                    Connect.context.SaveChanges();
                    SellerLV.ItemsSource = Connect.context.Sellers.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                var seller = Connect.GetCont().Sellers.ToList();
                SellerLV.ItemsSource = seller;
            }
        }

        private void updateSeller_Click(object sender, RoutedEventArgs e)
        {
            var seller = Connect.GetCont().Sellers.ToList();
            SellerLV.ItemsSource = seller;
        }
    }
}
