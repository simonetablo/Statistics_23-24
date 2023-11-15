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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        Rectangle rect1;
        Rectangle rect2;

        ResizableRectangle resRect1;
        ResizableRectangle resRect2;

        public Form1()
        {
            InitializeComponent();
        }

        int N=100;
        int M=100;
        double p=0.5;
        int S = 20;

        public void Form1_Load(Object sender, EventArgs e)
        {

            int newSplitterDistance = (int)(splitContainer1.Width * 0.03);
            splitContainer1.SplitterDistance = newSplitterDistance;

            int rectWidht = splitContainer1.Panel2.Width;
            int rectHeight = splitContainer1.Panel2.Height;
            rect1 = new Rectangle(0, 0, rectWidht/4*3, rectHeight);
            rect2 = new Rectangle(rectWidht / 4 * 3, 0, rectWidht / 4, rectHeight);

            resRect1 = new ResizableRectangle(rect1);
            resRect2 = new ResizableRectangle(rect2);

            splitContainer1.Panel2.Controls.Add(resRect1.pictureBox);
            splitContainer1.Panel2.Controls.Add(resRect2.pictureBox);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            double selectedValue = (double)trackBar1.Value / trackBar1.Maximum;
            p = selectedValue;
            label4.Text = selectedValue.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            M = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            N = (int)numericUpDown2.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Attack attack = new Attack(M, N, p);
            attack.SimulateAttack();
            List<List<int>> systems = attack.Systems();

            ObjectChart Chart1 = new ObjectChart(systems, "score");
            ObjectHistogram Hist1 = new ObjectHistogram(systems, S);

            bool rotation = true;

            if (rotation)
            {
                Hist1.histogram.Series["p"].Color = Color.FromArgb(110, 110, 0, 0);
                Chart1.chart.Titles.RemoveAt(0);
            }

            resRect1.drawChart(Chart1);
            resRect2.drawHistogram(Hist1, rotation);

        }
        
        private void Form1_Resize(object sender, EventArgs e)
        {
            int rectWidht = splitContainer1.Panel2.Width;
            int rectHeight = splitContainer1.Panel2.Height;
            resRect1.pictureBox.Size = new Size(rectWidht / 4 * 3, rectHeight);
            resRect1.pictureBox.Location = new Point(0, 0);
            resRect2.pictureBox.Size = new Size(rectWidht / 4, rectHeight);
            resRect2.pictureBox.Location = new Point(rectWidht / 4 * 3, 0);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            S=(int)numericUpDown3.Value;
        }
    }
}
