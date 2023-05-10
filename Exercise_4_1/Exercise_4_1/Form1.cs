namespace Exercise_4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics;

            graphics = this.CreateGraphics();

            Pen blackPen = new Pen(Color.Black);

            SolidBrush blackBrush = new SolidBrush(Color.Black);

            SolidBrush whiteBrush = new SolidBrush(Color.White);

            graphics.FillEllipse(whiteBrush, 0, 0, 160, 160);

            graphics.DrawEllipse(blackPen, 0, 0, 160, 160);

            graphics.FillPie(blackBrush, 0, 0, 160, 160, 90, 180);

            graphics.FillPie(blackBrush, 40, 0, 80, 80, 90, 360);

            graphics.FillPie(whiteBrush, 40, 80, 80, 80, 90, 360);

            graphics.FillEllipse(whiteBrush, 70, 30, 20, 20);

            graphics.FillEllipse(blackBrush, 70, 110, 20, 20);
        }
    }
}