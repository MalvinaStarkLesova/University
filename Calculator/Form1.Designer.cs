namespace Calculator
{
    partial class calcForm
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
            this.resultBox = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.memoryPlus = new System.Windows.Forms.Button();
            this.memoryMin = new System.Windows.Forms.Button();
            this.mr = new System.Windows.Forms.Button();
            this.mc = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.plu = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.ms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(12, 12);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(274, 20);
            this.resultBox.TabIndex = 0;
            this.resultBox.TextChanged += new System.EventHandler(this.resultBox_TextChanged);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(124, 320);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(50, 50);
            this.delete.TabIndex = 1;
            this.delete.Text = "C";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // memoryPlus
            // 
            this.memoryPlus.Location = new System.Drawing.Point(68, 62);
            this.memoryPlus.Name = "memoryPlus";
            this.memoryPlus.Size = new System.Drawing.Size(50, 50);
            this.memoryPlus.TabIndex = 2;
            this.memoryPlus.Text = "M+";
            this.memoryPlus.UseVisualStyleBackColor = true;
            this.memoryPlus.Click += new System.EventHandler(this.memoryPlus_Click);
            // 
            // memoryMin
            // 
            this.memoryMin.Location = new System.Drawing.Point(124, 62);
            this.memoryMin.Name = "memoryMin";
            this.memoryMin.Size = new System.Drawing.Size(50, 50);
            this.memoryMin.TabIndex = 3;
            this.memoryMin.Text = "M-";
            this.memoryMin.UseVisualStyleBackColor = true;
            this.memoryMin.Click += new System.EventHandler(this.memoryMin_Click);
            // 
            // mr
            // 
            this.mr.Location = new System.Drawing.Point(180, 62);
            this.mr.Name = "mr";
            this.mr.Size = new System.Drawing.Size(50, 50);
            this.mr.TabIndex = 4;
            this.mr.Text = "MR";
            this.mr.UseVisualStyleBackColor = true;
            this.mr.Click += new System.EventHandler(this.mr_Click);
            // 
            // mc
            // 
            this.mc.Location = new System.Drawing.Point(236, 62);
            this.mc.Name = "mc";
            this.mc.Size = new System.Drawing.Size(50, 50);
            this.mc.TabIndex = 5;
            this.mc.Text = "MC";
            this.mc.UseVisualStyleBackColor = true;
            this.mc.Click += new System.EventHandler(this.mc_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(12, 129);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(50, 50);
            this.seven.TabIndex = 6;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(68, 129);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(50, 50);
            this.eight.TabIndex = 7;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(124, 129);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(50, 50);
            this.nine.TabIndex = 8;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(12, 195);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(50, 50);
            this.four.TabIndex = 9;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(68, 195);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(50, 50);
            this.five.TabIndex = 10;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(124, 195);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(50, 50);
            this.six.TabIndex = 11;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(12, 256);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(50, 50);
            this.one.TabIndex = 12;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(68, 256);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(50, 50);
            this.two.TabIndex = 13;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(124, 256);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(50, 50);
            this.three.TabIndex = 14;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(68, 320);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(50, 50);
            this.zero.TabIndex = 15;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(12, 320);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(50, 50);
            this.dot.TabIndex = 17;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // percent
            // 
            this.percent.Location = new System.Drawing.Point(180, 129);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(50, 50);
            this.percent.TabIndex = 18;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = true;
            this.percent.Click += new System.EventHandler(this.percent_Click);
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(236, 129);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(50, 50);
            this.sqrt.TabIndex = 19;
            this.sqrt.Text = "√";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(180, 195);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(50, 50);
            this.multiply.TabIndex = 20;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(236, 195);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(50, 50);
            this.divide.TabIndex = 21;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // plu
            // 
            this.plu.Location = new System.Drawing.Point(180, 256);
            this.plu.Name = "plu";
            this.plu.Size = new System.Drawing.Size(50, 114);
            this.plu.TabIndex = 22;
            this.plu.Text = "+";
            this.plu.UseVisualStyleBackColor = true;
            this.plu.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(236, 256);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(50, 50);
            this.minus.TabIndex = 23;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(236, 320);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(50, 50);
            this.equals.TabIndex = 24;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // ms
            // 
            this.ms.Location = new System.Drawing.Point(12, 62);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(50, 50);
            this.ms.TabIndex = 25;
            this.ms.Text = "MS";
            this.ms.UseVisualStyleBackColor = true;
            this.ms.Click += new System.EventHandler(this.ms_Click);
            // 
            // calcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 382);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plu);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.mc);
            this.Controls.Add(this.mr);
            this.Controls.Add(this.memoryMin);
            this.Controls.Add(this.memoryPlus);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.resultBox);
            this.Name = "calcForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.calcForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button memoryPlus;
        private System.Windows.Forms.Button memoryMin;
        private System.Windows.Forms.Button mr;
        private System.Windows.Forms.Button mc;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button plu;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button ms;
    }
}

