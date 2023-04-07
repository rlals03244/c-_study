namespace _20234764이기민_과제3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adata = int.Parse(textBox1.Text);
            string sdata = "";

            for (int i = 1; i <= adata; i++)
            {
                sdata += i + ",";
            }
            label1.Text = "수행된 i 값 : " + sdata;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}