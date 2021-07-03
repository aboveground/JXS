using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace JxsUI.ViewModel
{
  public  class DataVM:BaseVM
    {
        private DateTime dateIn;
        public DateTime DateIn { get { return dateIn; } set { dateIn = value; NotifyPropertyChanged(); } }

        private int createdBy;
        public int CreatedBy { get { return createdBy; } set { createdBy = value;NotifyPropertyChanged(); } }

        private DateTime changeDate;
        public DateTime ChangeDate { get { return changeDate; } set { changeDate = value; NotifyPropertyChanged(); } }

        private int changedBy;
        public int ChangedBy { get { return changedBy; } set { ChangedBy = value; NotifyPropertyChanged(); } }

        private int recStatus;
        public int RecStatus { get { return recStatus; } set { recStatus = value; NotifyPropertyChanged(); } }

        private int id;
        public int Id { get { return id; } set { id = value; NotifyPropertyChanged(); } }
    }
}
