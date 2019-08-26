using jxsUI.SupportClasses;
using jxsUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace jxsUI
{
    public class JxsUiMain
    {

        private UISupport uiSupport;
        private MainWindowVM mainWindowVM;

        internal Window ShowMainWindow()
        {
            uiSupport = new UISupport();
            uiSupport.SetHandlers(AppClosing, OnError);
            mainWindowVM = new MainWindowVM();
            return uiSupport.GetMainWindow(mainWindowVM);
        }

        private void OnError(object sender, EventArgs e)
        {

        }

        private void AppClosing(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

    }
}
