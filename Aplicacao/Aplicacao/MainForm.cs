/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 05/11/2024
 * Time: 14:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Aplicacao
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
		void GroupBox1Enter(object sender, EventArgs e)
		{
	
		}
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
	
		}
		
		// limpar dados
		void Button3Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			radioButton1.Checked = false;
			radioButton2.Checked = false;
		}
		
		
		// confirmar
		void Button2Click(object sender, EventArgs e)
		{
			
			
			if(textBox1.Text.Length == 0)
			{
				MessageBox.Show("Digite o nome");
				textBox1.Focus();
			}
			if(comboBox1.Text.Length == 0)
			{
				MessageBox.Show("Destino não escolhido");
				comboBox1.Focus();
			}
			
			if(radioButton1.Checked == false && radioButton2.Checked == false){
				MessageBox.Show("Transporte não escolhido");

			}
			
			MessageBox.Show("Olá " + textBox1.Text + "Você vai viajar de ");
		}
		
		
		
		
	}
}
