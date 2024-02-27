using MySql.Data.MySqlClient;
using System.Collections;
using System.Security.AccessControl;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace WinFormsApp1
{


    public partial class TaskMaker : Form

    {
        private static DbConnection dbConnection = new();
        private ICommand? addCommand;
        private ICommand? removeCommand;
        private ICommand? updateCommand;

        public TaskMaker()
        {
            InitializeComponent();

            list_view.ColumnClick += list_view_ColumnClick!;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dbConnection.ConnectToDb();
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

            CreateCommand createTask = new CreateCommand(taskDesc, isUrgent, isDeadline, DateTimePicker);

            string[] newTask = createTask.Execute();

            return newTask;


        }

        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length < 1)
            {
                Label.Text = "To-Do field cannot be empty";
                return;
            }
            string[] newTask = CreateTask();
            addCommand = new AddTaskCommand(newTask);
            addCommand.Execute();
            
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

            string[] newTask = CreateTask();
            int selectedTask = GetSelectedTaskId();
            updateCommand = new UpdateTaskCommand(selectedTask, newTask);
            updateCommand.Execute();

            Console.WriteLine("Task Updated");
            LoadTableData();
            ResetInput();

        }


        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (list_view.SelectedItems.Count == 0)
            {
                Label.Text = "Please select a Task first";
                return;
            }

            removeCommand = new RemoveTaskCommand(GetSelectedTaskId());
            removeCommand.Execute();

            list_view.Items.Remove(list_view.SelectedItems[0]);
        }

        private int GetSelectedTaskId()
        {

            return (int)list_view.SelectedItems[0].Tag!;

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


        private void LoadTableData()
        {

            list_view.Items.Clear();
            LoadData loadData = new LoadData();
            loadData.LoadTasksIntoListView(list_view);
 
        }

        private void list_view_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ISortBy strategy;

            switch (e.Column)
            {
                case 0:
                    strategy = new SortByDescription();
                    strategy.SortBy(list_view);
                    break;
                case 1:
                    strategy = new SortByUrgent();
                    strategy.SortBy(list_view);
                    break;
                case 2:
                    strategy = new SortByDeadline();
                    strategy.SortBy(list_view);
                    break;
            }

        }

        
        
    }
}
