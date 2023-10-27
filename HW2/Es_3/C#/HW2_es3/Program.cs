using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int N = 100000; // Number of random variates
        int k = 100; // Number of class intervals
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
            Console.WriteLine($"Interval [{(double)i / k}, {(double)(i + 1) / k}): {counts[i]}");
        }
    }
}