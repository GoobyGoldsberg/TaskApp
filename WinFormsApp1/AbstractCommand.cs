using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal abstract class AbstractCommand : ICommand
    {
        protected DbConnection dbConnection = new();
        protected string[]? taskParts;

        public abstract void Execute();
        

    }
}
