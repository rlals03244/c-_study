namespace _20234764이기민_9주차_과제4
{
    public partial class Form1 : Form
    {
        double data = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double idata01 = double.Parse(textBox1.Text);
                data = data + idata01;
                label1.Text = "" + data;
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double idata01 = double.Parse(textBox1.Text);
                data = data - idata01;
                label1.Text = "" + data;
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double idata01 = double.Parse(textBox1.Text);
                data = data * idata01;
                label1.Text = "" + data;
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double idata01 = double.Parse(textBox1.Text);
                if (idata01 == 0)
                {
                    label1.Text = "무한루프";
                }
                else
                {
                    data = data / idata01;
                    label1.Text = "" + data;
                }
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            data = 0;
            label1.Text = "" + data;
        }
    }
}
