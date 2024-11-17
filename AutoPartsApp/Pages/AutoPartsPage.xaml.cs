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
    /// Логика взаимодействия для AutoPartsPage.xaml
    /// </summary>
    public partial class AutoPartsPage : Page
    {
        public AutoPartsPage()
        {
            InitializeComponent();
            APCcbx.ItemsSource = Connect.context.AutoPartsСategory.ToList();
            var autoParts = Connect.GetCont().AutoParts.ToList();
            AutoPartLV.ItemsSource = autoParts;
        }

        private void searchTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            AutoPartLV.ItemsSource = Connect.context.AutoParts.Where(x => x.NameAutoParts.StartsWith(searchTxt.Text)).ToList();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }

        private void editAutoPartBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new AddAutoPartPage((sender as Button).DataContext as AutoParts));
        }

        private void addAutoPart_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new AddAutoPartPage(null));
        }

        private void delAutoPart_Click(object sender, RoutedEventArgs e)
        {
            var delAutoParts = AutoPartLV.SelectedItems.Cast<AutoParts>().ToList();
            foreach (var delAutoPart in delAutoParts)
            {
                if (Connect.context.Sales.Any(x => x.IdAutoPart == delAutoPart.IdAutoPart) ||
                    Connect.context.Orders.Any(x => x.IdAutoPart == delAutoPart.IdAutoPart) ||
                    Connect.context.Supply.Any(x => x.IdAutoPart == delAutoPart.IdAutoPart))
                {
                    MessageBox.Show("Данные используются в другой таблице", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (MessageBox.Show($"Удалить {delAutoParts.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Connect.context.AutoParts.RemoveRange(delAutoParts);
                }
                try
                {
                    Connect.context.SaveChanges();
                    AutoPartLV.ItemsSource = Connect.context.AutoParts.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                var autoParts = Connect.GetCont().AutoParts.ToList();
                AutoPartLV.ItemsSource = autoParts;
            }
        }

        private void updateAutoPart_Click(object sender, RoutedEventArgs e)
        {
            var autoParts = Connect.GetCont().AutoParts.ToList();
            AutoPartLV.ItemsSource = autoParts;
        }

        private void APCcbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (APCcbx.SelectedItem != null)
            {
                var selectedCategory = (AutoPartsСategory)APCcbx.SelectedItem;
                var filteredAutoParts = Connect.context.AutoParts
                    .Include("AutoPartsСategory")
                    .Where(ap => ap.AutoPartsСategory.NameCategory == selectedCategory.NameCategory)
                    .ToList();
                AutoPartLV.ItemsSource = filteredAutoParts;
            }
        }
    }
}
