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
    /// Логика взаимодействия для AutoPartsCategoryPage.xaml
    /// </summary>
    public partial class AutoPartsCategoryPage : Page
    {
        public AutoPartsCategoryPage()
        {
            InitializeComponent();
            var autoPartsСategories = Connect.GetCont().AutoPartsСategory.ToList();
            AutoPartCategoryLV.ItemsSource = autoPartsСategories;
        }

        private void addAPC_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new AddAutoPartsCategory(null));
        }

        private void delAPC_Click(object sender, RoutedEventArgs e)
        {
            var delAPCs = AutoPartCategoryLV.SelectedItems.Cast<AutoPartsСategory>().ToList();
            foreach (var delAPC in delAPCs)
            {
                if (Connect.context.AutoParts.Any(x => x.IdAutoPartsСategory == delAPC.IdAutoPartsСategory))
                {
                    MessageBox.Show("Данные используются в другой таблице", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (MessageBox.Show($"Удалить {delAPCs.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Connect.context.AutoPartsСategory.RemoveRange(delAPCs);
                }
                try
                {
                    Connect.context.SaveChanges();
                    AutoPartCategoryLV.ItemsSource = Connect.context.AutoPartsСategory.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                var autoPartsСategories = Connect.GetCont().AutoPartsСategory.ToList();
                AutoPartCategoryLV.ItemsSource = autoPartsСategories;
            }
        }

        private void updateAPC_Click(object sender, RoutedEventArgs e)
        {
            var autoPartsСategories = Connect.GetCont().AutoPartsСategory.ToList();
            AutoPartCategoryLV.ItemsSource = autoPartsСategories;
        }

        private void editAPCBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new AddAutoPartsCategory((sender as Button).DataContext as AutoPartsСategory));
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }

        private void searchTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            AutoPartCategoryLV.ItemsSource = Connect.context.AutoPartsСategory.Where(x => x.NameCategory.StartsWith(searchTxt.Text)).ToList();
        }
    }
}
