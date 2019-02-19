/*
 * Created by SharpDevelop.
 * User: Diak
 * Date: 2019. 02. 19.
 * Time: 13:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace hatterszinvaltoztato
{
	partial class ablak
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button piros;
		private System.Windows.Forms.Button kek;
		private System.Windows.Forms.Button zold;
		private System.Windows.Forms.Button kilepes;
		private System.Windows.Forms.Button reset;
		private System.Windows.Forms.Button veletlen;
		
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
			this.piros = new System.Windows.Forms.Button();
			this.kek = new System.Windows.Forms.Button();
			this.zold = new System.Windows.Forms.Button();
			this.kilepes = new System.Windows.Forms.Button();
			this.reset = new System.Windows.Forms.Button();
			this.veletlen = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// piros
			// 
			this.piros.Location = new System.Drawing.Point(589, 101);
			this.piros.Name = "piros";
			this.piros.Size = new System.Drawing.Size(84, 53);
			this.piros.TabIndex = 0;
			this.piros.Text = "Piros";
			this.piros.UseVisualStyleBackColor = true;
			this.piros.Click += new System.EventHandler(this.PirosClick);
			this.piros.MouseEnter += new System.EventHandler(this.PirosMouseEnter);
			this.piros.MouseLeave += new System.EventHandler(this.PirosMouseLeave);
			// 
			// kek
			// 
			this.kek.Location = new System.Drawing.Point(589, 193);
			this.kek.Name = "kek";
			this.kek.Size = new System.Drawing.Size(84, 53);
			this.kek.TabIndex = 1;
			this.kek.Text = "Kék";
			this.kek.UseVisualStyleBackColor = true;
			this.kek.Click += new System.EventHandler(this.KekClick);
			this.kek.MouseEnter += new System.EventHandler(this.KekMouseEnter);
			this.kek.MouseLeave += new System.EventHandler(this.KekMouseLeave);
			// 
			// zold
			// 
			this.zold.Location = new System.Drawing.Point(589, 296);
			this.zold.Name = "zold";
			this.zold.Size = new System.Drawing.Size(84, 53);
			this.zold.TabIndex = 2;
			this.zold.Text = "Zöld";
			this.zold.UseVisualStyleBackColor = true;
			this.zold.Click += new System.EventHandler(this.ZoldClick);
			this.zold.MouseEnter += new System.EventHandler(this.ZoldMouseEnter);
			this.zold.MouseLeave += new System.EventHandler(this.ZoldMouseLeave);
			// 
			// kilepes
			// 
			this.kilepes.Location = new System.Drawing.Point(675, 496);
			this.kilepes.Name = "kilepes";
			this.kilepes.Size = new System.Drawing.Size(84, 53);
			this.kilepes.TabIndex = 3;
			this.kilepes.Text = "Kilépés";
			this.kilepes.UseVisualStyleBackColor = true;
			this.kilepes.Click += new System.EventHandler(this.KilepesClick);
			// 
			// reset
			// 
			this.reset.Location = new System.Drawing.Point(32, 496);
			this.reset.Name = "reset";
			this.reset.Size = new System.Drawing.Size(84, 53);
			this.reset.TabIndex = 4;
			this.reset.Text = "Reset";
			this.reset.UseVisualStyleBackColor = true;
			this.reset.Click += new System.EventHandler(this.ResetClick);
			// 
			// veletlen
			// 
			this.veletlen.Location = new System.Drawing.Point(589, 398);
			this.veletlen.Name = "veletlen";
			this.veletlen.Size = new System.Drawing.Size(84, 53);
			this.veletlen.TabIndex = 5;
			this.veletlen.Text = "Véletlen";
			this.veletlen.UseVisualStyleBackColor = true;
			this.veletlen.Click += new System.EventHandler(this.VeletlenClick);
			this.veletlen.MouseEnter += new System.EventHandler(this.VeletlenMouseEnter);
			this.veletlen.MouseLeave += new System.EventHandler(this.VeletlenMouseLeave);
			// 
			// ablak
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.veletlen);
			this.Controls.Add(this.reset);
			this.Controls.Add(this.kilepes);
			this.Controls.Add(this.zold);
			this.Controls.Add(this.kek);
			this.Controls.Add(this.piros);
			this.Name = "ablak";
			this.Text = "hatterszinvaltoztato";
			this.ResumeLayout(false);

		}
	}
}
