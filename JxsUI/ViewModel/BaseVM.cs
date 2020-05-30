using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace JxsUI.ViewModel
{
    public class BaseVM : INotifyPropertyChanged

    {

        #region INOTIFYPROPERTYCHANGE
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
