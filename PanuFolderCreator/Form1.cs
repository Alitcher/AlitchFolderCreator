using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PanuFolderCreator
{
    public partial class Form1 : Form
    {
        private string[] AllFiles;
        private List<string> ExtensionGenerated;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void GenerateFolderButton_Click(object sender, EventArgs e)
        {
            TraverseFiles();
            MessageBox.Show("done");
            Directory.CreateDirectory(textBox1.Text + "\\555");
        }

        private void TraverseFiles()
        {
            AllFiles = Directory.GetFiles(textBox1.Text);

            label2.Text = string.Empty;
            ExtensionGenerated = new List<string>();
            for (int i = 0; i < AllFiles.Length; i++)
            {
                ExtensionGenerated.Add(Path.GetExtension(AllFiles[i]));
                CreateFolder(AllFiles[i]);
            }
        }

        private void CreateFolder(string file)
        {
            //bool isCreateFolder = Program.ExtensionCollection.All(x => file.EndsWith(x));
            foreach (var extensionIndex in Program.ExtensionCollection)
            {
                if (file.EndsWith(extensionIndex))
                {
                    string folderName = Path.GetFileNameWithoutExtension(file);
                    if (!Directory.Exists(textBox1.Text + $"\\{folderName}"))
                    {
                        label2.Text += file + Environment.NewLine;
                        Directory.CreateDirectory(textBox1.Text + $"\\{folderName}");
                    }
                    else
                    {
                        MessageBox.Show($"{folderName} already exist");
                    }
                    //D:\panun\
                }
            }

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
