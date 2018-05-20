using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calcForm : Form
    {
        decimal firstNum;
        string operation;
        decimal secondNum;
        decimal result;
        public calcForm()
        {
            InitializeComponent();
        }
        private void equals_Click(object sender, EventArgs e)
        {
            secondNum = Convert.ToDecimal(resultBox.Text);

            if (operation == "+")
            {
                result = (firstNum + secondNum);
                resultBox.Text = Convert.ToString(result);
                firstNum = result;
            }
            if (operation == "-")
            {
                result = (firstNum - secondNum);
                resultBox.Text = Convert.ToString(result);
                firstNum = result;
            }
            if (operation == "*")
            {
                result = (firstNum * secondNum);
                resultBox.Text = Convert.ToString(result);
                firstNum = result;
            }
            if (operation == "/")
            {
                if (secondNum == 0)
                {
                    resultBox.Text = "Can't divide by zero!";

                }
                else
                {
                    result = (firstNum / secondNum);
                    resultBox.Text = Convert.ToString(result);
                    firstNum = result;
                }
            }
            if (operation == "%")
            {
                result = (firstNum % secondNum);
                resultBox.Text = Convert.ToString(result);
                firstNum = result;
            }
            if (operation == "√")
            {
                result = (decimal)Math.Sqrt(Convert.ToDouble(firstNum));
                resultBox.Text = Convert.ToString(result);
                firstNum = result;
            }
        }
        private void calcForm_Load(object sender, EventArgs e)
        {
            firstNum = 0;
        }
        private void plus_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDecimal(resultBox.Text);
            resultBox.Text = "0";
            operation = "+";
        }
        private void minus_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDecimal(resultBox.Text);
            resultBox.Text = "0";
            operation = "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDecimal(resultBox.Text);
            resultBox.Text = "0";
            operation = "*";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDecimal(resultBox.Text);
            resultBox.Text = "0";
            operation = "/";
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDecimal(resultBox.Text);
            resultBox.Text = "0";
            operation = "√";
        }

        private void one_Click(object sender, EventArgs e)
        {
            
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "1";
            }
            else
            {
                resultBox.Text = resultBox.Text + "1";
            }

        }

        private void two_Click(object sender, EventArgs e)
        {
          
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "2";
                
            }
            else
            {
                resultBox.Text = resultBox.Text + "2";
                firstNum = Convert.ToDecimal(resultBox.Text);
                resultBox.Text = firstNum.ToString();
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
           
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "3";
            }
            else
            {
                resultBox.Text = resultBox.Text + "3";
                firstNum = Convert.ToDecimal(resultBox.Text);
                resultBox.Text = firstNum.ToString();
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "4";
            }
            else
            {
                resultBox.Text = resultBox.Text + "4";
                firstNum = Convert.ToDecimal(resultBox.Text);
                resultBox.Text = firstNum.ToString();
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "5";
            }
            else
            {
                resultBox.Text = resultBox.Text + "5";
                firstNum = Convert.ToDecimal(resultBox.Text);
                resultBox.Text = firstNum.ToString();
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "6";
            }
            else
            {
                resultBox.Text = resultBox.Text + "6";
                firstNum = Convert.ToDecimal(resultBox.Text);
                resultBox.Text = firstNum.ToString();
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "7";
            }
            else
            {
                resultBox.Text = resultBox.Text + "7";
                firstNum = Convert.ToDecimal(resultBox.Text);
                resultBox.Text = firstNum.ToString();
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "8";
            }
            else
            {
                resultBox.Text = resultBox.Text + "8";
                firstNum = Convert.ToDecimal(resultBox.Text);
                resultBox.Text = firstNum.ToString();
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "9";
            }
            else
            {
                resultBox.Text = resultBox.Text + "9";
                firstNum = Convert.ToDecimal(resultBox.Text);
                resultBox.Text = firstNum.ToString();
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + "0";
            firstNum = Convert.ToDecimal(resultBox.Text);
            resultBox.Text = firstNum.ToString();
        }

        private void zeroX2_Click(object sender, EventArgs e)
        {
           
        }

        private void percent_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDecimal(resultBox.Text);
            resultBox.Text = "0";
            operation = "%";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            resultBox.Text = "0";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + ".";
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }

        decimal memory = 0;

        private void mc_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void mr_Click(object sender, EventArgs e)
        {
            resultBox.Text = memory.ToString();
        }

        private void memoryPlus_Click(object sender, EventArgs e)
        {           
            memory += result;
        }

        private void memoryMin_Click(object sender, EventArgs e)
        {
            memory -= result;
        }

        private void ms_Click(object sender, EventArgs e)
        {
            memory = decimal.Parse(resultBox.Text);
        }
    }
}
