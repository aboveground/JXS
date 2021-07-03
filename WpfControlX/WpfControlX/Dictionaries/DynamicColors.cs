using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using WpfControlX.ViewModel;

namespace WpfControlX.Dictionaries
{
    public class DynamicColors : ResourceDictionary
    {

        public DynamicColors()
        {
        }

        public DynamicColors(ColorSettings c)
        {
            SetupColors(c);
        }

        private void SetupColors(ColorSettings colors)
        {
            Dictionary<string, uint> d = colors.GetValueDictionary();
            foreach (KeyValuePair<string, uint> kvp in d)
            {
                this.Add(kvp.Key, NewColor(kvp.Value));
            }
        }

        private Color NewColor(uint value)
        {
            byte[] argb = BitConverter.GetBytes(value);
            return Color.FromArgb(argb[3], argb[2], argb[1], argb[0]);
        }
    }
}
