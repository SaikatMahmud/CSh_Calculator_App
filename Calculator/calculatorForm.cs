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
    public partial class calculatorForm : Form
    {

        int num1 = 0;
        int num2 = 0;
        int sq;
        int cb;
        bool flag = false;
        char opt = ' ';
        public calculatorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if(flag==false)
                textBox1.Text += "1";
            else
            {
                textBox1.Text = "1";
                flag = false;
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textBox1.Text += "2";
            else
            {
                textBox1.Text = "2";
                flag = false;
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textBox1.Text += "3";
            else
            {
                textBox1.Text = "3";
                flag = false;
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textBox1.Text += "4";
            else
            {
                textBox1.Text = "4";
                flag = false;
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textBox1.Text += "5";
            else
            {
                textBox1.Text = "5";
                flag = false;
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textBox1.Text += "6";
            else
            {
                textBox1.Text = "6";
                flag = false;
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textBox1.Text += "7";
            else
            {
                textBox1.Text = "7";
                flag = false;
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textBox1.Text += "8";
            else
            {
                textBox1.Text = "8";
                flag = false;
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textBox1.Text += "9";
            else
            {
                textBox1.Text = "9";
                flag = false;
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textBox1.Text += "0";
            else
            {
                textBox1.Text = "0";
                flag = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            label1.Text = num1 + "+";
            flag = true;
            opt = '+';
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            label1.Text = num1 + "-";
            flag = true;
            opt = '-';
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            label1.Text = num1 + "*";
            flag = true;
            opt = '*';
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            label1.Text = num1 + "/";
            flag = true;
            opt = '/';
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(textBox1.Text);
            float result;
            if (opt == '+')
            {
                result = num1 + num2;
                textBox1.Text = result + " ";
                label1.Text += num2 + "=";
               
            }
            if (opt == '-')
            {
                result = num1 - num2;
                textBox1.Text = result + " ";
                label1.Text += num2 + "=";

            }
            if (opt == '*')
            {
                result = num1 * num2;
                textBox1.Text = result + " ";
                label1.Text += num2 + "=";

            }
            if (opt == '/')
            {
                result = num1 / num2;
                textBox1.Text = result + " ";
                label1.Text += num2 + "=";

            }
        }

        private void calculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            label1.Text = " ";

        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {

        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
               sq = Convert.ToInt32(textBox1.Text);
               sq = sq * sq ;
               textBox1.Text = Convert.ToString(sq);
         
        }

        private void btnCube_Click(object sender, EventArgs e)
        {
            cb = Convert.ToInt32(textBox1.Text);
            cb = cb * cb * cb;
            textBox1.Text = Convert.ToString(cb);
        }
    }
}
