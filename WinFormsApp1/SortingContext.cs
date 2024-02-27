using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class SortingContext
    {
        private ISortBy sortBy;

        public SortingContext(ISortBy sortBy)
        {
            this.sortBy = sortBy;
        }

        public void SetStrategy(ISortBy sortBy)
        {
            this.sortBy = sortBy;
        }

        public void Sort(ListView list_view)
        {
            sortBy.SortBy(list_view);
        }
    }
}
