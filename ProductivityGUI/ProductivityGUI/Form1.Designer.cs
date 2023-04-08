namespace ProductivityGUI
{
    partial class DailyStatusReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CommandComboBox = new System.Windows.Forms.ComboBox();
            this.SelectTaskLabel = new System.Windows.Forms.Label();
            this.StatusProgressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SummaryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SummaryLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.TaskNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TaskProgressUpdateLabel = new System.Windows.Forms.Label();
            this.SubtaskTextBox = new System.Windows.Forms.TextBox();
            this.SubtaskLabel = new System.Windows.Forms.Label();
            this.EnterNewSubtaskStatus = new System.Windows.Forms.Label();
            this.SubtaskStatusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.TaskNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubtaskStatusNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CommandComboBox
            // 
            this.CommandComboBox.FormattingEnabled = true;
            this.CommandComboBox.Items.AddRange(new object[] {
            "Create Documentation",
            "Develop a GUI",
            "Test GUI",
            "Code Review",
            "Create Subtask",
            "Show Summary History"});
            this.CommandComboBox.Location = new System.Drawing.Point(12, 30);
            this.CommandComboBox.Name = "CommandComboBox";
            this.CommandComboBox.Size = new System.Drawing.Size(206, 21);
            this.CommandComboBox.TabIndex = 0;
            this.CommandComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SelectTaskLabel
            // 
            this.SelectTaskLabel.AutoSize = true;
            this.SelectTaskLabel.Location = new System.Drawing.Point(68, 14);
            this.SelectTaskLabel.Name = "SelectTaskLabel";
            this.SelectTaskLabel.Size = new System.Drawing.Size(81, 13);
            this.SelectTaskLabel.TabIndex = 1;
            this.SelectTaskLabel.Text = "Slect Command";
            // 
            // StatusProgressBar
            // 
            this.StatusProgressBar.Location = new System.Drawing.Point(642, 31);
            this.StatusProgressBar.Name = "StatusProgressBar";
            this.StatusProgressBar.Size = new System.Drawing.Size(100, 23);
            this.StatusProgressBar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(654, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Task Progress";
            // 
            // SummaryRichTextBox
            // 
            this.SummaryRichTextBox.Location = new System.Drawing.Point(12, 157);
            this.SummaryRichTextBox.Name = "SummaryRichTextBox";
            this.SummaryRichTextBox.Size = new System.Drawing.Size(776, 154);
            this.SummaryRichTextBox.TabIndex = 4;
            this.SummaryRichTextBox.Text = "";
            // 
            // SummaryLabel
            // 
            this.SummaryLabel.AutoSize = true;
            this.SummaryLabel.Location = new System.Drawing.Point(352, 141);
            this.SummaryLabel.Name = "SummaryLabel";
            this.SummaryLabel.Size = new System.Drawing.Size(101, 13);
            this.SummaryLabel.TabIndex = 5;
            this.SummaryLabel.Text = "Work Day Summary";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(338, 326);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(115, 23);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // TaskNumericUpDown
            // 
            this.TaskNumericUpDown.Location = new System.Drawing.Point(349, 31);
            this.TaskNumericUpDown.Name = "TaskNumericUpDown";
            this.TaskNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.TaskNumericUpDown.TabIndex = 7;
            this.TaskNumericUpDown.ValueChanged += new System.EventHandler(this.TaskNumericUpDown_ValueChanged);
            // 
            // TaskProgressUpdateLabel
            // 
            this.TaskProgressUpdateLabel.AutoSize = true;
            this.TaskProgressUpdateLabel.Location = new System.Drawing.Point(356, 12);
            this.TaskProgressUpdateLabel.Name = "TaskProgressUpdateLabel";
            this.TaskProgressUpdateLabel.Size = new System.Drawing.Size(113, 13);
            this.TaskProgressUpdateLabel.TabIndex = 8;
            this.TaskProgressUpdateLabel.Text = "Update Task Progress";
            // 
            // SubtaskTextBox
            // 
            this.SubtaskTextBox.Location = new System.Drawing.Point(349, 90);
            this.SubtaskTextBox.Name = "SubtaskTextBox";
            this.SubtaskTextBox.Size = new System.Drawing.Size(120, 20);
            this.SubtaskTextBox.TabIndex = 9;
            this.SubtaskTextBox.Visible = false;
            // 
            // SubtaskLabel
            // 
            this.SubtaskLabel.AutoSize = true;
            this.SubtaskLabel.Location = new System.Drawing.Point(356, 74);
            this.SubtaskLabel.Name = "SubtaskLabel";
            this.SubtaskLabel.Size = new System.Drawing.Size(99, 13);
            this.SubtaskLabel.TabIndex = 10;
            this.SubtaskLabel.Text = "Enter New Subtask";
            this.SubtaskLabel.Visible = false;
            // 
            // EnterNewSubtaskStatus
            // 
            this.EnterNewSubtaskStatus.AutoSize = true;
            this.EnterNewSubtaskStatus.Location = new System.Drawing.Point(639, 74);
            this.EnterNewSubtaskStatus.Name = "EnterNewSubtaskStatus";
            this.EnterNewSubtaskStatus.Size = new System.Drawing.Size(132, 13);
            this.EnterNewSubtaskStatus.TabIndex = 11;
            this.EnterNewSubtaskStatus.Text = "Enter New Subtask Status";
            this.EnterNewSubtaskStatus.Visible = false;
            // 
            // SubtaskStatusNumericUpDown
            // 
            this.SubtaskStatusNumericUpDown.Location = new System.Drawing.Point(642, 90);
            this.SubtaskStatusNumericUpDown.Name = "SubtaskStatusNumericUpDown";
            this.SubtaskStatusNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.SubtaskStatusNumericUpDown.TabIndex = 12;
            this.SubtaskStatusNumericUpDown.Visible = false;
            this.SubtaskStatusNumericUpDown.ValueChanged += new System.EventHandler(this.SubtaskStatusNumericUpDown_ValueChanged);
            // 
            // DailyStatusReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.SubtaskStatusNumericUpDown);
            this.Controls.Add(this.EnterNewSubtaskStatus);
            this.Controls.Add(this.SubtaskLabel);
            this.Controls.Add(this.SubtaskTextBox);
            this.Controls.Add(this.TaskProgressUpdateLabel);
            this.Controls.Add(this.TaskNumericUpDown);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.SummaryLabel);
            this.Controls.Add(this.SummaryRichTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusProgressBar);
            this.Controls.Add(this.SelectTaskLabel);
            this.Controls.Add(this.CommandComboBox);
            this.Name = "DailyStatusReportForm";
            this.Text = "Daily Status Report";
            ((System.ComponentModel.ISupportInitialize)(this.TaskNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubtaskStatusNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CommandComboBox;
        private System.Windows.Forms.Label SelectTaskLabel;
        private System.Windows.Forms.ProgressBar StatusProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox SummaryRichTextBox;
        private System.Windows.Forms.Label SummaryLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.NumericUpDown TaskNumericUpDown;
        private System.Windows.Forms.Label TaskProgressUpdateLabel;
        private System.Windows.Forms.TextBox SubtaskTextBox;
        private System.Windows.Forms.Label SubtaskLabel;
        private System.Windows.Forms.Label EnterNewSubtaskStatus;
        private System.Windows.Forms.NumericUpDown SubtaskStatusNumericUpDown;
    }
}

