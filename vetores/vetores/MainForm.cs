/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 16/11/2024
 * Time: 13:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace vetores
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
			Form novoForm = new Form();
			novoForm.Text = "blbalbl blablab ";
			novoForm.Show();
		} 
		
		
	}
}
