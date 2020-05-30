using System.Windows;
using System.Windows.Controls;

namespace JxsUI.UIControl
{
    public    class FlatCheckBox:CheckBox
    {
        public FlatCheckBox()
        {
            Style = this.FindResource("FlatCheckbox") as Style;
        }
    }
}
