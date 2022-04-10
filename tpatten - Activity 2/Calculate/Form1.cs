// tyson patten
// cst 150
// Topic 1 // Activity 2
// this is my own work


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // establishes degF variable from user input converted to double
            double degF = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(Math.Round((degF - 32) / 1.8, 2));
            // changes the celsius box from calculation and rounds to 2 decimal points
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
