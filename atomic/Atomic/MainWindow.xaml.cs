using Atomic.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Atomic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
        void hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://atomicheart.vkplay.ru/"); //открытие ссылки в браузере

        }
        private void Move_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void AboutUs_Click(object sender, RoutedEventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
            Close();
        }
        private void Multimedia_Click(object sender, RoutedEventArgs e)
        {
            Multimedia multimedia = new Multimedia();
            multimedia.Show();
            Close();
        }
    }
}

