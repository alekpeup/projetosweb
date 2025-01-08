/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 05/09/2024
 * Time: 00:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ceramica
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
		 		
			// recebendo valores
			
			int paLargu = int.Parse(paLarg.Text);
			int paCompr = int.Parse(paComp.Text);
			
			float ceLargu = float.Parse(ceLarg.Text);
			float ceCompr = float.Parse(ceComp.Text);
			
			
			// contas
			float qtdLarg = paLargu / ceLargu;
			float qtdComp = paCompr / ceCompr;
			
			int qtdLargArr = (int)Math.Ceiling(qtdLarg);
			int qtdCompArr = (int)Math.Ceiling(qtdComp);
			
			int qtdTotal = qtdLargArr * qtdCompArr;
			
			// saidas
			textBox2.Text = qtdCompArr.ToString();
			textBox1.Text = qtdLargArr.ToString();
			qtdLargFinal.Text = qtdLarg.ToString();
			qtdCompFinal.Text = qtdComp.ToString();
			qtdFinal.Text = qtdTotal.ToString();
		 	
		 	
		}
		
	}
}
