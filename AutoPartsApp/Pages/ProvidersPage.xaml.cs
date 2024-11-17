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
    /// Логика взаимодействия для ProvidersPage.xaml
    /// </summary>
    public partial class ProvidersPage : Page
    {
        public ProvidersPage()
        {
            InitializeComponent();
            var provider = Connect.GetCont().Providers.ToList();
            ProviderLV.ItemsSource = provider;
        }

        private void addProvider_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new AddProviderPage(null));
        }

        private void delProvider_Click(object sender, RoutedEventArgs e)
        {
            var delProviders = ProviderLV.SelectedItems.Cast<Providers>().ToList();
            foreach (var delProvider in delProviders)
            {
                if (Connect.context.Supply.Any(x => x.IdSupply == delProvider.IdProvider))
                {
                    MessageBox.Show("Данные используются в другой таблице", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (MessageBox.Show($"Удалить {delProviders.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Connect.context.Providers.RemoveRange(delProviders);
                }
                try
                {
                    Connect.context.SaveChanges();
                    ProviderLV.ItemsSource = Connect.context.Providers.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                var provider = Connect.GetCont().Providers.ToList();
                ProviderLV.ItemsSource = provider;
            }
        }
        private void updateProvider_Click(object sender, RoutedEventArgs e)
        {
            var provider = Connect.GetCont().Providers.ToList();
            ProviderLV.ItemsSource = provider;
        }

        private void editProviderBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new AddProviderPage((sender as Button).DataContext as Providers));
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }
    }
}
