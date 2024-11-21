namespace _19._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush redBrush = new SolidBrush(Color.Red);
            Brush whiteBrush = new SolidBrush(Color.White);
            Brush blueBrush = new SolidBrush(Color.Blue);
            Pen blackPen = new Pen(Color.Black, 2);
            g.FillRectangle(redBrush, 50, 50, 300, 200);
            g.FillRectangle(whiteBrush, 110, 50, 30, 200);
            g.FillRectangle(whiteBrush, 50, 135, 300, 30);
            g.FillRectangle(blueBrush, 115, 50, 20, 200);
            g.FillRectangle(blueBrush, 50, 140, 300, 20);
            g.DrawRectangle(blackPen, 50, 50, 300, 200);
            redBrush.Dispose();
            whiteBrush.Dispose();
            blueBrush.Dispose();
            blackPen.Dispose();
        }
    }
}
