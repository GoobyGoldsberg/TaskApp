using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class SortByDeadline : ISortBy
    {
        public void SortBy(ListView list_view)
        {
            list_view.ListViewItemSorter = new ListViewItemComparer(2);
            list_view.Sort();
        }
    }
}
