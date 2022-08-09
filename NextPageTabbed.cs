using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBarTextSizeTester
{
    internal class NextPageTabbed : TabbedPage
    {
        public NextPageTabbed()
        {
            Children.Add(new NextPageTab());
            Children.Add(new NextPageTab());
        }
    }
}
