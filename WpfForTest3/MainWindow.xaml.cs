using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

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
            int a = 12;
        }

        private void ChangeColor_MouseEnter(object sender, MouseEventArgs e)
        {
            this.StateString.Content = ((MenuItem) sender).Header.ToString();
        }
        private void ChangeColor_MouseLeave(object sender, MouseEventArgs e)
        {
            this.StateString.Content = string.Empty;
        }
        
        private void ChangeColor_OnClick(object sender, RoutedEventArgs e)
        {
            this.DockPanel.Background = new SolidColorBrush(
                Color.FromRgb((byte)_rand.Next(0, 255), (byte)_rand.Next(0, 255), (byte)_rand.Next(0, 255)));
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