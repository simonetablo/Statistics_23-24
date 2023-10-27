using System.Windows.Forms;

namespace C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Bitmap b;
        public Graphics g;
        private void Form1_Load(object sender, EventArgs e)
        {
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);

            Pen blackPen = new Pen(Color.Black, 3);
            Point p1 = new Point(30, 10);
            Point p2 = new Point(30, 300);
            Color color = Color.DarkBlue;

            g.DrawLine(blackPen, p1, p2);
            b.SetPixel(30, 350, color);
            g.FillRectangle(Brushes.MediumSeaGreen, 100, 10, 100, 300);
            g.FillEllipse(Brushes.OrangeRed, 100, 330, 100, 100);

            pictureBox1.Image = b;
        }

    }
}