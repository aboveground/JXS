using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jxsUI.ViewModels
{
    public class MainWindowVM : BaseVM
    {

        private double mainTop;
        public double MainTop
        {
            get { return mainTop; }
            set
            {
                mainTop = value; NotifyPropertyChanged();
                Properties.Settings.Default.MainTop = value;
            }
        }

        private double mainLeft;
        public double MainLeft
        {
            get { return mainLeft; }
            set
            {
                mainLeft = value; NotifyPropertyChanged();
                Properties.Settings.Default.MainLeft = value;
            }
        }

        private double mainHeight;
        public double MainHeight
        {
            get { return mainHeight; }
            set
            {
                mainHeight = value; NotifyPropertyChanged();
                Properties.Settings.Default.MainHeight = value;
            }
        }

        private double mainWidth;
        public double MainWidth
        {
            get { return mainWidth; }
            set
            {
                mainWidth = value; NotifyPropertyChanged();
                Properties.Settings.Default.MainWidth = value;
            }
        }


        public MainWindowVM()
        {
            mainTop = Properties.Settings.Default.MainTop;
            mainLeft = Properties.Settings.Default.MainLeft;
            mainWidth = Properties.Settings.Default.MainWidth;
            mainHeight = Properties.Settings.Default.MainHeight;
        }

    }
}
