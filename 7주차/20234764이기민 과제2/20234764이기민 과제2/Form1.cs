using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20234764이기민_과제2
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
                bool bdata = false;

                for (int i = 2; i < adata; i++)
                {
                    if (adata % i == 0)
                    {
                        bdata = true;

                    }
                }
                if (bdata == true)
                {
                    label2.Text = adata + "은 소수가 아닙니다";
                }
                else
                {
                    label2.Text = adata + "은 소수입니다";
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
