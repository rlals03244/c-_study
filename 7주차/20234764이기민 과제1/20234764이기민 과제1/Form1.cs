using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20234764이기민_과제1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int adata = int.Parse(textBox1.Text);
                int bdata = int.Parse(textBox2.Text);
                string cdata = "";
                label3.Text = "";

                if (adata < 10 && adata > 1 && bdata < 10 && bdata > 1)
                {
                    label3.Text = "구구단" + adata + "부터" + bdata + "단 까지 입니다" + "\n\n"; 
                    for (int i = adata; i <= bdata; i++)
                    {
                        for (int j = 2; j <= 9; j++)
                        {
                            label3.Text += i + "*" + j + "=" + (i * j);
                            label3.Text += "\n";
 
                        }
                        label3.Text += "\n";
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
