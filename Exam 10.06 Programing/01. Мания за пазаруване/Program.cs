using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Мания_за_пазаруване
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<double>> shop = new Dictionary<string, List<double>>();     

            while(command != "STOP SHOPPING")
            {
                string[] cmdArgs = command.Split('-');  
                string product = cmdArgs[0];
                double price = double.Parse(cmdArgs[1]);
                if(!shop.ContainsKey(product))
                {
                    shop.Add(product, new List<double>() { price});
                }
                else
                {
                    shop[product].Add(price);
                }
                command = Console.ReadLine();
            }
            shop = shop.OrderByDescending(x=>x.Value.Sum()).ToDictionary(x => x.Key, x => x.Value);
            double total = 0;
            foreach(var item in shop)
            {
                total += item.Value.Sum(); 
                Console.WriteLine($"{item.Key} -> {item.Value.Sum():f2}");
            }
            Console.WriteLine($"Toatl sum: {total}");

           
        }
    }
}
