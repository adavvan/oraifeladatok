/*
 * Created by SharpDevelop.
 * User: Diak
 * Date: 2019. 02. 15.
 * Time: 7:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace terkerter
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button terulet;
		private System.Windows.Forms.Button kerulet;
		private System.Windows.Forms.TextBox a_box;
		private System.Windows.Forms.TextBox b_box;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox erdmeny_box;
		private System.Windows.Forms.Button reset;
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
			this.terulet = new System.Windows.Forms.Button();
			this.kerulet = new System.Windows.Forms.Button();
			this.a_box = new System.Windows.Forms.TextBox();
			this.b_box = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.erdmeny_box = new System.Windows.Forms.TextBox();
			this.reset = new System.Windows.Forms.Button();
			this.kilepes = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// terulet
			// 
			this.terulet.Location = new System.Drawing.Point(455, 223);
			this.terulet.Name = "terulet";
			this.terulet.Size = new System.Drawing.Size(108, 48);
			this.terulet.TabIndex = 0;
			this.terulet.Text = "Terület";
			this.terulet.UseVisualStyleBackColor = true;
			this.terulet.Click += new System.EventHandler(this.Button1Click);
			// 
			// kerulet
			// 
			this.kerulet.Location = new System.Drawing.Point(125, 223);
			this.kerulet.Name = "kerulet";
			this.kerulet.Size = new System.Drawing.Size(108, 48);
			this.kerulet.TabIndex = 1;
			this.kerulet.Text = "Kerület";
			this.kerulet.UseVisualStyleBackColor = true;
			this.kerulet.Click += new System.EventHandler(this.KeruletClick);
			// 
			// a_box
			// 
			this.a_box.Location = new System.Drawing.Point(125, 69);
			this.a_box.Name = "a_box";
			this.a_box.Size = new System.Drawing.Size(97, 20);
			this.a_box.TabIndex = 2;
			// 
			// b_box
			// 
			this.b_box.Location = new System.Drawing.Point(465, 69);
			this.b_box.Name = "b_box";
			this.b_box.Size = new System.Drawing.Size(97, 20);
			this.b_box.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(52, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 18);
			this.label1.TabIndex = 4;
			this.label1.Text = "a oldal:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(400, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 18);
			this.label2.TabIndex = 5;
			this.label2.Text = "b oldal:";
			// 
			// erdmeny_box
			// 
			this.erdmeny_box.Location = new System.Drawing.Point(292, 238);
			this.erdmeny_box.Name = "erdmeny_box";
			this.erdmeny_box.Size = new System.Drawing.Size(111, 20);
			this.erdmeny_box.TabIndex = 6;
			// 
			// reset
			// 
			this.reset.Location = new System.Drawing.Point(125, 426);
			this.reset.Name = "reset";
			this.reset.Size = new System.Drawing.Size(107, 46);
			this.reset.TabIndex = 7;
			this.reset.Text = "Reset";
			this.reset.UseVisualStyleBackColor = true;
			this.reset.Click += new System.EventHandler(this.ResetClick);
			// 
			// kilepes
			// 
			this.kilepes.Location = new System.Drawing.Point(455, 426);
			this.kilepes.Name = "kilepes";
			this.kilepes.Size = new System.Drawing.Size(107, 46);
			this.kilepes.TabIndex = 8;
			this.kilepes.Text = "Kilépés";
			this.kilepes.UseVisualStyleBackColor = true;
			this.kilepes.Click += new System.EventHandler(this.KilepesClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(664, 515);
			this.Controls.Add(this.kilepes);
			this.Controls.Add(this.reset);
			this.Controls.Add(this.erdmeny_box);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.b_box);
			this.Controls.Add(this.a_box);
			this.Controls.Add(this.kerulet);
			this.Controls.Add(this.terulet);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "terkerter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		}
	}

