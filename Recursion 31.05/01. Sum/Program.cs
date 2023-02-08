using System;

namespace _01._Sum
{
    internal class Program
    {
        static int Sum(int num)
        {
            int sum = (num * (num - 1));
            if(num == 1)
            {
                return 0;
            }
            else
            {
              return Sum(num-1)+sum;
                
            }

            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(6));
        }
    }
}
