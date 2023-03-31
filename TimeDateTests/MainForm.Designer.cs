/*
 * Created by SharpDevelop.
 * User: lponce
 * Date: 10/11/2017
 * Time: 02:41 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TimeDateTests
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox tbDTNow;
		private System.Windows.Forms.Label lbShift;
		private System.Windows.Forms.Button btTest;
		
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
			this.tbDTNow = new System.Windows.Forms.TextBox();
			this.lbShift = new System.Windows.Forms.Label();
			this.btTest = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbDTNow
			// 
			this.tbDTNow.Location = new System.Drawing.Point(33, 20);
			this.tbDTNow.Name = "tbDTNow";
			this.tbDTNow.Size = new System.Drawing.Size(130, 20);
			this.tbDTNow.TabIndex = 0;
			// 
			// lbShift
			// 
			this.lbShift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbShift.Cursor = System.Windows.Forms.Cursors.Default;
			this.lbShift.Location = new System.Drawing.Point(33, 72);
			this.lbShift.Name = "lbShift";
			this.lbShift.Size = new System.Drawing.Size(130, 20);
			this.lbShift.TabIndex = 2;
			this.lbShift.Text = "Turno";
			this.lbShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btTest
			// 
			this.btTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btTest.Location = new System.Drawing.Point(169, 20);
			this.btTest.Name = "btTest";
			this.btTest.Size = new System.Drawing.Size(103, 72);
			this.btTest.TabIndex = 3;
			this.btTest.Text = "Test";
			this.btTest.UseVisualStyleBackColor = true;
			this.btTest.Click += new System.EventHandler(this.BtTestClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btTest);
			this.Controls.Add(this.lbShift);
			this.Controls.Add(this.tbDTNow);
			this.Name = "MainForm";
			this.Text = "TimeDateTests";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
