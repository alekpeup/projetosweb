/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 25/08/2024
 * Time: 00:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolProject
{
	/// <summary>
	/// Description of frmProdutos.
	/// </summary>
	public partial class frmProdutos : Form
	{
		Cliente cli = new Cliente();
			
		public frmProdutos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BEnviarClick(object sender, EventArgs e)
		{
			
			cli.Codigo = tCodigo.Text;
			cli.Nome = tNome.Text;
			cli.Endereco = tEndereco.Text;
			cli.Telefone = tTelefone.Text;
			cli.Pessoa = cPessoaFisica.Checked;
		
		
		}
		void BExcluirClick(object sender, EventArgs e)
		{
			MessageBox.Show(cli.Nome);
			
		}
	}
	
	public class Cliente
	{
		public string Codigo {get; set; } 
		public string Nome {get; set; }
		public string Endereco {get; set; }
		public string Telefone {get; set; }
		public bool Pessoa {get; set; }
	}
}
