/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 27/11/2024
 * Time: 13:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CadastroEventoTech
{
	/// <summary>
	/// Description of FmHome.
	/// </summary>
	public partial class FmHome : Form
	{
		
		public FmHome(string nome)
		{
	
			InitializeComponent();
					pictureBox1.Load("alexsandro-img.png"); 
			label1.Text = nome;
			
		}
				
		
	}
}
