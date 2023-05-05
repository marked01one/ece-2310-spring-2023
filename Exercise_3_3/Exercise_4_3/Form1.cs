namespace Exercise_4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount = Convert.ToDecimal(textBox1.Text);
                decimal monthlyRate = Convert.ToDecimal(textBox2.Text) / 100 / 12;
                int years = Convert.ToInt32(textBox3.Text);

                string output = "Amount\t\tCurrent Total\n";

                for (int i = 0; i < years; i++)
                {
                    decimal monthlyAmount = amount * monthlyRate;

                    for (int j = 1; j <= 12; j++)
                    {
                        amount += monthlyAmount;

                        output += $"{monthlyAmount:C}\t\t{amount:C}\n";
                    }
                }

                label4.Text = "";

                richTextBox1.Text = output;
                return;
            } 
            catch (FormatException) 
            {
                label4.Text = "WARNING:\nInvalid values in one of the fields above.";
                return;
            }
            

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            richTextBox1.Text = string.Empty;
        }
    }
}