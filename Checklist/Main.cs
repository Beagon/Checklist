using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Checklist
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            if (Environment.GetCommandLineArgs().Length > 1)
            {
               loadFile(Environment.GetCommandLineArgs()[1]);
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (textBox.Text != "")
                {
                    checkedListBox1.Items.Add(textBox.Text);
                    textBox.Text = "";
                }
            }
        }


        private void loadFile(string path)
        {
            checkedListBox1.Items.Clear();
            System.IO.StreamReader sr = new
               System.IO.StreamReader(path);
            string line;
            try
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(',');
                    bool isChecked = Convert.ToBoolean(Convert.ToInt16(words[1]));
                    checkedListBox1.Items.Add(words[0]);
                    checkedListBox1.SetItemChecked(checkedListBox1.Items.Count - 1, isChecked);
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("An error has occured. The file " + openFileDialog1.SafeFileName +
                                " is corrupt or invalid.", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                checkedListBox1.Items.Clear();
            }

            sr.Close();           
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loadFile(openFileDialog1.FileName);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                List<string> lines = new List<string> {};
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    lines.Add(checkedListBox1.Items[i].ToString() + "," +
                              Convert.ToInt32(checkedListBox1.GetItemChecked(i)).ToString());
                }
                System.IO.File.WriteAllLines(saveFileDialog1.FileName, lines);
            }

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
        }

        private void checkedListBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                removeButton_Click(null, null);
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return && textBox.Text != "")
            {
                e.Handled = true;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
        }

        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            loadFile(files[0]);
        }
    }
}
