namespace _20234764이기민_과제2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sendero, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                bool c = a > b;
                label2.Text = ">";
                label1.Text = "결과는" + c + "입니다.";
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                bool c = a >= b;
                label2.Text = ">=";
                label1.Text = "결과는" + c + "입니다.";
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
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                bool c = a == b;
                label2.Text = "==";
                label1.Text = "결과는" + c + "입니다.";
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
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                bool c = a != b;
                label2.Text = "!=";
                label1.Text = "결과는" + c + "입니다.";
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                bool c = a <= b;
                label2.Text = "<=";
                label1.Text = "결과는" + c + "입니다.";
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                bool c = a < b;
                label2.Text = "<";
                label1.Text = "결과는" + c + "입니다.";
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }
    }
}