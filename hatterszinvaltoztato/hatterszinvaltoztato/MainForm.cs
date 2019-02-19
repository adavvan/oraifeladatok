/*
 * Created by SharpDevelop.
 * User: Diak
 * Date: 2019. 02. 19.
 * Time: 13:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace hatterszinvaltoztato
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class ablak : Form
	{
		public ablak()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		string hatter = "ures";
		
		void PirosClick(object sender, EventArgs e)
		{
			BackColor = Color.Red;
			hatter = "piros";
		}
		void KekClick(object sender, EventArgs e)
		{
			BackColor = Color.Blue;
			hatter = "kek";
		}
		void ZoldClick(object sender, EventArgs e)
		{
			BackColor = Color.Green;
			hatter = "zold";
		}
		void ResetClick(object sender, EventArgs e)
		{
			BackColor = ablak.DefaultBackColor;
		}
		void VeletlenClick(object sender, EventArgs e)
		{
			Random rnd = new Random();
			int szam = rnd.Next(1,4);
			switch(szam)
			{
				case 1: BackColor = Color.Red; hatter = "piros";
					break;
				case 2: BackColor = Color.Blue; hatter = "kek";
					break;
				case 3: BackColor = Color.Green; hatter = "zold";
					break;	
			}
		}
		void PirosMouseEnter(object sender, EventArgs e)
		{
			BackColor = Color.Red;
		}
		void ZoldMouseEnter(object sender, EventArgs e)
		{
			BackColor = Color.Green;
		}

		void KekMouseEnter(object sender, EventArgs e)
		{
			BackColor = Color.Blue;
		}
		void KekMouseLeave(object sender, EventArgs e)
		{
			if (hatter == "piros")
				BackColor = Color.Red;
			if (hatter == "kek")
				BackColor = Color.Blue;
			if (hatter == "zold")
				BackColor = Color.Green;
			if (hatter == "ures")
				BackColor = ablak.DefaultBackColor;
		}
		void PirosMouseLeave(object sender, EventArgs e)
		{
			if (hatter == "piros")
				BackColor = Color.Red;
			if (hatter == "kek")
				BackColor = Color.Blue;
			if (hatter == "zold")
				BackColor = Color.Green;
			if (hatter == "ures")
				BackColor = ablak.DefaultBackColor;
		}
		void ZoldMouseLeave(object sender, EventArgs e)
		{
			if (hatter == "piros")
				BackColor = Color.Red;
			if (hatter == "kek")
				BackColor = Color.Blue;
			if (hatter == "zold")
				BackColor = Color.Green;
			if (hatter == "ures")
				BackColor = ablak.DefaultBackColor;
		}
		void VeletlenMouseEnter(object sender, EventArgs e)
		{
			Random rnd = new Random();
			int szam = rnd.Next(1,4);
			switch(szam)
			{
				case 1: BackColor = Color.Red;
					break;
				case 2: BackColor = Color.Blue;
					break;
				case 3: BackColor = Color.Green;
					break;	
			}
		}
		void VeletlenMouseLeave(object sender, EventArgs e)
		{
			if (hatter == "piros")
				BackColor = Color.Red;
			if (hatter == "kek")
				BackColor = Color.Blue;
			if (hatter == "zold")
				BackColor = Color.Green;
						if (hatter == "ures")
				BackColor = ablak.DefaultBackColor;
		}
		void KilepesClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
