using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;
using System.Net.NetworkInformation;

namespace HW2
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static Dictionary<string, List<string>> ReadFromCSV(string dir)
        {
            StreamReader reader = new StreamReader(dir);

            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
            result["qualitative"] = new List<string>();
            result["quantitative_disc"] = new List<string>();
            result["quantitative_cont"] = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = Regex.Split(line, ",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");

                result["qualitative"].Add(values[15].Trim('"'));
                result["quantitative_disc"].Add(values[5].Trim('"'));
                result["quantitative_cont"].Add(values[6].Trim('"'));
            }
            
            return result;
        }

        public static Dictionary<string, int> AbsoluteDistribution(List<string> dataset)
        {
            Dictionary<string, int> absoluteDistribution = dataset.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

            return absoluteDistribution;
        }

        public static Dictionary<string, double> RelativeDistribution(List<string> dataset)
        {
            Dictionary<string, int> absoluteDistribution = AbsoluteDistribution(dataset);
            Dictionary<string, double> relativeDistribution = absoluteDistribution.ToDictionary(kvp => kvp.Key, kvp => (double)kvp.Value / dataset.Count);

            return relativeDistribution;
        }

        public static Dictionary<string, double> PercentageDistribution(List<string> dataset)
        {
            Dictionary<string, double> relativeDistribution = RelativeDistribution(dataset);
            Dictionary<string, double> percentageDistribution = relativeDistribution.ToDictionary(kvp => kvp.Key, kvp => kvp.Value * 100);

            return percentageDistribution;
        }

        public static Dictionary<Tuple<string, string>, double> JointDistribution(List<string> dataset1, List<string> dataset2)
        {
            Dictionary<Tuple<string, string>, double> jointDistribution=new Dictionary<Tuple<string, string>, double>();
            for(int i=0; i<dataset2.Count; i++)
            {
                var key = Tuple.Create(dataset1[i], dataset2[i]);
                if (jointDistribution.ContainsKey(key))
                {
                    jointDistribution[key]++;
                }
                else
                {
                    jointDistribution[key] = 1;
                }
            }
            return jointDistribution;
        }
    }
}