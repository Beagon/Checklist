namespace Checklist
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.removeButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.clearButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.completedStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.incompleteStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatuUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(1, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(800, 334);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.checkedListBox1_KeyUp);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(1, 340);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(578, 20);
            this.textBox.TabIndex = 1;
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(585, 340);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(47, 20);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(638, 340);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(47, 20);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Checklist! files|*.chlist|All Files|*.*";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(691, 340);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(57, 20);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Checklist! files|*.chlist";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(754, 340);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(47, 20);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.completedStatusLabel,
            this.incompleteStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 371);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(801, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // completedStatusLabel
            // 
            this.completedStatusLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.completedStatusLabel.ForeColor = System.Drawing.Color.Green;
            this.completedStatusLabel.Name = "completedStatusLabel";
            this.completedStatusLabel.Size = new System.Drawing.Size(83, 17);
            this.completedStatusLabel.Text = "Completed: ...";
            // 
            // incompleteStatusLabel
            // 
            this.incompleteStatusLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.incompleteStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.incompleteStatusLabel.Name = "incompleteStatusLabel";
            this.incompleteStatusLabel.Size = new System.Drawing.Size(50, 17);
            this.incompleteStatusLabel.Text = "To do: ..";
            // 
            // StatuUpdateTimer
            // 
            this.StatuUpdateTimer.Enabled = true;
            this.StatuUpdateTimer.Interval = 1000;
            this.StatuUpdateTimer.Tick += new System.EventHandler(this.statusUpdate_tick);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 393);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.checkedListBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Checklist!";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Main_DragEnter);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel completedStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel incompleteStatusLabel;
        private System.Windows.Forms.Timer StatuUpdateTimer;
    }
}

