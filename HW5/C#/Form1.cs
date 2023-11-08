using C_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        Rectangle rect1;
        Rectangle rect2;
        Rectangle rect3;

        ResizableRectangle resRect1;
        ResizableRectangle resRect2;
        ResizableRectangle resRect3;

        PictureBox box = new PictureBox();

        public Form1()
        {
            InitializeComponent();
        }

        int N=100;
        int M=100;
        int T=1;
        double lambda=10;
        int time = 99;

        public void Form1_Load(Object sender, EventArgs e)
        {

            int newSplitterDistance = (int)(splitContainer1.Width * 0.03);
            splitContainer1.SplitterDistance = newSplitterDistance;

            int rectWidht = splitContainer1.Panel2.Width;
            int rectHeight = splitContainer1.Panel2.Height;

            rect1 = new Rectangle(0, 0, rectWidht, rectHeight);
            rect2 = new Rectangle(0, 0, rectWidht, rectHeight);
            rect3 = new Rectangle(0, 0, rectWidht, rectHeight);

            resRect1 = new ResizableRectangle(rect1);
            resRect2 = new ResizableRectangle(rect2);
            resRect3 = new ResizableRectangle(rect3);
            
            box.Size = splitContainer1.Panel2.Size;
            splitContainer1.Panel2.Controls.Add(box);
            resRect1.pictureBox.Parent = box;
            resRect2.pictureBox.Parent = resRect1.pictureBox;
            resRect3.pictureBox.Parent = box;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            M = (int)numericUpDown1.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            N = (int)numericUpDown3.Value;
            time = N - 1;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            T=(int)numericUpDown2.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            lambda = (int)numericUpDown4.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double p = lambda * T / N;
            if(p>1)
            {
                MessageBox.Show("the values of T, N or Lambda gives a probability p>1. Change these values  ( p = "+ p.ToString()+" )");
                return;
            }
            Attack attack = new Attack(M, N, p);
            attack.SimulateAttack();
            List<List<int>> systems = attack.Systems();

            ObjectChart Chart1 = new ObjectChart(systems, "cumulated_frequency");

            ObjectHistogram Hist1 = new ObjectHistogram(Chart1, time);
            ObjectHistogram Hist2 = new ObjectHistogram(Chart1, time/2);
            bool rotation = true;

            if (rotation)
            {
                resRect1.pictureBox.Size = new Size(splitContainer1.Panel2.Width / 4 * 3, splitContainer1.Panel2.Height);
                resRect2.pictureBox.Size = new Size(splitContainer1.Panel2.Width / 4, splitContainer1.Panel2.Height);
                resRect2.pictureBox.Location = new Point(splitContainer1.Panel2.Width / 3, 0);
                resRect3.pictureBox.Size = new Size(splitContainer1.Panel2.Width / 4, splitContainer1.Panel2.Height);
                resRect3.pictureBox.Location = new Point(splitContainer1.Panel2.Width / 4 * 3, 0);
                Hist1.histogram.Series["s"].Color = Color.FromArgb(110, 110, 0, 0);
                Hist2.histogram.Series["s"].Color = Color.FromArgb(110, 0, 0, 80);
                Chart1.chart.Titles.RemoveAt(0);
                Hist1.histogram.Titles.RemoveAt(0);
                Hist2.histogram.Titles.RemoveAt(0);
                Hist1.histogram.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
                Hist1.histogram.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
                Hist1.histogram.ChartAreas[0].AxisY.LineColor = Color.Transparent;
                Hist2.histogram.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
                Hist2.histogram.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
                Hist2.histogram.ChartAreas[0].AxisY.LineColor = Color.Transparent;
                Hist1.histogram.ChartAreas[0].BackColor = Color.Transparent;
                Hist2.histogram.ChartAreas[0].BackColor = Color.Transparent;
                Hist1.histogram.BackColor = Color.Transparent;
                Hist2.histogram.BackColor = Color.Transparent;
                Hist1.histogram.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                Hist1.histogram.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
                Hist1.histogram.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                Hist1.histogram.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
                Hist2.histogram.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                Hist2.histogram.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
                Hist2.histogram.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                Hist2.histogram.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            }
            resRect1.drawChart(Chart1, rotation);
            resRect2.drawHistogram(Hist1, rotation);
            resRect3.drawHistogram(Hist2, rotation);
        }
        
        private void Form1_Resize(object sender, EventArgs e)
        {
            int rectWidht = splitContainer1.Panel2.Width;
            int rectHeight = splitContainer1.Panel2.Height;
            box.Size = splitContainer1.Panel2.Size;
            resRect1.pictureBox.Size = new Size(rectWidht/4*3, rectHeight);
            resRect1.pictureBox.Location = new Point(0, 0);
            resRect2.pictureBox.Size = new Size(rectWidht / 4, rectHeight);
            resRect2.pictureBox.Location = new Point(rectWidht / 3, 0);
            resRect3.pictureBox.Size = new Size(rectWidht / 4, rectHeight);
            resRect3.pictureBox.Location = new Point(rectWidht / 4 * 3, 0);
        }
    }
}
