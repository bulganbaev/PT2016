using Paint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PAINT_MB
{
    public partial class Form1 : Form
    {
      
       
         
        Paint.Drawer drawer;
        public bool check = true;
        public Form1()
        {
            InitializeComponent();
           
            drawer = new Paint.Drawer(pictureBox1);

            drawer.lpen.Color = Color.Black;
            drawer.color = Color.Black;
            drawer.rpen.Color = Color.White;
            button51.BackColor = Color.White;
            button50.BackColor = Color.Black;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawer.prev = e.Location;
               
                drawer.paintStarted1 = true;
               drawer.paintStarted2 = false;
                if (drawer.shape == Shape.Fill)
                {
                    
                    
                    drawer.fill(e.Location);
                }
            }
            if (e.Button == MouseButtons.Right)
            {

                drawer.prev = e.Location;
                drawer.paintStarted2 = true;
                drawer.paintStarted1 = false;
                if (drawer.shape == Shape.Fill)
                {
                    
                    drawer.fill(e.Location);
                }
            }

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
            
            if (drawer.paintStarted1 || drawer.paintStarted2 )
            {
                drawer.Draw(e.Location);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawer.paintStarted1 = false;
            drawer.paintStarted = false;
            drawer.paintStarted2 = false;
            drawer.saveLastPath();
        }
        private void Form1_Load(object sender, MouseEventArgs e)
        {
            
        }


        private void Color_click(object sender, EventArgs e)
        {
            Button a = sender as Button;
            if (check)
            {
                drawer.lpen = new Pen(a.BackColor);
                button50.BackColor = drawer.lpen.Color;
                drawer.color = a.BackColor;
                
            }
            else
            {
                drawer.rpen = new Pen(a.BackColor);
                button51.BackColor = drawer.rpen.Color;
                drawer.color = a.BackColor;

            }
            
            
        }

        private void Color_button(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
             if (check)
             {
                 drawer.lpen = new Pen(colorDialog1.Color);
                 button50.BackColor = drawer.lpen.Color;
                drawer.color = colorDialog1.Color;
            }
             if (check == false)
             {
                 drawer.rpen = new Pen(colorDialog1.Color);
                 button51.BackColor = drawer.rpen.Color;
                drawer.color = colorDialog1.Color;
            }
 
        }

        private void button50_Click(object sender, EventArgs e)
        {
            check = true;
            button50.ForeColor = Color.BlueViolet;
            button51.ForeColor = Color.White;
            label3.BackColor = Color.White;
            label2.BackColor = Color.Aqua;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            check = false;
            button51.ForeColor = Color.BlueViolet;
            button50.ForeColor = Color.White;
            label2.BackColor = Color.White;
            label3.BackColor = Color.Aqua;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            drawer.pen.Width = trackBar1.Value;
           drawer.rpen.Width = trackBar1.Value;
            drawer.lpen.Width = trackBar1.Value;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Pencil": drawer.shape= Shape.Pencil; break;
                case "Line": drawer.shape = Shape.Line; break;
                case "Circle": drawer.shape = Shape.Circle; break;
                case "Eraser": drawer.shape = Shape.Eraser; break;
                case "Rectangle": drawer.shape = Shape.Rectangle; break;
                case "Triangle": drawer.shape = Shape.Triangle; break;
                case "Romb": drawer.shape = Shape.Romb; break;
                case "Six": drawer.shape = Shape.Six; break;
                case "Five": drawer.shape = Shape.Five; break;
                case "Trapeca": drawer.shape = Shape.Trapeca; break;
                case "Fill": drawer.shape = Shape.Fill; break;

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                drawer.OpenImage(openFileDialog1.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                drawer.SaveImage(saveFileDialog1.FileName);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawer.g.Clear(Color.White);
            pictureBox1.Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyValue + " ");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar + " ");
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
