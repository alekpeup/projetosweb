/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 16/10/2024
 * Time: 12:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace lojaDeChinchilas
{
	/// <summary>
	/// Description of roundedPanel.
	/// </summary>
	public class roundedPanel: Panel
	{
		public int CornerRadius {get; set;} = 20;
		
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			
			using (GraphicsPath Path = new GraphicsPath())
			{
				Path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
				Path.AddArc(Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
				 path.AddArc(Width - CornerRadius, Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
	            path.AddArc(0, Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
	            path.CloseFigure();

         	   e.Graphics.FillPath(new SolidBrush(BackColor), path);
			}
		}
		
		protected override void onResize(EventArgs e)
		{
			base.OnResize(e);
			this.Invalidate();
		}
	}
}
