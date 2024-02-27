using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class CreateCommand
    {
        private string taskDesc;
        private bool isUrgent;
        private bool isDeadline;
        private DateTime taskDate;
        private DateTimePicker dateTimePicker;
        private string[]? taskParts;

        public CreateCommand(string taskDesc, bool isUrgent, bool isDeadline, DateTimePicker dateTimePicker)
        {
            this.taskDesc = taskDesc;
            this.isUrgent = isUrgent;
            this.isDeadline = isDeadline;
            this.dateTimePicker = dateTimePicker;
        }

        public string[] Execute()
        {
            TaskDirector director = new TaskDirector();
            TaskBuilder builder = new TaskBuilder();
            director.TaskBuilder = builder;

            switch ((isUrgent, isDeadline))
            {
                case (true, true):
                    taskDate = dateTimePicker.Value;
                    director.BuildFullFeaturedTask(taskDesc, isUrgent, taskDate);
                    break;
                case (true, false):
                    director.BuildAnUrgentTask(taskDesc, isUrgent);
                    break;
                case (false, true):
                    taskDate = dateTimePicker.Value;
                    director.BuildDeadlinedTask(taskDesc, taskDate);
                    break;
                case (false, false):
                    director.BuildMinimalViableTask(taskDesc);
                    break;
            }

            Task newTask = builder.GetTask();


            taskParts = newTask.ReturnParts();

            return taskParts;
        }

       

       


    }
}
