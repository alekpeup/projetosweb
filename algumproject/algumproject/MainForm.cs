/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 27/11/2024
 * Time: 10:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace algumproject
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
		
		List<string> produtos = new List<string>();
		int count = 0;
		
		void Button1Click(object sender, EventArgs e)
		{
			produtos.Add(textBox1.Text);
			listBox1.Items.Add(produtos[count].ToUpper());
			textBox1.Clear();
			
			count++;
		}
		void Button2Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
				for (int i = 0; i < count; i++) {
				
				int data = DateTime();
				
					listBox2.Items.Add(' ');
					listBox2.Items.Add(i + " - " + produtos[i]);
					listBox2.Items.Add( data);
					listBox2.Items.Add("-------------");
				};
			
			
		}
	}
}
