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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Shell
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NewDownloadButton_Click(object sender, RoutedEventArgs e)
        {
            NewDownload window = new NewDownload();
            window.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameContainer.Navigate(new Uri("FramePages/DownloadingPage.xaml", UriKind.Relative));
        }

        private void CompletePageButton_Click(object sender, RoutedEventArgs e)
        {
            FrameContainer.Navigate(new Uri("FramePages/CompletePage.xaml", UriKind.Relative));
        }
    }
}
