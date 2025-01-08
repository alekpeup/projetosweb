/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 21/10/2024
 * Time: 16:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CadastroEventoTech
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	
	
	
	
	
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
		
		
		public string userName;
		
		
		
		// mostrar sign in form
		void Button2Click(object sender, EventArgs e)
		{
			panel1.Visible = true;
			label11.Text = "";
		}
		
		// close sign in form
		void Button3Click(object sender, EventArgs e)
		{
			panel1.Visible = false;
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
		}
		
		// confirm cadastro
		public void ConfirmCadastroClick(object sender, EventArgs e)
		{	
			userName = textBox1.Text;
			int userIdade = int.Parse(textBox2.Text);
//			bool workornot = radioButton1.Checked;
//			bool workornotno = radioButton2.Checked;
			
			string userEmail = textBox3.Text;
//			string usernumber = textBox4.Text;
			
			int iddmin = 18;
			if (userIdade < iddmin)
			{
				panel1.Visible = false;
				label11.Text = "Você é de menor não entra";
			}else {
				label11.Text = "Seja bem vindo";
			}
			panel1.Visible = false;
			
			FmHome home = new FmHome(userName);
	
			home.Show();
			this.Hide();
			
			
		}
		
		// acessar link
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://oalekdv.github.io/casioWeb/"); 
		}
		void Label10Click(object sender, EventArgs e)
		{
	
		}
		
	
	}
	
	
	
	public partial class User{
		public string nome{get; set; }
		
		public User(String nome, int idade, string email){
			
		}
	}
}
