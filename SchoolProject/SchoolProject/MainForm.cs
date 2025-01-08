/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 24/08/2024
 * Time: 23:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolProject
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
		void ClientesToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmCliente jan = new frmCliente();
			jan.Show();
			
		}
		void ToolStripLabel1Click(object sender, EventArgs e)
		{
	
		}
		void ProdutosToolStripMenuItemClick(object sender, EventArgs e)
		{
			new frmProdutos().ShowDialog();
		}
		void CadastroToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		}
	}
}
