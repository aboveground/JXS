using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlX.ViewModel
{
    public class ColorSettings : BaseVM
    {

        private uint mainClientArea;
        public uint xMainClientArea { get { return mainClientArea; } set { mainClientArea = value; NotifyPropertyChanged(); } }

        private uint topbarBackground;
        public uint xTopbarBackground { get { return topbarBackground; } set { topbarBackground = value; NotifyPropertyChanged(); } }

        private uint controlButtonOver;
        public uint xControlButtonOver { get { return controlButtonOver; } set { controlButtonOver = value; NotifyPropertyChanged(); } }

        private uint controlButtonForeground;
        public uint xControlButtonForeground { get { return controlButtonForeground; } set { controlButtonForeground = value; NotifyPropertyChanged(); } }

        private uint controlButtonBackground;
        public uint xControlButtonBackground { get { return controlButtonBackground; } set { controlButtonBackground = value; NotifyPropertyChanged(); } }

        private uint controlButtonPressed;
        public uint xControlButtonPressed { get { return controlButtonPressed; } set { controlButtonPressed = value; NotifyPropertyChanged(); } }

        private uint statusBarBackGround;
        public uint xStatusBarBackGround { get { return statusBarBackGround; } set { statusBarBackGround = value; NotifyPropertyChanged(); } }

        private uint statusBarTextForeground;
        public uint xStatusBarTextForeground { get { return statusBarTextForeground; } set { statusBarTextForeground = value; NotifyPropertyChanged(); } }

        private uint mainWindowBorderColor;
        public uint xMainWindowBorderColor { get { return mainWindowBorderColor; } set { mainWindowBorderColor = value; NotifyPropertyChanged(); } }

        private uint menuForeground;
        public uint xMenuForeground { get { return menuForeground; } set { menuForeground = value; NotifyPropertyChanged(); } }

        private uint menuBackground;
        public uint xMenuBackground { get { return menuBackground; } set { menuBackground = value; NotifyPropertyChanged(); } }

        private uint menuItemForeground;
        public uint xMenuItemForeground { get { return menuItemForeground; } set { menuItemForeground = value; NotifyPropertyChanged(); } }

        private uint menuItemBackground;
        public uint xMenuItemBackground { get { return menuItemBackground; } set { menuItemBackground = value; NotifyPropertyChanged(); } }

        public ColorSettings()
        {

        }

        public static ColorSettings Dark()
        {
            ColorSettings c = new ColorSettings();
            c.xMainClientArea = 0xff112233;
            // c.xMainClientArea = 0xffff0000;
            c.xTopbarBackground = 0xff444444;
            c.xControlButtonOver = 0xff777777;
            c.xControlButtonBackground = 0xff555555;
            c.xControlButtonForeground = 0xffdddd00;
            c.xControlButtonPressed = 0xff777777;
            c.xStatusBarBackGround = 0xffccccff;
            c.xStatusBarTextForeground = 0xffffffff;
            c.xMainWindowBorderColor = 0xff0000ff;
            c.xMenuForeground = 0xffffff00;
            c.xMenuBackground = 0xff444444;
            c.xMenuItemForeground = 0xffffffff;
            c.xMenuItemBackground = 0xff444444;
            return c;
        }


        public static ColorSettings Light()
        {
            ColorSettings c = new ColorSettings();
            c.xMainClientArea = 0;
            c.xTopbarBackground = 0;
            c.xControlButtonOver = 0;
            c.xControlButtonBackground = 0;
            c.xControlButtonForeground = 0;
            c.xControlButtonPressed = 0;
            c.xStatusBarBackGround = 0;
            c.xStatusBarTextForeground = 0;
            c.xMainWindowBorderColor = 0;
            c.xMenuForeground = 0;
            c.xMenuBackground = 0;
            c.xMenuItemForeground = 0;
            c.xMenuItemBackground = 0;

            return c;
        }

        public Dictionary<string, uint> GetValueDictionary()
        {
            Dictionary<string, uint> d = new Dictionary<string, uint>();
            foreach (PropertyInfo pi in GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {

                d.Add(pi.Name, (uint)pi.GetValue(this));
            }
            return d;
        }

        public void SaveColors(ColorSettings c, string file)
        {
            Common.WriteToXML(c, file);
        }


        public static ColorSettings FromFile(string file)
        {
            ColorSettings c = new ColorSettings();
            if (!Common.ReadFromXML(ref c, file))
            {
                c = ColorSettings.Dark();
            }
            return c;
        }
    }
}
