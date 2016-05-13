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

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;
        SolidBrush fill;
        public int dx1 = 200;
        public int dy1 = 410;
        public int dx2 = 200;
        public int dy2 = 360;
        public int dx3 = 210;
        public int dy3 = 330;
        public int dx4 = 220;
        public int dy4 = 360;
        public int dx5 = 220;
        public int dy5 = 410;
        public int x = 10;
        public int y = 10;

        public bool gameover = false;
        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Black);
            pen.Width = 2;
            g = this.CreateGraphics();
            fill = new SolidBrush(Color.Blue);
            timer1.Interval = 50;
          
           // timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            timer1.Start();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(dy3 !=0)
            {
                dy1 = 410;
                dy2 = 360;
                dy3 = 330;
                dy4 = 360;
                dy5 = 410;
                while (dy3 != 0)
                {
                    y = -10;
                    dy1 += y;
                    dy2 += y;
                    dy3 += y;
                    dy4 += y;
                    dy5 += y;
                    Thread.Sleep(20);
                    Refresh();
                }
            }
            else 
            {
                dy1 = 0;
                dy2 = 50;
                dy3 = 80;
                dy4 = 50;
                dy5 = 0;
                while (dy3 != 410)
                {
                    y = 10;
                    
                    dy1 += y;
                    dy2 += y;
                    dy3 += y;
                    dy4 += y;
                    dy5 += y;
                    Thread.Sleep(20);
                    Refresh();
                }
                
    }
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Point[] arr =
            {
                new Point(dx1,dy1),
                new Point(dx2,dy2),
                new Point(dx3,dy3),
                new Point(dx4, dy4),
                new Point(dx5,dy5)};
            g.DrawPolygon(pen, arr);
            Point[] arr1 =
           {
                new Point(dx1+100,410-dy1),
                new Point(dx2+100,410-dy2),
                new Point(dx3+100,410-dy3),
                new Point(dx4+100, 410-dy4),
                new Point(dx5+100,410-dy5)};
            g.DrawPolygon(pen, arr1);
            Point[] arr2 =
         {
                new Point(dx1-100,410-dy1),
                new Point(dx2-100,410-dy2),
                new Point(dx3-100,410-dy3),
                new Point(dx4-100, 410-dy4),
                new Point(dx5-100,410-dy5)};
            g.DrawPolygon(pen, arr2);
            Point[] arr3 =
           {
                new Point(dx1-200,dy1),
                new Point(dx2-200,dy2),
                new Point(dx3-200,dy3),
                new Point(dx4-200, dy4),
                new Point(dx5-200,dy5)};
            g.DrawPolygon(pen, arr3);
            Point[] arr4 =
   {
                new Point(dx1+300,dy1),
                new Point(dx2+300,dy2),
                new Point(dx3+300,dy3),
                new Point(dx4+300, dy4),
                new Point(dx5+300,dy5)};
            g.DrawPolygon(pen, arr4);
        }
    
        

}
}
