namespace _20234764이기민_10주차_과제2
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
                    Array01[i] = haha.Next(1, 100);
                }
                for (int i = 0; i < 10; i++)
                {
                    if (i % 2 != 0)
                    {
                        str1 = str1 + "iarray[" + i + "] = " + Array01[i] + "\n";
                    }
                    else
                    {
                        str1 = str1 + "iarray[" + i + "] = " + Array01[i] + "   ";
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