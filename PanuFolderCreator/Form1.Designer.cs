
namespace PanuFolderCreator
{
    partial class Form1
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
            this.GenerateFolderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.movCheck = new System.Windows.Forms.CheckBox();
            this.ktvCheck = new System.Windows.Forms.CheckBox();
            this.mp4Check = new System.Windows.Forms.CheckBox();
            this.aviCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenerateFolderButton
            // 
            this.GenerateFolderButton.Location = new System.Drawing.Point(111, 246);
            this.GenerateFolderButton.Name = "GenerateFolderButton";
            this.GenerateFolderButton.Size = new System.Drawing.Size(149, 23);
            this.GenerateFolderButton.TabIndex = 0;
            this.GenerateFolderButton.Text = "Generate Folder";
            this.GenerateFolderButton.UseVisualStyleBackColor = true;
            this.GenerateFolderButton.Click += new System.EventHandler(this.GenerateFolderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select your directory here";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(592, 68);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 3;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(475, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // movCheck
            // 
            this.movCheck.AutoSize = true;
            this.movCheck.Location = new System.Drawing.Point(221, 91);
            this.movCheck.Name = "movCheck";
            this.movCheck.Size = new System.Drawing.Size(49, 17);
            this.movCheck.TabIndex = 7;
            this.movCheck.Text = ".mov";
            this.movCheck.UseVisualStyleBackColor = true;
            this.movCheck.CheckedChanged += new System.EventHandler(this.Mov_CheckedChanged);
            // 
            // ktvCheck
            // 
            this.ktvCheck.AutoSize = true;
            this.ktvCheck.Location = new System.Drawing.Point(166, 91);
            this.ktvCheck.Name = "ktvCheck";
            this.ktvCheck.Size = new System.Drawing.Size(44, 17);
            this.ktvCheck.TabIndex = 8;
            this.ktvCheck.Text = ".ktv";
            this.ktvCheck.UseVisualStyleBackColor = true;
            this.ktvCheck.CheckedChanged += new System.EventHandler(this.Ktv_CheckedChanged);
            // 
            // mp4Check
            // 
            this.mp4Check.AutoSize = true;
            this.mp4Check.Location = new System.Drawing.Point(111, 91);
            this.mp4Check.Name = "mp4Check";
            this.mp4Check.Size = new System.Drawing.Size(49, 17);
            this.mp4Check.TabIndex = 9;
            this.mp4Check.Text = ".mp4";
            this.mp4Check.UseVisualStyleBackColor = true;
            this.mp4Check.CheckedChanged += new System.EventHandler(this.Mp4_CheckedChanged);
            // 
            // aviCheck
            // 
            this.aviCheck.AutoSize = true;
            this.aviCheck.Location = new System.Drawing.Point(276, 91);
            this.aviCheck.Name = "aviCheck";
            this.aviCheck.Size = new System.Drawing.Size(43, 17);
            this.aviCheck.TabIndex = 10;
            this.aviCheck.Text = ".avi";
            this.aviCheck.UseVisualStyleBackColor = true;
            this.aviCheck.CheckedChanged += new System.EventHandler(this.Avi_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 281);
            this.Controls.Add(this.aviCheck);
            this.Controls.Add(this.mp4Check);
            this.Controls.Add(this.ktvCheck);
            this.Controls.Add(this.movCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerateFolderButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateFolderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox movCheck;
        private System.Windows.Forms.CheckBox ktvCheck;
        private System.Windows.Forms.CheckBox mp4Check;
        private System.Windows.Forms.CheckBox aviCheck;
        private System.Windows.Forms.Label label2;
    }
}

