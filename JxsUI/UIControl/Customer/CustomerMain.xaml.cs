﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace JxsUI.UIControl.Customer
{
    /// <summary>
    /// Interaction logic for CustomerMain.xaml
    /// </summary>
    public partial class CustomerMain : UserControl
    {
        public CustomerMain()
        {
            InitializeComponent();
        }
        public CustomerMain(ViewModel.Customer c)
        {
            DataContext = c;
            InitializeComponent();
        }
    }
}
