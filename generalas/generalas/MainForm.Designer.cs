/*
 * Created by SharpDevelop.
 * User: Diak
 * Date: 2019. 02. 14.
 * Time: 7:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace generalas
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox generalt_mezo;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox novekvo_mezo;
		private System.Windows.Forms.Button novekvo;
		private System.Windows.Forms.Button csokkeno;
		private System.Windows.Forms.TextBox csokkeno_mezo;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		
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
			this.generalt_mezo = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.novekvo_mezo = new System.Windows.Forms.TextBox();
			this.novekvo = new System.Windows.Forms.Button();
			this.csokkeno = new System.Windows.Forms.Button();
			this.csokkeno_mezo = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// generalt_mezo
			// 
			this.generalt_mezo.Location = new System.Drawing.Point(45, 46);
			this.generalt_mezo.Name = "generalt_mezo";
			this.generalt_mezo.Size = new System.Drawing.Size(369, 20);
			this.generalt_mezo.TabIndex = 0;
			this.generalt_mezo.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(600, 34);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(95, 43);
			this.button1.TabIndex = 1;
			this.button1.Text = "Generálás";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// novekvo_mezo
			// 
			this.novekvo_mezo.Location = new System.Drawing.Point(45, 145);
			this.novekvo_mezo.Name = "novekvo_mezo";
			this.novekvo_mezo.Size = new System.Drawing.Size(369, 20);
			this.novekvo_mezo.TabIndex = 2;
			// 
			// novekvo
			// 
			this.novekvo.Location = new System.Drawing.Point(600, 133);
			this.novekvo.Name = "novekvo";
			this.novekvo.Size = new System.Drawing.Size(94, 43);
			this.novekvo.TabIndex = 3;
			this.novekvo.Text = "Növekvő";
			this.novekvo.UseVisualStyleBackColor = true;
			this.novekvo.Click += new System.EventHandler(this.NovekvoClick);
			// 
			// csokkeno
			// 
			this.csokkeno.Location = new System.Drawing.Point(600, 258);
			this.csokkeno.Name = "csokkeno";
			this.csokkeno.Size = new System.Drawing.Size(94, 43);
			this.csokkeno.TabIndex = 4;
			this.csokkeno.Text = "Csökkenő";
			this.csokkeno.UseVisualStyleBackColor = true;
			this.csokkeno.Click += new System.EventHandler(this.CsokkenoClick);
			// 
			// csokkeno_mezo
			// 
			this.csokkeno_mezo.Location = new System.Drawing.Point(45, 270);
			this.csokkeno_mezo.Name = "csokkeno_mezo";
			this.csokkeno_mezo.Size = new System.Drawing.Size(369, 20);
			this.csokkeno_mezo.TabIndex = 5;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(71, 472);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(89, 35);
			this.button2.TabIndex = 6;
			this.button2.Text = "Új";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(600, 464);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(112, 50);
			this.button3.TabIndex = 7;
			this.button3.Text = "Exit";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.csokkeno_mezo);
			this.Controls.Add(this.csokkeno);
			this.Controls.Add(this.novekvo);
			this.Controls.Add(this.novekvo_mezo);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.generalt_mezo);
			this.Name = "MainForm";
			this.Text = "Új";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
