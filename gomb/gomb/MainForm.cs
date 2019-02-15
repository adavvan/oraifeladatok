/*
 * Created by SharpDevelop.
 * User: Diak
 * Date: 2019. 02. 13.
 * Time: 8:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace gomb
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
		
		void Button1MouseEnter(object sender, EventArgs e)
		{
			Random rnd = new Random();
			button1.Location = new Point(rnd.Next(0,750), rnd.Next(0,550));
		}

	}
}
