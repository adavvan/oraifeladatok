/*
 * Created by SharpDevelop.
 * User: Diak
 * Date: 2019. 02. 28.
 * Time: 8:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lebel
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
		void JobbClick(object sender, EventArgs e)
		{
			Image s = label1.Image;
			label1.Image = label2.Image;
			label2.Image = label3.Image;
			label3.Image = label4.Image;
			label4.Image = s;
		}
		void BalClick(object sender, EventArgs e)
		{
			Image s = label1.Image;
			label1.Image = label4.Image;
			label4.Image = label3.Image;
			label3.Image = label2.Image;
			label2.Image = s;
		}
		void KilepesClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
