namespace _20234764이기민_9주차_과제1
{
    public partial class Form1 : Form
    {
        int cnt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int iData01 = int.Parse(textBox1.Text);
                int result = 0;
                if (iData01 >= 50000 || iData01 < 1)
                {
                    label2.Text = "1~50000 사이의 수만 입력해주세요.";
                }
                else
                {
                    cnt++;
                    for (int i = 1; i <= iData01; i++)
                    {
                        result += i;

                        label2.Text = "합 :" + result;
                        label3.Text = "이용 횟수 : " + cnt + "회";
                    }
                }
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }
        }
    }
}