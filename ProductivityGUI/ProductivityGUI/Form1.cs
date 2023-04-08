using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductivityGUI
{
    public partial class DailyStatusReportForm : Form
    {
        int value1, value2, value3, value4;
        string CommandHistory = "";
        List<String> newSubTasks = new List<String>();
        List<int> newSubTasksStatus = new List<int>();
        public DailyStatusReportForm()
        {
            InitializeComponent();
            value1 = 50;
            value2 = 40;
            value3 = 30;
            value4 = 20;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CommandComboBox.Text.Equals("Create Documentation"))
            {
                this.StatusProgressBar.Value = value1;
                this.TaskNumericUpDown.Value = value1;
                hideSubTask();
                this.TaskNumericUpDown.Enabled = true;
            }
            else if (this.CommandComboBox.Text.Equals("Develop a GUI"))
            {
                this.StatusProgressBar.Value = value2;
                this.TaskNumericUpDown.Value = value2;
                hideSubTask();
                this.TaskNumericUpDown.Enabled = true;
            }
            else if (this.CommandComboBox.Text.Equals("Test GUI"))
            {
                this.StatusProgressBar.Value = value3;
                this.TaskNumericUpDown.Value = value3;
                hideSubTask();
                this.TaskNumericUpDown.Enabled = true;
            }
            else if (this.CommandComboBox.Text.Equals("Code Review"))
            {
                this.StatusProgressBar.Value = value4;
                this.TaskNumericUpDown.Value = value4;
                hideSubTask();
                this.TaskNumericUpDown.Enabled = true;
            }
            else if (this.CommandComboBox.Text.Equals("Create Subtask"))
            {
                this.SubtaskLabel.Visible = true;
                this.SubtaskTextBox.Visible = true;
                this.EnterNewSubtaskStatus.Visible = true;
                this.SubtaskStatusNumericUpDown.Visible = true;
                this.TaskNumericUpDown.Enabled = false;
            }
            else if (this.CommandComboBox.Text.Equals("Show Summary History"))
            {
                this.SummaryRichTextBox.Text = "" + this.CommandHistory + "\n";
                hideSubTask();
                this.TaskNumericUpDown.Enabled = true;
            }
            else 
            {
                foreach (String x in this.newSubTasks) 
                {
                    if (this.CommandComboBox.Text.Equals(x)) 
                    {
                        this.TaskNumericUpDown.Value = this.newSubTasksStatus.ElementAt(newSubTasks.FindIndex(a => a.Contains(x)));
                        this.StatusProgressBar.Value = (int)this.TaskNumericUpDown.Value;
                    }
                }
                this.TaskNumericUpDown.Enabled = true;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (this.CommandComboBox.Text.Equals("Create Documentation"))
            {
                value1 = (int)this.TaskNumericUpDown.Value;
            }
            else if (this.CommandComboBox.Text.Equals("Develop a GUI"))
            {
                value2 = (int)this.TaskNumericUpDown.Value;
            }
            else if (this.CommandComboBox.Text.Equals("Test GUI"))
            {
                value3 = (int)this.TaskNumericUpDown.Value;
            }
            else if (this.CommandComboBox.Text.Equals("Code Review"))
            {
                value4 = (int)this.TaskNumericUpDown.Value;
            }
            else if (this.CommandComboBox.Text.Equals("Create Subtask"))
            {
                this.CommandComboBox.Items.Add(this.SubtaskTextBox.Text);
                this.newSubTasks.Add(this.SubtaskTextBox.Text);
                this.newSubTasksStatus.Add((int)this.SubtaskStatusNumericUpDown.Value);
            }
            else
            {
                foreach (String x in this.newSubTasks)
                {
                    if (this.CommandComboBox.Text.Equals(x))
                    {
                        int index = newSubTasks.FindIndex(a => a.Contains(x));
                        this.newSubTasksStatus[index] = ((int)this.TaskNumericUpDown.Value);
                    }
                }
            }

            CommandHistory += "" + this.SummaryRichTextBox.Text + "\n";
            this.SummaryRichTextBox.Text = string.Empty;
            this.SubtaskTextBox.Text = string.Empty;
            hideSubTask();
            this.StatusProgressBar.Value = 0;
        }

        private void TaskNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.StatusProgressBar.Value = (int)this.TaskNumericUpDown.Value;
        }

        private void SubtaskStatusNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.StatusProgressBar.Value = (int)this.SubtaskStatusNumericUpDown.Value;
        }

        private void hideSubTask() 
        {
            this.SubtaskLabel.Visible = false;
            this.SubtaskTextBox.Visible = false;
            this.EnterNewSubtaskStatus.Visible = false;
            this.SubtaskStatusNumericUpDown.Visible = false;
        }
    }
}
