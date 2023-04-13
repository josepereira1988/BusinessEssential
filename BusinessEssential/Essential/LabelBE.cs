using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential
{
    public class LabelBE : Label
    {
        public LabelBE()
        {
            //this.AutoSize = false;
            this.Size = new System.Drawing.Size(64, 14);
            this.Font = new System.Drawing.Font(new FontFamily("Calibri"), 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.label_Paint);
            this.AutoSizeChanged += new System.EventHandler(this.label_AutoSizeChanged);

        }
        private void label_Paint(object sender, PaintEventArgs e)
        {
            
            Pen blackPen = new Pen(Color.Gray, 2);
            PointF point1 = new PointF(0, ((Label)sender).Size.Height);
            PointF point2 = new PointF(((Label)sender).Location.Y + ((Label)sender).Size.Width, ((Label)sender).Size.Height);
            e.Graphics.DrawLine(blackPen, point1, point2);
        }
        private void label_AutoSizeChanged(object sender, EventArgs e)
        {
            ((Label)sender).AutoSize = false;
        }
    }
}
