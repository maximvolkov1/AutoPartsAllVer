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
    /// Логика взаимодействия для AddOrderPage.xaml
    /// </summary>
    public partial class AddOrderPage : Page
    {
        static Orders ord;
        bool checkNullOrder;
        public AddOrderPage(Orders orders)
        {
            InitializeComponent();
            statusCbx.ItemsSource = new string[] { "Выполнен", "Отменен" };
            if (orders == null)
            {
                checkNullOrder = true;
                orders = new Orders();
                orders.DateOrder = DateTime.Today;
            }
            else
            {
                checkNullOrder = false;
                orders.DateOrder = DateTime.Today;
            }
            ord = orders;
            DataContext = ord;
        }
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }
        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder err = new StringBuilder();
            if (string.IsNullOrEmpty(ord.IdOrder.ToString()) && ord.IdOrder > 0) err.AppendLine("Код заказа заполнен неверно");
            if (string.IsNullOrEmpty(ord.IdSeller.ToString()) && ord.IdSeller > 0) err.AppendLine("Код продавца заполнен неверно");
            if (string.IsNullOrEmpty(ord.IdAutoPart.ToString()) && ord.IdAutoPart > 0) err.AppendLine("Код автозапчасти заполнен неверно");
            if (string.IsNullOrEmpty(ord.IdClient.ToString()) && ord.IdClient > 0) err.AppendLine("Код клиента заполнен неверно");
            if (string.IsNullOrEmpty(ord.Quantity.ToString())) err.AppendLine("Количество заполнено неверно");
            if (string.IsNullOrEmpty(ord.Price.ToString())) err.AppendLine("Цена указана неверно");
            if (string.IsNullOrEmpty(ord.Stasus)) err.AppendLine("Статус заполнен неверно");
            if (err.Length > 0)
            {
                MessageBox.Show(err.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (checkNullOrder)
                Connect.GetCont().Orders.Add(ord);
            try
            {
                Connect.GetCont().SaveChanges();
                MessageBox.Show("Информация о заказе сохранена", "Сохранение", MessageBoxButton.OK, MessageBoxImage.Information);
                Nav.MFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения " + ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (!dateOrderpkr.SelectedDate.HasValue)
            {
                dateOrderpkr.SelectedDate = DateTime.Today;
            }
        }
    }
}
