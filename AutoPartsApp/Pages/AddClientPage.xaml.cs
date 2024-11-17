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
    /// Логика взаимодействия для AddClientPage.xaml
    /// </summary>
    public partial class AddClientPage : Page
    {
        static Clients cli;
        bool checkNullClient;
        public AddClientPage(Clients clients)
        {
            InitializeComponent();
            if (clients == null)
            {
                checkNullClient = true;
                clients = new Clients();
            }
            else checkNullClient = false;
            cli = clients;
            DataContext = cli;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrEmpty(cli.IdClient.ToString()) && cli.IdClient > 0) errors.AppendLine("Код клиента заполнен неверно");
            if (string.IsNullOrEmpty(cli.NameClient)) errors.AppendLine("Имя клиента заполнено неверно");
            if (string.IsNullOrEmpty(cli.SurnameClient)) errors.AppendLine("Фамилия клиента указана неверно");
            if (string.IsNullOrEmpty(cli.Addres)) errors.AppendLine("Адрес клиента заполнен неверно");
            if (string.IsNullOrEmpty(cli.Phone) && cli.Phone.Length != 11) errors.AppendLine("Телефон клиента заполнен неверно");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (checkNullClient)
                Connect.GetCont().Clients.Add(cli);
            try
            {
                Connect.GetCont().SaveChanges();
                MessageBox.Show("Информация о клиенте сохранена", "Сохранение", MessageBoxButton.OK, MessageBoxImage.Information);
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
