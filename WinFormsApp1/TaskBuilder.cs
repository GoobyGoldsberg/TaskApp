using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class TaskBuilder : ITaskBuilder
    {
        private Task _task = new Task();
   

        public TaskBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._task = new Task();
        }

        public void AddDate(DateTime? date)
        {
            string formattedDate = date.HasValue ? date.Value.ToString() : "No Date";
            this._task.Add(formattedDate.ToString());
        }

        public void AddDesc(string desc)
        {
            this._task.Add(desc);
        }

        public void AddIsUrgent(bool isUrgent)
        {
            this._task.Add(isUrgent ? "true" : "false");
        }

        

        public Task GetTask()
        {
            Task result = this._task;

            this.Reset();

            return result;
        }
       

        // DateTime date = new DateTime(2023, 3, 11, 10, 30, 0); 
        // string formattedDate1 = date.ToString("d");  "3/11/2023" 

    }
}
