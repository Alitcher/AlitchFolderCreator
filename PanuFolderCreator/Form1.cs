using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PanuFolderCreator
{
    public partial class AlicianMovieRelocator : Form
    {

        private string[] allFiles;
        private bool isAnyExtensionsSelected = false;

        private Dictionary<string, bool> ExtensionGeneratedDict = new Dictionary<string, bool>();
        private List<CheckBox> ExtensionCheckersList = new List<CheckBox>();
        public AlicianMovieRelocator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.folderFromFilesText.Text = "";
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
                selectedDirectoryText.Text = folderBrowserDialog1.SelectedPath;
            }

            if (selectedDirectoryText.Text == string.Empty)
            {
                return;
            }
            allFiles = Directory.GetFiles(selectedDirectoryText.Text);
            GenerateCheckBox();
        }

        private void GenerateFolderButton_Click(object sender, EventArgs e)
        {
            TraverseFiles();
            if (!isAnyExtensionsSelected)
            {
                MessageBox.Show($"Please select atleast one extenstion to create the folder for your videos.");
            }
            MessageBox.Show("done");
        }

        private void TraverseFiles()
        {
            if (selectedDirectoryText.Text == string.Empty)
            {
                MessageBox.Show("directory cannot be null");
                return;
            }

            folderFromFilesText.Text = string.Empty;
            for (int i = 0; i < allFiles.Length; i++)
            {
                CreateFolder(allFiles[i]);
                RelocateFiles(allFiles[i]);
            }

        }

        private void GenerateCheckBox()
        {
            int extensionPerRow = 9;

            int rowCount = 0;
            int memberInRowCount = 0;
            int extensionCount = 0;
            for (int i = 0; i < allFiles.Length; i++)
            {
                foreach (var item in PanunHelper.ExtensionCollection)
                {
                    string lowerExt = item.ToLower();
                    if (ExtensionGeneratedDict.ContainsKey(lowerExt))
                        continue;

                    if (allFiles[i].EndsWith(lowerExt))
                    {
                        ExtensionGeneratedDict.Add(lowerExt, true);

                        if (memberInRowCount > extensionPerRow)
                        {
                            rowCount++;
                            memberInRowCount = 0;
                        }

                        int xPos = (int)PanunHelper.FirstCheckPos.x + memberInRowCount * PanunHelper.XOffset;
                        int yPos = (int)PanunHelper.FirstCheckPos.y + rowCount * PanunHelper.YOffset;

                        CheckBox checker = new CheckBox();
                        checker.AutoSize = true;
                        checker.Location = new System.Drawing.Point(xPos, yPos);
                        checker.Name = lowerExt;
                        checker.Size = new System.Drawing.Size(61, 21);
                        checker.TabIndex = 7;
                        checker.Text = lowerExt;
                        checker.UseVisualStyleBackColor = true;
                        checker.CheckedChanged += new EventHandler(ExtensionsCheckedChanged);
                        this.Controls.Add(checker);
                        memberInRowCount++;
                        extensionCount++;

                        ExtensionCheckersList.Add(checker);
                    }
                }
            }
        }

        private void CreateFolder(string file)
        {
            foreach (var extensionIndex in ExtensionGeneratedDict.Keys)
            {
                if (file.EndsWith(extensionIndex) && ExtensionGeneratedDict[extensionIndex] == true)
                {
                    isAnyExtensionsSelected = true;
                    string folderName = Path.GetFileNameWithoutExtension(file);
                    if (!Directory.Exists(selectedDirectoryText.Text + $"\\{folderName}"))
                    {
                        folderFromFilesText.Text += file + Environment.NewLine;
                        Directory.CreateDirectory(selectedDirectoryText.Text + $"\\{folderName}");
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
            string destination = $"{selectedDirectoryText.Text}/{Path.GetFileNameWithoutExtension(source)}/{Path.GetFileNameWithoutExtension(source)}{Path.GetExtension(source)}";
            if (File.Exists(destination))
            {
                MessageBox.Show($"{destination} already exist. The system is skipping this file.");
                return;
            }

            foreach (var extensionIndex in ExtensionGeneratedDict.Keys)
            {
                if (source.EndsWith(extensionIndex) && ExtensionGeneratedDict[extensionIndex] == true)
                {
                    File.Move(source, destination);
                }
            }
        }

        private void ExtensionsCheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
