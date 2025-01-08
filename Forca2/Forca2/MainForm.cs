/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 24/10/2024
 * Time: 07:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Forca2
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
		int err = 0;
		int errFinal = 0;
		
		string palavracerta;
		void Button1Click(object sender, EventArgs e)
		{
			palavracerta = textBox1.Text;
			int tamanhoPalavra = textBox1.Text.Length;
			
			
			if(tamanhoPalavra == 0)
			{ MessageBox.Show("Opa amiguinho, bota uma palavra");
				textBox1.Visible = true;
			}else{
				textBox1.Visible = false;
				button1.Visible = false;
				label1.Visible = true;
				label1.Text = "A palavra tem " + tamanhoPalavra + " letras";
				
				button2.Enabled = true;
			}
		}
		
		
		void Button2Click(object sender, EventArgs e)
		{
			
			int tamanho = textBox1.Text.Length;
			char chute = textBox2.Text[0];
			char chuteErrado =' ';
			int cont = 0;
			
			
			for (int i = 0; i < tamanho; i++)
			{
				if(chute == palavracerta[i]){
					cont++;
				}
			}
			
			if(cont > 0)
			{
				listBox1.Items.Add(chute + " > acertou!" + " Aparece " + cont + " vez(es)");
			}
			else
			{
				MessageBox.Show("Opa, você errou kkkkkkkkkk, vai la tenta outra letra");
				err++;
				chuteErrado = chute;
				
				listBox1.Items.Add(chute + ": errou, não tem");
				parteImagens();
				
			}
			
			textBox2.Clear();
			textBox2.Focus();
			if(err == 6)
			{
				textBox2.Enabled = false;
				button2.Enabled = false;
			}
			
		}
		
		
		// click do revelar
		
		void Button3Click(object sender, EventArgs e)
		{
			string tentativaPalavra = textBox3.Text;
			if(tentativaPalavra == palavracerta){
				label2.ForeColor = Color.Lime;
				label2.Text = "Parabéns você acertou";
			}
			else {
				label2.ForeColor = Color.Red;
				label2.Text = "Parabéns você errou";
				textBox3.Clear();
				textBox3.Focus();
				
				errFinal++;
			}
			
			if(errFinal  == 2)
			{
				textBox3.Enabled = false;
				button3.Enabled = false;
				textBox3.Clear();
				listBox1.Items.Clear();
				label2.Text = "A palavra era " + palavracerta + " :)";
			}
		}
		void Button4Click(object sender, EventArgs e)
		{
			err = 0;
			errFinal = 0;
			
			button1.Visible = true;
			textBox1.Visible = true;
			textBox2.Enabled = true;
			textBox3.Enabled = true;
			button3.Enabled = true;
			
			textBox1.Clear();
			listBox1.Items.Clear();
			textBox2.Clear();
			textBox3.Clear();
			
			label2.Text = "";
			label1.Text = "";
			
			pictureBox1.Visible = false;
			pictureBox2.Visible = false;
			pictureBox3.Visible = false;
			pictureBox4.Visible = false;
			pictureBox5.Visible = false;
			pictureBox6.Visible = false;
		}
		
		void parteImagens()
		{
			int tamPartesP = palavracerta.Length;

			
			for(int i = 1; i <= err; i++){
				
				switch (i)
				{
					case 1:
						pictureBox1.Visible = true;
						break;
					case 2:
						pictureBox2.Visible = true;
						break;
					case 3:
						pictureBox3.Visible = true;
						break;
					case 4:
						pictureBox4.Visible = true;
						break;
					case 5:
						pictureBox5.Visible = true;
						break;
					case 6:
						pictureBox6.Visible = true;
						break;
				}
				
			}
			
			
			
			
			
//			if(err == 1)
//			{
//				pictureBox1.Visible = true;
//			}else if(err == 2){
//				pictureBox2.Visible = true;
//			}else if(err == 3){
//				pictureBox3.Visible = true;
//			}else if(err == 4){
//				pictureBox4.Visible = true;
//			}else if(err == 5){
//				pictureBox5.Visible = true;
//			}else if(err == 6){
//				pictureBox6.Visible = true;
//			}
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		
	}
}
