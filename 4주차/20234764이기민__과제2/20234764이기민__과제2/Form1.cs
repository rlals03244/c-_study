namespace _20234764이기민__과제2
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
                int idata01 = int.Parse(textBox1.Text);
                double ddata01 = double.Parse(textBox2.Text);

                if (idata01 == 1)
                {
                    double result = ddata01 * 3.28;
                    textBox3.Text = "결과는 " + result;
                    label4.Text = "feet";
                }
                else if (idata01 == 2)
                {
                    double result = ddata01 / 3.28;
                    textBox3.Text = "결과는 " + result;
                    label4.Text = "meter";
                }
                else
                {
                    textBox1.Text = "1또는 2를 입력하세요";
                }
            }
            catch (Exception ex)
            {
                textBox3.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}