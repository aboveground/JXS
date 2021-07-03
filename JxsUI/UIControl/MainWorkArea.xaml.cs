using JxsUI.ViewModel;
using System;
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

namespace JxsUI.UIControl
{
    /// <summary>
    /// Interaction logic for MainWorkArea.xaml
    /// </summary>
    public partial class MainWorkArea : UserControl
    {
        public MainWorkArea(MainAreaVM vm)
        {
            DataContext = vm;
            InitializeComponent();
        }


    }
}
