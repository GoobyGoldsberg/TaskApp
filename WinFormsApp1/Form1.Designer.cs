namespace WinFormsApp1
{
    partial class TaskMaker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Desc = new ColumnHeader();
            isUrgent = new ColumnHeader();
            Deadl = new ColumnHeader();
            newTaskBtn = new Button();
            editBtn = new Button();
            removeBtn = new Button();
            addTaskBtn = new Button();
            TextBox = new TextBox();
            UrgentTick = new CheckBox();
            SortByBox = new ComboBox();
            DateTimePicker = new DateTimePicker();
            Deadline = new CheckBox();
            ListView = new ListView();
            SuspendLayout();
            // 
            // Desc
            // 
            Desc.Tag = "";
            Desc.Text = "Desc";
            Desc.Width = 180;
            // 
            // isUrgent
            // 
            isUrgent.Tag = "";
            isUrgent.Text = "isUrgent";
            // 
            // Deadl
            // 
            Deadl.Tag = "";
            Deadl.Text = "Deadline";
            Deadl.Width = 93;
            // 
            // newTaskBtn
            // 
            newTaskBtn.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            newTaskBtn.Location = new Point(12, 58);
            newTaskBtn.Name = "newTaskBtn";
            newTaskBtn.Size = new Size(75, 23);
            newTaskBtn.TabIndex = 0;
            newTaskBtn.Text = "New Task";
            newTaskBtn.UseVisualStyleBackColor = true;
            newTaskBtn.Click += NewTaskBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(12, 166);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(75, 23);
            editBtn.TabIndex = 1;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += EditBtn_Click;
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(269, 166);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(75, 23);
            removeBtn.TabIndex = 2;
            removeBtn.Text = "Remove";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += RemoveBtn_Click;
            // 
            // addTaskBtn
            // 
            addTaskBtn.Location = new Point(266, 58);
            addTaskBtn.Name = "addTaskBtn";
            addTaskBtn.Size = new Size(75, 23);
            addTaskBtn.TabIndex = 3;
            addTaskBtn.Text = "Add Task";
            addTaskBtn.UseVisualStyleBackColor = true;
            addTaskBtn.Click += AddTaskBtn_Click;
            // 
            // TextBox
            // 
            TextBox.Font = new Font("Segoe UI", 16F);
            TextBox.Location = new Point(10, 12);
            TextBox.MaxLength = 23;
            TextBox.Multiline = true;
            TextBox.Name = "TextBox";
            TextBox.PlaceholderText = "To-Do";
            TextBox.Size = new Size(334, 40);
            TextBox.TabIndex = 4;
            TextBox.TextAlign = HorizontalAlignment.Center;
            TextBox.TextChanged += TextBox_TextChanged;
            // 
            // UrgentTick
            // 
            UrgentTick.AutoSize = true;
            UrgentTick.BackColor = Color.Gainsboro;
            UrgentTick.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            UrgentTick.ForeColor = Color.Crimson;
            UrgentTick.Location = new Point(142, 58);
            UrgentTick.Name = "UrgentTick";
            UrgentTick.Size = new Size(66, 19);
            UrgentTick.TabIndex = 6;
            UrgentTick.Text = "Urgent";
            UrgentTick.UseVisualStyleBackColor = false;
            UrgentTick.CheckedChanged += UrgentTick_CheckedChanged;
            // 
            // SortByBox
            // 
            SortByBox.FormattingEnabled = true;
            SortByBox.Items.AddRange(new object[] { "Urgent", "Deadline", "New" });
            SortByBox.Location = new Point(142, 166);
            SortByBox.Name = "SortByBox";
            SortByBox.Size = new Size(66, 23);
            SortByBox.TabIndex = 7;
            SortByBox.Text = "Sort by";
            SortByBox.SelectedIndexChanged += SortBy_SelectedIndexChanged;
            // 
            // DateTimePicker
            // 
            DateTimePicker.Location = new Point(243, 87);
            DateTimePicker.MinDate = new DateTime(2024, 1, 29, 0, 0, 0, 0);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(98, 23);
            DateTimePicker.TabIndex = 8;
            DateTimePicker.Visible = false;
            DateTimePicker.ValueChanged += DateTimePicker_ValueChanged;
            // 
            // Deadline
            // 
            Deadline.Location = new Point(142, 87);
            Deadline.Name = "Deadline";
            Deadline.Size = new Size(78, 23);
            Deadline.TabIndex = 9;
            Deadline.Text = "Deadline";
            Deadline.UseVisualStyleBackColor = true;
            Deadline.CheckedChanged += Deadline_CheckedChanged;
            // 
            // ListView
            // 
            ListView.Columns.AddRange(new ColumnHeader[] { Desc, isUrgent, Deadl });
            ListView.GridLines = true;
            ListView.HoverSelection = true;
            ListView.Location = new Point(10, 205);
            ListView.MultiSelect = false;
            ListView.Name = "ListView";
            ListView.Size = new Size(334, 238);
            ListView.TabIndex = 10;
            ListView.TileSize = new Size(10, 10);
            ListView.UseCompatibleStateImageBehavior = false;
            ListView.View = View.Details;
            ListView.SelectedIndexChanged += ListView_SelectedIndexChanged;
            // 
            // TaskMaker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(353, 455);
            Controls.Add(ListView);
            Controls.Add(Deadline);
            Controls.Add(DateTimePicker);
            Controls.Add(SortByBox);
            Controls.Add(UrgentTick);
            Controls.Add(TextBox);
            Controls.Add(addTaskBtn);
            Controls.Add(removeBtn);
            Controls.Add(editBtn);
            Controls.Add(newTaskBtn);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "TaskMaker";
            Text = "Tasks";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button newTaskBtn;
        private Button editBtn;
        private Button removeBtn;
        private Button addTaskBtn;
        private TextBox TextBox;
        private CheckBox UrgentTick;
        private ComboBox SortByBox;
        private DateTimePicker DateTimePicker;
        private CheckBox Deadline;
        private ListView ListView;
        private ColumnHeader Desc;
        private ColumnHeader isUrgent;
        private ColumnHeader Deadl;
    }
}
