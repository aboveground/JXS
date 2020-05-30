using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace JxsUI.ExtendedDefinitions
{
  public  class GridExtended:Grid
    {
        public static  DependencyProperty SelectedProperty =DependencyProperty.Register("Selected", typeof(Boolean), typeof(object));
        public Boolean Selected
        {
            get
            {
                return (Boolean)this.GetValue(SelectedProperty);
            }
            set
            {
                this.SetValue(SelectedProperty, value);
            }
        }
    }
}
