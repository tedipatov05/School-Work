using System;
using System.Collections.Generic;

namespace Многомерен_масив
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n=");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i< n;i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"matrix[{i},{j}]=");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            List<int> sums = new List<int>();
            int sum = 0;
            for(int i=0;i<n;i++)
            {
               
                for (int j = 0; j < n; j++)
                {
                    sum += matrix[i, j];
                }
                sums.Add(sum);
                sum = 0;
            }
            for(int i=0;i<n;i++)
            {
                sum += matrix[i, i];
               
            }
            sums.Add(sum);
            sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, n-1-i];
                
            }
            sums.Add(sum);
            sum = 0;



        }
    }
}
