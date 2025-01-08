/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 17/08/2024
 * Time: 18:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SalarioLiquido
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
			double sal, inss, fal, absenceDeduction, netPay;
			
			
			fal = float.Parse(textBox2.Text);
			sal = float.Parse(textBox1.Text);
			inss = sal * 0.12;
			
			label4.Text = inss.ToString("F2");
			label3.Text = fal.ToString();
			
		}
		void Button2Paint(object sender, PaintEventArgs e)
		{
			    // Define a cor do fundo e da borda do botão
            Color buttonBackgroundColor = Color.LightBlue;
            Color buttonBorderColor = Color.DarkBlue;
            
            // Obtém o retângulo do botão
            Rectangle buttonRect = button1.ClientRectangle;

            // Define o raio das bordas arredondadas
            int cornerRadius = 20;

            // Cria um objeto GraphicsPath para desenhar bordas arredondadas
            GraphicsPath roundedPath = new GraphicsPath();
            roundedPath.AddArc(buttonRect.X, buttonRect.Y, cornerRadius, cornerRadius, 180, 90);
            roundedPath.AddArc(buttonRect.X + buttonRect.Width - cornerRadius, buttonRect.Y, cornerRadius, cornerRadius, 270, 90);
            roundedPath.AddArc(buttonRect.X + buttonRect.Width - cornerRadius, buttonRect.Y + buttonRect.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            roundedPath.AddArc(buttonRect.X, buttonRect.Y + buttonRect.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            roundedPath.CloseFigure();

            // Preenche o botão com a cor de fundo
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillPath(new SolidBrush(buttonBackgroundColor), roundedPath);

            // Desenha a borda do botão
            e.Graphics.DrawPath(new Pen(buttonBorderColor, 2), roundedPath);

            // Desenha o texto do botão
            TextRenderer.DrawText(e.Graphics, button1.Text, button1.Font, buttonRect, button1.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
		}
	}
}
