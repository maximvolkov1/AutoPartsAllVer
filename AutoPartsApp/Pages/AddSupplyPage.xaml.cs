using AutoPartsApp.AppDate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Логика взаимодействия для AddSupplyPage.xaml
    /// </summary>
    public partial class AddSupplyPage : Page
    {
        static Supply sup;
        bool checkNullSupply;
        public AddSupplyPage(Supply supply)
        {
            InitializeComponent();
            if (supply == null)
            {
                checkNullSupply = true;
                supply = new Supply();
                supply.DateSupply = DateTime.Today;
            }
            else
            {
                checkNullSupply = false;
                supply.DateSupply = DateTime.Today;
            }
            sup = supply;
            DataContext = sup;
        }
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }
        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder err = new StringBuilder();
            if (string.IsNullOrEmpty(sup.IdSupply.ToString()) && sup.IdSupply > 0) err.AppendLine("Код поставки заполнен неверно");
            if (string.IsNullOrEmpty(sup.IdAutoPart.ToString()) && sup.IdAutoPart > 0) err.AppendLine("Код автозапчасти заполнен неверно");
            if (string.IsNullOrEmpty(sup.IdProvider.ToString()) && sup.IdProvider > 0) err.AppendLine("Код поставщика заполнен неверно");          
            if (string.IsNullOrEmpty(sup.Quantity.ToString())) err.AppendLine("Количество заполнено неверно");
            if (string.IsNullOrEmpty(sup.Quantity.ToString())) err.AppendLine("Цена заполнена неверно");
            if (err.Length > 0)
            {
                MessageBox.Show(err.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (checkNullSupply)
                Connect.GetCont().Supply.Add(sup);
            try
            {
                Connect.GetCont().SaveChanges();
                MessageBox.Show("Информация о поставке сохранена", "Сохранение", MessageBoxButton.OK, MessageBoxImage.Information);
                Nav.MFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения " + ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (!dateSupplypkr.SelectedDate.HasValue)
            {
                dateSupplypkr.SelectedDate = DateTime.Today;
            }
        }
    }
}
