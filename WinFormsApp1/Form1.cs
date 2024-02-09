using MySql.Data.MySqlClient;

namespace WinFormsApp1
{       


    public partial class TaskMaker : Form

    {
        private string connectionString = "server=127.0.0.1;uid=root;pwd=Darknes221;database=testdb";
        private static MySqlConnection? connection;
        

        public TaskMaker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectToDb(connectionString);
            LoadTableData();

        }   

        private void NewTaskBtn_Click(object sender, EventArgs e)
        {
            TextBox.ResetText();
            UrgentTick.Checked = false;
            DateTimePicker.Value = DateTime.Now; // Check if it resets properly
            Deadline.Checked = false;

        }

        private void AddTaskBtn_Click(object sender, EventArgs e)
        {


            string query = "INSERT INTO tasks (taskDesc, isUrgent, taskDate) VALUES (@taskDesc, @isUrgent, @taskDate)";

            string taskDesc = TextBox.Text;
            bool isUrgent = UrgentTick.Checked;
            bool isDeadline = Deadline.Checked;
            DateTime taskDate;

            if (taskDesc.Length > 0)
            {

                TaskDirector director = new TaskDirector();
                TaskBuilder builder = new TaskBuilder();
                director.TaskBuilder = builder;

               


                switch ((isUrgent, isDeadline))
                {
                    case (true, true):
                        taskDate = DateTimePicker.Value;
                        director.BuildFullFeaturedTask(taskDesc, isUrgent, taskDate);
                        break;
                    case (true, false):
                        director.BuildAnUrgentTask(taskDesc, isUrgent);
                        break;
                    case (false, true):
                        taskDate = DateTimePicker.Value;
                        director.BuildDeadlinedTask(taskDesc, taskDate);
                        break;
                    case (false, false):
                        director.BuildMinimalViableTask(taskDesc);
                        break;
                }

                Task newTask = builder.GetTask();


                string[] subs = newTask.ReturnParts();



                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@taskDesc", "test");
                    command.Parameters.AddWithValue("@isUrgent", "test");
                    command.Parameters.AddWithValue("@taskDate", "test");
                    Console.WriteLine("Inserted");




                }
                LoadTableData();
                // Test if the task insertion to db is good
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {

        }

        private void Deadline_CheckedChanged(object sender, EventArgs e)
        {
            if (Deadline.Checked)
            {
                DateTimePicker.Visible = true;
            }
            else
            {
                DateTimePicker.Visible = false;
            }
        }

        private void SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UrgentTick_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ConnectToDb(string connectionString)
        {   
            if (connection == null)
            {
                connection = new();
                connection.ConnectionString = connectionString;
                connection.Open();
                Console.WriteLine("Connected to DB");
            }

            
        }

        private void LoadTableData()
        {
            ListView.Items.Clear();
            ListView.Columns.Clear();

            string query = "SELECT taskDesc, isUrgent, taskDate FROM tasks";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["taskDesc"].ToString());
                        item.SubItems.Add(reader["isUrgent"].ToString());
                        item.SubItems.Add(reader["Date"].ToString());

                        ListView.Items.Add(item);
                    }
                }
            }

        }


    }
}
