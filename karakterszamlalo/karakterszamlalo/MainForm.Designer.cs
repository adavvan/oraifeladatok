/*
 * Created by SharpDevelop.
 * User: Diak
 * Date: 2019. 02. 27.
 * Time: 11:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace karakterszamlalo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox szo_textbox;
		private System.Windows.Forms.TextBox karakter_textbox;
		private System.Windows.Forms.Button szamolas;
		private System.Windows.Forms.Button kilepes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox eredmeny;
		
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
			this.szo_textbox = new System.Windows.Forms.TextBox();
			this.karakter_textbox = new System.Windows.Forms.TextBox();
			this.szamolas = new System.Windows.Forms.Button();
			this.kilepes = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.eredmeny = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// szo_textbox
			// 
			this.szo_textbox.Location = new System.Drawing.Point(144, 72);
			this.szo_textbox.Name = "szo_textbox";
			this.szo_textbox.Size = new System.Drawing.Size(103, 20);
			this.szo_textbox.TabIndex = 0;
			// 
			// karakter_textbox
			// 
			this.karakter_textbox.Location = new System.Drawing.Point(144, 119);
			this.karakter_textbox.MaxLength = 1;
			this.karakter_textbox.Name = "karakter_textbox";
			this.karakter_textbox.Size = new System.Drawing.Size(36, 20);
			this.karakter_textbox.TabIndex = 1;
			// 
			// szamolas
			// 
			this.szamolas.Location = new System.Drawing.Point(41, 178);
			this.szamolas.Name = "szamolas";
			this.szamolas.Size = new System.Drawing.Size(57, 28);
			this.szamolas.TabIndex = 2;
			this.szamolas.Text = "Számolj";
			this.szamolas.UseVisualStyleBackColor = true;
			this.szamolas.Click += new System.EventHandler(this.SzamolasClick);
			// 
			// kilepes
			// 
			this.kilepes.Location = new System.Drawing.Point(354, 313);
			this.kilepes.Name = "kilepes";
			this.kilepes.Size = new System.Drawing.Size(95, 62);
			this.kilepes.TabIndex = 3;
			this.kilepes.Text = "Exit";
			this.kilepes.UseVisualStyleBackColor = true;
			this.kilepes.Click += new System.EventHandler(this.KilepesClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(38, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Szó:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(38, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Keresett karakter";
			// 
			// eredmeny
			// 
			this.eredmeny.Enabled = false;
			this.eredmeny.Location = new System.Drawing.Point(144, 183);
			this.eredmeny.Name = "eredmeny";
			this.eredmeny.Size = new System.Drawing.Size(36, 20);
			this.eredmeny.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 413);
			this.Controls.Add(this.eredmeny);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.kilepes);
			this.Controls.Add(this.szamolas);
			this.Controls.Add(this.karakter_textbox);
			this.Controls.Add(this.szo_textbox);
			this.Name = "MainForm";
			this.Text = "karakterszamlalo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		}
	}

