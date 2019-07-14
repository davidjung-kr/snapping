/*
 * Created by SharpDevelop.
 * User: ZHANITEST
 * Date: 2019-07-14
 * Time: 오전 12:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Snapping
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.lbPorts = new System.Windows.Forms.ListBox();
			this.tbOs = new System.Windows.Forms.TextBox();
			this.tbRam = new System.Windows.Forms.TextBox();
			this.tbGpu = new System.Windows.Forms.TextBox();
			this.tbCpu = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.rtbReport = new System.Windows.Forms.RichTextBox();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnOutText = new System.Windows.Forms.Button();
			this.lbStatus = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(560, 257);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.lbPorts);
			this.tabPage1.Controls.Add(this.tbOs);
			this.tabPage1.Controls.Add(this.tbRam);
			this.tabPage1.Controls.Add(this.tbGpu);
			this.tabPage1.Controls.Add(this.tbCpu);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 24);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(552, 229);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Pretty View";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// lbPorts
			// 
			this.lbPorts.FormattingEnabled = true;
			this.lbPorts.ItemHeight = 15;
			this.lbPorts.Location = new System.Drawing.Point(6, 139);
			this.lbPorts.Name = "lbPorts";
			this.lbPorts.Size = new System.Drawing.Size(540, 79);
			this.lbPorts.TabIndex = 8;
			// 
			// tbOs
			// 
			this.tbOs.Location = new System.Drawing.Point(61, 82);
			this.tbOs.Name = "tbOs";
			this.tbOs.ReadOnly = true;
			this.tbOs.Size = new System.Drawing.Size(485, 21);
			this.tbOs.TabIndex = 7;
			// 
			// tbRam
			// 
			this.tbRam.Location = new System.Drawing.Point(60, 55);
			this.tbRam.Name = "tbRam";
			this.tbRam.ReadOnly = true;
			this.tbRam.Size = new System.Drawing.Size(486, 21);
			this.tbRam.TabIndex = 6;
			// 
			// tbGpu
			// 
			this.tbGpu.Location = new System.Drawing.Point(61, 28);
			this.tbGpu.Name = "tbGpu";
			this.tbGpu.ReadOnly = true;
			this.tbGpu.Size = new System.Drawing.Size(485, 21);
			this.tbGpu.TabIndex = 5;
			// 
			// tbCpu
			// 
			this.tbCpu.Location = new System.Drawing.Point(60, 4);
			this.tbCpu.Name = "tbCpu";
			this.tbCpu.ReadOnly = true;
			this.tbCpu.Size = new System.Drawing.Size(486, 21);
			this.tbCpu.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 113);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(120, 23);
			this.label5.TabIndex = 3;
			this.label5.Text = "Opend Serial Port:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "OS/SP:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "RAM:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "GPU:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "CPU:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.rtbReport);
			this.tabPage2.Location = new System.Drawing.Point(4, 24);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(552, 229);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Plain Text";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// rtbReport
			// 
			this.rtbReport.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbReport.Location = new System.Drawing.Point(7, 7);
			this.rtbReport.Name = "rtbReport";
			this.rtbReport.ReadOnly = true;
			this.rtbReport.Size = new System.Drawing.Size(539, 216);
			this.rtbReport.TabIndex = 0;
			this.rtbReport.Text = "";
			// 
			// btnRefresh
			// 
			this.btnRefresh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefresh.Location = new System.Drawing.Point(412, 275);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(75, 23);
			this.btnRefresh.TabIndex = 2;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.BtnRefreshClick);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(16, 275);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(30, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "&?";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnOutText
			// 
			this.btnOutText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOutText.Location = new System.Drawing.Point(493, 276);
			this.btnOutText.Name = "btnOutText";
			this.btnOutText.Size = new System.Drawing.Size(75, 23);
			this.btnOutText.TabIndex = 4;
			this.btnOutText.Text = "Get text file";
			this.btnOutText.UseVisualStyleBackColor = true;
			this.btnOutText.Click += new System.EventHandler(this.BtnOutTextClick);
			// 
			// lbStatus
			// 
			this.lbStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbStatus.ForeColor = System.Drawing.Color.Blue;
			this.lbStatus.Location = new System.Drawing.Point(206, 276);
			this.lbStatus.Name = "lbStatus";
			this.lbStatus.Size = new System.Drawing.Size(200, 23);
			this.lbStatus.TabIndex = 5;
			this.lbStatus.Text = "Updated! - 2019/07/14 05:00:00";
			this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 311);
			this.Controls.Add(this.lbStatus);
			this.Controls.Add(this.btnOutText);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Snapping";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ListBox lbPorts;
		private System.Windows.Forms.Label lbStatus;
		private System.Windows.Forms.TextBox tbGpu;
		private System.Windows.Forms.TextBox tbRam;
		private System.Windows.Forms.TextBox tbOs;
		private System.Windows.Forms.TextBox tbCpu;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnOutText;
		private System.Windows.Forms.RichTextBox rtbReport;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
	}
}
