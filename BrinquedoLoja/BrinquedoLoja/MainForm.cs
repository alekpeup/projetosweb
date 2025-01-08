
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BrinquedoLoja
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		
		}
		void GroupBox1Enter(object sender, EventArgs e)
		{
	
		}
		void PictureBox2Click(object sender, EventArgs e)
		{
	
		}
		void EmailToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		void HistóricoToolStripMenuItemClick(object sender, EventArgs e)
		{
			historico jan = new historico();
			jan.ShowDialog();
		}
	}
}
