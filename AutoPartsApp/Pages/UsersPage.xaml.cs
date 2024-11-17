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
    /// Логика взаимодействия для UsersPage.xaml
    /// </summary>
    public partial class UsersPage : Page
    {
        public UsersPage()
        {
            InitializeComponent();
            var user = Connect.GetCont().Users.ToList();
            UserLV.ItemsSource = user;
        }

        private void addUser_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new AddUserPage(null));
        }

        private void delUser_Click(object sender, RoutedEventArgs e)
        {
            var delUsers = UserLV.SelectedItems.Cast<Users>().ToList();
            foreach (var delUser in delUsers)
            {
                if (Connect.context.Sellers.Any(x => x.IdUser == delUser.IdUser))
                {
                    MessageBox.Show("Данные используются в другой таблице", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (MessageBox.Show($"Удалить {delUsers.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Connect.context.Users.RemoveRange(delUsers);
                }
                try
                {
                    Connect.context.SaveChanges();
                    UserLV.ItemsSource = Connect.context.Users.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                var user = Connect.GetCont().Users.ToList();
                UserLV.ItemsSource = user;
            }
        }

        private void updateUser_Click(object sender, RoutedEventArgs e)
        {
            var user = Connect.GetCont().Clients.ToList();
            UserLV.ItemsSource = user;
        }

        private void editUserBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new AddUserPage((sender as Button).DataContext as Users));
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }
    }
}
