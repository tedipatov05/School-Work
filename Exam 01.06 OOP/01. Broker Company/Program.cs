using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Broker_Company
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Building> list = new List<Building>(); 

            while(command != "EndBuildings")
            {
                string[] cmdArgs = command.Split(' ');
                string name = cmdArgs[1];
                string city = cmdArgs[2];  
                int stars = int.Parse(cmdArgs[3]);
                double rentAmount = double.Parse(cmdArgs[4]);

                if(cmdArgs[0] == "RegisterBuilding")
                {
                    Building building = new Building(name, city, stars, rentAmount);
                    list.Add(building);
                }

                command = Console.ReadLine();
            }

            List<string> brokers = Console.ReadLine().Split(' ').ToList();

            string nameB = brokers[1];
            int ageB = int.Parse(brokers[2]);
            string cityB = brokers[3];

            Broker broker = new Broker(nameB, ageB, cityB);
            List<int> nums = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();  
            
            foreach(int num in nums)
            {
               broker.buildings.Add(list[num - 1]);
                list[num - 1].Rent(); 
            }

            Console.WriteLine(broker.ToString());
            

        }
    }
}
