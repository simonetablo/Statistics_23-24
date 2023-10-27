using C_;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class ResizableRectangle
    {
        public PictureBox pictureBox = new PictureBox();
        public Rectangle rectangle;

        public Bitmap b;
        public Graphics g;

        private Point offset;

        int originalWidth;
        int originalHeight;
        private Point originalOffset;

        bool dragging = false;

        public ResizableRectangle(Rectangle rectangle)
        {
            this.rectangle = rectangle;
            this.pictureBox.Width = rectangle.Width;
            this.pictureBox.Height = rectangle.Height;
            this.offset.X = rectangle.X;
            this.offset.Y = rectangle.Y;
            this.pictureBox.Location = offset;
            this.pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            originalWidth = rectangle.Width;
            originalHeight = rectangle.Height;
            originalOffset.X = rectangle.X;
            originalOffset.Y = rectangle.Y;

            b = new Bitmap(this.pictureBox.Width, this.pictureBox.Height);
            g = Graphics.FromImage(b);
            this.pictureBox.Image = b;

            pictureBox.MouseDown += new MouseEventHandler(pictureBox_MouseDown);
            pictureBox.MouseUp += new MouseEventHandler(pictureBox_MouseUp);
            pictureBox.MouseMove += new MouseEventHandler(pictureBox_MouseMove);
            pictureBox.MouseWheel += new MouseEventHandler(pictureBox_MouseWheel);
            pictureBox.MouseDoubleClick += new MouseEventHandler(pictureBox_MouseDoubleClick);
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.dragging = true;
                offset = e.Location;
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.dragging = false;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (dragging && c != null)
            {
                c.Top = e.Y + c.Top - offset.Y;
                c.Left = e.X + c.Left - offset.X;
            }
        }

        private void pictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            int widthDelta = (int)Math.Round(originalWidth * 0.1);
            int heightDelta = (int)Math.Round(originalHeight * 0.1);
            if (e.Delta > 0)
            {
                this.pictureBox.Width += widthDelta;
                this.pictureBox.Height += heightDelta;
            }
            else
            {
                this.pictureBox.Width -= widthDelta;
                this.pictureBox.Height -= heightDelta;
            }

        }

        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.pictureBox.Location = originalOffset;
            this.pictureBox.Width = originalWidth;
            this.pictureBox.Height = originalHeight;
        }

        public void drawChart(ObjectChart chart)
        {
            b.Dispose();
            Chart c = chart.getChart();
            c.Size = this.pictureBox.Size;

            c.SaveImage(chart.type + "Chart.png", ChartImageFormat.Png);

            b = new Bitmap(chart.type + "Chart.png");
            pictureBox.Image = b;
        }
        public void drawHistogram(ObjectHistogram histogram)
        {
            b.Dispose();
            Chart h = histogram.getHistogram();
            h.Size = this.pictureBox.Size;

            h.SaveImage(histogram.type + "Histogram.png", ChartImageFormat.Png);

            b = new Bitmap(histogram.type + "Histogram.png");
            pictureBox.Image = b;
        }

    }
}
