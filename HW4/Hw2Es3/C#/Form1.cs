namespace C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int N = 100;
        int k = 10;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            calculate();
        }

        private void calculate()
        {
            Random random = new Random();
            double[] variates = new double[N];
            int[] counts = new int[k];

            // Generate N uniform random variates in [0,1)
            for (int i = 0; i < N; i++)
            {
                variates[i] = random.NextDouble();
            }

            // Determine the distribution into class intervals [i/k, (i+1)/k)
            for (int i = 0; i < N; i++)
            {
                int index = (int)(variates[i] * k);
                counts[index]++;
            }

            // Print the distribution
            for (int i = 0; i < k; i++)
            {
                textBox1.AppendText($"Interval [{(double)i / k}, {(double)(i + 1) / k}): {counts[i]}" + Environment.NewLine);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            N = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            k = (int)numericUpDown2.Value;
        }
    }
}