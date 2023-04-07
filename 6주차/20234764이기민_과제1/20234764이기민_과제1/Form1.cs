using System.Diagnostics.Eventing.Reader;

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
            if (textBox1.Text == "") 
            {
                label3.Text = "시작값을 입력하세요!";
            }
            else if (textBox2.Text == "") 
            {
                label3.Text = "마지막값을 입력하세요!";
            }
            else
            {
                ulong adata = ulong.Parse(textBox1.Text);
                ulong bdata = ulong.Parse(textBox2.Text);
                ulong cdata = 0;
                ulong ddata = 1;

                if (adata >= bdata)
                {
                    label3.Text = "시작값은 마지막값 보다 작은 값이어야 합니다!";
                }
                else if (adata <= 0)
                {
                    label3.Text = "시작값은 0보다 큰 값이어야 합니다!";
                }
                else if (bdata >= 21)
                {
                    label3.Text = "마지막값은 21보다 작은 값이어야 합니다!";
                }
                else if (adata > 0 && bdata < 21)
                {
                    for (ulong edata = adata; edata <= bdata; edata++)
                    {
                        cdata += edata;
                        ddata *= edata;
                        label3.Text = adata + "부터" + bdata + "까지의 합은" + cdata + "곱은" + ddata;
                    }
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}