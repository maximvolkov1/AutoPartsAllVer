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
    /// Логика взаимодействия для AddAutoPartsCategory.xaml
    /// </summary>
    public partial class AddAutoPartsCategory : Page
    {
        static AutoPartsСategory APС;
        bool checkNullAutoPartsСategory;
        public AddAutoPartsCategory(AutoPartsСategory autoPartsСategory)
        {
            InitializeComponent();
            if (autoPartsСategory == null)
            {
                checkNullAutoPartsСategory = true;
                autoPartsСategory = new AutoPartsСategory();
            }
            else checkNullAutoPartsСategory = false;
            APС = autoPartsСategory;
            DataContext = APС;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrEmpty(APС.IdAutoPartsСategory.ToString()) && APС.IdAutoPartsСategory > 0) errors.AppendLine("Код категории автозапчасти заполнен неверно");
            if (string.IsNullOrEmpty(APС.NameCategory)) errors.AppendLine("Название категории автозапчасти заполнено неверно");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (checkNullAutoPartsСategory)
                Connect.GetCont().AutoPartsСategory.Add(APС);
            try
            {
                Connect.GetCont().SaveChanges();
                MessageBox.Show("Информация о категории сохранена", "Сохранение", MessageBoxButton.OK, MessageBoxImage.Information);
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

        private void namecategorytextbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                saveBtn_Click(sender, e);
            }
        }
    }
}
