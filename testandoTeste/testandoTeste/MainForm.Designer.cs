/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 17/10/2024
 * Time: 10:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace testandoTeste
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label qtdLetras;
		private System.Windows.Forms.Label qtdWord;
		private System.Windows.Forms.Label label3;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.qtdLetras = new System.Windows.Forms.Label();
			this.qtdWord = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(96, 234);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(133, 40);
			this.button1.TabIndex = 3;
			this.button1.Text = "Contar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(28, 9);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(342, 294);
			this.panel1.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Cornsilk;
			this.label2.Location = new System.Drawing.Point(16, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(148, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Insira a palavra:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox1
			// 
			this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(16, 124);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(232, 44);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Gray;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Cornsilk;
			this.label1.Location = new System.Drawing.Point(55, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(214, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Contador de palavras e letras";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
			this.panel2.Controls.Add(this.qtdLetras);
			this.panel2.Controls.Add(this.qtdWord);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(448, 9);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(325, 293);
			this.panel2.TabIndex = 5;
			// 
			// qtdLetras
			// 
			this.qtdLetras.AutoSize = true;
			this.qtdLetras.BackColor = System.Drawing.Color.Transparent;
			this.qtdLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.qtdLetras.ForeColor = System.Drawing.Color.Cornsilk;
			this.qtdLetras.Location = new System.Drawing.Point(21, 124);
			this.qtdLetras.Name = "qtdLetras";
			this.qtdLetras.Size = new System.Drawing.Size(0, 24);
			this.qtdLetras.TabIndex = 2;
			this.qtdLetras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// qtdWord
			// 
			this.qtdWord.AutoSize = true;
			this.qtdWord.BackColor = System.Drawing.Color.Transparent;
			this.qtdWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.qtdWord.ForeColor = System.Drawing.Color.Cornsilk;
			this.qtdWord.Location = new System.Drawing.Point(21, 88);
			this.qtdWord.Name = "qtdWord";
			this.qtdWord.Size = new System.Drawing.Size(0, 24);
			this.qtdWord.TabIndex = 2;
			this.qtdWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Gray;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Cornsilk;
			this.label3.Location = new System.Drawing.Point(66, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(214, 30);
			this.label3.TabIndex = 0;
			this.label3.Text = "Resultado";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(784, 371);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.MaximumSize = new System.Drawing.Size(800, 410);
			this.MinimumSize = new System.Drawing.Size(800, 410);
			this.Name = "MainForm";
			this.Text = "testandoTeste";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
