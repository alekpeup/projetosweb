using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CadastroNotasAlunos
{
	
	public partial class MainForm : Form
	{

		public MainForm()
		{
			
			InitializeComponent();
		}
		
		
//		string[] nomes = new string[5];
		string nome;
		float[] notas = new float[5];
		int cont = 0;
		int mediafinal = 7;
		void Button2Click(object sender, EventArgs e)
		{
			nome = textBox1.Text;
			textBox1.Enabled = false;
		}
		void Button1Click(object sender, EventArgs e)
		{
			
			
			notas[cont] = float.Parse(textBox2.Text);
			textBox2.Clear();
			cont++;
			if(cont == 5){
				textBox2.Enabled = false;
			}
			
			
		}
		void Button3Click(object sender, EventArgs e)
		{
			
			float mediaaluno = 0;
			for (int i = 0; i < cont; i++) {
			    
				mediaaluno += notas[i];
			}
			double mediafinA = mediaaluno / notas.Length;
			
			for (int i = 1; i < cont; i++) {
					if(mediafinA < mediafinal){
				listareprovados.Items.Add(nome  + " - " + mediafinA);
			}else{
				listaaprovados.Items.Add(nome + " - " + mediafinA);
			}
			}
			
		
		}
		
	
	
	
	}
}
