using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class TaskDirector
    {
        private ITaskBuilder? _taskBuilder;

        public ITaskBuilder TaskBuilder
        {
            set { _taskBuilder = value; }
        }

        public void BuildMinimalViableTask(string desc)
        {
            _taskBuilder!.AddDesc(desc);
            _taskBuilder.AddIsUrgent(false);
            _taskBuilder.AddDate(null);

        }

        public void BuildAnUrgentTask(string desc, bool isUrgent)
        {
            _taskBuilder!.AddDesc(desc);
            _taskBuilder.AddIsUrgent(isUrgent);
            _taskBuilder.AddDate(null);
        }

        public void BuildDeadlinedTask(string desc, DateTime date)
        {
            _taskBuilder!.AddDesc(desc);
            _taskBuilder.AddIsUrgent(false);
            _taskBuilder.AddDate(date);
            
        }

        public void BuildFullFeaturedTask(string desc, bool isUrgent, DateTime date)
        {
            _taskBuilder!.AddDesc(desc);
            _taskBuilder.AddIsUrgent(isUrgent);
            _taskBuilder.AddDate(date);
        
        }
        
       

    }
}
