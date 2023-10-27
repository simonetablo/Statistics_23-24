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
        Rectangle rect3;
        Rectangle rect4;
        Rectangle rect5;
        Rectangle rect6;
        Rectangle rect7;
        Rectangle rect8;

        ResizableRectangle resRect1;
        ResizableRectangle resRect2;
        ResizableRectangle resRect3;
        ResizableRectangle resRect4;
        ResizableRectangle resRect5;
        ResizableRectangle resRect6;
        ResizableRectangle resRect7;
        ResizableRectangle resRect8;

        public Form1()
        {
            InitializeComponent();
        }

        int N=100;
        int M=100;
        double p=0.5;
        int time = 99;

        public void Form1_Load(Object sender, EventArgs e)
        {

            int newSplitterDistance = (int)(splitContainer1.Width * 0.03);
            splitContainer1.SplitterDistance = newSplitterDistance;

            int rectWidht = splitContainer1.Panel2.Width / 2;
            int rectHeight = splitContainer1.Panel2.Height / 4;
            rect1 = new Rectangle(0, 0, rectWidht, rectHeight);
            rect2 = new Rectangle(0, rectHeight, rectWidht, rectHeight);
            rect3 = new Rectangle(0, 2*rectHeight, rectWidht, rectHeight);
            rect4 = new Rectangle(0, 3*rectHeight, rectWidht, rectHeight);
            rect5 = new Rectangle(rectWidht, 0, rectWidht, rectHeight);
            rect6 = new Rectangle(rectWidht, 1 * rectHeight, rectWidht, rectHeight);
            rect7 = new Rectangle(rectWidht, 2 * rectHeight, rectWidht, rectHeight);
            rect8 = new Rectangle(rectWidht, 3 * rectHeight, rectWidht, rectHeight);

            resRect1 = new ResizableRectangle(rect1);
            resRect2 = new ResizableRectangle(rect2);
            resRect3 = new ResizableRectangle(rect3);
            resRect4 = new ResizableRectangle(rect4);
            resRect5 = new ResizableRectangle(rect5);
            resRect6 = new ResizableRectangle(rect6);
            resRect7 = new ResizableRectangle(rect7);
            resRect8 = new ResizableRectangle(rect8);

            splitContainer1.Panel2.Controls.Add(resRect1.pictureBox);
            splitContainer1.Panel2.Controls.Add(resRect2.pictureBox);
            splitContainer1.Panel2.Controls.Add(resRect3.pictureBox);
            splitContainer1.Panel2.Controls.Add(resRect4.pictureBox);
            splitContainer1.Panel2.Controls.Add(resRect5.pictureBox);
            splitContainer1.Panel2.Controls.Add(resRect6.pictureBox);
            splitContainer1.Panel2.Controls.Add(resRect7.pictureBox);
            splitContainer1.Panel2.Controls.Add(resRect8.pictureBox);
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
            time = N - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Attack attack = new Attack(M, N, p);
            attack.SimulateAttack();
            List<List<int>> systems = attack.Systems();

            ObjectChart Chart1 = new ObjectChart(systems, "score");
            ObjectHistogram Hist1 = new ObjectHistogram(Chart1, time);

            ObjectChart Chart2 = new ObjectChart(systems, "cumulated_frequency");
            ObjectHistogram Hist2 = new ObjectHistogram(Chart2, time);


            ObjectChart Chart3 = new ObjectChart(systems, "relative_frequency");
            ObjectHistogram Hist3 = new ObjectHistogram(Chart3, time);

            ObjectChart Chart4 = new ObjectChart(systems, "ratio");
            ObjectHistogram Hist4 = new ObjectHistogram(Chart4, time);

            resRect1.drawChart(Chart1);
            resRect2.drawChart(Chart2);
            resRect3.drawChart(Chart3);
            resRect4.drawChart(Chart4);
            resRect5.drawHistogram(Hist1);
            resRect6.drawHistogram(Hist2);
            resRect7.drawHistogram(Hist3);
            resRect8.drawHistogram(Hist4);
        }
        
        private void Form1_Resize(object sender, EventArgs e)
        {
            int rectWidht = splitContainer1.Panel2.Width / 2;
            int rectHeight = splitContainer1.Panel2.Height / 4;
            resRect1.pictureBox.Size = new Size(rectWidht, rectHeight);
            resRect1.pictureBox.Location = new Point(0, 0);
            resRect2.pictureBox.Size = new Size(rectWidht, rectHeight);
            resRect2.pictureBox.Location = new Point(0, rectHeight);
            resRect3.pictureBox.Size = new Size(rectWidht, rectHeight);
            resRect3.pictureBox.Location = new Point(0, 2 * rectHeight);
            resRect4.pictureBox.Size = new Size(rectWidht, rectHeight);
            resRect4.pictureBox.Location = new Point(0, 3 * rectHeight);
            resRect5.pictureBox.Size = new Size(rectWidht, rectHeight);
            resRect5.pictureBox.Location = new Point(rectWidht, 0);
            resRect6.pictureBox.Size = new Size(rectWidht, rectHeight);
            resRect6.pictureBox.Location = new Point(rectWidht, rectHeight);
            resRect7.pictureBox.Size = new Size(rectWidht, rectHeight);
            resRect7.pictureBox.Location = new Point(rectWidht, 2 * rectHeight);
            resRect8.pictureBox.Size = new Size(rectWidht, rectHeight);
            resRect8.pictureBox.Location = new Point(rectWidht, 3 * rectHeight);
        }
    }
}
