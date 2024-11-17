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
    /// Логика взаимодействия для AddSalePage.xaml
    /// </summary>
    public partial class AddSalePage : Page
    {
        static Sales sa;
        bool checkNullSale;
        public AddSalePage(Sales sales)
        {
            InitializeComponent();
            if (sales == null)
            {
                checkNullSale = true;
                sales = new Sales();
                sales.DateSale = DateTime.Today;
            }
            else
            {
                checkNullSale = false;
                sales.DateSale = DateTime.Today;
            }
            sa = sales;
            DataContext = sa;
        }
        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder err = new StringBuilder();
            if (string.IsNullOrEmpty(sa.IdSale.ToString()) && sa.IdSale > 0) err.AppendLine("Код продажи заполнен неверно");
            if (string.IsNullOrEmpty(sa.IdAutoPart.ToString()) && sa.IdAutoPart > 0) err.AppendLine("Код автозапчасти заполнен неверно");
            if (string.IsNullOrEmpty(sa.IdSeller.ToString()) && sa.IdSeller > 0) err.AppendLine("Код продавца заполнен неверно");
            if (string.IsNullOrEmpty(sa.IdClient.ToString()) && sa.IdClient > 0) err.AppendLine("Код клиента заполнен неверно");
            if (string.IsNullOrEmpty(sa.Quantity.ToString())) err.AppendLine("Количество заполнено неверно");
            if (string.IsNullOrEmpty(sa.Price.ToString())) err.AppendLine("Цена указана неверно");
            if (err.Length > 0)
            {
                MessageBox.Show(err.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (checkNullSale)
                Connect.GetCont().Sales.Add(sa);
            try
            {
                Connect.GetCont().SaveChanges();
                MessageBox.Show("Информация о продаже сохранена", "Сохранение", MessageBoxButton.OK, MessageBoxImage.Information);
                Nav.MFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения " + ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (!dateSalepkr.SelectedDate.HasValue)
            {
                dateSalepkr.SelectedDate = DateTime.Today;
            }
        }
    }
}
