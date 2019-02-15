/*
 * Created by SharpDevelop.
 * User: Diak
 * Date: 2019. 02. 14.
 * Time: 7:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace generalas
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
		
		}
		int[] generalt_szamok = new int[10];
		bool gen_megnyomva = false;
		bool nov_megnyomva = false;
		bool csokk_megnyomva = false;
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			if(gen_megnyomva == false){
			Random rnd = new Random();
			for (int i = 0; i < 10; i++)
			{
				int szam = rnd.Next(-100, 100);
				generalt_szamok[i] = szam;
				string s_szam = szam.ToString();
				generalt_mezo.AppendText(s_szam);
				generalt_mezo.AppendText("; ");
			}
			gen_megnyomva = true;
			}
		}
		void NovekvoClick(object sender, EventArgs e)
		{
			if(nov_megnyomva == false)
			{
				int[] novekvo_szamok = generalt_szamok;
				Array.Sort(novekvo_szamok);
				for (int i = 0; i < novekvo_szamok.Length; i++)
				{
					novekvo_mezo.AppendText(novekvo_szamok[i].ToString());
					novekvo_mezo.AppendText("; ");
				}
				nov_megnyomva = true;
			}
		}
		void CsokkenoClick(object sender, EventArgs e)
		{
			if (csokk_megnyomva == false)
			{
				int[] csokkeno_szamok = generalt_szamok;
				Array.Sort(csokkeno_szamok);
				Array.Reverse(csokkeno_szamok);
				for (int i = 0; i < csokkeno_szamok.Length; i++)
				{
					csokkeno_mezo.AppendText(csokkeno_szamok[i].ToString());
					csokkeno_mezo.AppendText("; ");
				}
				csokk_megnyomva = true;
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			generalt_mezo.Clear();
			novekvo_mezo.Clear();
			csokkeno_mezo.Clear();
			gen_megnyomva = false;
		    nov_megnyomva = false;
		    csokk_megnyomva = false;
		}
		void Button3Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

	}
}
