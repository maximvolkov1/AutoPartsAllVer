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
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void inputBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(loginTxb.Text) || string.IsNullOrEmpty(passwordBx.Password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Rights.curUser = Connect.GetCont().Users.FirstOrDefault(x => x.LoginUser == loginTxb.Text && x.PasswordUser == passwordBx.Password);
            if (Rights.curUser == null)
            {
                MessageBox.Show("Неверное имя пользователя или пароль.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Nav.MFrame.Navigate(new MainPage());
        }

        private void checkPasswordChbx_Checked(object sender, RoutedEventArgs e)
        {
            if (checkPasswordChbx.IsChecked == true)
            {
                loginTxb.Clear();
                passwordBx.Clear();
            }
        }

        private void passwordBx_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                inputBtn_Click(sender, e);
            }
        }
    }
}
