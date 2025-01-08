/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 25/08/2024
 * Time: 00:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SchoolProject
{
	partial class frmProdutos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tCodigo;
		private System.Windows.Forms.TextBox tNome;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tEndereco;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tTelefone;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button bAnterior;
		private System.Windows.Forms.CheckBox cPessoaFisica;
		private System.Windows.Forms.Button bEnviar;
		private System.Windows.Forms.Button bProximo;
		private System.Windows.Forms.Button bExcluir;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.tCodigo = new System.Windows.Forms.TextBox();
			this.tNome = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tEndereco = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tTelefone = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.bAnterior = new System.Windows.Forms.Button();
			this.cPessoaFisica = new System.Windows.Forms.CheckBox();
			this.bEnviar = new System.Windows.Forms.Button();
			this.bProximo = new System.Windows.Forms.Button();
			this.bExcluir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoEllipsis = true;
			this.label1.Location = new System.Drawing.Point(123, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "Código";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tCodigo
			// 
			this.tCodigo.Location = new System.Drawing.Point(182, 38);
			this.tCodigo.MaxLength = 3;
			this.tCodigo.Name = "tCodigo";
			this.tCodigo.Size = new System.Drawing.Size(50, 20);
			this.tCodigo.TabIndex = 0;
			// 
			// tNome
			// 
			this.tNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tNome.Location = new System.Drawing.Point(182, 74);
			this.tNome.MaxLength = 40;
			this.tNome.Name = "tNome";
			this.tNome.Size = new System.Drawing.Size(222, 20);
			this.tNome.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoEllipsis = true;
			this.label2.Location = new System.Drawing.Point(123, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Nome";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tEndereco
			// 
			this.tEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tEndereco.Location = new System.Drawing.Point(182, 109);
			this.tEndereco.MaxLength = 40;
			this.tEndereco.Name = "tEndereco";
			this.tEndereco.Size = new System.Drawing.Size(222, 20);
			this.tEndereco.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoEllipsis = true;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(123, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Endereço";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tTelefone
			// 
			this.tTelefone.Location = new System.Drawing.Point(182, 144);
			this.tTelefone.MaxLength = 15;
			this.tTelefone.Name = "tTelefone";
			this.tTelefone.Size = new System.Drawing.Size(222, 20);
			this.tTelefone.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoEllipsis = true;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(127, 147);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Telefone";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bAnterior
			// 
			this.bAnterior.Location = new System.Drawing.Point(123, 209);
			this.bAnterior.Name = "bAnterior";
			this.bAnterior.Size = new System.Drawing.Size(75, 23);
			this.bAnterior.TabIndex = 5;
			this.bAnterior.Text = "<<";
			this.bAnterior.UseVisualStyleBackColor = true;
			// 
			// cPessoaFisica
			// 
			this.cPessoaFisica.AutoSize = true;
			this.cPessoaFisica.Location = new System.Drawing.Point(415, 40);
			this.cPessoaFisica.Name = "cPessoaFisica";
			this.cPessoaFisica.Size = new System.Drawing.Size(93, 17);
			this.cPessoaFisica.TabIndex = 1;
			this.cPessoaFisica.Text = "Pessoa Física";
			this.cPessoaFisica.UseVisualStyleBackColor = true;
			// 
			// bEnviar
			// 
			this.bEnviar.Location = new System.Drawing.Point(379, 209);
			this.bEnviar.Name = "bEnviar";
			this.bEnviar.Size = new System.Drawing.Size(75, 23);
			this.bEnviar.TabIndex = 10;
			this.bEnviar.Text = "Enviar";
			this.bEnviar.UseVisualStyleBackColor = true;
			this.bEnviar.Click += new System.EventHandler(this.BEnviarClick);
			// 
			// bProximo
			// 
			this.bProximo.Location = new System.Drawing.Point(204, 209);
			this.bProximo.Name = "bProximo";
			this.bProximo.Size = new System.Drawing.Size(75, 23);
			this.bProximo.TabIndex = 11;
			this.bProximo.Text = ">>";
			this.bProximo.UseVisualStyleBackColor = true;
			// 
			// bExcluir
			// 
			this.bExcluir.Location = new System.Drawing.Point(298, 209);
			this.bExcluir.Name = "bExcluir";
			this.bExcluir.Size = new System.Drawing.Size(75, 23);
			this.bExcluir.TabIndex = 12;
			this.bExcluir.Text = "Excluir";
			this.bExcluir.UseVisualStyleBackColor = true;
			this.bExcluir.Click += new System.EventHandler(this.BExcluirClick);
			// 
			// frmProdutos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(689, 261);
			this.Controls.Add(this.bExcluir);
			this.Controls.Add(this.bProximo);
			this.Controls.Add(this.bEnviar);
			this.Controls.Add(this.cPessoaFisica);
			this.Controls.Add(this.bAnterior);
			this.Controls.Add(this.tTelefone);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tEndereco);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tNome);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tCodigo);
			this.Controls.Add(this.label1);
			this.Name = "frmProdutos";
			this.Text = "frmProdutos";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
