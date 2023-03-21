namespace _20234764이기민_과제4
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
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c = a / b;
                int d = a % b;
                label2.Text = a + "나누기" + b + "의 몫은" + c + "이고 나머지는" + d + "입니다.";
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                label2.Text = "";
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }
        }
    }
}