using jxsUI.ViewModels;
using jxsUI.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jxsUI
{
    internal class UISupport
    {
        private EventHandler MainindowClosingHandler;
        private EventHandler ErrorHAndler;
        private MainWindow mainWindow;
        internal UISupport()
        {

        }

        internal void SetHandlers(EventHandler mainWindowClosing, EventHandler errorHandler)
        {
            MainindowClosingHandler = mainWindowClosing;
            ErrorHAndler = errorHandler;
        }
        internal MainWindow GetMainWindow(MainWindowVM vm)
        {

            if (mainWindow == null)
            {
                mainWindow = new MainWindow(vm);
                mainWindow.Closing += MainWindow_Closing;
            }
            return mainWindow;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainindowClosingHandler?.Invoke(this, EventArgs.Empty);
        }
    }
}