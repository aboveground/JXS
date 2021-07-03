using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfControlX.ViewModel;

namespace WpfControlX
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
       // public static Dictionaries.DynamicColors dynamicColors = new Dictionaries.DynamicColors(ColorSettings.Dark());
       private string file= @"c:\testData\colors.xml";
        private ColorSettings colors;
        private void Application_Startup(object sender, StartupEventArgs e)
        {

            try
            {
                colors = ColorSettings.FromFile (file);
                AddDictionary(new Dictionaries.DynamicColors(colors));
                Main main = new Main();
                this.MainWindow = main.OnStartup();
                this.MainWindow.Closed += MainWindow_Closed;
                this.MainWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Application Startup error - " + ex.ToString(), "Application Startup", MessageBoxButton.OK, MessageBoxImage.Error);
                Current.Shutdown();
            }
        }

        private void MainWindow_Closed(object sender, EventArgs e)
        {
          //  Common.WriteToXML(colors, file);
            Shutdown();
        }

        public void AddDictionary(ResourceDictionary d)
        {

            Resources.MergedDictionaries.Add(d);
            
        }
       
    }
}
