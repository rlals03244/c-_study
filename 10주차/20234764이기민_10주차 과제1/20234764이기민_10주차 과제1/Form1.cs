namespace _20234764이기민_9주차_과제1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] Array01 = new int[100];

                for (int i = 0; i < 100; i++)
                {
                    Array01[i] = i + 1;
                }
                string str1 = " ";
                int cnt = 0;

                foreach (int iOne in Array01)
                {
                    cnt++;
                    if (cnt % 10 == 0)
                    {
                        str1 += iOne + "\n";
                    }
                    else
                    {
                        str1 = str1 + iOne + " ";
                    }
                }
                label1.Text = str1;
            }
            catch
            {

            }
        }
    }
}