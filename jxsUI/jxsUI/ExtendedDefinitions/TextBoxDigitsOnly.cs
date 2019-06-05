using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace jxsUI.ExtendedDefinitions
{
 public   class TextBoxDigitsOnly:TextBox
    {
        public TextBoxDigitsOnly()
        {
            this.KeyDown += TextBoxDigitsOnly_KeyDown;
        }

        private void TextBoxDigitsOnly_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            throw new NotImplementedException();
        }
      
    }
}
