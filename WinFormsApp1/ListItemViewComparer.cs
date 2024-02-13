using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class ListViewItemComparer : IComparer
    {
        private readonly int columnIndex;

        public ListViewItemComparer(int columnIndex)
        {
            this.columnIndex = columnIndex;
        }

        public int Compare(object x, object y)
        {
            ListViewItem itemX = x as ListViewItem;
            ListViewItem itemY = y as ListViewItem;

            return string.Compare(itemX.SubItems[columnIndex].Text,
                                  itemY.SubItems[columnIndex].Text);
        }
    }
}
