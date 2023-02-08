using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Broker_Company
{
    internal class Broker
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }    
        public List<Building> buildings { get; set; }
        public Broker(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
            buildings = new List<Building>();
        }
        public void AddBuilding(Building building)
        {
            buildings.Add(building);
        }
        public double RecieveBonus()
        {
            return buildings.Sum(x => (x.RentAmount * 2 * x.Stars) / 1000);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"Broker:{Name} {Age} {City} -> Bonus:{RecieveBonus()}");
            sb.AppendLine();
            foreach (var building in buildings)
            {
                sb.AppendLine(building.ToString());
            }
            return sb.ToString();
            
               
        }

    }
}
