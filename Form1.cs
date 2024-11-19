namespace _19._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Red, 50, 50, 300, 200);
            g.FillRectangle(Brushes.White, 110, 50, 30, 200);
            g.FillRectangle(Brushes.White, 50, 135, 300, 30);
            g.FillRectangle(Brushes.Blue, 115, 50, 20, 200);
            g.FillRectangle(Brushes.Blue, 50, 140, 300, 20);
        }
    }
}
