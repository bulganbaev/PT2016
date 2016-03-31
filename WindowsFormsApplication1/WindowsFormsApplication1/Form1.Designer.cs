using System;

namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.number1 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // number1
            // 
            this.number1.BackColor = System.Drawing.Color.Transparent;
            this.number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.number1.Location = new System.Drawing.Point(28, 84);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(54, 23);
            this.number1.TabIndex = 1;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = false;
            this.number1.Click += new System.EventHandler(this.num_Click);
            // 
            // number4
            // 
            this.number4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number4.Location = new System.Drawing.Point(29, 113);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(54, 23);
            this.number4.TabIndex = 2;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.num_Click);
            // 
            // number7
            // 
            this.number7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number7.Location = new System.Drawing.Point(28, 144);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(54, 23);
            this.number7.TabIndex = 3;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.num_Click);
            // 
            // number0
            // 
            this.number0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number0.Location = new System.Drawing.Point(28, 174);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(54, 23);
            this.number0.TabIndex = 4;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.num_Click);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dot.Location = new System.Drawing.Point(88, 174);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(54, 23);
            this.dot.TabIndex = 8;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // number8
            // 
            this.number8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number8.Location = new System.Drawing.Point(88, 144);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(54, 23);
            this.number8.TabIndex = 7;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.num_Click);
            // 
            // number5
            // 
            this.number5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number5.Location = new System.Drawing.Point(88, 114);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(54, 23);
            this.number5.TabIndex = 6;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.num_Click);
            // 
            // number2
            // 
            this.number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number2.Location = new System.Drawing.Point(88, 84);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(54, 23);
            this.number2.TabIndex = 5;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.num_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.Location = new System.Drawing.Point(148, 174);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(54, 23);
            this.delete.TabIndex = 12;
            this.delete.Text = "C";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.UseWaitCursor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // number9
            // 
            this.number9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number9.Location = new System.Drawing.Point(148, 144);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(54, 23);
            this.number9.TabIndex = 11;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.num_Click);
            // 
            // number6
            // 
            this.number6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number6.Location = new System.Drawing.Point(148, 114);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(54, 23);
            this.number6.TabIndex = 10;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.num_Click);
            // 
            // number3
            // 
            this.number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number3.Location = new System.Drawing.Point(148, 84);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(54, 23);
            this.number3.TabIndex = 9;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.num_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sub.Location = new System.Drawing.Point(218, 174);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(54, 23);
            this.sub.TabIndex = 16;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.simple_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(218, 144);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(54, 23);
            this.add.TabIndex = 15;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.simple_Click);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiply.Location = new System.Drawing.Point(218, 114);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(54, 23);
            this.multiply.TabIndex = 14;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.simple_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divide.Location = new System.Drawing.Point(218, 84);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(54, 23);
            this.divide.TabIndex = 13;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.simple_Click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equal.Location = new System.Drawing.Point(148, 203);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(218, 35);
            this.equal.TabIndex = 17;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 18;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(172, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "M+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(126, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "MC";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(76, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "MR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(28, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "MS";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(216, 56);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "M-";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(327, 84);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 23);
            this.button6.TabIndex = 24;
            this.button6.Text = "sqrt";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(278, 85);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(43, 23);
            this.button7.TabIndex = 25;
            this.button7.Text = "sin";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.trig_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.Location = new System.Drawing.Point(327, 114);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(39, 23);
            this.button13.TabIndex = 28;
            this.button13.Text = "x^y";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(278, 114);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(43, 23);
            this.button8.TabIndex = 29;
            this.button8.Text = "cos";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.trig_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(279, 173);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(43, 23);
            this.button9.TabIndex = 31;
            this.button9.Text = "ctg";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.trig_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(279, 144);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(43, 23);
            this.button10.TabIndex = 30;
            this.button10.Text = "tan";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.trig_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Location = new System.Drawing.Point(328, 144);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(39, 23);
            this.button11.TabIndex = 32;
            this.button11.Text = "x^2";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(328, 174);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(39, 23);
            this.button12.TabIndex = 33;
            this.button12.Text = "log";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.trig_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button17.Location = new System.Drawing.Point(89, 203);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(53, 35);
            this.button17.TabIndex = 35;
            this.button17.Text = "n!";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button18.Location = new System.Drawing.Point(30, 203);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(53, 35);
            this.button18.TabIndex = 34;
            this.button18.Text = "pi";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(255, 56);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(110, 26);
            this.button14.TabIndex = 36;
            this.button14.Text = "DELETE";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(377, 243);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.simple_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button14;
    }
}

