namespace _20234764이기민_10주차_과제3
{
    public partial class Form1 : Form
    {
        int win = 0;
        int draw = 0;
        int lose = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "가위";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "바위";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "보";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string user = textBox1.Text;
                if (user == "가위" || user == "바위" || user == "보")
                {
                    System.Random haha = new System.Random();
                    int sysnum = haha.Next(1, 4);
                    string Sysstr = "";
                    string sysstr = "";
                    if (sysnum == 1)
                    {
                        sysstr = "가위";
                    }
                    else if (sysnum == 2)
                    {
                        sysstr = "바위";
                    }
                    else if (sysnum == 3)
                    {
                        sysstr = "보";
                    }

                    label1.Text = "user 는 ->" + user;
                    label2.Text = "system 는 ->" + sysstr;

                    if (user == sysstr)
                    {
                        label3.Text = "결과는 ->무승부";
                        draw++;
                    }
                    else if ((user == "가위" && sysstr == "보") || (user == "바위" && sysstr == "가위") || (user == "보" && sysstr == "바위"))
                    {
                        label3.Text = "결과는 ->승리";
                        win++;
                    }
                    else
                    {
                        label3.Text = "결과는 ->패배";
                        lose++;
                    }

                    label4.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패";
                }
                else
                {
                    label4.Text = "잘못된 입력입니다. 가위, 바위, 보 중 하나를 선택해주세요.";
                }
                textBox1.Text = "";
            }
            catch
            {
                label4.Text = "오류가 발생했습니다.";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}