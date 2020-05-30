using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows;

namespace JxsUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public void  ApplocationStart(object sender, StartupEventArgs el)
        {
            try
            {
                JxsMain main = new JxsMain();
                main.GetMainWindow().Show();
            }
            catch(Exception ex)
            {

            }
            finally
            {

            }
        }
    }
}
