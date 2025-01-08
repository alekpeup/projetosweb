/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 16/10/2024
 * Time: 11:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lojaDeChinchilas
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
			roundedPanel roundPanel = new roundedPanel
			{
				BackColor = Color.Blue,
				CornerRadius = 30, 
				Dock = DockStyle.Fill 
			};
			this.Controls.Add(roundedPanel);
		}
		void Button1Click(object sender, EventArgs e)
		{
			string itens = textBox1.Text;
			string[] produtos = itens.Split(' ');
			
			foreach(string produto in produtos)
			{
				listBoxProdutos.Items.Add(produto);
				textBox1.Clear();
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			
			
			listBoxProdutos.Items.Clear();
	
		}
		
		
	}
}
