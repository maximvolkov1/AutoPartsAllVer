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
    /// Логика взаимодействия для AddSellerPage.xaml
    /// </summary>
    public partial class AddSellerPage : Page
    {
        static Sellers sel;
        bool checkNullSeller;
        public AddSellerPage(Sellers sellers)
        {
            InitializeComponent();
            if (sellers == null)
            {
                checkNullSeller = true;
                sellers = new Sellers();
            }
            else checkNullSeller = false;
            sel = sellers;
            DataContext = sel;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrEmpty(sel.IdSeller.ToString()) && sel.IdSeller > 0) errors.AppendLine("Код продавца заполнен неверно");
            if (string.IsNullOrEmpty(sel.IdUser.ToString()) && sel.IdUser > 0) errors.AppendLine("Код пользователя заполнен неверно");
            if (string.IsNullOrEmpty(sel.FIO)) errors.AppendLine("ФИО продавца заполнено неверно");          
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (checkNullSeller)
                Connect.GetCont().Sellers.Add(sel);
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
