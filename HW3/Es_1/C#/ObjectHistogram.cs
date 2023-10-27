using C_;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    internal class ObjectHistogram
    {
        public Chart histogram;
        public int time;
        public string type;
        List<List<double>> data;

        public ObjectHistogram(ObjectChart chart, int time)
        {
            this.type = chart.type;
            this.time = time;
            this.data = chart.data;
            histogram = new Chart();
            histogram.ChartAreas.Add("Area");
            histogram.Titles.Add(type+"_histogram");
            this.GenerateHistogram();
        }

        private void GenerateHistogram()
        {
            Series serie = new Series("s");
            this.histogram.Series.Add(serie);
            serie.ChartType = SeriesChartType.Column;
            List<double> values=new List<double>();
            for(int v=0; v<data.Count(); v++) 
            {
                if (!values.Contains(data[v][time]))
                {
                    values.Add(data[v][time]);
                }
            }
            for (int i=0; i<values.Count; i++)
            {
                int value = 0;
                for(int j=0; j<data.Count(); j++)
                {
                    if (data[j][time] == values[i])
                    {
                        value++;
                    }
                }
                histogram.Series["s"].Points.AddXY(values[i], value);
            }
        }
        public Chart getHistogram()
        {
            return this.histogram;
        }
    }
}
