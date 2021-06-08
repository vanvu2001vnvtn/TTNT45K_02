using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            decimal dKQ = dSo1 + dSo2;
            txtKQ.Text = dKQ.ToString();
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            decimal dKQ = dSo1 - dSo2;
            txtKQ.Text = dKQ.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            decimal dKQ = dSo1 * dSo2;
            txtKQ.Text = dKQ.ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            decimal dKQ = dSo1 / dSo2;
            txtKQ.Text = dKQ.ToString();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtSo1.Text = "";
            txtSo2.Text = "";
            txtKQ.Text = "";

        }
    }
}
