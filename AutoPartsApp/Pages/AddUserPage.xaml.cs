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
    /// Логика взаимодействия для AddUserPage.xaml
    /// </summary>
    public partial class AddUserPage : Page
    {
        static Users u;
        bool checkNullUser;
        public AddUserPage(Users users)
        {
            InitializeComponent();
            if (users == null)
            {
                checkNullUser = true;
                users = new Users();
            }
            else checkNullUser = false;
            u = users;
            DataContext = u;
        }
        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrEmpty(u.IdUser.ToString()) && u.IdUser > 0) errors.AppendLine("Код пользователя заполнен неверно");
            if (string.IsNullOrEmpty(u.LoginUser)) errors.AppendLine("Логин пользователя заполнен неверно");
            if (string.IsNullOrEmpty(u.PasswordUser)) errors.AppendLine("Пароль пользователя заполнен неверно");
            if (string.IsNullOrEmpty(u.RoleUser)) errors.AppendLine("Роль пользователя заполнена неверно");           
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (checkNullUser)
                Connect.GetCont().Users.Add(u);
            try
            {
                Connect.GetCont().SaveChanges();
                MessageBox.Show("Информация о пользователе сохранена", "Сохранение", MessageBoxButton.OK, MessageBoxImage.Information);
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
    }
}
