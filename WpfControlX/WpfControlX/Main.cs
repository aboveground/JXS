using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfControlX
{
    public class Main
    {
 

        public Main()
        {
       
        }

        public Window OnStartup()
        {
            ViewModel.MainWindow vm = new ViewModel.MainWindow { ExitHandler = OnExit };
            Windows.xWindow window = new Windows.xWindow(vm);
            window.Closing += Window_Closing;
            window.ExitHandler = OnExit;
            return window;
        }

        private void OnExit(object sender, EventArgs e)
        {
            Window w = (Window)sender;
            w.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
      //      throw new NotImplementedException();
        }
    }


}
