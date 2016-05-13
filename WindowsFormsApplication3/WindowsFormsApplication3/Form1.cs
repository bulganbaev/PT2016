using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;
        SolidBrush fill;
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
            g.DrawEllipse(pen, new Rectangle(50, 300, 120, 120));
            g.DrawEllipse(pen, new Rectangle(500, 300, 120, 120));
            g.FillEllipse(fill, new Rectangle(50, 300, 120, 120));
            g.FillEllipse(fill, new Rectangle(500, 300, 120, 120));
            g.DrawLine(pen, new Point(171, 363), new Point(500, 363));
            g.DrawLine(pen, new Point(109, 300), new Point(109, 240));
            g.DrawLine(pen, new Point(109, 240), new Point(323, 240));
            g.DrawRectangle(pen, new Rectangle(320, 120, 300, 120));
            g.DrawLine(pen, new Point(620, 209), new Point(620, 357));
            g.DrawLine(pen, new Point(478, 120), new Point(478, 240));
        }

        private void Form1_Click(object sender, EventArgs e)
        {
      
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Location.ToString());
        }
    }
}
