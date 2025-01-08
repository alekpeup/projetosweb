/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 20/10/2024
 * Time: 21:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace TestesTestativos
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
			
			 
			 string userTask = textBox2.Text;
			 string caminhoArquivoTask = "arquivoTask.txt";
			 File.Create(caminhoArquivoTask);
			 File.WriteAllText(caminhoArquivoTask, userTask);
			 
			 string conteudoTask = File.ReadAllText(caminhoArquivoTask);
			 label3.Text = conteudoTask;
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
	}
}
