using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class UpdateTaskCommand : AbstractCommand
    {
        private int task_ID;
        public UpdateTaskCommand(int task_ID, string[] taskParts)
        {
            this.task_ID = task_ID;
            this.taskParts = taskParts;
        }

        public override void Execute()
        {   

            string query = "UPDATE tasks SET taskDesc=@taskDesc, isUrgent=@isUrgent, taskDate=@taskDate WHERE task_ID=@task_ID";

            using (MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection()))
            {
                command.Parameters.AddWithValue("taskDesc", taskParts[0]);
                command.Parameters.AddWithValue("isUrgent", taskParts[1]);
                command.Parameters.AddWithValue("taskDate", taskParts[2]);
                command.Parameters.AddWithValue("task_ID", task_ID);
                command.ExecuteNonQuery();
            }
        }
    }
}
