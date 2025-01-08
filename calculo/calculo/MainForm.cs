using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace calculo
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			int numero_1 = int.Parse(tPrimeiro.Text);
			int numero_2 = int.Parse(tPrimeiro.Text);
			int numero_3 = int.Parse(tPrimeiro.Text);
			int numero_maior = numero_1;
			
			if (numero_2 > numero_3 && numero_2 > numero_1){
				if(numero_3 > numero_2 && numero_3 > numero_1){
					numero_maior = numero_3;
				}
				numero_maior = numero_2;
				tOmaior.Text = numero_maior.ToString();
			} else {
			
			}
		}
	}
}
