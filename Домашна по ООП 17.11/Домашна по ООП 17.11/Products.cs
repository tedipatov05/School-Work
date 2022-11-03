using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашна_по_ООП_17._11
{
    internal class Products
    {
        private string type;
        private string name;
        private double price;

        public Products(string _type, string _name, double _price)
        {
            Type = _type;
            Name = _name;
            Price = _price;
           
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public double Discount(double discount)
        {
           
            if(Type=="food")
            {
                Price -= Price * discount / 100;
            }
            return Price;
        }
        
    }
}
