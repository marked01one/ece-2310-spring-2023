namespace Exercise_4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            label8.ForeColor = Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                Complex num1 = new Complex(
                    Convert.ToDouble(textBox1.Text),
                    Convert.ToDouble(textBox2.Text)
                );

                Complex num2 = new Complex(
                    Convert.ToDouble(textBox4.Text),
                    Convert.ToDouble(textBox5.Text)
                );

                if (radioButton1.Checked) { num1.add(num2); }
                else if (radioButton2.Checked) { num1.diff(num2); }
                else if (radioButton3.Checked) { num1.mulfix(num2); }
                else if (radioButton4.Checked) { num1.div(num2); }

                textBox3.Text = num1.returnComplexString();
                label8.Text = string.Empty;
                return;
            }
            catch (FormatException)
            {
                label8.Text = "WARNING:\nYour inputs are not valid!";
                return;
            }   
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            label8.Text = string.Empty;
        }
    }
}