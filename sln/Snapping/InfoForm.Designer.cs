/*
 * Created by SharpDevelop.
 * User: ZHANITEST
 * Date: 2019-07-14
 * Time: 오전 2:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Snapping
{
	partial class InfoForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.lkLicense = new System.Windows.Forms.LinkLabel();
			this.linkSourceCode = new System.Windows.Forms.LinkLabel();
			this.linkUsedIcon = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(56, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(128, 128);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 143);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(220, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "Snapping";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 182);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(220, 36);
			this.label2.TabIndex = 2;
			this.label2.Text = "Lightweight, system information tool for Windows PC.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(80, 256);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// lkLicense
			// 
			this.lkLicense.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lkLicense.Location = new System.Drawing.Point(12, 230);
			this.lkLicense.Name = "lkLicense";
			this.lkLicense.Size = new System.Drawing.Size(78, 23);
			this.lkLicense.TabIndex = 4;
			this.lkLicense.TabStop = true;
			this.lkLicense.Text = "License";
			this.lkLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LkLicenseLinkClicked);
			// 
			// linkSourceCode
			// 
			this.linkSourceCode.Cursor = System.Windows.Forms.Cursors.Hand;
			this.linkSourceCode.Location = new System.Drawing.Point(155, 230);
			this.linkSourceCode.Name = "linkSourceCode";
			this.linkSourceCode.Size = new System.Drawing.Size(78, 23);
			this.linkSourceCode.TabIndex = 5;
			this.linkSourceCode.TabStop = true;
			this.linkSourceCode.Text = "Source code";
			this.linkSourceCode.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.linkSourceCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSourceCodeLinkClicked);
			// 
			// linkUsedIcon
			// 
			this.linkUsedIcon.Location = new System.Drawing.Point(80, 230);
			this.linkUsedIcon.Name = "linkUsedIcon";
			this.linkUsedIcon.Size = new System.Drawing.Size(78, 23);
			this.linkUsedIcon.TabIndex = 6;
			this.linkUsedIcon.TabStop = true;
			this.linkUsedIcon.Text = "Used Icon";
			this.linkUsedIcon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.linkUsedIcon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkUsedIconLinkClicked);
			// 
			// InfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(244, 291);
			this.Controls.Add(this.linkUsedIcon);
			this.Controls.Add(this.linkSourceCode);
			this.Controls.Add(this.lkLicense);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InfoForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Snapping";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.LinkLabel linkUsedIcon;
		private System.Windows.Forms.LinkLabel linkSourceCode;
		private System.Windows.Forms.LinkLabel lkLicense;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
