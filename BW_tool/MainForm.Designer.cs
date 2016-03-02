﻿/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 01/03/2016
 * Time: 20:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BW_tool
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button loadsave_but;
		private System.Windows.Forms.TextBox savegamename;
		private System.Windows.Forms.Button save_but;
		private System.Windows.Forms.Label versiontext;
		private System.Windows.Forms.Button dumper_but;
		private System.Windows.Forms.Button chk_but;
		
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
			this.loadsave_but = new System.Windows.Forms.Button();
			this.savegamename = new System.Windows.Forms.TextBox();
			this.save_but = new System.Windows.Forms.Button();
			this.versiontext = new System.Windows.Forms.Label();
			this.dumper_but = new System.Windows.Forms.Button();
			this.chk_but = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// loadsave_but
			// 
			this.loadsave_but.Location = new System.Drawing.Point(12, 12);
			this.loadsave_but.Name = "loadsave_but";
			this.loadsave_but.Size = new System.Drawing.Size(132, 23);
			this.loadsave_but.TabIndex = 0;
			this.loadsave_but.Text = "Load Savegame";
			this.loadsave_but.UseVisualStyleBackColor = true;
			this.loadsave_but.Click += new System.EventHandler(this.Loadsave_butClick);
			// 
			// savegamename
			// 
			this.savegamename.Location = new System.Drawing.Point(12, 41);
			this.savegamename.Name = "savegamename";
			this.savegamename.Size = new System.Drawing.Size(484, 20);
			this.savegamename.TabIndex = 1;
			// 
			// save_but
			// 
			this.save_but.Location = new System.Drawing.Point(421, 12);
			this.save_but.Name = "save_but";
			this.save_but.Size = new System.Drawing.Size(75, 23);
			this.save_but.TabIndex = 2;
			this.save_but.Text = "Save";
			this.save_but.UseVisualStyleBackColor = true;
			this.save_but.Click += new System.EventHandler(this.Save_butClick);
			// 
			// versiontext
			// 
			this.versiontext.Location = new System.Drawing.Point(150, 17);
			this.versiontext.Name = "versiontext";
			this.versiontext.Size = new System.Drawing.Size(100, 18);
			this.versiontext.TabIndex = 3;
			// 
			// dumper_but
			// 
			this.dumper_but.Location = new System.Drawing.Point(12, 80);
			this.dumper_but.Name = "dumper_but";
			this.dumper_but.Size = new System.Drawing.Size(92, 23);
			this.dumper_but.TabIndex = 4;
			this.dumper_but.Text = "Block dumper";
			this.dumper_but.UseVisualStyleBackColor = true;
			this.dumper_but.Click += new System.EventHandler(this.Dumper_butClick);
			// 
			// chk_but
			// 
			this.chk_but.Location = new System.Drawing.Point(316, 12);
			this.chk_but.Name = "chk_but";
			this.chk_but.Size = new System.Drawing.Size(99, 23);
			this.chk_but.TabIndex = 5;
			this.chk_but.Text = "Verify Checksums";
			this.chk_but.UseVisualStyleBackColor = true;
			this.chk_but.Click += new System.EventHandler(this.Chk_butClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 119);
			this.Controls.Add(this.chk_but);
			this.Controls.Add(this.dumper_but);
			this.Controls.Add(this.versiontext);
			this.Controls.Add(this.save_but);
			this.Controls.Add(this.savegamename);
			this.Controls.Add(this.loadsave_but);
			this.Name = "MainForm";
			this.Text = "Gen V save tool";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
