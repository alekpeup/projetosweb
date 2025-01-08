/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 09/10/2024
 * Time: 12:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace teste
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.TreeView treeView2;
		private System.Windows.Forms.ColorDialog colorDialog1;
		
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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("pequena batata");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("batata", new System.Windows.Forms.TreeNode[] {
			treeNode1});
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.treeView2 = new System.Windows.Forms.TreeView();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(215, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Informe o tamanhz";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(318, 268);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(318, 242);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 2;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"Cachorro",
			"Galinha",
			"Pato"});
			this.comboBox1.Location = new System.Drawing.Point(137, 157);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 4;
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(103, 242);
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(104, 45);
			this.trackBar1.TabIndex = 5;
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(478, 105);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(121, 97);
			this.treeView1.TabIndex = 6;
			// 
			// treeView2
			// 
			this.treeView2.Location = new System.Drawing.Point(297, 118);
			this.treeView2.Name = "treeView2";
			treeNode1.Name = "Node1";
			treeNode1.Text = "pequena batata";
			treeNode2.Name = "Node0";
			treeNode2.Text = "batata";
			this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
			treeNode2});
			this.treeView2.Size = new System.Drawing.Size(121, 97);
			this.treeView2.TabIndex = 7;
			this.treeView2.Visible = false;
			// 
			// colorDialog1
			// 
			this.colorDialog1.FullOpen = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(886, 500);
			this.Controls.Add(this.treeView2);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "teste";
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
