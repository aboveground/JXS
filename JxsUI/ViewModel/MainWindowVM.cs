using System;
using System.Collections.Generic;
using System.Text;

namespace JxsUI.ViewModel
{
    public class MainWindowVM : BaseVM
    {
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


        public MainWindowVM()
        {
            left = JxsSettings.Default.Left;
            top = JxsSettings.Default.Top;
            width = JxsSettings.Default.Width;
            height = JxsSettings.Default.Height;
            workBenchSplitDistance = new System.Windows.GridLength(JxsSettings.Default.WorkBenchSplitDistance);
        }
    }
}
