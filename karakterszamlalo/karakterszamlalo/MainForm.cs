/*
 * Created by SharpDevelop.
 * User: Diak
 * Date: 2019. 02. 27.
 * Time: 11:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace karakterszamlalo
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
		
		public int szamol(string szo, string betu)
		{
			int szam = 0;
			for(int i = 0; i < szo.Length; i++)
			{
				if (szo[i] == char.Parse(betu))
				{
					szam++;
				}
			}
			return szam;
		}
		void SzamolasClick(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(szo_textbox.Text) || string.IsNullOrWhiteSpace(karakter_textbox.Text))
			{
				MessageBox.Show("Üresen hagytad a szó és/vagy karakter mezőt!","Hiba");
			}
			else
				eredmeny.Text = szamol(szo_textbox.Text, karakter_textbox.Text).ToString();
		}
		void KilepesClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
