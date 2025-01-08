/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 23/10/2024
 * Time: 11:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ForcaPrimeiroTeste
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
		 	int tamanhoPalavra = textBox1.Text.Length;
		 	
		 	textBox1.Visible = false;
		 	button1.Visible = false;
		 	
		 	label1.Text = "A palavra tem " + tamanhoPalavra + " letras";
		 	button2.Enabled = true;
		 	
		}
		void Button2Click(object sender, EventArgs e)
		{
			string palavracerta = textBox1.Text;
			int tamanhopalava = textBox1.Text.Length;
			string letra = textBox2.Text;
			int contCerto = 0;
			int contErrado = 0;
			
			
			for(int i = 0; i < letra.Length; i++)
			{
				if(i < tamanhopalava)
				{
					if(letra[i] == palavracerta)
				}
				
			}
			
			
		}
	}
}


/*
 * if(letra == palavracerta[i]){
					contCerto++;
					listBox1.Items.Add(letra + ": correto aparece " + contCerto + "vezes" );
					
				}else if(letra != palavracerta[i]){
					listBox1.Items.Add(letra + ": errado");
					contErrado++;
				}
				textBox2.Clear();
*/