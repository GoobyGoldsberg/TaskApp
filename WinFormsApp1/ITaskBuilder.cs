using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal interface ITaskBuilder
    {

        void AddDesc(string desc);

        void AddIsUrgent(bool isUrgent);

        void AddDate(DateTime? date);

    }
}
