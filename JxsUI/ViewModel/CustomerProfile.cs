using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace JxsUI.ViewModel
{
 public partial   class Customer:DataVM
    {

        private ObservableCollection<AddressVM> addresses;
        public ObservableCollection<AddressVM> Addresses { get { return addresses; } set { addresses = value; NotifyPropertyChanged(); } }
    }
}
