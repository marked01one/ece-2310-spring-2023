namespace Exercise_4_2
{
    public partial class Exercise_4_Q2 : Form
    {
        public Exercise_4_Q2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") {
                label1.ForeColor = Color.Red;
                label1.Text = "WARNING: You have not typed anything!";
            } else
            {
                label1.ForeColor = Color.Black;
                label1.Text = textBox1.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}