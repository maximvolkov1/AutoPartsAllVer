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
    /// Логика взаимодействия для SupplyPage.xaml
    /// </summary>
    public partial class SupplyPage : Page
    {
        public SupplyPage()
        {
            InitializeComponent();
            var supply = Connect.GetCont().Supply.ToList();
            SupplyLV.ItemsSource = supply;
        }

        private void addSupply_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new AddSupplyPage(null));
        }

        private void delSupply_Click(object sender, RoutedEventArgs e)
        {
            var delSupply = SupplyLV.SelectedItems.Cast<Supply>().ToList();
            if (MessageBox.Show($"Удалить {delSupply.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Connect.context.Supply.RemoveRange(delSupply);
            }
            try
            {
                Connect.context.SaveChanges();
                SupplyLV.ItemsSource = Connect.context.Supply.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            var supply = Connect.GetCont().Supply.ToList();
            SupplyLV.ItemsSource = supply;
        }

        private void updateSupply_Click(object sender, RoutedEventArgs e)
        {
            var supply = Connect.GetCont().Supply.ToList();
            SupplyLV.ItemsSource = supply;
        }

        private void reportSupply_Click(object sender, RoutedEventArgs e)
        {

        }

        private void editSupplyBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new AddSupplyPage((sender as Button).DataContext as Supply));
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
            var filteredSales = Connect.context.Supply
                .Where(o => o.DateSupply >= startDate && o.DateSupply <= endDate)
                .ToList();
            SupplyLV.ItemsSource = filteredSales;
        }
    }
}
