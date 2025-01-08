/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 24/08/2024
 * Time: 23:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SchoolProject
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem startUpToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.startUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.MediumAquamarine;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.manutençãoToolStripMenuItem,
			this.cadastroToolStripMenuItem,
			this.sobreToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
			this.menuStrip1.Size = new System.Drawing.Size(1214, 36);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// manutençãoToolStripMenuItem
			// 
			this.manutençãoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.manutençãoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
			this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(137, 28);
			this.manutençãoToolStripMenuItem.Text = "Manutenção";
			// 
			// sobreToolStripMenuItem
			// 
			this.sobreToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sobreToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
			this.sobreToolStripMenuItem.Size = new System.Drawing.Size(78, 28);
			this.sobreToolStripMenuItem.Text = "Sobre";
			// 
			// cadastroToolStripMenuItem
			// 
			this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.clientesToolStripMenuItem,
			this.produtosToolStripMenuItem,
			this.funcionáriosToolStripMenuItem,
			this.startUpToolStripMenuItem});
			this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cadastroToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
			this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(104, 28);
			this.cadastroToolStripMenuItem.Text = "Cadastro";
			this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.CadastroToolStripMenuItemClick);
			// 
			// clientesToolStripMenuItem
			// 
			this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
			this.clientesToolStripMenuItem.Size = new System.Drawing.Size(202, 28);
			this.clientesToolStripMenuItem.Text = "Clientes";
			this.clientesToolStripMenuItem.Click += new System.EventHandler(this.ClientesToolStripMenuItemClick);
			// 
			// produtosToolStripMenuItem
			// 
			this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
			this.produtosToolStripMenuItem.Size = new System.Drawing.Size(202, 28);
			this.produtosToolStripMenuItem.Text = "Produtos";
			this.produtosToolStripMenuItem.Click += new System.EventHandler(this.ProdutosToolStripMenuItemClick);
			// 
			// funcionáriosToolStripMenuItem
			// 
			this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
			this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(202, 28);
			this.funcionáriosToolStripMenuItem.Text = "Funcionários";
			// 
			// startUpToolStripMenuItem
			// 
			this.startUpToolStripMenuItem.Name = "startUpToolStripMenuItem";
			this.startUpToolStripMenuItem.Size = new System.Drawing.Size(202, 28);
			this.startUpToolStripMenuItem.Text = "StartUp";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(224, 175);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(760, 338);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.OrangeRed;
			this.label1.Location = new System.Drawing.Point(428, 79);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(182, 31);
			this.label1.TabIndex = 2;
			this.label1.Text = "LOUJA BRINQ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSlateGray;
			this.ClientSize = new System.Drawing.Size(1214, 663);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.HelpButton = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SchoolProject";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
