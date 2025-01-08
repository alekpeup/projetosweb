/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 05/11/2024
 * Time: 13:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace gerenciarTarefas
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			Button pequenobtn = new Button();
			pequenobtn.Size = new Size(300, 100);
			pequenobtn.BackColor = Color.Blue;
			pequenobtn.Location = new Point(60, 0);
			
			pequenobtn.Click += (ev) => { 
				pequenobtn.BackColor = Color.AliceBlue;
				
				Button outrobtn = new Button();
				outrobtn.Size = new Size(200, 200);
				outrobtn.Text = "Muito foda";
				outrobtn.BackColor = Color.CadetBlue;
				outrobtn.Location = new Point(150, 34);
				Controls.Add(outrobtn);
				
				outrobtn.Click += (s, ev) => {
					this.BackColor = Color.BurlyWood ;
				};
			};
			this.Controls.Add(pequenobtn);
			

			string nome = "jão";
			while(nome == "joão"){
					int y = this.Controls.OfType<Button>().Count() * 110; // Calcula a posição com base no número de botões existentes
    Button Buttonh = new Button
    {
        Size = new Size(300, 100),
        BackColor = Color.Blue,
        Location = new Point(20, y),
        Text = "Botão " + (y / 110 + 1).ToString() // Concatenação de strings
    };

   				 this.Controls.Add(Buttonh);
			}
		}
		
	}
}
