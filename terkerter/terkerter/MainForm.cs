/*
 * Created by SharpDevelop.
 * User: Diak
 * Date: 2019. 02. 15.
 * Time: 7:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace terkerter
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		float ker;
		float ter;
		
		void Button1Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(a_box.Text) || string.IsNullOrWhiteSpace(b_box.Text)) {
				MessageBox.Show("Az a és/vagy b oldal nem lett megadva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				float a = float.Parse(a_box.Text);
				float b = float.Parse(b_box.Text);
				ter = a*b;
				erdmeny_box.Text = ter.ToString();
				terulet.Enabled = false;
			}
		}
		void KeruletClick(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(a_box.Text) || string.IsNullOrWhiteSpace(b_box.Text)) {
				MessageBox.Show("Az a és/vagy b oldal nem lett megadva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				float a = float.Parse(a_box.Text);
				float b = float.Parse(b_box.Text);
				ker = (a+b)*2;
				erdmeny_box.Text = ker.ToString();
				kerulet.Enabled = false;
			}
		}
		void ResetClick(object sender, EventArgs e)
		{
			a_box.Text = "";
			b_box.Text = "";
			erdmeny_box.Text = "";
			kerulet.Enabled = true;
			terulet.Enabled = true;
		}
		void KilepesClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
	}
}
