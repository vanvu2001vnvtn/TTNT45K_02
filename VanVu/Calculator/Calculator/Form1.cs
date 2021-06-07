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
    public partial class Form1 : Form
    {
        string sign;
        double val1;
        double val2;
        int trackkeypoint = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd0_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd0.Text;
            
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd1.Text;
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd2.Text;
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd3.Text;
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd4.Text;
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd5.Text;
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd6.Text;
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd7.Text;
        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd8.Text;
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd9.Text;
        }

        private void cmdBang_Click(object sender, EventArgs e)
        {
            val2 = double.Parse(txtBox.Text);
            double result;
            if (sign == "+")
            {
                result = val1 + val2;
                txtBox.Text = result.ToString();
            }
            else if (sign == "-")
            {
                result = val1 - val2;
                txtBox.Text = result.ToString();
            }
            else if (sign == "*")
            {
                result = val1 * val2;
                txtBox.Text = result.ToString();
            }
            else
            {
                result = val1 / val2;
                txtBox.Text = result.ToString();
            }
        }

        private void cmdCong_Click(object sender, EventArgs e)
        {
            sign = "+";
            val1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }

        private void cmdTru_Click(object sender, EventArgs e)
        {
            sign = "-";
            val1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }

        private void cmdNhan_Click(object sender, EventArgs e)
        {
            sign = "*";
            val1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }

        private void cmdChia_Click(object sender, EventArgs e)
        {
            sign = "/";
            val1 = double.Parse(txtBox.Text);
            txtBox.Text = "";

        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtBox.Text = "";
            val1 = 0;
            val2 = 0;
            sign = "";

        }

    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdCham_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmdCham.Text;
        }
    }
}
