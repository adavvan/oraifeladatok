/*
 * Created by SharpDevelop.
 * User: Diak
 * Date: 2019. 02. 22.
 * Time: 13:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace picturebox
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
		void Button1Click(object sender, EventArgs e)
		{
			if (button1.Text == "Start")
			{
				pictureBox1.Enabled = true;
				button1.Text = "Stop";
			}
			else
			{
				pictureBox1.Enabled = false;
				button1.Text = "Start";
			}
				
		}
		void Button2Click(object sender, EventArgs e)
		{
				Application.Exit();
		}
	}
}
