using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);

            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);

            decimal dKQ = dSo1 + dSo2;

            txtKQ.Text = dKQ.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);

            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);

            decimal dKQ = dSo1 - dSo2;

            txtKQ.Text = dKQ.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);

            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);

            decimal dKQ = dSo1 * dSo2;

            txtKQ.Text = dKQ.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);

            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            if (dSo2==0)
            {
                MessageBox.Show("Vui lòng nhập số thứ 2 khác 0", "Thông báo");
                return;
            }
            decimal dKQ = dSo1 / dSo2;

            txtKQ.Text = dKQ.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSo1.Text = "";
            txtSo2.Text = "";
            txtKQ.Text = "";
        }
    }
}
