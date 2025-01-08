/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 03/12/2024
 * Time: 08:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AgendaContatos
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
			textBox1.Text = Messages.Hello();
		}
		void Button1Click(object sender, EventArgs e)
		{
			textBox1.Text = Messages.Bye();
		}
		
		
	}
	
	
	
}
