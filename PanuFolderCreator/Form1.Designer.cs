
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PanuFolderCreator
{
    partial class AlicianMovieRelocator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlicianMovieRelocator));
            this.GenerateFolderButton = new System.Windows.Forms.Button();
            this.navigationText = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.selectedDirectoryText = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderFromFilesText = new System.Windows.Forms.Label();
            this.checker = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // GenerateFolderButton
            // 
            this.GenerateFolderButton.Location = new System.Drawing.Point(690, 288);
            this.GenerateFolderButton.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateFolderButton.Name = "GenerateFolderButton";
            this.GenerateFolderButton.Size = new System.Drawing.Size(199, 28);
            this.GenerateFolderButton.TabIndex = 0;
            this.GenerateFolderButton.Text = "Generate Folder";
            this.GenerateFolderButton.UseVisualStyleBackColor = true;
            this.GenerateFolderButton.Click += new System.EventHandler(this.GenerateFolderButton_Click);
            // 
            // label1
            // 
            this.navigationText.AutoSize = true;
            this.navigationText.Location = new System.Drawing.Point(144, 68);
            this.navigationText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.navigationText.Name = "label1";
            this.navigationText.Size = new System.Drawing.Size(171, 17);
            this.navigationText.TabIndex = 1;
            this.navigationText.Text = "Select your directory here";
            this.navigationText.Click += new System.EventHandler(this.label1_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(789, 84);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(4);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(100, 28);
            this.BrowseButton.TabIndex = 3;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // textBox1
            // 
            this.selectedDirectoryText.Location = new System.Drawing.Point(148, 84);
            this.selectedDirectoryText.Margin = new System.Windows.Forms.Padding(4);
            this.selectedDirectoryText.Name = "textBox1";
            this.selectedDirectoryText.Size = new System.Drawing.Size(632, 22);
            this.selectedDirectoryText.TabIndex = 4;
            this.selectedDirectoryText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // label2
            // 
            this.folderFromFilesText.AutoSize = true;
            this.folderFromFilesText.Location = new System.Drawing.Point(145, 202);
            this.folderFromFilesText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.folderFromFilesText.Name = "label2";
            this.folderFromFilesText.Size = new System.Drawing.Size(46, 17);
            this.folderFromFilesText.TabIndex = 5;
            this.folderFromFilesText.Text = "label2";
            // 
            // checker
            // 
            this.checker.AutoSize = true;
            this.checker.Location = new System.Drawing.Point(148, 112);
            this.checker.Name = "checker";
            this.checker.Size = new System.Drawing.Size(61, 21);
            this.checker.TabIndex = 7;
            this.checker.Text = "fghf";
            this.checker.UseVisualStyleBackColor = true;
            this.checker.CheckedChanged += new System.EventHandler(this.ExtensionsCheckedChanged);
            // 
            // AlicianMovieRelocator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 346);
            this.Controls.Add(this.folderFromFilesText);
            this.Controls.Add(this.selectedDirectoryText);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.navigationText);
            this.Controls.Add(this.GenerateFolderButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AlicianMovieRelocator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlicianMovieRelocator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateFolderButton;
        private System.Windows.Forms.Label navigationText;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox selectedDirectoryText;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label folderFromFilesText;
        private CheckBox checker;
    }
}

