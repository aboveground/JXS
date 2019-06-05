using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using jxsUI.UserControls;

namespace jxsUI.ExtendedDefinitions
{
  public  class CloseableTabItem : TabItem
    {
        public delegate void RemoveTabDel(object sender, EventArgs e);
        private RemoveTabDel removeThisTab;
        private EventHandler PutInWindowHandler;
        private string headerText;
        public void SetHeader(string header)
        {
            headerText = header;
            var tb = new TextBlock { Text = header };
            var dockPanel = new DockPanel();
            dockPanel.Children.Add(tb);

            // Close button to remove the tab
            var closeButton = new ucTabHeaderCloser();

            closeButton.Click += CloseButton_Click;
            dockPanel.Children.Add(closeButton);
            this.MouseDoubleClick += CloseableTabItem_MouseDoubleClick;
            // Set the header
            Header = dockPanel;

        }

        private void CloseableTabItem_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            PutInWindowHandler?.Invoke(this, EventArgs.Empty);
        }

        public string GetHeaderText() { return headerText; }

        public void SetDel(RemoveTabDel del, EventHandler putInWindow)
        {
            removeThisTab = del;
            PutInWindowHandler = putInWindow;
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
