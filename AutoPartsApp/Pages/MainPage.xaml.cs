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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void clientsBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new ClientsPage());
        }

        private void providersBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate (new ProvidersPage());
        }

        private void supplyBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new SupplyPage());
        }

        private void autoPartsCategoryBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new AutoPartsCategoryPage());
        }

        private void autoPartBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new AutoPartsPage());
        }

        private void salesBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new SalesPage());
        }

        private void ordersBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new OrdersPage());
        }

        private void sellersBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new SellersPage());
        }

        private void usersBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new UsersPage());
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }
        public void UpdateButtonAccess(Users users)
        {

            if (users.RoleUser == "Администратор")
            {
                usersBtn.Visibility = Visibility.Visible;
                sellersBtn.Visibility = Visibility.Visible;
            }
            else if (users.RoleUser == "Продавец")
            {
                usersBtn.Visibility = Visibility.Collapsed;
                sellersBtn.Visibility = Visibility.Collapsed;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateButtonAccess(Rights.curUser);
        }
    }
}
