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
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 0;
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(28, 80);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(54, 23);
            this.number1.TabIndex = 1;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.button1_Click);
            // 
            // number4
            // 
            this.number4.Location = new System.Drawing.Point(28, 110);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(54, 23);
            this.number4.TabIndex = 2;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.number4_Click);
            // 
            // number7
            // 
            this.number7.Location = new System.Drawing.Point(28, 140);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(54, 23);
            this.number7.TabIndex = 3;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.number7_Click);
            // 
            // number0
            // 
            this.number0.Location = new System.Drawing.Point(28, 170);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(54, 23);
            this.number0.TabIndex = 4;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.number0_Click);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dot.Location = new System.Drawing.Point(88, 170);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(54, 23);
            this.dot.TabIndex = 8;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // number8
            // 
            this.number8.Location = new System.Drawing.Point(88, 140);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(54, 23);
            this.number8.TabIndex = 7;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.number8_Click);
            // 
            // number5
            // 
            this.number5.Location = new System.Drawing.Point(88, 110);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(54, 23);
            this.number5.TabIndex = 6;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.number5_Click);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(88, 80);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(54, 23);
            this.number2.TabIndex = 5;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.number2_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.Location = new System.Drawing.Point(148, 170);
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
            this.number9.Location = new System.Drawing.Point(148, 140);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(54, 23);
            this.number9.TabIndex = 11;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.number9_Click);
            // 
            // number6
            // 
            this.number6.Location = new System.Drawing.Point(148, 110);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(54, 23);
            this.number6.TabIndex = 10;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.number6_Click);
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(148, 80);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(54, 23);
            this.number3.TabIndex = 9;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.number3_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sub.Location = new System.Drawing.Point(218, 170);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(54, 23);
            this.sub.TabIndex = 16;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(218, 140);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(54, 23);
            this.add.TabIndex = 15;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiply.Location = new System.Drawing.Point(218, 110);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(54, 23);
            this.multiply.TabIndex = 14;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divide.Location = new System.Drawing.Point(218, 80);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(54, 23);
            this.divide.TabIndex = 13;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equal.Location = new System.Drawing.Point(31, 201);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(240, 43);
            this.equal.TabIndex = 17;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

