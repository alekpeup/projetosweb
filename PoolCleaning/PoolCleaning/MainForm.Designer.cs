/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 01/09/2024
 * Time: 13:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PoolCleaning
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox tProfundidade;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label laTamanhoTotal;
		private System.Windows.Forms.TextBox tLargura;
		private System.Windows.Forms.TextBox tComprimento;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button bCalcularTamanho;
		
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
			this.tProfundidade = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.laTamanhoTotal = new System.Windows.Forms.Label();
			this.tLargura = new System.Windows.Forms.TextBox();
			this.tComprimento = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.bCalcularTamanho = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tProfundidade
			// 
			this.tProfundidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tProfundidade.Location = new System.Drawing.Point(172, 18);
			this.tProfundidade.Name = "tProfundidade";
			this.tProfundidade.Size = new System.Drawing.Size(100, 22);
			this.tProfundidade.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Informe a profundidade:";
			// 
			// laTamanhoTotal
			// 
			this.laTamanhoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.laTamanhoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.laTamanhoTotal.Location = new System.Drawing.Point(576, 12);
			this.laTamanhoTotal.Name = "laTamanhoTotal";
			this.laTamanhoTotal.Size = new System.Drawing.Size(67, 31);
			this.laTamanhoTotal.TabIndex = 3;
			this.laTamanhoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tLargura
			// 
			this.tLargura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tLargura.Location = new System.Drawing.Point(172, 54);
			this.tLargura.Name = "tLargura";
			this.tLargura.Size = new System.Drawing.Size(100, 22);
			this.tLargura.TabIndex = 2;
			// 
			// tComprimento
			// 
			this.tComprimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tComprimento.Location = new System.Drawing.Point(172, 91);
			this.tComprimento.Name = "tComprimento";
			this.tComprimento.Size = new System.Drawing.Size(100, 22);
			this.tComprimento.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(147, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Informe o comprimento:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(397, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(154, 24);
			this.label4.TabIndex = 3;
			this.label4.Text = "Tamanho em m³:";
			// 
			// label5
			// 
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(541, 70);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(102, 24);
			this.label5.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(397, 67);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(109, 24);
			this.label6.TabIndex = 3;
			this.label6.Text = "Orçamento:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(12, 57);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(111, 16);
			this.label7.TabIndex = 1;
			this.label7.Text = "Informe a largura:";
			// 
			// bCalcularTamanho
			// 
			this.bCalcularTamanho.BackColor = System.Drawing.Color.PaleGreen;
			this.bCalcularTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bCalcularTamanho.Location = new System.Drawing.Point(12, 153);
			this.bCalcularTamanho.Name = "bCalcularTamanho";
			this.bCalcularTamanho.Size = new System.Drawing.Size(139, 51);
			this.bCalcularTamanho.TabIndex = 4;
			this.bCalcularTamanho.Text = "Calcular tamanho total";
			this.bCalcularTamanho.UseVisualStyleBackColor = false;
			this.bCalcularTamanho.Click += new System.EventHandler(this.BCalcularTamanhoClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 395);
			this.Controls.Add(this.bCalcularTamanho);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tComprimento);
			this.Controls.Add(this.laTamanhoTotal);
			this.Controls.Add(this.tLargura);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tProfundidade);
			this.Name = "MainForm";
			this.Text = "PoolCleaning";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
