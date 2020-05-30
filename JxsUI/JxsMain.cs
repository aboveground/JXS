using JxsUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace JxsUI
{
 public   class JxsMain
    {

        private MainWindow mainWindow;
        private MainWindowVM mainWindowVM;


        public JxsMain()
        {

        }

        public MainWindow GetMainWindow()
        {
            mainWindowVM = new MainWindowVM();
            mainWindow = new MainWindow(mainWindowVM);
            mainWindow.Closing += MainWindow_Closing;
            return mainWindow;

        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CloseApp();
        }

        private void CloseApp()
        {
            if (mainWindowVM != null)
            {
                JxsSettings.Default.Top = mainWindowVM.Top;
                JxsSettings.Default.Left = mainWindowVM.Left;
                JxsSettings.Default.Width = mainWindowVM.Width;
                JxsSettings.Default.Height = mainWindowVM.Height;
                JxsSettings.Default.WorkBenchSplitDistance = mainWindowVM.WorkBenchSplitDistance.Value;
            }
            JxsSettings.Default.Save();
        }

        private void test()
        {
           // System.Windows.Forms f;
        }
    }
}
