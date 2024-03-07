using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOD3_Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        int angka1 = 0;
        int hasil;

        private void button1_Click(object sender, EventArgs e)
        {
            angka1 = int.Parse(label1.Text);
            this.label1.Text = this.label1.Text + this.label1.Text;
            this.label1.Text = null;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            hasil = angka1 + int.Parse(label1.Text);
            label1.Text = hasil.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + this.button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + this.button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + this.button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + this.button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + this.button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + this.button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + this.button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + this.button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + this.button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + this.button12.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
