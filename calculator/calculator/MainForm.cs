/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 08/08/2024
 * Time: 11:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace calculator
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
		
		void Button2Click(object sender, EventArgs e)
		{
			textBox3.Text = (int.Parse(textBox1.Text) - int.Parse(textBox2.Text)).ToString();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			textBox3.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			textBox3.Text = (int.Parse(textBox1.Text) * int.Parse(textBox2.Text)).ToString();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			textBox3.Text = (int.Parse(textBox1.Text) / int.Parse(textBox2.Text)).ToString();
		}
		void Label1Click(object sender, EventArgs e)
		{
			if (textBox3.ForeColor == Color.Black){
				textBox3.ForeColor = Color.Blue;	
			}else {
				textBox3.ForeColor = Color.Black;
			}
		}
	}
}
