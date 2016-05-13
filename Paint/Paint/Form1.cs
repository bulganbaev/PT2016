using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Drawer drawer;
        public Form1()
        {
            InitializeComponent();
            drawer = new Drawer(pictureBox1);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.Rectangle;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            drawer.paintStarted = true;
            drawer.prev = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(drawer.paintStarted)
            {
                drawer.Draw(e.Location);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.Circle;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.Line;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.Pencil;
        }

        private void Color(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            drawer.pen = new Pen(colorDialog1.Color);
        }
    }
}
