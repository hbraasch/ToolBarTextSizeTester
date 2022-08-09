using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBarTextSizeTester
{
    internal class StartupPage: ContentPage
    {
        public StartupPage()
        {
            ToolbarItems.Add(new ToolbarItem("Press me", "", () => {
                Navigation.PushAsync(new NextPageTabbed());
            }, ToolbarItemOrder.Secondary));
            Content = new Label { Text = "StartupPage" };
        }
    }
}
