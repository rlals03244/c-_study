namespace _20234764이기민_9주차_과제3
{
    public partial class Form1 : Form
    {
        int money = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idata01 = int.Parse(textBox1.Text);
                if (idata01 > 0 && idata01 < 1000)
                {
                    money = money + idata01;
                    label4.Text = "이기민 계좌잔고 : " + money + "원";
                }
                else
                {
                    label4.Text = "1~1000 사이의 수를 입력";
                }
            }
            catch
            {
                int idata02 = int.Parse(textBox2.Text);
                if (idata02 <= money && idata02 > 0)
                {
                    money = money - idata02;
                    label4.Text = "이기민 계좌잔고 :" + money + "원";
                }
                else
                {
                    label4.Text = "값이 음수이거나 출금은 계좌잔액보다 많을 수 없습니다.";
                }
            }
        }
    }
}