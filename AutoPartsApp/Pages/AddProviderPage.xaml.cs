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
    /// Логика взаимодействия для AddProviderPage.xaml
    /// </summary>
    public partial class AddProviderPage : Page
    {
        static Providers pro;
        bool checkNullProvider;
        public AddProviderPage(Providers providers)
        {
            InitializeComponent();
            if (providers == null)
            {
                checkNullProvider = true;
                providers = new Providers();
            }
            else checkNullProvider = false;
            pro = providers;
            DataContext = pro;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrEmpty(pro.IdProvider.ToString()) && pro.IdProvider > 0) errors.AppendLine("Код поставщика заполнен неверно");
            if (string.IsNullOrEmpty(pro.NameProvider)) errors.AppendLine("Наименование поставщика заполнено неверно");
            if (string.IsNullOrEmpty(pro.Addres)) errors.AppendLine("Адрес поставщика заполнен неверно");
            if (string.IsNullOrEmpty(pro.Phone) && pro.Phone.Length != 11) errors.AppendLine("Телефон клиента заполнен неверно");
            if (string.IsNullOrEmpty(pro.Email)) errors.AppendLine("Почта заполнена неверно");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (checkNullProvider)
                Connect.GetCont().Providers.Add(pro);
            try
            {
                Connect.GetCont().SaveChanges();
                MessageBox.Show("Информация о поставщике сохранена", "Сохранение", MessageBoxButton.OK, MessageBoxImage.Information);
                Nav.MFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения " + ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
