using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class AddTaskCommand : AbstractCommand
    {

        public AddTaskCommand(string[] taskParts)
        {
            base.taskParts = taskParts;
        }

        public override void Execute()
        {
            if (taskParts == null)
            {
                return;
            }

            string query = "INSERT INTO tasks (taskDesc, isUrgent, taskDate) VALUES (@taskDesc, @isUrgent, @taskDate)";

            using (MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection()))
            {
                command.Parameters.AddWithValue("@taskDesc", taskParts[0]);
                command.Parameters.AddWithValue("@isUrgent", taskParts[1]);
                command.Parameters.AddWithValue("@taskDate", taskParts[2]);

                command.ExecuteNonQuery();
                Console.WriteLine("Inserted");

            }
        }
    }
    
}
