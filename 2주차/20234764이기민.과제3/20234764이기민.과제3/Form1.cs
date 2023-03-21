using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20234764이기민.과제3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string sdata01 = textBox1.Text;
             int Idata01 = int.Parse(textBox2.Text);

             label5.Text = "성명:" + sdata01 + "\n학번:" + Idata01;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sdata01 = textBox3.Text;
            int ldata01 = int.Parse(textBox4.Text);

            label6.Text = "유선전화:" + sdata01 + " \n무선전화:" + ldata01;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            label5.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
