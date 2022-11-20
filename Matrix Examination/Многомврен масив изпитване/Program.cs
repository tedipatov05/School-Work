using System;
using System.Collections.Generic;

namespace Многомврен_масив_изпитване
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int counterPrime = 0;
            List<int> numsPrime = new List<int>();
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.Write($"matrix[{i},{j}]= ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < n; j++)
                {
                    counterPrime = 0;
                    int num = matrix[i, j];
                    for(int k=2;k<Math.Sqrt(num);i++)
                    {
                        if(num%k==0)
                        {
                            
                        }
                        else
                        {
                            counterPrime++;
                        }
                    }
                    numsPrime.Add(counterPrime);

                }
                
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]+" ");
                    
                }
                Console.WriteLine();
            }
            
            Console.WriteLine(string.Join(' ',numsPrime));



        }
    }
}
