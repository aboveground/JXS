using System.Windows;
using System.Windows.Controls;

namespace jxsUI.ExtendedDefinitions
{
    public    class FlatCheckBox:CheckBox
    {
        public FlatCheckBox()
        {
            Style = this.FindResource("FlatCheckbox") as Style;
        }
    }
}
