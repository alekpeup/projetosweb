using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace testandoTeste
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			
			string phrase = textBox1.Text;
			string[] words = phrase.Split(' ');
			int qtdletrinhas = words[0].Length + words[1].Length;
			int qtdwords = words.Length;
			qtdWord.Text = "A frase tem " + qtdwords + " Palavras";
			qtdLetras.Text = "Tem " + qtdletrinhas + " letras";
			
		}
	}
}
