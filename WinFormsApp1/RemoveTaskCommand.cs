using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class RemoveTaskCommand : AbstractCommand
    {
        private int task_ID;

        public RemoveTaskCommand(int task_ID) 
        {
            this.task_ID = task_ID;
        }

        public override void Execute()
        {
            string query = "DELETE from tasks WHERE task_ID = @task_ID";

            using (MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection()))
            {
                command.Parameters.AddWithValue("@task_ID", task_ID);
                command.ExecuteNonQuery();
            }
        }


    }
}
