/*
 * Created by SharpDevelop.
 * User: DEV0003
 * Date: 14/05/2019
 * Time: 9:53 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Gauntlet
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button addListButton;
		private System.Windows.Forms.Button snapButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.ListBox listView;
		private System.Windows.Forms.Label countLabel;
		private System.Windows.Forms.Label countLabel2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.addButton = new System.Windows.Forms.Button();
			this.removeButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.addListButton = new System.Windows.Forms.Button();
			this.snapButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.listView = new System.Windows.Forms.ListBox();
			this.countLabel = new System.Windows.Forms.Label();
			this.countLabel2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(312, 12);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 1;
			this.addButton.Text = "Add...";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.AddButtonClick);
			// 
			// removeButton
			// 
			this.removeButton.Enabled = false;
			this.removeButton.Location = new System.Drawing.Point(312, 64);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(75, 23);
			this.removeButton.TabIndex = 2;
			this.removeButton.Text = "Remove";
			this.removeButton.UseVisualStyleBackColor = true;
			this.removeButton.Click += new System.EventHandler(this.RemoveButtonClick);
			// 
			// clearButton
			// 
			this.clearButton.Enabled = false;
			this.clearButton.Location = new System.Drawing.Point(312, 90);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(75, 23);
			this.clearButton.TabIndex = 3;
			this.clearButton.Text = "Clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
			// 
			// addListButton
			// 
			this.addListButton.Location = new System.Drawing.Point(312, 38);
			this.addListButton.Name = "addListButton";
			this.addListButton.Size = new System.Drawing.Size(75, 23);
			this.addListButton.TabIndex = 4;
			this.addListButton.Text = "Add List...";
			this.addListButton.UseVisualStyleBackColor = true;
			this.addListButton.Click += new System.EventHandler(this.AddListButtonClick);
			// 
			// snapButton
			// 
			this.snapButton.Location = new System.Drawing.Point(312, 154);
			this.snapButton.Name = "snapButton";
			this.snapButton.Size = new System.Drawing.Size(75, 23);
			this.snapButton.TabIndex = 5;
			this.snapButton.Text = "Snap";
			this.snapButton.UseVisualStyleBackColor = true;
			this.snapButton.Click += new System.EventHandler(this.SnapButtonClick);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(312, 369);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 6;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
			// 
			// listView
			// 
			this.listView.FormattingEnabled = true;
			this.listView.Location = new System.Drawing.Point(12, 12);
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(294, 381);
			this.listView.TabIndex = 7;
			this.listView.SelectedIndexChanged += new System.EventHandler(this.ListViewSelectedIndexChanged);
			// 
			// countLabel
			// 
			this.countLabel.Location = new System.Drawing.Point(312, 193);
			this.countLabel.Name = "countLabel";
			this.countLabel.Size = new System.Drawing.Size(75, 15);
			this.countLabel.TabIndex = 8;
			this.countLabel.Text = "Count:";
			// 
			// countLabel2
			// 
			this.countLabel2.Location = new System.Drawing.Point(312, 208);
			this.countLabel2.Name = "countLabel2";
			this.countLabel2.Size = new System.Drawing.Size(75, 50);
			this.countLabel2.TabIndex = 9;
			this.countLabel2.Text = "0";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(399, 404);
			this.Controls.Add(this.countLabel2);
			this.Controls.Add(this.countLabel);
			this.Controls.Add(this.listView);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.snapButton);
			this.Controls.Add(this.addListButton);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.removeButton);
			this.Controls.Add(this.addButton);
			this.Name = "MainForm";
			this.Text = "Gauntlet";
			this.ResumeLayout(false);

		}
	}
}
