using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace jxsUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private JxsUiMain main;
        void App_Startup(object sender, StartupEventArgs e)
        {
            try
            {
                main = new JxsUiMain();
                main.ShowMainWindow().Show();
            }
            catch(Exception ex)
            {

            }
        }

    }
}
