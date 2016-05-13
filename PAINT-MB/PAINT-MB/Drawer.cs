using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public enum Shape { Pencil, Rectangle, Circle, Line, Eraser, Triangle, Romb ,Five, Six,Trapeca, Fill}

    class Drawer
    {
        public Graphics g;
        private Bitmap btm;
        private PictureBox picture;
        public Shape shape;
        public Pen pen;
        public Pen rpen;
        public Pen lpen;
        public GraphicsPath path;
        public bool paintStarted = false;
        public bool paintStarted1 = false;
        public bool paintStarted2 = false;
       public bool check = true;
        public Point prev;
        public Queue<Point> q = new Queue<Point>();
        public bool[,] used = new bool[615, 362];
        public Color color;

        public Drawer(PictureBox p)
        {
            this.picture = p;
            btm = new Bitmap(picture.Width, picture.Height);
            g = Graphics.FromImage(btm);
            picture.Image = btm;
            lpen = new Pen(Color.Black);
             rpen = new Pen(Color.White);
            pen = new Pen(Color.Black);
            picture.Paint += Picture_Paint;
            
        }


        public void Picture_Paint(object sender, PaintEventArgs e)
        {
            if (path != null)
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        public void saveLastPath()
        {
            if (path != null)
            {
                g.DrawPath(pen, path);
                path = null;
            }
        }


        public void Draw(Point cur)
        {
            if(paintStarted2)
            {
                pen = rpen;
            }
            else
            {
                pen = lpen;
            }
            
            switch (shape)
            {
                case Shape.Pencil:
                    g.DrawLine(pen, prev, cur);
                    prev = cur;
                    break;
                case Shape.Eraser:
                    pen = new Pen(Color.White, pen.Width);
                    g.DrawLine(pen, prev, cur);
                    
                    prev = cur;
                    break;
                case Shape.Rectangle:
                    path = new GraphicsPath();
                    Point[] arrRe = { prev, new Point(cur.X, prev.Y), cur, new Point(prev.X, cur.Y) };
                    path.AddPolygon(arrRe);
                    break;
                case Shape.Circle:
                    path = new GraphicsPath();
                    Rectangle r = new Rectangle(prev.X, prev.Y, (cur.X - prev.X), cur.Y - prev.Y);
                    path.AddEllipse(r);
                    break;
                case Shape.Line:
                    path = new GraphicsPath();
                    path.AddLine(prev, cur);
                    break;
                case Shape.Triangle:
                    path = new GraphicsPath();
                    if (cur.Y < prev.Y)
                    {

                        Point[] arrTr = { new Point(cur.X - 2 * (cur.X - prev.X), cur.Y), cur, prev };
                        path.AddPolygon(arrTr);
                    }
                    else
                    {
                      
                        Point[] arrTr = { new Point(cur.X - 2 * (cur.X - prev.X), cur.Y),  prev,cur };
                        path.AddPolygon(arrTr);
                    }
                    break;
                case Shape.Romb:
                    path = new GraphicsPath();


                    Point[] arrTr2 = { new Point(prev.X, (prev.Y - cur.Y) / 2 + cur.Y), new Point((cur.X - prev.X) / 2 + prev.X, prev.Y), new Point(cur.X, (prev.Y - cur.Y) / 2 + cur.Y), new Point((cur.X - prev.X) / 2 + prev.X, cur.Y) };
                    path.AddPolygon(arrTr2);

                    break;
                case Shape.Six:
                    path = new GraphicsPath();
                    
                    Point[] arrTr1 = { new Point(prev.X, 3 * (prev.Y - cur.Y) / 4 + cur.Y), new Point((cur.X - prev.X) / 2 + prev.X, prev.Y), new Point(cur.X, 3 * (prev.Y - cur.Y) / 4 + cur.Y), new Point(cur.X, (prev.Y - cur.Y) / 4 + cur.Y), new Point((cur.X - prev.X) / 2 + prev.X, cur.Y), new Point(prev.X, (prev.Y - cur.Y) / 4 + cur.Y) };
                    path.AddPolygon(arrTr1);
                    
                    break;
                case Shape.Five:
                    path = new GraphicsPath();

                    Point[] arrTr3 = { new Point(prev.X,2*(prev.Y-cur.Y)/3+cur.Y ), new Point((cur.X - prev.X) / 2 + prev.X, prev.Y), new Point(cur.X,2*(prev.Y - cur.Y) / 3+cur.Y), new Point(5*(cur.X-prev.X)/6+prev.X,cur.Y), new Point( (cur.X - prev.X) / 6+prev.X, cur.Y) };
                    path.AddPolygon(arrTr3);

                    break;

                
                case Shape.Trapeca:
                    path = new GraphicsPath();

                    //  Point[] arrTr4 = {new Point((cur.X-prev.X)/4+prev.X, prev.Y), new Point(3*(cur.X - prev.X) / 4 + prev.X, prev.Y), prev, new Point(prev.X, cur.Y) };
                    Point[] arrTr4 = { new Point(prev.X, cur.Y), new Point(prev.X + (cur.X - prev.X) / 4, prev.Y), new Point(prev.X + 3 * (cur.X - prev.X) / 4, prev.Y), cur };
                    path.AddPolygon(arrTr4);

                    break;
                
                


                default:
                    break;
            }
            picture.Refresh();
        }

        public void SaveImage(string filename)
        {
            btm.Save(filename);
        }

        public void OpenImage(string filename)
        {

            if (filename == "")
            {
                btm = new Bitmap(picture.Width, picture.Height);
            }
            else {
                btm = new Bitmap(filename);
            }
            g = Graphics.FromImage(btm);
            picture.Image = btm;
        }
        public void fill(Point cur)
        {
            used = new bool[615, 362];
            Color clicked_color = btm.GetPixel(cur.X, cur.Y);
            check1(cur.X, cur.Y, clicked_color);
            while (q.Count > 0)
            {
                Point p = q.Dequeue();
                check1(p.X + 1, p.Y, clicked_color);
                check1(p.X, p.Y + 1, clicked_color);
                check1(p.X - 1, p.Y, clicked_color);
                check1(p.X, p.Y - 1, clicked_color);
            }
            picture.Refresh();
        }

        public void check1(int x, int y, Color clicked_color)
        {
            if (x > 0 && y > 0 && x < picture.Width && y < picture.Height)
            {
                if (used[x, y] == false && btm.GetPixel(x, y) == clicked_color)
                {
                    used[x, y] = true;
                    btm.SetPixel(x, y, color);
                    q.Enqueue(new Point(x, y));
                    paintStarted=false;
                    paintStarted1 = false;
                    paintStarted2 = false;


                }
            }
        }
    }
}