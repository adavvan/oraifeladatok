/*
 * Created by SharpDevelop.
 * User: Diak
 * Date: 2019. 02. 28.
 * Time: 8:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace lebel
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button bal;
		private System.Windows.Forms.Button jobb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button kilepes;
		
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
			this.bal = new System.Windows.Forms.Button();
			this.jobb = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.kilepes = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bal
			// 
			this.bal.Location = new System.Drawing.Point(43, 35);
			this.bal.Name = "bal";
			this.bal.Size = new System.Drawing.Size(55, 35);
			this.bal.TabIndex = 0;
			this.bal.Text = "Bal";
			this.bal.UseVisualStyleBackColor = true;
			this.bal.Click += new System.EventHandler(this.BalClick);
			// 
			// jobb
			// 
			this.jobb.Location = new System.Drawing.Point(621, 35);
			this.jobb.Name = "jobb";
			this.jobb.Size = new System.Drawing.Size(55, 35);
			this.jobb.TabIndex = 1;
			this.jobb.Text = "Jobb";
			this.jobb.UseVisualStyleBackColor = true;
			this.jobb.Click += new System.EventHandler(this.JobbClick);
			// 
			// label1
			// 
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.Location = new System.Drawing.Point(346, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 50);
			this.label1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(168, 210);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 50);
			this.label2.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
			this.label3.Location = new System.Drawing.Point(346, 301);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 50);
			this.label3.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
			this.label4.Location = new System.Drawing.Point(500, 210);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 50);
			this.label4.TabIndex = 5;
			// 
			// kilepes
			// 
			this.kilepes.Location = new System.Drawing.Point(626, 409);
			this.kilepes.Name = "kilepes";
			this.kilepes.Size = new System.Drawing.Size(50, 33);
			this.kilepes.TabIndex = 6;
			this.kilepes.Text = "Exit";
			this.kilepes.UseVisualStyleBackColor = true;
			this.kilepes.Click += new System.EventHandler(this.KilepesClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(720, 454);
			this.Controls.Add(this.kilepes);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.jobb);
			this.Controls.Add(this.bal);
			this.Name = "MainForm";
			this.Text = "lebel";
			this.ResumeLayout(false);

		}
	}
}
