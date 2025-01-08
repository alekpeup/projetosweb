using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PoolCleaning
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void BCalcularTamanhoClick(object sender, EventArgs e)
		{	
			// recebendo os dados
			int profundidade = int.Parse(tProfundidade.Text); 
			int comprimento = int.Parse(tComprimento.Text); 
			int  largura = int.Parse(tLargura.Text);
			
			// calculo m³
			int mTotal = profundidade * comprimento * largura;
			
			// saida
			laTamanhoTotal.Text = mTotal + "m³";
			
			
			
			// orcamento
			
			float orcamento;
			
			const float valorfixo = 49.99f;
			
			orcamento = valorfixo + mTotal + 250.00f;
			label5.Text = orcamento.ToString("C");
		}
		
	}
}
