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
            DateTimePicker = new DateTimePicker();
            Deadline = new CheckBox();
            list_view = new ListView();
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
            newTaskBtn.Location = new Point(22, 58);
            newTaskBtn.Name = "newTaskBtn";
            newTaskBtn.Size = new Size(75, 23);
            newTaskBtn.TabIndex = 0;
            newTaskBtn.Text = "New Task";
            newTaskBtn.UseVisualStyleBackColor = true;
            newTaskBtn.Click += NewTaskBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(22, 166);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(75, 23);
            editBtn.TabIndex = 1;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += EditBtn_Click;
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(279, 166);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(75, 23);
            removeBtn.TabIndex = 2;
            removeBtn.Text = "Remove";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += RemoveBtn_Click;
            // 
            // addTaskBtn
            // 
            addTaskBtn.Location = new Point(276, 58);
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
            TextBox.Location = new Point(22, 12);
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
            UrgentTick.Location = new Point(152, 58);
            UrgentTick.Name = "UrgentTick";
            UrgentTick.Size = new Size(66, 19);
            UrgentTick.TabIndex = 6;
            UrgentTick.Text = "Urgent";
            UrgentTick.UseVisualStyleBackColor = false;
            UrgentTick.CheckedChanged += UrgentTick_CheckedChanged;
            // 
            // DateTimePicker
            // 
            DateTimePicker.Location = new Point(253, 87);
            DateTimePicker.MinDate = new DateTime(2024, 1, 29, 0, 0, 0, 0);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(98, 23);
            DateTimePicker.TabIndex = 8;
            DateTimePicker.Visible = false;
            DateTimePicker.ValueChanged += DateTimePicker_ValueChanged;
            // 
            // Deadline
            // 
            Deadline.Location = new Point(152, 87);
            Deadline.Name = "Deadline";
            Deadline.Size = new Size(78, 23);
            Deadline.TabIndex = 9;
            Deadline.Text = "Deadline";
            Deadline.UseVisualStyleBackColor = true;
            Deadline.CheckedChanged += Deadline_CheckedChanged;
            // 
            // list_view
            // 
            list_view.Columns.AddRange(new ColumnHeader[] { Desc, isUrgent, Deadl });
            list_view.FullRowSelect = true;
            list_view.GridLines = true;
            list_view.HoverSelection = true;
            list_view.Location = new Point(22, 205);
            list_view.MultiSelect = false;
            list_view.Name = "list_view";
            list_view.Size = new Size(334, 238);
            list_view.TabIndex = 10;
            list_view.TileSize = new Size(10, 10);
            list_view.UseCompatibleStateImageBehavior = false;
            list_view.View = View.Details;
            list_view.ColumnClick += list_view_ColumnClick;
            list_view.SelectedIndexChanged += SortBy_SelectedIndexChanged;
            // 
            // TaskMaker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(380, 455);
            Controls.Add(list_view);
            Controls.Add(Deadline);
            Controls.Add(DateTimePicker);
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
        private DateTimePicker DateTimePicker;
        private CheckBox Deadline;
        private ListView list_view;
        private ColumnHeader Desc;
        private ColumnHeader isUrgent;
        private ColumnHeader Deadl;
    }
}
