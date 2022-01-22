using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PanuFolderCreator
{
    public partial class Form1 : Form
    {
        private string[] AllFiles;
        private Dictionary<string, bool> ExtensionGenerated = new Dictionary<string, bool> { { ".mp4", false }, { ".avi", false }, { ".ktv", false }, { ".mov", false } };

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
        }

        private void TraverseFiles()
        {
            if (textBox1.Text == string.Empty) 
            {
                MessageBox.Show("directory cannot be null");
                return;
            }
            AllFiles = Directory.GetFiles(textBox1.Text);

            label2.Text = string.Empty;
            for (int i = 0; i < AllFiles.Length; i++)
            {
                CreateFolder(AllFiles[i]);
                RelocateFiles(AllFiles[i]);
            }
            MessageBox.Show("done");
        }

        private void CreateFolder(string file)
        {
            foreach (var extensionIndex in ExtensionGenerated.Keys)
            {
                if (file.EndsWith(extensionIndex) && ExtensionGenerated[extensionIndex] == true)
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
                }
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void RelocateFiles(string source)
        {
            string destination = $"{textBox1.Text}/{Path.GetFileNameWithoutExtension(source)}/{Path.GetFileNameWithoutExtension(source)}{Path.GetExtension(source)}";
            if (File.Exists(destination))
            {
                MessageBox.Show($"{destination} already exist. Thw system is skipping this file.");
                return;
            }

            foreach (var extensionIndex in ExtensionGenerated.Keys)
            {
                if (source.EndsWith(extensionIndex) && ExtensionGenerated[extensionIndex] == true)
                {
                    File.Move(source, destination);
                }
            }

        }

        private void Mp4_CheckedChanged(object sender, EventArgs e)
        {
            if (!ExtensionGenerated.ContainsKey(".mp4"))
                return;
            ExtensionGenerated[".mp4"] = mp4Check.CheckState == CheckState.Checked;
        }

        private void Avi_CheckedChanged(object sender, EventArgs e)
        {
            if (!ExtensionGenerated.ContainsKey(".avi"))
                return;
            ExtensionGenerated[".avi"] = aviCheck.CheckState == CheckState.Checked;
        }

        private void Ktv_CheckedChanged(object sender, EventArgs e)
        {
            if (!ExtensionGenerated.ContainsKey(".ktv"))
                return;
            ExtensionGenerated[".ktv"] = ktvCheck.CheckState == CheckState.Checked;
        }

        private void Mov_CheckedChanged(object sender, EventArgs e)
        {
            if (!ExtensionGenerated.ContainsKey(".mov"))
                return;
            ExtensionGenerated[".mov"] = movCheck.CheckState == CheckState.Checked;
        }
    }
}
