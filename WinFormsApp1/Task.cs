using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Task
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string[] ReturnParts()
        {   
            Console.WriteLine("Parts: " +  _parts);
            return _parts.ToArray();
        }
    }
}
