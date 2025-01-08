using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NostradamusTelecomunicacao
{
	public partial class MainForm : Form
	{
		public MainForm()
		{	
			InitializeComponent();
		}
		
		// vetores
		string[] funcionarios = {
			"Lucas Almeida",  
			"Gabriela Costa",  
			"Rafael Pereira",  
			"Ana Clara Souza",  
			"João Silva",  
			"Mariana Oliveira",  
			"Felipe Santos",  
			"Beatriz Lima",  
			"Gabriel Rocha",  
			"Camila Martins",  
			"Thiago Souza",  
			"Luana Barbosa",  
			"Felipe Costa",  
			"Larissa Moreira",  
			"Victor Hugo Fernandes",  
			"Vanessa Ribeiro",  
			"Gustavo Oliveira",  
			"Carolina Almeida",  
			"Bruno Pereira",  
			"Amanda Silva",  
			"Jorge Santos",  
			"Renata Costa",  
			"Diego Alves",  
			"Juliana Machado",  
			"Caio Barbosa",  
			"Roberta Ribeiro",  
			"Igor Souza",  
			"Fernanda Lima",  
			"Daniel Martins",  
			"Sofia Gomes",  
		};
		
		long[] telefones = {
			11912345678,
			21987654321,
			31998765432,
			41998654321,
			51987654321,
			61981234567,
			71993456789,
			81988776543,
			91985432121,
			92987651234,
			11943215678,
			21998765432,
			31977654321,
			41987433210,
			51985674321,
			61996542310,
			71981234567,
			81963219876,
			91992345678,
			92961234567,
			11945671234,
			21988998765,
			31933224455,
			41987234568,
			51973216547,
			61999876543,
			71920109876,
			81912347654,
			91993456789,
			92979876543,
		};
		
		
		double[] gastos = {
		 	85.20, 
		 	95.50, 
		 	110.40,
		 	102.30, 
		 	98.00,
		    104.70, 
		    99.90,
		    120.60, 
		    88.20,
		    97.80, 
		    105.50,
		    115.40, 
		    90.70,
		    94.30, 
		    108.10,
		    87.90, 
		    96.20,
		    92.50, 
		    112.30,
		    107.00,
		    101.80, 
		    89.60, 
		    113.90, 
		    100.00, 
		    91.40,
		    109.70, 
		    103.50, 
		    106.30, 
		    93.80, 
		    98.90
		};
		
		
	 	// variaveis que serão usadas nos eventos
	    int qtdgastos;
	    double media;
	    
	    // contador pra saber quantos gastões tem
	    int count = 0;
	    
	    // button para calcular a media
		void Button1Click(object sender, EventArgs e)
		{
			double soma = 0;
			
			qtdgastos = gastos.Length;
			
			// loop para somar os valores
			for (int i = 0; i < qtdgastos; i++) {
				soma += gastos[i];
			}
			
			media = soma / qtdgastos;
			
			listBox2.Items.Add("R$ " + media.ToString("F2"));
			 button1.Enabled = false;
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			// loop para verificar quem é o gastão
			for(int i = 0; i < qtdgastos; i++){
				if( gastos[i] > media){
					listBox1.Items.Add(("Nome: ").ToUpper() + funcionarios[i] + " ----  Telefone: ".ToUpper() + telefones[i] + " ------   " + (gastos[i]).ToString("C"));
					listBox1.Items.Add(" ");
					listBox1.Items.Add(" ");
					count++;
				}
				
			}
			label3.Text = "Total de " + count + " gastões";
			button2.Enabled = false;
		}
	}
}
