
namespace HW2
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<string>> data;
        List<string> dataset;
        List<string> dataset1;
        List<string> dataset2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dir = @"E:\File\Università\Cybersecurity\Statistics\code\HW2\dataset.csv";
            data = Program.ReadFromCSV(dir);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                textBox1.Text = "Choose a type of variable";
            }
            else
            {
                textBox1.Text = string.Empty;
                Dictionary<string, int> absoluteDist = Program.AbsoluteDistribution(dataset);
                foreach (KeyValuePair<string, int> kvp in absoluteDist)
                {
                    textBox1.Text += (kvp.Key, kvp.Value);
                    textBox1.AppendText(Environment.NewLine);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                textBox2.Text = "Choose a type of variable";
            }
            else
            {
                textBox2.Text = string.Empty;
                Dictionary<string, double> relativeDist = Program.RelativeDistribution(dataset);
                foreach (KeyValuePair<string, double> kvp in relativeDist)
                {
                    textBox2.Text += (kvp.Key, kvp.Value);
                    textBox2.AppendText(Environment.NewLine);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                textBox3.Text = "Choose a type of variable";
            }
            else
            {
                textBox3.Text = string.Empty;
                Dictionary<string, double> percentageDist = Program.PercentageDistribution(dataset);
                foreach (KeyValuePair<string, double> kvp in percentageDist)
                {
                    textBox3.Text += (kvp.Key, kvp.Value + "%");
                    textBox3.AppendText(Environment.NewLine);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dataset = data["qualitative"];
                    break;
                case 1:
                    dataset = data["quantitative_disc"];
                    break;
                case 2:
                    dataset = data["quantitative_cont"];
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    dataset1 = data["qualitative"];
                    break;
                case 1:
                    dataset1 = data["quantitative_disc"];
                    break;
                case 2:
                    dataset1 = data["quantitative_cont"];
                    break;
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    dataset2 = data["qualitative"];
                    break;
                case 1:
                    dataset2 = data["quantitative_disc"];
                    break;
                case 2:
                    dataset2 = data["quantitative_cont"];
                    break;
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1)
            {
                textBox4.Text = "Choose the variables";
            }
            else
            {
                textBox4.Text = string.Empty;
                Dictionary<Tuple<string, string>, double> jointDist = Program.JointDistribution(dataset1, dataset2);
                foreach (KeyValuePair<Tuple<string, string>, double> kvp in jointDist)
                {
                    textBox4.Text += (kvp.Key, kvp.Value);
                    textBox4.AppendText(Environment.NewLine);
                }
            }
        }
    }
}