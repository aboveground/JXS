using System;
using System.Collections.Generic;
using System.Text;

namespace JxsUI.ViewModel
{
    public class AddressVM : DataVM
    {

        private string street;
        public string Street { get { return street; } set { street = value; NotifyPropertyChanged(); } }

        private string street2;
        public string Street2 { get { return street2; } set { street2 = value; NotifyPropertyChanged(); } }

        private string mailStop;
        public string MailStop { get { return mailStop; } set { mailStop = value; NotifyPropertyChanged(); } }

        private string poBox;
        public string POBOX { get { return poBox; } set { poBox = value; NotifyPropertyChanged(); } }
    
        private string city;
        public string City { get { return city; } set { city = value; NotifyPropertyChanged(); } }

        private string state;
        public string State { get { return state; } set { state = value; NotifyPropertyChanged(); } }

        private string postalCode;
        public string PostalCode { get { return postalCode; } set { postalCode = value; NotifyPropertyChanged(); } }

        private string country;
        public string Country { get { return country; } set { country = value; NotifyPropertyChanged(); } }

        private string attention;
        public string Attention { get { return attention; } set { attention = value; NotifyPropertyChanged(); } }

        private int addressType;
        public int AddressType { get { return addressType; } set { addressType = value; NotifyPropertyChanged(); } }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; NotifyPropertyChanged(); }
        }
    }
}
