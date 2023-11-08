using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace C_
{
    internal class ObjectChart
    {
        public Chart chart;
        public string type;
        public List<List<double>> data;

        public ObjectChart(List<List<int>> attacks, string type)
        {
            chart = new Chart();
            chart.ChartAreas.Add("Area");
            chart.ChartAreas[0].AxisX.Minimum = 0;
            chart.Titles.Add(type);
            this.data = new List<List<double>>();
            this.GenerateChart(attacks, type);
            this.type = type;
        }

        private void GenerateChart(List<List<int>> attacks, string type)
        {
            switch (type)
            {
                case "score":
                    for (int i = 0; i < attacks.Count; i++)
                    {
                        Series series = new Series(i.ToString());
                        chart.Series.Add(series);
                        int value = 0;
                        chart.Series[series.Name].Points.AddXY(0, value);
                        this.data.Add(new List<double>());
                        for (int j = 0; j < attacks[i].Count; j++)
                        {
                            value += attacks[i][j];
                            chart.Series[series.Name].Points.AddXY(j + 1, value);
                            this.data[i].Add(value);
                        }
                        chart.Series[series.Name].ChartType = SeriesChartType.Line;
                    }
                    break;
                case "cumulated_frequency":
                    for (int i = 0; i < attacks.Count; i++)
                    {
                        Series series = new Series(i.ToString());
                        chart.Series.Add(series);
                        int value = 0;
                        chart.Series[series.Name].Points.AddXY(0, value);
                        this.data.Add(new List<double>());
                        for (int j = 0; j < attacks[i].Count; j++)
                        {
                            if (attacks[i][j] == -1)
                            {
                                value++;
                            }
                            chart.Series[series.Name].Points.AddXY(j + 1, value);
                            this.data[i].Add(value);
                        }
                        chart.Series[series.Name].ChartType = SeriesChartType.Line;
                    }
                    break;
                case "relative_frequency":
                    int max = 0;
                    for (int i = 0; i < attacks.Count; i++)
                    {
                        Series series = new Series(i.ToString());
                        chart.Series.Add(series);
                        int value = 0;
                        chart.Series[series.Name].Points.AddXY(0, value);
                        this.data.Add(new List<double>());
                        for (int j = 0; j < attacks[i].Count; j++)
                        {
                            if (attacks[i][j] == -1)
                            {
                                value++;
                            }
                            chart.Series[series.Name].Points.AddXY(j + 1, (double)value / (j+1));
                            this.data[i].Add((double)value / (j + 1));
                        }
                        if (value > max) { max = value; }
                        chart.Series[series.Name].ChartType = SeriesChartType.Line;
                    }

                    break;
                case "ratio":
                    for (int i = 0; i < attacks.Count; i++)
                    {
                        Series series = new Series(i.ToString());
                        chart.Series.Add(series);
                        int value = 0;
                        chart.Series[series.Name].Points.AddXY(0, value);
                        this.data.Add(new List<double>());
                        for (int j = 0; j < attacks[i].Count; j++)
                        {
                            if (attacks[i][j] == -1)
                            {
                                value++;
                            }
                            chart.Series[series.Name].Points.AddXY(j + 1, (double)value / (Math.Sqrt(j + 1)));
                            this.data[i].Add((double)value / (Math.Sqrt(j + 1)));
                        }
                        chart.Series[series.Name].ChartType = SeriesChartType.Line;
                    }
                    break;
                default:
                    break;
            }
        }

        public Chart getChart()
        {
            return this.chart;
        }
    }
}
