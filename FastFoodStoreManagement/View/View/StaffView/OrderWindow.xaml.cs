﻿using Models;
using Services.Interfaces;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using View.Helper;

namespace View.StaffView
{
    /// <summary>
    /// Interaction logic for OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        public OrderWindow()
        {
            InitializeComponent();
            Loaded += OrderWindow_Loaded;
        }

        // Khi cửa sổ được load, khởi tạo dữ liệu ban đầu (danh sách sản phẩm, danh mục,...)
        private void OrderWindow_Loaded(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new OrderPage());
        }
    }
}