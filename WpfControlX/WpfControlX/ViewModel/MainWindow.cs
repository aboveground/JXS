using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfControlX.ViewModel
{
  public  class MainWindow:BaseVM
    {
        private EventHandler exitHandler;
        public EventHandler ExitHandler { set { exitHandler = value; } }
       private ICommand exit;
        public ICommand Exit { get { return exit; }set { exit = value; } }

        public MainWindow()
        {
            exit = new RelayCommand(ExcuteExit, CanExecuteExit);
        }

        private bool CanExecuteExit(object parameter)
        {
            return true;
        }

        private void ExcuteExit(object parameter)
        {
            exitHandler?.Invoke(this, EventArgs.Empty);
        }
    }
}
