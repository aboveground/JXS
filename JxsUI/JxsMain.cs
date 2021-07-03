using JxsUI.UIControl;
using JxsUI.UIControl.Customer;
using JxsUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace JxsUI
{
    public class JxsMain
    {

        private MainWindow mainWindow;
        private MainAreaVM mainAreaVM;


        public JxsMain()
        {

        }

        public Window GetMainWindow()
        {
            mainWindow = new MainWindow(new MainWorkArea(SetupMainAreaVM()));
            mainWindow.Closing += MainWindow_Closing;
            
            return mainWindow;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CloseApp();
        }

        private void CloseApp()
        {
            if (mainAreaVM != null)
            {
                JxsSettings.Default.Top = mainAreaVM.Top;
                JxsSettings.Default.Left = mainAreaVM.Left;
                JxsSettings.Default.Width = mainAreaVM.Width;
                JxsSettings.Default.Height = mainAreaVM.Height;
                JxsSettings.Default.WorkBenchSplitDistance = mainAreaVM.WorkBenchSplitDistance.Value;
                JxsSettings.Default.ToolBoxSplitDistance = mainAreaVM.ToolBoxSplitDistance.Value;
                JxsSettings.Default.ShowMessageArea = mainAreaVM.ShowMessageArea;
                JxsSettings.Default.ShowWorkBench = mainAreaVM.ShowWorkBench;
            }
            JxsSettings.Default.Save();
        }

        private MainAreaVM SetupMainAreaVM()
        {
            mainAreaVM = new MainAreaVM();
            mainAreaVM.SetDelegates(OnOpen, OnSave, OnSaveAs, OnExit, OnPrint, test);
            return mainAreaVM;

        }

        private void test(object sender, EventArgs e)
        {
            Customer c = new Customer();
            CustomerMain cm = new CustomerMain(c);
            TabItem t = new TabItem();
            t.Content = cm;
            mainAreaVM.AddToRightArea(t);
          //  mainWindow.A
        }

        private void OnCustomermain(object sensder, EventArgs e)
        {

        }

        private void OnSave(object sensder, EventArgs e)
        {

        }
        private void OnSaveAs(object sender, EventArgs e)
        {

        }

        private void OnPrint(object sender, EventArgs e)
        {

        }

        private void OnOpen(object sender, EventArgs e)
        {

        }

        private void OnExit(object sender, EventArgs e)
        {
            mainWindow.Close();
        }

    }
}
