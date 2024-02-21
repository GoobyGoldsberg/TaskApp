using MySql.Data.MySqlClient;
using System.Collections;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace WinFormsApp1
{


    public partial class TaskMaker : Form

    {
        private string connectionString = "server=127.0.0.1;uid=root;pwd=Darknes221;database=testdb";
        private static MySqlConnection? connection;


        public TaskMaker()
        {
            InitializeComponent();

            list_view.ColumnClick += list_view_ColumnClick!;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectToDb(connectionString);
            LoadTableData();

        }

        private void ResetInput()
        {

            TextBox.ResetText();
            UrgentTick.Checked = false;
            DateTimePicker.Value = DateTime.Now;
            Deadline.Checked = false;
            addTaskBtn.Enabled = true;
            addTaskBtn.Visible = true;
            UpdateBtn.Enabled = false;
            UpdateBtn.Visible = false;


        }

        private void NewTaskBtn_Click(object sender, EventArgs e)
        {

            ResetInput();

        }

        private string[] CreateTask()
        {
            string taskDesc = TextBox.Text;
            bool isUrgent = UrgentTick.Checked;
            bool isDeadline = Deadline.Checked;
            DateTime taskDate;



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


            string[] taskParts = newTask.ReturnParts();

            return taskParts;



        }

        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length < 1)
            {
                Label.Text = "To-Do field cannot be empty";
                return;
            }

            string[] taskParts = CreateTask();

            string query = "INSERT INTO tasks (taskDesc, isUrgent, taskDate) VALUES (@taskDesc, @isUrgent, @taskDate)";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@taskDesc", taskParts[0]);
                command.Parameters.AddWithValue("@isUrgent", taskParts[1]);
                command.Parameters.AddWithValue("@taskDate", taskParts[2]);

                command.ExecuteNonQuery();
                Console.WriteLine("Inserted");




            }
            LoadTableData();
            ResetInput();



        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            if (list_view.SelectedItems.Count == 0)
            {
                Label.Text = "Please select a Task first";
                return;
            }

            addTaskBtn.Enabled = false;
            addTaskBtn.Visible = false;
            UpdateBtn.Enabled = true;
            UpdateBtn.Visible = true;


        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length < 1)
            {
                Label.Text = "To-Do field cannot be empty";
                return;
            }

            UpdateTask();
            Console.WriteLine("Task Updated");
            LoadTableData();
            ResetInput();

        }

        private void UpdateTask()
        {
            int task_ID = GetSelectedTaskId();


            string[] taskParts = CreateTask();

            string query = "UPDATE tasks SET taskDesc=@taskDesc, isUrgent=@isUrgent, taskDate=@taskDate WHERE task_ID=@task_ID";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("taskDesc", taskParts[0]);
                command.Parameters.AddWithValue("isUrgent", taskParts[1]);
                command.Parameters.AddWithValue("taskDate", taskParts[2]);
                command.Parameters.AddWithValue("task_ID", task_ID);
                command.ExecuteNonQuery();
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (list_view.SelectedItems.Count == 0)
            {
                Label.Text = "Please select a Task first";
                return;
            }
            DeleteTaskFromDb(GetSelectedTaskId());

            list_view.Items.Remove(list_view.SelectedItems[0]);
        }
        private int GetSelectedTaskId()
        {

            return (int)list_view.SelectedItems[0].Tag!;

        }


        private void DeleteTaskFromDb(int taskId)
        {
            int task_ID = GetSelectedTaskId();

            string query = "DELETE from tasks WHERE task_ID = @task_ID";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@task_ID", taskId);
                command.ExecuteNonQuery();
            }

            
            
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

            list_view.Items.Clear();


            string query = "SELECT * FROM tasks";
            using (MySqlCommand command = new MySqlCommand(query, connection))
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




        private void list_view_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column)
            {
                case 0:
                    SortByDescription();
                    break;
                case 1:
                    SortByUrgent();
                    break;
                case 2:
                    SortByDeadline();
                    break;
            }

        }

        private void SortByDescription()
        {
            list_view.ListViewItemSorter = new ListViewItemComparer(0);
            list_view.Sort();
        }


        private void SortByUrgent()
        {
            list_view.ListViewItemSorter = new ListViewItemComparer(1);
            list_view.Sort();
        }

        private void SortByDeadline()
        {
            list_view.ListViewItemSorter = new ListViewItemComparer(2);
            list_view.Sort();
        }

        
    }
}
