/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 05/09/2024
 * Time: 00:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ceramica
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox paComp;
		private System.Windows.Forms.TextBox paLarg;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox ceLarg;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox ceComp;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox qtdFinal;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox qtdCompFinal;
		private System.Windows.Forms.TextBox qtdLargFinal;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label11;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel2 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.ceLarg = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.ceComp = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.qtdFinal = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.qtdCompFinal = new System.Windows.Forms.TextBox();
			this.qtdLargFinal = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.paComp = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.paLarg = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.ceLarg);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.ceComp);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Location = new System.Drawing.Point(342, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(265, 160);
			this.panel2.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(15, 97);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "Comprimento ";
			// 
			// ceLarg
			// 
			this.ceLarg.Location = new System.Drawing.Point(121, 54);
			this.ceLarg.Name = "ceLarg";
			this.ceLarg.Size = new System.Drawing.Size(100, 20);
			this.ceLarg.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(15, 17);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "cerâmica";
			// 
			// ceComp
			// 
			this.ceComp.Location = new System.Drawing.Point(121, 100);
			this.ceComp.Name = "ceComp";
			this.ceComp.Size = new System.Drawing.Size(100, 20);
			this.ceComp.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(15, 57);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 23);
			this.label6.TabIndex = 0;
			this.label6.Text = "largura";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(111, 192);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(197, 62);
			this.button1.TabIndex = 4;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// qtdFinal
			// 
			this.qtdFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.qtdFinal.Location = new System.Drawing.Point(208, 358);
			this.qtdFinal.Name = "qtdFinal";
			this.qtdFinal.Size = new System.Drawing.Size(214, 41);
			this.qtdFinal.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(102, 377);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 0;
			this.label7.Text = "qtd Final";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(55, 279);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(127, 23);
			this.label8.TabIndex = 0;
			this.label8.Text = "qtd. Larg";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(55, 327);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(127, 23);
			this.label9.TabIndex = 0;
			this.label9.Text = "qtd. Comp";
			// 
			// qtdCompFinal
			// 
			this.qtdCompFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.qtdCompFinal.Location = new System.Drawing.Point(208, 309);
			this.qtdCompFinal.Name = "qtdCompFinal";
			this.qtdCompFinal.Size = new System.Drawing.Size(214, 41);
			this.qtdCompFinal.TabIndex = 1;
			// 
			// qtdLargFinal
			// 
			this.qtdLargFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.qtdLargFinal.Location = new System.Drawing.Point(208, 261);
			this.qtdLargFinal.Name = "qtdLargFinal";
			this.qtdLargFinal.Size = new System.Drawing.Size(214, 41);
			this.qtdLargFinal.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(15, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "largura";
			// 
			// paComp
			// 
			this.paComp.Location = new System.Drawing.Point(121, 100);
			this.paComp.Name = "paComp";
			this.paComp.Size = new System.Drawing.Size(100, 20);
			this.paComp.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(15, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Parede 1";
			// 
			// paLarg
			// 
			this.paLarg.Location = new System.Drawing.Point(121, 54);
			this.paLarg.Name = "paLarg";
			this.paLarg.Size = new System.Drawing.Size(100, 20);
			this.paLarg.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(15, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "Comprimento ";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.paLarg);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.paComp);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(265, 160);
			this.panel1.TabIndex = 2;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(530, 335);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(214, 41);
			this.textBox1.TabIndex = 1;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(530, 309);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(169, 23);
			this.label10.TabIndex = 0;
			this.label10.Text = "qtd com adicional larg";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(530, 408);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(214, 41);
			this.textBox2.TabIndex = 1;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(530, 382);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(169, 23);
			this.label11.TabIndex = 0;
			this.label11.Text = "qtd com adicional comp";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(756, 461);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.qtdLargFinal);
			this.Controls.Add(this.qtdCompFinal);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.qtdFinal);
			this.MaximumSize = new System.Drawing.Size(820, 500);
			this.MinimumSize = new System.Drawing.Size(500, 500);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ceramica";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
