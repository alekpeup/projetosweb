/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 26/09/2024
 * Time: 08:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace radar
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		void Panel1Paint(object sender, PaintEventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			int p1 = int.Parse(textBox1.Text);
			int p2 = int.Parse(textBox3.Text);
			int t = int.Parse(textBox2.Text);
			float vm = (p2 - p1) / t;
			
			label7.Text = vm.ToString();
			
			if(vm >= 90)
			{
				label8.Text = "Passou do permitido parcero, pare ai, toma sua multinha";
				pictureBox1.Load("agente.png");
			}else{
				label8.Text = "Isso ai parcero, você está certinho";
				pictureBox1.Load("positivo.png");
			}
			
		}
	}
}
