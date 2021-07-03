using System;
using System.Collections.Generic;
using System.Text;

namespace JxsUI.ViewModel
{
  public partial   class Customer:DataVM
    {
        private string name;
        public string Name { get { return name; } set { name = value; NotifyPropertyChanged(); } }

        private string code;
        public string Code { get { return code; } set { code = value; NotifyPropertyChanged(); } }

        private string division;
        public string Division { get { return division; } set { division = value; NotifyPropertyChanged(); } }

        private int mailAddress;
        public int MailAddress { get { return mailAddress; } set { mailAddress = value;NotifyPropertyChanged(); } }

        private int shipTo;
        public int ShipTo { get { return shipTo; } set { shipTo = value; NotifyPropertyChanged(); } }

        private int billTo;
        public int BillTo { get { return billTo; } set { billTo = value; NotifyPropertyChanged(); } }

        private int payTo;
        public int PayTo { get { return payTo; } set { payTo = value; NotifyPropertyChanged(); } }

        private string taxId;
        public string TaxId { get { return taxId; } set { taxId = value; NotifyPropertyChanged(); } }

        private string duns;
        public string Duns { get { return duns; } set { duns = value; NotifyPropertyChanged(); } }

        private int accountStatus;
        public int AccountStatus { get { return accountStatus; } set { accountStatus = value; NotifyPropertyChanged(); } }

        private int businessType;
        public int BusinessType { get { return businessType; } set { businessType = value;NotifyPropertyChanged(); } }

        public Customer()
        {
            Name = "Test Customer One";
            Code = "TCO";
            Division = "West Coast Ops.";
            MailAddress = 1;
            ShipTo = 2;
            BillTo = 3;
            PayTo = 4;
            Duns = "X12345";
            AccountStatus = 1;
            BusinessType = 1;
            TaxId = "S334-034";
            addresses = new System.Collections.ObjectModel.ObservableCollection<AddressVM>();
            addresses.Add(new AddressVM { Attention = "Bob T.", City = "Saint Luis", State = "IL", Street = "123 ArtyRoad", PostalCode="93115", AddressType=1 });
            addresses.Add(new AddressVM { Attention = "Bob W.", City = "Los Angeles", State = "CA", Street = "123 Bishop Pl." ,PostalCode="88547", AddressType =0 });
            addresses.Add(new AddressVM { Attention = "Bob Z.", City = "Denver", State = "CO", Street = "123 East St." , PostalCode ="96325", AddressType=3});
        }

    }
}
