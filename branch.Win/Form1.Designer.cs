﻿namespace branch.Win
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
			this.lblPathStatic = new System.Windows.Forms.Label();
			this.lblPath = new System.Windows.Forms.Label();
			this.lblGitBranchStatic = new System.Windows.Forms.Label();
			this.lblGitBranch = new System.Windows.Forms.Label();
			this.lblRepoStatic = new System.Windows.Forms.Label();
			this.lblRepository = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblFound = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblPathStatic
			// 
			this.lblPathStatic.AutoSize = true;
			this.lblPathStatic.Location = new System.Drawing.Point(31, 46);
			this.lblPathStatic.Name = "lblPathStatic";
			this.lblPathStatic.Size = new System.Drawing.Size(29, 13);
			this.lblPathStatic.TabIndex = 0;
			this.lblPathStatic.Text = "Path";
			// 
			// lblPath
			// 
			this.lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPath.Location = new System.Drawing.Point(72, 46);
			this.lblPath.Name = "lblPath";
			this.lblPath.Size = new System.Drawing.Size(435, 13);
			this.lblPath.TabIndex = 0;
			this.lblPath.Text = "<path>";
			// 
			// lblGitBranchStatic
			// 
			this.lblGitBranchStatic.AutoSize = true;
			this.lblGitBranchStatic.Location = new System.Drawing.Point(31, 96);
			this.lblGitBranchStatic.Name = "lblGitBranchStatic";
			this.lblGitBranchStatic.Size = new System.Drawing.Size(41, 13);
			this.lblGitBranchStatic.TabIndex = 0;
			this.lblGitBranchStatic.Text = "Branch";
			// 
			// lblGitBranch
			// 
			this.lblGitBranch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblGitBranch.Location = new System.Drawing.Point(72, 96);
			this.lblGitBranch.Name = "lblGitBranch";
			this.lblGitBranch.Size = new System.Drawing.Size(435, 13);
			this.lblGitBranch.TabIndex = 0;
			this.lblGitBranch.Text = "<branch>";
			// 
			// lblRepoStatic
			// 
			this.lblRepoStatic.AutoSize = true;
			this.lblRepoStatic.Location = new System.Drawing.Point(31, 71);
			this.lblRepoStatic.Name = "lblRepoStatic";
			this.lblRepoStatic.Size = new System.Drawing.Size(33, 13);
			this.lblRepoStatic.TabIndex = 0;
			this.lblRepoStatic.Text = "Repo";
			// 
			// lblRepository
			// 
			this.lblRepository.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblRepository.Location = new System.Drawing.Point(72, 71);
			this.lblRepository.Name = "lblRepository";
			this.lblRepository.Size = new System.Drawing.Size(435, 13);
			this.lblRepository.TabIndex = 0;
			this.lblRepository.Text = "<repo>";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Found";
			// 
			// lblFound
			// 
			this.lblFound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblFound.Location = new System.Drawing.Point(72, 24);
			this.lblFound.Name = "lblFound";
			this.lblFound.Size = new System.Drawing.Size(435, 13);
			this.lblFound.TabIndex = 0;
			this.lblFound.Text = "<found>";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(519, 142);
			this.Controls.Add(this.lblRepository);
			this.Controls.Add(this.lblGitBranch);
			this.Controls.Add(this.lblRepoStatic);
			this.Controls.Add(this.lblFound);
			this.Controls.Add(this.lblPath);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblGitBranchStatic);
			this.Controls.Add(this.lblPathStatic);
			this.Name = "Form1";
			this.Text = "branch";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblPathStatic;
		private System.Windows.Forms.Label lblPath;
		private System.Windows.Forms.Label lblGitBranchStatic;
		private System.Windows.Forms.Label lblGitBranch;
		private System.Windows.Forms.Label lblRepoStatic;
		private System.Windows.Forms.Label lblRepository;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblFound;
	}
}
