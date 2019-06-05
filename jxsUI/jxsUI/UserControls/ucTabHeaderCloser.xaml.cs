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

namespace jxsUI.UserControls
{
    /// <summary>
    /// Interaction logic for ucTabHeaderCloser.xaml
    /// </summary>
    public partial class ucTabHeaderCloser : UserControl
    {
        public event EventHandler Click;
        public ucTabHeaderCloser()
        {
            InitializeComponent();
        }
        private void OnClick(object sender, RoutedEventArgs e)
        {
            if (Click != null)
            {
                Click(sender, e);
            }
        }

    }
}
