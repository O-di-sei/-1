using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace МиСПИСиТ__лаба1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //sooka
            InitializeComponent();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tBa.Text);
            double b = Convert.ToDouble(tBb.Text);
            tB.Text = Convert.ToString(a + b);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tBa.Text);
            double b = Convert.ToDouble(tBb.Text);
            tB.Text = Convert.ToString(a - b);
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tBa.Text);
            double b = Convert.ToDouble(tBb.Text);
            tB.Text = Convert.ToString(a * b);
        }

        private void share_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tBa.Text);
            double b = Convert.ToDouble(tBb.Text);
            tB.Text = Convert.ToString(a / b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tBa.Text);
            double b = Convert.ToDouble(tBb.Text);
            tB.Text = Convert.ToString(Math.Pow(a,b));
        }
    }
}