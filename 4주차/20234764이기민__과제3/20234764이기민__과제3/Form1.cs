namespace _20234764이기민__과제3
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
                int idata02 = int.Parse(textBox2.Text);
                string sdata01 = textBox3.Text;

                bool result;

                if (sdata01 == "==")
                {
                    result = idata01 == idata02;
                    label1.Text = idata01 + sdata01 + idata02 + "의 결과는" + result;
                }
                else if (sdata01 == "<=")
                {
                    bool bData01 = idata01 <= idata02;
                    label5.Text = idata01 + "<=" + idata02 + "의 결과는" + bData01;
                }
                else if (sdata01 == "=>")
                {
                    bool bData01 = idata01 >= idata02;
                    label5.Text = idata01 + ">=" + idata02 + "의 결과는" + bData01;
                }
                else if (sdata01 == "!=")
                {
                    bool bData01 = idata01 != idata02;
                    label5.Text = idata01 + "!=" + idata02 + "의 결과는" + bData01;
                }
                else if (sdata01 == "<")
                {
                    bool bData01 = idata01 < idata02;
                    label5.Text = idata01 + "<" + idata02 + "의 결과는" + bData01;
                }
                else if (sdata01 == ">")
                {
                    bool bData01 = idata01 > idata02;
                    label5.Text = idata01 + ">" + idata02 + "의 결과는" + bData01;
                }
                else
                {
                    label1.Text = "알 수 없는 관계연산자입니다.";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}