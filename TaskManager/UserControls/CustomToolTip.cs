using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TaskManager.UserControls
{
    public class CustomToolTip : ToolTip
    {
        int w, h; 

        public CustomToolTip() 
        {           
            this.OwnerDraw = true;
            this.Popup += new PopupEventHandler(this.OnPopup);
            this.Draw += new DrawToolTipEventHandler(this.OnDraw);
        }

        private void OnDraw(object sender, DrawToolTipEventArgs e)
        {
            Graphics g = e.Graphics;

            LinearGradientBrush b = new LinearGradientBrush(e.Bounds,
                Color.FromArgb(64,64,64), Color.FromArgb(64, 64, 64), 45f);

            g.FillRectangle(b, e.Bounds);

            g.DrawRectangle(new Pen(Brushes.Black, 1), new Rectangle(e.Bounds.X, e.Bounds.Y,
                e.Bounds.Width - 1, e.Bounds.Height - 1));

            //g.DrawString(e.ToolTipText, new Font(e.Font, FontStyle.Bold), Brushes.White,
            //    new PointF(e.Bounds.X + 6, e.Bounds.Y + 6)); // shadow layer
            g.DrawString(e.ToolTipText, new Font(e.Font, FontStyle.Bold), Brushes.White,
                new PointF(e.Bounds.X + 5, e.Bounds.Y + 5)); // top layer

            b.Dispose();
        }

        private void OnPopup(object sender, PopupEventArgs e)
        {
           //e.ToolTipSize = new Size(width, height);
        }

        //public Size SetToolTipSize(int width, int height)
        //{

        //    return new Size(width, height);
        //}

    }
}
