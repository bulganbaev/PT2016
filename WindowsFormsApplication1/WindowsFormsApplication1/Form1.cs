using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string memory = string.Empty;
        bool check = false;
      
   
        public Form1()
        {
            InitializeComponent();
        }
        

        private void dot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('.'))
            {

            }
            else
            {
                if (this.textBox1.Text == string.Empty)
                {
                    this.textBox1.Text = "";
                    input += "0,";
                    this.textBox1.Text += input;
                }
                else
                {
                    this.textBox1.Text = "";
                    input += ",";
                    this.textBox1.Text += input;
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            calc.first = 0;
            calc.second = 0;
            calc.Result = 0;
            calc.operation = "";
            textBox1.Text = string.Empty;
            label1.Text = string.Empty;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if(!check)
            {
                calc.first = Double.Parse(textBox1.Text);
                calc.second = double.Parse(input);
                calc.Calculate();
            }
            else
            {

                calc.second = double.Parse(input);
                calc.Calculate();
                check = false;
            }
               
                textBox1.Text = calc.Result.ToString();
                label1.Text = calc.show;
            
            
        }

     

        private void button6_Click(object sender, EventArgs e)
        {
            calc.first = double.Parse(input);
            calc.operation = "sqrt";
            calc.Calculate();
            textBox1.Text = calc.Result.ToString();
            label1.Text = calc.show;
            input = string.Empty;


        }

        private void button13_Click(object sender, EventArgs e)
        {
            calc.first = double.Parse(input);
            calc.operation = "^";
            input = string.Empty;
            textBox1.Text = string.Empty;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            calc.first = double.Parse(input);
            calc.operation = "sqr";
            calc.Calculate();
            textBox1.Text = calc.Result.ToString();
            label1.Text = calc.show;
            input = string.Empty;
        }

       

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input = "3,14159265359";
            this.textBox1.Text += input;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            calc.first = double.Parse(input);
            calc.operation = "log";
            calc.Calculate();
            textBox1.Text = calc.Result.ToString();
            label1.Text = calc.show;
            input = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e)
        {
                
                string delete = textBox1.Text;
            if (delete.Length <= 1)
            {
                input = string.Empty;
                textBox1.Text = input;
            }
            else {
                delete = delete.Remove(delete.Length - 1);
                input = delete;
                textBox1.Text = input;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
             memory = textBox1.Text;
            textBox1.Text = string.Empty;
            input = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox1.Text = memory;
            input = memory;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            memory = string.Empty;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            calc.first = Double.Parse(memory);
            calc.second = Double.Parse(textBox1.Text);
            calc.operation = "+";
            calc.Calculate();
            memory = calc.Result.ToString();
            textBox1.Text = string.Empty;
            input = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            calc.first = Double.Parse(memory);
            calc.second = Double.Parse(textBox1.Text);
            calc.operation = "-";
            calc.Calculate();
            memory = calc.Result.ToString();
            textBox1.Text = string.Empty;
            input = string.Empty;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            calc.first = Double.Parse(input);
            input = string.Empty;
            calc.operation = "!";
            calc.Calculate();
            textBox1.Text = calc.Result.ToString();
            label1.Text = calc.show;
           
        }
        
        private void num_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            this.textBox1.Text = "";
            input += b.Text;
            this.textBox1.Text += input;
        }

        private void simple_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (!check)
            {
                calc.first = double.Parse(textBox1.Text);
            }
            else
            {
                calc.first = double.Parse(input);
            }
            calc.operation = b.Text;
            input = string.Empty;
            textBox1.Text = string.Empty;
            check = true;
        }

        private void trig_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            calc.first = double.Parse(textBox1.Text);
            calc.operation = b.Text;
            calc.Calculate();
            textBox1.Text = calc.Result.ToString();
            label1.Text = calc.show;
            input = string.Empty;
        }
    }
}
