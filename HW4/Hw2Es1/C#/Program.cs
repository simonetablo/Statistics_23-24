using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;
using System.Net.NetworkInformation;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection;
using System.Data;

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
            result["quantitative_cont_1"] = new List<string>();
            result["quantitative_cont_2"] = new List<string>();
            result["quantitative_cont_3"] = new List<string>();
            result["quantitative_cont_4"] = new List<string>();
            result["quantitative_cont_5"] = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = Regex.Split(line, ",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");

                result["qualitative"].Add(values[15].Trim('"'));
                result["quantitative_disc"].Add(values[5].Trim('"'));
                result["quantitative_cont_1"].Add(values[6].Trim('"'));
                for ( int i=0; i<result["quantitative_cont_1"].Count(); i++)
                {
                    if (result["quantitative_cont_1"][i] == "") { result["quantitative_cont_1"][i] = "0"; }
                }
                result["quantitative_cont_2"].Add(values[10].Trim('"'));
                for (int i = 0; i < result["quantitative_cont_1"].Count(); i++)
                {
                    if (result["quantitative_cont_2"][i] == "") { result["quantitative_cont_2"][i] = "0"; }
                }
                result["quantitative_cont_3"].Add(values[16].Trim('"'));
                for (int i = 0; i < result["quantitative_cont_1"].Count(); i++)
                {
                    if (result["quantitative_cont_3"][i] == "") { result["quantitative_cont_3"][i] = "0"; }
                }
                result["quantitative_cont_4"].Add(values[17].Trim('"'));
                for (int i = 0; i < result["quantitative_cont_1"].Count(); i++)
                {
                    if (result["quantitative_cont_4"][i] == "") { result["quantitative_cont_4"][i] = "0"; }
                }
                result["quantitative_cont_5"].Add(values[18].Trim('"'));
                for (int i = 0; i < result["quantitative_cont_1"].Count(); i++)
                {
                    if (result["quantitative_cont_5"][i] == "") { result["quantitative_cont_5"][i] = "0"; }
                }
            }
            
            return result;
        }

        public static Dictionary<string, int> AbsoluteDistribution(List<string> dataset, int intervals)
        {
            Dictionary<string, int> absoluteDistribution;
            if (intervals == -1)
            {
                absoluteDistribution = dataset.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
            }
            else
            {
                absoluteDistribution=new Dictionary<string, int>();
                double max = Convert.ToDouble(dataset.Max());
                double min = Convert.ToDouble(dataset.Where(x => x!= "0").Min());
                for (int i=0; i<intervals; i++)
                {
                    double interval = (max-min)/intervals;
                    double startInterval = min+(i*interval);
                    double stopInterval = startInterval+interval;
                    int value = dataset.Count(x => Convert.ToDouble(x) >= startInterval && Convert.ToDouble(x) <= stopInterval);
                    string key = "(" + startInterval + ", " + stopInterval + ")";
                    absoluteDistribution.Add(key, value);
                }
            }
            return absoluteDistribution;
        }

        public static Dictionary<string, double> RelativeDistribution(List<string> dataset, int intervals)
        {
            Dictionary<string, double> relativeDistribution;
            if (intervals == -1)
            {
                Dictionary<string, int> absoluteDistribution = AbsoluteDistribution(dataset, intervals);
                relativeDistribution = absoluteDistribution.ToDictionary(kvp => kvp.Key, kvp => (double)kvp.Value / dataset.Count);
            }
            else
            {
                Dictionary<string, int> absoluteDistribution = AbsoluteDistribution(dataset, intervals);
                relativeDistribution = absoluteDistribution.ToDictionary(kvp => kvp.Key, kvp => (double)kvp.Value / dataset.Where(x => x != "0").Count());
            }

            return relativeDistribution;
        }

        public static Dictionary<string, double> PercentageDistribution(List<string> dataset, int intervals)
        {
            Dictionary<string, double> percentageDistribution;
            if (intervals == -1)
            {
                Dictionary<string, double> relativeDistribution = RelativeDistribution(dataset, intervals);
                percentageDistribution = relativeDistribution.ToDictionary(kvp => kvp.Key, kvp => kvp.Value * 100);
            }
            else
            {
                Dictionary<string, double> relativeDistribution = RelativeDistribution(dataset, intervals);
                percentageDistribution = relativeDistribution.ToDictionary(kvp => kvp.Key, kvp => kvp.Value * 100);
            }

            return percentageDistribution;
        }

        public static Dictionary<List<string>, double> JointDistribution(List<List<string>> datasets, int n, List<List<double>> intervals)
        {
            Dictionary<List<string>, double> jointDistribution=new Dictionary<List<string>, double>();
            Dictionary<List<string>, int> frequencyMatrix = new Dictionary<List<string>, int>();
            for (int i = 0; i < datasets.Count; i++)
            {
                for(int j = 0; j < datasets[i].Count; j++)
                {
                    List<string> key = new List<string>();
                    for (int z=0; z < intervals.Count; z++)
                    {
                        string index = FindInterval(Convert.ToDouble(datasets[i][j]), intervals[z]);
                        key.Add(index);
                    }
                    if (!frequencyMatrix.ContainsKey(key))
                    {
                        frequencyMatrix.Add(key, 1);
                    }
                    else
                    {
                        frequencyMatrix[key]++;
                    }
                }
            }
            int observations = 0;
            for(int i=0; i< datasets.Count; i++)
            {
                observations+= datasets[i].Count;
            }
            foreach(var key in frequencyMatrix.Keys)
            {
                jointDistribution[key] = (double)frequencyMatrix[key]/observations;
            }
            return jointDistribution;
        }

        static string FindInterval(double value, List<double> intervals)
        {
            for(int i=0; i<(intervals.Count()-1); i++)
            {
                if(value >= intervals[i] && value < intervals[i + 1])
                {
                    return ("("+intervals[i].ToString()+" - "+intervals[i+1].ToString()+")");
                }
            }
            return "(null)";
        }

        public static List<double> IntervalLenght(List<string> dataset, int interval)
        {
            List<double> intervals = new List<double>();
            double max = Convert.ToDouble(dataset.Max());
            double min = Convert.ToDouble(dataset.Where(x => x != "0").Min());
            double intervalLenght = (max - min) / interval;
            for (int i = 0; i < interval; i++)
            {
                intervals.Add(min+(i*intervalLenght));
            }
            return intervals;
        }
    }
}