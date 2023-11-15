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
        List<List<int>> attacks;
        int S;

        public ObjectHistogram(List<List<int>> attacks, int S)
        {
            this.attacks = attacks;
            this.S = S;
            histogram = new Chart();
            histogram.ChartAreas.Add("Area");
            this.GenerateHistogram();
        }

        private void GenerateHistogram()
        {
            Series serie = new Series("p");
            this.histogram.Series.Add(serie);
            serie.ChartType = SeriesChartType.Column;
            List<int> shielded=new List<int>(attacks.Count);
            List<List<int>> penetrated=new List<List<int>>(attacks.Count);
            for (int i=0; i<attacks.Count; i++)
            {
                int p = 0;
                int s = 0;
                List<int> innerP = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                shielded.Add(0);
                for (int j=0; j< attacks[i].Count; j++)
                {
                    if (attacks[i][j] == 1)
                    {
                        s++;
                        if(s==S)
                        {   
                            shielded[i] = j;
                        }
                    }
                    else
                    {
                        p++;
                        switch (p)
                        {
                            case 20:
                                innerP[0] = j;
                                break;
                            case 30:
                                innerP[1] = j;
                                break;
                            case 40:
                                innerP[2] = j;
                                break;
                            case 50:
                                innerP[3] = j;
                                break;
                            case 60:
                                innerP[4] = j;
                                break;
                            case 70:
                                innerP[5] = j;
                                break;
                            case 80:
                                innerP[6] = j;
                                break;
                            case 90:
                                innerP[7] = j;
                                break;
                            case 100:
                                innerP[8] = j;
                                break;
                            default: break;
                        }
                    }
                }
                penetrated.Add(innerP);
            }
            List<int> discarded = new List<int>{ 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for(int i=0; i<shielded.Count; i++)
            {
                for (int j=0; j<discarded.Count; j++)
                {
                    if (penetrated[i][j]!=0 && penetrated[i][j] < shielded[i])
                    {
                        discarded[j]++;
                    }
                }
            }

            for(int i=0; i<discarded.Count; i++) 
            {
                int Pvalue = 20 + i * 10;
                histogram.Series["p"].Points.AddXY(Pvalue, discarded[i]);
            }

        }
        public Chart getHistogram()
        {
            return this.histogram;
        }
    }
}
