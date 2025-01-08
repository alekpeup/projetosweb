/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 27/10/2024
 * Time: 17:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TabuadaCompleta
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
			listBox1.Items.Clear();
			int tabuada = int.Parse(textBox1.Text);
			int cont = 0;
			
			for(int i = 0; i <= 10; i++){
				int conta = tabuada * cont;
				listBox1.Items.Add(tabuada + "x" + cont + " = " + conta);
				cont++;
			}
			
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			
			listBox1.Items.Clear();
			int tabuada = int.Parse(textBox1.Text);
			int cont = 0;
			
			while(cont <= 10){
				int conta = tabuada * cont;
				listBox1.Items.Add(tabuada + "x" + cont + " = " + conta);
				cont++;
			}
		}
		void Button3Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			int tabuada = int.Parse(textBox1.Text);
			int cont = 0;
			
			do{
				int conta = tabuada * cont;
				listBox1.Items.Add(tabuada + "x" + cont + " = " + conta);
				cont++;
			}while(cont <= 10);
		}
		
	}
}
