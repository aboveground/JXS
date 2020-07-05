using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace JxsUI.ViewModel
{
    public class MainAreaVM : BaseVM
    {

        private EventHandler OpenHandler;
        private EventHandler SaveHandler;
        private EventHandler SaveAsHandler;
        private EventHandler ExitHandler;
        private EventHandler PrintHandler;

        private double top;
        public double Top
        {
            get { return top; }
            set { top = value; NotifyPropertyChanged(); }
        }
        private double left;
        public double Left
        {
            get { return left; }
            set { left = value; NotifyPropertyChanged(); }
        }

        private double width;
        public double Width
        {
            get { return width; }
            set { width = value; NotifyPropertyChanged(); }
        }
        private double height;
        public double Height
        {
            get { return height; }
            set { height = value; NotifyPropertyChanged(); }
        }

        private System.Windows.GridLength workBenchSplitDistance;
        public System.Windows.GridLength WorkBenchSplitDistance
        {
            get { return workBenchSplitDistance; }
            set { workBenchSplitDistance = value; NotifyPropertyChanged(); }
        }

        private System.Windows.GridLength toolBoxSplitDistance;
        public System.Windows.GridLength ToolBoxSplitDistance
        {
            get { return toolBoxSplitDistance; }
            set { toolBoxSplitDistance = value; NotifyPropertyChanged(); }
        }

        private bool showWorkBench;
        public bool ShowWorkBench { get { return showWorkBench; } set { showWorkBench = value; NotifyPropertyChanged(); } }

        private bool showMessageArea;
        public bool ShowMessageArea { get { return showMessageArea; } set { showMessageArea = value; NotifyPropertyChanged(); } }

        private ICommand exit;
        public ICommand Exit { get { return exit; } set { exit = value; } }

        private ICommand messageAreaShow;
        public ICommand MessageAreaShow { get { return messageAreaShow; } set { messageAreaShow = value; } }

        private ICommand workBenchShow;
        public ICommand WorkBenchShow { get { return workBenchShow; } set { workBenchShow = value; } }

        private ICommand customerMaintenance;
        public ICommand CustomerMaintenance { get { return customerMaintenance; } set { customerMaintenance = value; } }

        private ICommand open;
        public ICommand Open { get { return open; } set { open = value; } }

        private ICommand save;
        public ICommand Save { get { return save; } set { save = value; } }

        private ICommand saveAs;
        public ICommand SaveAs { get { return saveAs; } set { saveAs = value; } }

        private ICommand print;
        public ICommand Print { get { return print; } set { print = value; } }


        public MainAreaVM()
        {
            left = JxsSettings.Default.Left;
            top = JxsSettings.Default.Top;
            width = JxsSettings.Default.Width;
            height = JxsSettings.Default.Height;
            workBenchSplitDistance = new System.Windows.GridLength(JxsSettings.Default.WorkBenchSplitDistance);
            toolBoxSplitDistance = new System.Windows.GridLength(JxsSettings.Default.ToolBoxSplitDistance);
            showWorkBench = JxsSettings.Default.ShowWorkBench;
            showMessageArea = JxsSettings.Default.ShowMessageArea;
            SetupRelays();
        }

        internal void SetDelegates(EventHandler openHandler, EventHandler saveHandler, EventHandler saveAsHandler, EventHandler exitHandler, EventHandler printHandler)
        {
            OpenHandler = openHandler;
            SaveAsHandler = saveAsHandler;
            SaveHandler = saveHandler;
            ExitHandler = exitHandler;
            PrintHandler = printHandler;
        }

        private void SetupRelays()
        {
            open = new RelayCommand(ExecuteOpen, CanExecuteOpen);
            save = new RelayCommand(ExecuteSave, CanExecuteSave);
            saveAs = new RelayCommand(ExecuteSaveAs, CanExecuteSaveAs);
            exit = new RelayCommand(ExecuteExit, CanExecuteExit);
            print = new RelayCommand(ExecutePrint, CanExecutePrint);
        }

        private bool CanExecutePrint(object parameter)
        {
            return true;
        }

        private void ExecutePrint(object parameter)
        {
            PrintHandler?.Invoke(this, EventArgs.Empty);
        }

        private bool CanExecuteSave(object parameter)
        {
            return true;
        }

        private void ExecuteSave(object parameter)
        {
           SaveHandler?.Invoke(this, EventArgs.Empty);
        }

        private bool CanExecuteSaveAs(object parameter)
        {
            return true;
        }

        private void ExecuteSaveAs(object parameter)
        {
            SaveAsHandler?.Invoke(this, EventArgs.Empty);
        }

        private bool CanExecuteExit(object parameter)
        {
            return true;
        }

        private void ExecuteExit(object parameter)
        {
            ExitHandler?.Invoke(this, EventArgs.Empty);
        }

        private bool CanExecuteOpen(object parameter)
        {
            return true;
        }

        private void ExecuteOpen(object parameter)
        {
            OpenHandler?.Invoke(this, EventArgs.Empty);
        }


    }
}
