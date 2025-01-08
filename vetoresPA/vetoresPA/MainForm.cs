using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace vetoresPA
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		string[] nomes ={
			"felipe",
			"josenilton",
			"robertinho",
			"ananda",
			"roberia",
			"claudia",
			"amilton",
			"lucas",
			"caio",
			"zoio",
			"joelma",
			"rafael",
			"alek",
			"wellington",
			"guilherme",
		
		};
		
		double[] salarios = {
		    2400.44d,
		    5250.80d,
		    980.00d,
		    7000.00d,
		    1412.00d,
		    3300.55d,
		    10012.01d,
		    2000.75d,
		    8700.30d,
		    3100.60d,
		    4500.90d,
		    6500.10d,
		    2200.25d,
		    8100.40d,
		    3900.15d
		};

		
	
		void Button1Click(object sender, EventArgs e)
		{
			for(int n = 0; n < 15; n++){
				
				listBox1.Items.Add(nomes[n] + " -- " + (salarios[n]).ToString("C"));
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			for(int i = 0; i < salarios.Length;i++){
				if(salarios[i] == 10012.01){
					listBox2.Items.Add(nomes[i] + " --- " + (salarios[i]).ToString("C"));
				}
			}
		}
	}
}
