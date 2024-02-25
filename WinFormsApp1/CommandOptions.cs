using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class CommandOptions
    {
        private ICommand addCommand;
        private ICommand removeCommand;
        private ICommand updateCommand;

        public CommandOptions(ICommand add, ICommand remove, ICommand update)
        {
            this.addCommand = add;
            this.removeCommand = remove;
            this.updateCommand = update;
        }

        public void ClickAdd()
        {
            addCommand.Execute();
        }

        public void ClickRemove()
        {
            removeCommand.Execute();
        }

        public void ClickUpdate()
        {
            updateCommand.Execute();
        }
    }
}
