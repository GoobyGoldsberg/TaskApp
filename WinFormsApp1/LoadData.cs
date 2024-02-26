using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class LoadData
    {
        private DbConnection dbConnection = new();

        public void LoadTasksIntoListView(ListView list_view)
        {
            string query = "SELECT * FROM tasks";
            using (MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection()))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader.GetString(1));
                        item.SubItems.Add(reader.GetString(2));
                        item.SubItems.Add(reader.GetString(3));

                        item.Tag = reader.GetInt32(0);

                        list_view.Items.Add(item);
                    }
                }
            }
        }
    }
}
