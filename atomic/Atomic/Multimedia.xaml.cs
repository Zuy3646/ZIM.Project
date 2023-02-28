﻿using System;
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
using System.Windows.Shapes;

namespace Atomic
{
    /// <summary>
    /// Логика взаимодействия для Multimedia.xaml
    /// </summary>
    public partial class Multimedia : Window
    {
        public Multimedia()
        {
            InitializeComponent();
        }
        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void MainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
        private void Move_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}