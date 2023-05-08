namespace _20234764이기민_10주차_과제4
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
                int[] Array01 = new int[10];
                string str1 = "";
                System.Random haha = new System.Random();
                for (int i = 0; i < 10; i++)
                {
                    Array01[i] = haha.Next(1, 101);
                }

                for (int i = 0; i < 10; i += 2)
                {

                    str1 += "Array01[" + i + "] = " + Array01[i] + " Array01[" + (i + 1) + "] = " + Array01[i + 1] + "\n";

                }

                label1.Text = str1;


                double sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    sum += Array01[i];
                }
                double avg = sum / 10;

                label2.Text = "10개 원소 평균값: " + avg.ToString();
            }
            catch
            {

            }
        }
    }
}