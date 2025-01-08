/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 18/09/2024
 * Time: 23:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace calculo
{
	partial class MainForm
	{
		
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonClick;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tPrimeiro;
		private System.Windows.Forms.TextBox tSegundo;
		private System.Windows.Forms.TextBox tTerceiro;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tOmaior;
		private System.Windows.Forms.Panel panel2;
		
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
			this.buttonClick = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tPrimeiro = new System.Windows.Forms.TextBox();
			this.tSegundo = new System.Windows.Forms.TextBox();
			this.tTerceiro = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tOmaior = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Teal;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(144, 143);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(126, 41);
			this.button1.TabIndex = 0;
			this.button1.Text = "Mostrar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(300, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(390, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Vamos descobrir qual número é o maior?";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "Insira o primeiro:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(147, 22);
			this.label3.TabIndex = 1;
			this.label3.Text = "Insira o segundo:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 162);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(138, 22);
			this.label4.TabIndex = 1;
			this.label4.Text = "Insira o terceiro:";
			// 
			// tPrimeiro
			// 
			this.tPrimeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.tPrimeiro.Location = new System.Drawing.Point(151, 62);
			this.tPrimeiro.Name = "tPrimeiro";
			this.tPrimeiro.Size = new System.Drawing.Size(122, 28);
			this.tPrimeiro.TabIndex = 2;
			// 
			// tSegundo
			// 
			this.tSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.tSegundo.Location = new System.Drawing.Point(151, 112);
			this.tSegundo.Name = "tSegundo";
			this.tSegundo.Size = new System.Drawing.Size(122, 28);
			this.tSegundo.TabIndex = 2;
			// 
			// tTerceiro
			// 
			this.tTerceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.tTerceiro.Location = new System.Drawing.Point(151, 162);
			this.tTerceiro.Name = "tTerceiro";
			this.tTerceiro.Size = new System.Drawing.Size(122, 28);
			this.tTerceiro.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(3, 14);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(291, 24);
			this.label5.TabIndex = 1;
			this.label5.Text = "Aqui você vai inserir os valores.\r\n";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(58, 77);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(861, 216);
			this.panel1.TabIndex = 3;
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.button1);
			this.panel3.Controls.Add(this.tOmaior);
			this.panel3.Location = new System.Drawing.Point(329, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(528, 207);
			this.panel3.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(11, 88);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(195, 22);
			this.label7.TabIndex = 1;
			this.label7.Text = "Este é o número maior:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(20, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(250, 25);
			this.label6.TabIndex = 0;
			this.label6.Text = "Aqui será mostrado o maior";
			// 
			// tOmaior
			// 
			this.tOmaior.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.tOmaior.Location = new System.Drawing.Point(228, 85);
			this.tOmaior.Name = "tOmaior";
			this.tOmaior.Size = new System.Drawing.Size(149, 28);
			this.tOmaior.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.tTerceiro);
			this.panel2.Controls.Add(this.tPrimeiro);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.tSegundo);
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(300, 207);
			this.panel2.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1279, 546);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "calculo";
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
