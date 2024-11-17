using AutoPartsApp.AppDate;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AddAutoPartPage.xaml
    /// </summary>
    public partial class AddAutoPartPage : Page
    {
        static AutoParts autop;
        bool checkNullAutoParts;
        string pathImage = null;
        public AddAutoPartPage(AutoParts autoParts)
        {
            InitializeComponent();
            if (autoParts == null)
            {
                checkNullAutoParts = true;
                autoParts = new AutoParts();
            }
            else checkNullAutoParts = false;
            autop = autoParts;
            DataContext = autop;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }

        private void imageBtn_Click(object sender, RoutedEventArgs e)
        {
            var d = new OpenFileDialog();
            d.Filter = "Файлы изображений (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            if (d.ShowDialog().GetValueOrDefault(false))
            {
                pathImage = d.FileName;
            }
            imgBox.Source = new BitmapImage(new Uri(pathImage));
        }

        private void clearImageBtn_Click(object sender, RoutedEventArgs e)
        {
            autop.Photo = null;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder err = new StringBuilder();
            if (string.IsNullOrEmpty(autop.IdAutoPart.ToString()) && autop.IdAutoPart > 0) err.AppendLine("Код автозапчасти заполнен неверно");
            if (string.IsNullOrEmpty(autop.NameAutoParts)) err.AppendLine("Название автозапчасти заполнено неверно");
            if (string.IsNullOrEmpty(autop.IdAutoPartsСategory.ToString()) && autop.IdAutoPartsСategory > 0) err.AppendLine("Код категории автозапчасти заполнен неверно");
            if (string.IsNullOrEmpty(autop.NameAutoParts)) err.AppendLine("Название автозапчасти заполнено неверно");
            try
            {
                if (pathImage != null && pathImage.Trim() != "")
                {
                    autop.Photo = File.ReadAllBytes(pathImage);
                }
            }
            catch
            {
                autop.Photo = null;
                err.AppendLine("Ошибка загрузки изображения");
            }
            if (err.Length > 0)
            {
                MessageBox.Show(err.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (checkNullAutoParts)
                Connect.GetCont().AutoParts.Add(autop);
            try
            {
                Connect.GetCont().SaveChanges();
                MessageBox.Show("Информация о автозапчасти сохранена", "Сохранение", MessageBoxButton.OK, MessageBoxImage.Information);
                Nav.MFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения " + ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
