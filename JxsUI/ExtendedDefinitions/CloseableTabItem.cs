using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using JxsUI.UIControl;

namespace JxsUI.ExtendedDefinitions
{
    class CloseableTabItem : TabItem
    {
        public delegate void RemoveTabDel(object sender, EventArgs e);
        private RemoveTabDel removeThisTab;
        public void SetHeader(string header)
        {
            var tb = new TextBlock { Text = header };
            var dockPanel = new DockPanel();
            dockPanel.Children.Add(tb);

            // Close button to remove the tab
            var closeButton = new ucTabHeaderCloser();

            closeButton.Click += CloseButton_Click;
            dockPanel.Children.Add(closeButton);

            // Set the header
            Header = dockPanel;

        }
        public void SetDel(RemoveTabDel del)
        {
            removeThisTab = del;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            removeThisTab?.Invoke(this, EventArgs.Empty);
        }
        public object RemoveUC()
        {
            object uc = Content;
            Content = null;
            return uc;

        }
     }
}
