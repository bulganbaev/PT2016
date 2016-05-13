using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public enum Shape {Pencil, Line, Rectangle, Circle}
    public enum Tool { pen, brush }

    class Drawer
    {
        public Graphics g;
        public Bitmap btm;
        public Pen pen;
        public PictureBox picture;
        public Point prev;
        public Shape shape;
      
        public bool paintStarted;
        public Drawer(PictureBox picture)
        {
            this.picture = picture;
            pen = new Pen(Color.Red);
            btm = new Bitmap(picture.Width, picture.Height);
            g =  Graphics.FromImage(btm);
            picture.Image = btm;             
        }
        public void Draw(Point cur)
        {
            switch(shape)
            {
                case Shape.Circle:
                    break;
                case Shape.Line:
                    g.DrawLine(pen, prev, cur);
                    prev = cur;
                    break;
                case Shape.Pencil:
                    break;
                case Shape.Rectangle:
                    break;
            }
            picture.Refresh();
        }
    }
}
