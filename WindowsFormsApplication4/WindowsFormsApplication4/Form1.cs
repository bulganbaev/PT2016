using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {

        Graphics g;
        Pen pen;
        SolidBrush fill;
       
        public bool gameover = false;
        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Black);
            pen.Width = 2;
            g = this.CreateGraphics();
            fill = new SolidBrush(Color.Blue);
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {


            g.DrawRectangle(pen, new Rectangle(new Point(200,400),new Size(200, 10)));
            g.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(new Point(200, 400), new Size(200, 10)));
            Point[] array = {new Point(250,400),new Point(260,370),new Point(270,370),new Point(280,400) };
            g.DrawPolygon(pen, array);
            g.FillPolygon(new SolidBrush(Color.Silver), array);
            g.DrawRectangle(pen, new Rectangle(new Point(210,290 ), new Size(110, 80)));
            g.FillRectangle(new SolidBrush(Color.DarkGray), new Rectangle(new Point(210, 290), new Size(110, 80)));
            g.DrawRectangle(pen, new Rectangle(new Point(220, 300), new Size(90, 60)));
            g.FillRectangle(new SolidBrush(Color.White), new Rectangle(new Point(220, 300), new Size(90, 60)));
            g.DrawEllipse(pen, new Rectangle(new Point(262, 360), new Size(8, 8)));
            Point[] array1 = { new Point(370, 370), new Point(340, 370), new Point(350, 400), new Point(360, 400) };
            g.DrawPolygon(pen, array1);
            g.FillPolygon(new SolidBrush(Color.Brown), array1);
            g.DrawLine(pen, new Point(355, 370), new Point(355, 320));
            g.DrawEllipse(pen, new Rectangle(new Point(349, 320), new Size(12, 12)));
            g.DrawEllipse(pen, new Rectangle(new Point(349, 308), new Size(12, 12)));
            g.DrawEllipse(pen, new Rectangle(new Point(349, 296), new Size(12, 12)));
            g.DrawEllipse(pen, new Rectangle(new Point(361, 308), new Size(12, 12)));
            g.DrawEllipse(pen, new Rectangle(new Point(337, 308), new Size(12, 12)));
            g.FillEllipse(new SolidBrush(Color.Green), new Rectangle(new Point(349, 320), new Size(12, 12)));
            g.FillEllipse(new SolidBrush(Color.Yellow), new Rectangle(new Point(349, 308), new Size(12, 12)));
            g.FillEllipse(new SolidBrush(Color.Green), new Rectangle(new Point(349, 296), new Size(12, 12)));
            g.FillEllipse(new SolidBrush(Color.Green), new Rectangle(new Point(361, 308), new Size(12, 12)));
            g.FillEllipse(new SolidBrush(Color.Green), new Rectangle(new Point(337, 308), new Size(12, 12)));
        }
       

       
        
        

       

        
    }
}
