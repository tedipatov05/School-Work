using System;
using System.Collections.Generic;
using System.Linq;

namespace Многомерен_масив_11._02._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            bool isWinning = false;
            int sumUpMainD = 0;
            int sumDownMainD = 0;
            int sumMainD = 0;
            for(int i = 0; i<n;i++)
            {
                List<int> input = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToList();
                
                    for (int k = 0; k < n; k++)
                    {
                        matrix[i, k] = input[k];
                    }
                
            }
            
            int sumEvenMainD = 0;
            for(int i=0;i<n;i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(i==j)
                    {
                        sumMainD += matrix[i, j];
                        if (matrix[i,j] % 2 == 0)
                        {
                            
                            sumEvenMainD += matrix[i, j];
                        }
                        
                        
                    }
                    else if(i<j)
                    {
                        sumUpMainD += matrix[i, j];
                    }
                    else if(i>j)
                    {
                        sumDownMainD += matrix[i, j];
                        
                    }
                }
            }
            int sumSecondD = 0;
            for(int i=0;i<n;i++)
            {
                sumSecondD += matrix[i, n - i - 1];
            }
            if(sumMainD==sumSecondD && sumUpMainD%2==0 && sumDownMainD%2!=0)
            {
                isWinning = true;
            }

            int sumOutRows = 0;
            int sumOutCols = 0;
            if(isWinning)
            {
                for(int i=0;i<n;i++)
                {
                    if(matrix[0,i]%2==0)
                    {
                        sumOutRows += matrix[0, i];
                        
                    }
                    if(matrix[n-1,i]%2==0)
                    {
                        sumOutRows += matrix[n - 1, i];
                        
                    }
                    if (matrix[i,0] % 2 == 1)
                    {
                        sumOutCols += matrix[i,0];
                        
                    }
                    if (matrix[i,n-1] % 2 == 1)
                    {
                        sumOutCols += matrix[i,n-1];
                        
                    }
                }
                double sumWinning = (sumEvenMainD + sumDownMainD + sumOutCols + sumOutRows)/4;
                Console.WriteLine("Yes");
                Console.WriteLine($"The amount of money won is: {sumWinning:f2}");

            }
            else
            {
                Console.WriteLine("NO");
            }
               
        }
    }
}
