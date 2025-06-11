namespace GasKeun.Helpers
{
    public static class UIHelper
    {
        public static void MakeRoundedCorners(Control control, int cornerRadius, PaintEventArgs e = null)
        {
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int arcSize = cornerRadius * 2;
                Rectangle bounds = new Rectangle(0, 0, control.Width, control.Height);

                path.AddArc(bounds.X, bounds.Y, arcSize, arcSize, 180, 90);
                path.AddArc(bounds.Right - arcSize, bounds.Y, arcSize, arcSize, 270, 90);
                path.AddArc(bounds.Right - arcSize, bounds.Bottom - arcSize, arcSize, arcSize, 0, 90);
                path.AddArc(bounds.X, bounds.Bottom - arcSize, arcSize, arcSize, 90, 90);
                path.CloseFigure();

                control.Region = new Region(path);

                if (e != null)
                {
                    var g = e.Graphics;
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                    using (Pen pen = new Pen(Color.FromArgb(172, 172, 172), 4))
                    {
                        g.DrawPath(pen, path);
                    }
                }
            }
        }
    }
}



