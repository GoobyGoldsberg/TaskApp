using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class SortByUrgent : ISortBy
    {
        public void SortBy(ListView list_view)
        {
            list_view.ListViewItemSorter = new ListViewItemComparer(1);
            list_view.Sort();
        }
    }
}
