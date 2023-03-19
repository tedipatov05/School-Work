using System;
using System.Collections.Generic;

namespace _03._Miner_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputMetal = Console.ReadLine();
            Dictionary<string,int> metals = new Dictionary<string,int>();
            while(inputMetal != "stop")
            {
                int value = int.Parse(Console.ReadLine());
                if(value > 0)
                {
                    if(metals.ContainsKey(inputMetal))
                    {
                        metals.Add(inputMetal,value);
                    }
                    else
                    {
                        metals[inputMetal] = value;
                    }
                }
                inputMetal = Console.ReadLine();
            }
            foreach(var metal in metals)
            {
                Console.WriteLine($"{metal.Key} -> {metal.Value}");
            }

        }
    }
}
