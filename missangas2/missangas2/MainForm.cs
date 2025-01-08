/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 14/10/2024
 * Time: 13:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace missangas2
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
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			 // Criando um novo Label dinamicamente
            Label novoLabel = new Label();
            novoLabel.Text = "Novo Label Criado!";
            novoLabel.AutoSize = true;
            
            // Definindo a localização do Label (exemplo: baseado no número de controles atuais)
            novoLabel.Location = new Point(101, 9); // Ajusta a posição para cada novo label não sobrepor o anterior
            
            // Adicionando o Label ao formulário
            this.Controls.Add(novoLabel);
            
            panel2.Location.GetHashCode();
            panel2  
		}
	}
}
