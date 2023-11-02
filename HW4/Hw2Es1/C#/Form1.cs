
namespace HW2
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<string>> data;
        List<string> dataset;
        List<List<string>> datasets = new List<List<string>>();
        List<int> intervals = new List<int>();
        int interval = -1;
        int n = 2;
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 6; i++)
            {
                datasets.Add(new List<string>());
                intervals.Add(-1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dir = @"F:\Code\Statistics_23-24\HW4\Hw2Es1\C#\dataset.csv";
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
                Dictionary<string, int> absoluteDist = Program.AbsoluteDistribution(dataset, interval);
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
                Dictionary<string, double> relativeDist = Program.RelativeDistribution(dataset, interval);
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
                Dictionary<string, double> percentageDist = Program.PercentageDistribution(dataset, interval);
                foreach (KeyValuePair<string, double> kvp in percentageDist)
                {
                    textBox3.Text += (kvp.Key, kvp.Value + "%");
                    textBox3.AppendText(Environment.NewLine);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            numericUpDown2.Visible = false;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dataset = data["qualitative"];
                    break;
                case 1:
                    dataset = data["quantitative_disc"];
                    break;
                case 2:
                    dataset = data["quantitative_cont_1"];
                    label2.Visible = true;
                    numericUpDown2.Visible = true;
                    break;
                case 3:
                    dataset = data["quantitative_cont_2"];
                    label2.Visible = true;
                    numericUpDown2.Visible = true;
                    break;
                case 4:
                    dataset = data["quantitative_cont_3"];
                    label2.Visible = true;
                    numericUpDown2.Visible = true;
                    break;
                case 5:
                    dataset = data["quantitative_cont_4"];
                    label2.Visible = true;
                    numericUpDown2.Visible = true;
                    break;
                case 6:
                    dataset = data["quantitative_cont_5"];
                    label2.Visible = true;
                    numericUpDown2.Visible = true;
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    datasets[0] = data["qualitative"];
                    numericUpDown3.Visible = false;
                    intervals[0] = -1;
                    break;
                case 1:
                    datasets[0] = data["quantitative_disc"];
                    numericUpDown4.Visible = false;
                    intervals[0] = -1;
                    break;
                case 2:
                    datasets[0] = data["quantitative_cont_1"];
                    numericUpDown3.Visible = true;
                    intervals[0] = 1;
                    break;
                case 3:
                    datasets[0] = data["quantitative_cont_2"];
                    numericUpDown3.Visible = true;
                    intervals[0] = 1;
                    break;
                case 4:
                    datasets[0] = data["quantitative_cont_3"];
                    numericUpDown3.Visible = true;
                    intervals[0] = 1;
                    break;
                case 5:
                    datasets[0] = data["quantitative_cont_4"];
                    numericUpDown3.Visible = true;
                    intervals[0] = 1;
                    break;
                case 6:
                    datasets[0] = data["quantitative_cont_5"];
                    numericUpDown3.Visible = true;
                    intervals[0] = 1;
                    break;
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    datasets[1] = data["qualitative"];
                    numericUpDown4.Visible = false;
                    intervals[1] = -1;
                    break;
                case 1:
                    datasets[1] = data["quantitative_disc"];
                    numericUpDown4.Visible = false;
                    intervals[1] = -1;
                    break;
                case 2:
                    datasets[1] = data["quantitative_cont_1"];
                    numericUpDown4.Visible = true;
                    intervals[1] = 1;
                    break;
                case 3:
                    datasets[1] = data["quantitative_cont_2"];
                    numericUpDown4.Visible = true;
                    intervals[1] = 1;
                    break;
                case 4:
                    datasets[1] = data["quantitative_cont_3"];
                    numericUpDown4.Visible = true;
                    intervals[1] = 1;
                    break;
                case 5:
                    datasets[1] = data["quantitative_cont_4"];
                    numericUpDown4.Visible = true;
                    intervals[1] = 1;
                    break;
                case 6:
                    datasets[1] = data["quantitative_cont_5"];
                    numericUpDown4.Visible = true;
                    intervals[1] = 1;
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
                List<List<double>> intervalsLength = new List<List<double>>();
                for (int i = 0; i < intervals.Count; i++)
                {
                    if (intervals[i] > 0)
                    {
                        intervalsLength.Add(Program.IntervalLenght(datasets[i], intervals[i]));
                    }
                }
                textBox4.Text = string.Empty;
                Dictionary<List<string>, double> jointDist = Program.JointDistribution(datasets, n, intervalsLength);
                foreach (KeyValuePair<List<string>, double> kvp in jointDist)
                {
                    textBox4.Text += (String.Join(",", kvp.Key) + " : " + kvp.Value);
                    textBox4.AppendText(Environment.NewLine);
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            n = (int)numericUpDown1.Value;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;

            switch (n)
            {
                case 2:
                    numericUpDown5.Visible = false;
                    break;
                case 3:
                    comboBox4.Visible = true;
                    numericUpDown6.Visible=false;
                    numericUpDown7.Visible=false;
                    numericUpDown8.Visible=false;
                    break;
                case 4:
                    comboBox4.Visible = true;
                    comboBox5.Visible = true;
                    numericUpDown7.Visible = false;
                    numericUpDown8.Visible = false;
                    break;
                case 5:
                    comboBox4.Visible = true;
                    comboBox5.Visible = true;
                    comboBox6.Visible = true;
                    numericUpDown8.Visible = false;
                    break;
                case 6:
                    comboBox4.Visible = true;
                    comboBox5.Visible = true;
                    comboBox6.Visible = true;
                    comboBox7.Visible = true;
                    break;
                default: break;

            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedIndex)
            {
                case 0:
                    datasets[2] = data["qualitative"];
                    numericUpDown5.Visible = false;
                    intervals[2] = -1;
                    break;
                case 1:
                    datasets[2] = data["quantitative_disc"];
                    numericUpDown5.Visible = false;
                    intervals[2] = -1;
                    break;
                case 2:
                    datasets[2] = data["quantitative_cont_1"];
                    numericUpDown5.Visible = true;
                    intervals[2] = 1;
                    break;
                case 3:
                    datasets[2] = data["quantitative_cont_2"];
                    numericUpDown5.Visible = true;
                    intervals[2] = 1;
                    break;
                case 4:
                    datasets[2] = data["quantitative_cont_3"];
                    numericUpDown5.Visible = true;
                    intervals[2] = 1;
                    break;
                case 5:
                    datasets[2] = data["quantitative_cont_4"];
                    numericUpDown5.Visible = true;
                    intervals[2] = 1;
                    break;
                case 6:
                    datasets[2] = data["quantitative_cont_5"];
                    numericUpDown5.Visible = true;
                    intervals[2] = 1;
                    break;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox5.SelectedIndex)
            {
                case 0:
                    datasets[3] = data["qualitative"];
                    numericUpDown6.Visible = false;
                    intervals[3] = -1;
                    break;
                case 1:
                    datasets[3] = data["quantitative_disc"];
                    numericUpDown6.Visible = false;
                    intervals[3] = -1;
                    break;
                case 2:
                    datasets[3] = data["quantitative_cont_1"];
                    numericUpDown6.Visible = true;
                    intervals[3] = 1;
                    break;
                case 3:
                    datasets[3] = data["quantitative_cont_2"];
                    numericUpDown6.Visible = true;
                    intervals[3] = 1;
                    break;
                case 4:
                    datasets[3] = data["quantitative_cont_3"];
                    numericUpDown6.Visible = true;
                    intervals[3] = 1;
                    break;
                case 5:
                    datasets[3] = data["quantitative_cont_4"];
                    numericUpDown6.Visible = true;
                    intervals[3] = 1;
                    break;
                case 6:
                    datasets[3] = data["quantitative_cont_5"];
                    numericUpDown6.Visible = true;
                    intervals[3] = 1;
                    break;
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox6.SelectedIndex)
            {
                case 0:
                    datasets[4] = data["qualitative"];
                    numericUpDown7.Visible = false;
                    intervals[4] = -1;
                    break;
                case 1:
                    datasets[4] = data["quantitative_disc"];
                    numericUpDown7.Visible = false;
                    intervals[4] = -1;
                    break;
                case 2:
                    datasets[4] = data["quantitative_cont_1"];
                    numericUpDown7.Visible = true;
                    intervals[4] = 1;
                    break;
                case 3:
                    datasets[4] = data["quantitative_cont_2"];
                    numericUpDown7.Visible = true;
                    intervals[4] = 1;
                    break;
                case 4:
                    datasets[4] = data["quantitative_cont_3"];
                    numericUpDown7.Visible = true;
                    intervals[4] = 1;
                    break;
                case 5:
                    datasets[4] = data["quantitative_cont_4"];
                    numericUpDown7.Visible = true;
                    intervals[4] = 1;
                    break;
                case 6:
                    datasets[4] = data["quantitative_cont_5"];
                    numericUpDown7.Visible = true;
                    intervals[4] = 1;
                    break;
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox7.SelectedIndex)
            {
                case 0:
                    datasets[5] = data["qualitative"];
                    numericUpDown8.Visible = false;
                    intervals[5] = -1;
                    break;
                case 1:
                    datasets[5] = data["quantitative_disc"];
                    numericUpDown8.Visible = false;
                    intervals[5] = -1;
                    break;
                case 2:
                    datasets[5] = data["quantitative_cont_1"];
                    numericUpDown8.Visible = true;
                    intervals[5] = 1;
                    break;
                case 3:
                    datasets[5] = data["quantitative_cont_2"];
                    numericUpDown8.Visible = true;
                    intervals[5] = 1;
                    break;
                case 4:
                    datasets[5] = data["quantitative_cont_3"];
                    numericUpDown8.Visible = true;
                    intervals[5] = 1;
                    break;
                case 5:
                    datasets[5] = data["quantitative_cont_4"];
                    numericUpDown8.Visible = true;
                    intervals[5] = 1;
                    break;
                case 6:
                    datasets[5] = data["quantitative_cont_5"];
                    numericUpDown8.Visible = true;
                    intervals[5] = 1;
                    break;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            interval = (int)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            intervals[0] = (int)numericUpDown3.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            intervals[1] = (int)numericUpDown4.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            intervals[2] = (int)numericUpDown5.Value;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            intervals[3] = (int)numericUpDown6.Value;
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            intervals[4] = (int)numericUpDown7.Value;
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            intervals[5] = (int)numericUpDown8.Value;
        }
    }
}