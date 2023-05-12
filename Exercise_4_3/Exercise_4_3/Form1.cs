namespace Exercise_4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.ForeColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int try_n = Convert.ToInt32(textBox1.Text);
            }
            catch (FormatException)
            {
                label2.Text = "Error: Please enter numbers only!";
                return;
            }

            int n = Convert.ToInt32(textBox1.Text);

            if (n % 2 == 0) { 
                label2.Text = "Make sure magic number is odd!";
                return;
            }
            
            int[,] matrix = new int[n, n];

            int row = 0, col = n / 2;

            matrix[row, col] = 1;

            for (int i = 2; i <= n * n; i++)
            {
                if (matrix[(row + 1) % n, (col + 1) % n] == 0)
                {
                    row = (row + 1) % n;
                    col = (col + 1) % n;
                }
                else
                {
                    row = (row - 1 + n) % n;
                    // don't change col
                }
                matrix[row, col] = i;
            }

            Graphics graphics;

            graphics = this.CreateGraphics();

            graphics.Clear(Color.White);

            Pen blackPen = new Pen(Color.Black);

            SolidBrush greenBrush = new SolidBrush(Color.Green);

            SolidBrush blackBrush = new SolidBrush(Color.Black);

            int rectX = 20, rectY = 85;
            int strX = 25, strY = 80;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Rectangle background = new Rectangle(rectX + 40 * i, rectY + 40 * j, 40, 40);

                    PointF numStart = new PointF(strX + 40 * i, strY + 40 * j);
                    
                    graphics.FillRectangle(greenBrush, background);
                    
                    graphics.DrawRectangle(blackPen, background);
                    
                    graphics.DrawString(
                        $"{matrix[i, j]}",
                        new Font(label3.Font.Name, 20),
                        blackBrush,
                        numStart
                    );
                }
            }

            



            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}