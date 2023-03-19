using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Phone_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string commands = Console.ReadLine();
            var dict = new Dictionary<string, string>();    
            while(commands != "END")
            {
                string[] cmdArgs = commands.Split();
                string type = cmdArgs[0];
                string name = cmdArgs[1];
                if(type == "A")
                {
                    if(!dict.ContainsKey(name))
                    {
                        dict.Add(name, cmdArgs[2]);
                    }
                    else
                    {
                        dict[name] = cmdArgs[2];
                    }
                }
                else if(type == "S")
                {
                    if(dict.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {dict[name]}" );
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                commands = Console.ReadLine();
            }
            
        }
    }
}
