/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 27/09/2024
 * Time: 21:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BrinquedoLoja
{
	partial class historico
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.SuspendLayout();
			// 
			// historico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 261);
			this.MaximumSize = new System.Drawing.Size(500, 500);
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "historico";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Histórico do Usuário";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.ResumeLayout(false);

		}
	}
}
