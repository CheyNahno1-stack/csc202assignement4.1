namespace twodolist
{
    partial class background
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
            txtTask = new TextBox();
            lstTasks = new ListBox();
            bttnRemove = new Button();
            bttnSave = new Button();
            bttnAdd = new Button();
            bttnComplete = new Button();
            SuspendLayout();
            // 
            // txtTask
            // 
            txtTask.Location = new Point(98, 99);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(196, 23);
            txtTask.TabIndex = 0;
            txtTask.UseWaitCursor = true;
            // 
            // lstTasks
            // 
            lstTasks.BackColor = SystemColors.ActiveCaption;
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 15;
            lstTasks.Location = new Point(458, 84);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(286, 214);
            lstTasks.TabIndex = 1;
            lstTasks.UseWaitCursor = true;
            // 
            // bttnRemove
            // 
            bttnRemove.Font = new Font("Perpetua Titling MT", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bttnRemove.Location = new Point(306, 172);
            bttnRemove.Name = "bttnRemove";
            bttnRemove.Size = new Size(119, 23);
            bttnRemove.TabIndex = 2;
            bttnRemove.Text = "Remove Task";
            bttnRemove.UseVisualStyleBackColor = true;
            bttnRemove.UseWaitCursor = true;
            bttnRemove.Click += bttnRemove_Click;
            // 
            // bttnSave
            // 
            bttnSave.Font = new Font("Perpetua Titling MT", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bttnSave.Location = new Point(299, 235);
            bttnSave.Name = "bttnSave";
            bttnSave.Size = new Size(126, 23);
            bttnSave.TabIndex = 3;
            bttnSave.Text = "Save Task";
            bttnSave.UseVisualStyleBackColor = true;
            bttnSave.UseWaitCursor = true;
            bttnSave.Click += bttnSave_Click;
            // 
            // bttnAdd
            // 
            bttnAdd.Font = new Font("Perpetua Titling MT", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bttnAdd.Location = new Point(323, 114);
            bttnAdd.Name = "bttnAdd";
            bttnAdd.Size = new Size(102, 23);
            bttnAdd.TabIndex = 4;
            bttnAdd.Text = "Add Task";
            bttnAdd.UseVisualStyleBackColor = true;
            bttnAdd.UseWaitCursor = true;
            bttnAdd.Click += bttnAdd_Click;
            // 
            // bttnComplete
            // 
            bttnComplete.Font = new Font("Perpetua Titling MT", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bttnComplete.Location = new Point(299, 287);
            bttnComplete.Name = "bttnComplete";
            bttnComplete.Size = new Size(126, 23);
            bttnComplete.TabIndex = 5;
            bttnComplete.Text = "Complete Task";
            bttnComplete.UseVisualStyleBackColor = true;
            bttnComplete.UseWaitCursor = true;
            // 
            // background
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(bttnComplete);
            Controls.Add(bttnAdd);
            Controls.Add(bttnSave);
            Controls.Add(bttnRemove);
            Controls.Add(lstTasks);
            Controls.Add(txtTask);
            Name = "background";
            Text = "remove Task";
            UseWaitCursor = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTask;
        private ListBox lstTasks;
        private Button bttnRemove;
        private Button bttnSave;
        private Button bttnAdd;
        private Button bttnComplete;
    }
}
