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

namespace WpfForTest3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Random _rand = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeColor_MouseEnter(object sender, MouseEventArgs e)
        {
            this.StateString.Content = "Изменение цвета";
        }

        private void CatalogGoods_OnMouseEnter(object sender, MouseEventArgs e)
        {
            this.StateString.Content = "Каталог товаров";
        }

        private void ServiceCatalog_OnMouseEnter(object sender, MouseEventArgs e)
        {
            this.StateString.Content = "Каталог услуг";
        }

        private void AboutUs_OnMouseEnter(object sender, MouseEventArgs e)
        {
            this.StateString.Content = "О нас";
        }

        private void FindUs_OnMouseEnter(object sender, MouseEventArgs e)
        {
            this.StateString.Content = "Как найти нас";
        }

        private void ChangeColor_MouseLeave(object sender, MouseEventArgs e)
        {
            this.StateString.Content = string.Empty;
        }

        private void Styles_OnMouseEnter(object sender, MouseEventArgs e)
        {
            this.StateString.Content = "Стили";
        }

        private void Links_OnMouseEnter(object sender, MouseEventArgs e)
        {
            this.StateString.Content = "Сслыки";
        }

        private void ChangeColor_OnClick(object sender, RoutedEventArgs e)
        {
            this.DockPanel.Background = new SolidColorBrush(Color.FromRgb((byte)_rand.Next(0, 255), (byte)_rand.Next(0, 255), (byte)_rand.Next(0, 255)));
        }

        private void CatalogGoods_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Каталог товаров");
        }

        private void ServiceCatalog_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Каталог услуг");
        }

        private void AboutUs_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("О нас");
        }

        private void FindUs_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Как найти нас");
        }
    }
}
