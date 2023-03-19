using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<double>> shop = new Dictionary<string, List<double>>();
            while(input != "stocked")
            {
                string[] inpArgs = input.Split();
                string product = inpArgs[0];
                double price = double.Parse(inpArgs[1]);
                double quantity = double.Parse(inpArgs[2]);
                if (!shop.ContainsKey(product))
                {
                    shop.Add(product, new List<double>{price, quantity});
                }
                else
                {
                    shop[product] = new List<double>{price, quantity};
                }
                input = Console.ReadLine();
            }
            double total = 0;
            foreach(var sh in shop)
            {
                Console.WriteLine($"{sh.Key}: ${sh.Value[0]:f2} * {(int)sh.Value[1]} = ${(sh.Value[0]* sh.Value[1]):f2}");
                total += sh.Value[0] * sh.Value[1];
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${total:F2}");
        }
    }
}
