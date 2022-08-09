using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBarTextSizeTester
{
    internal class NextPageTab: ContentPage
    {
        public NextPageTab()
        {
            ToolbarItems.Add(new ToolbarItem("Press me", "", () => { }, ToolbarItemOrder.Secondary));
            Title = "Tab";
            Content = new Label { Text = "NextPageTab" };
        }
    }
}
