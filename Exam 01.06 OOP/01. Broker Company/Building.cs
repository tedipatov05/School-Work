using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Broker_Company
{
    internal class Building
    {
        private string name;
        private string city;
        private int stars;
        private double rentAmount;
        private bool isAvaliable;

        public string Name
        {
            get { return name; }
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException("The name mustn't be null or empty");
                }
                this.name = value;
            }
        }
        public string City
        {
            get { return city; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("The city mustn't be null or empty");
                }
                this.city = value;

            }
        }
        public int Stars
        {
            get { return stars; }
            set
            {
                if(value < 0 || value>5 )
                {
                    throw new ArgumentOutOfRangeException("The stars cannot be less than 0 or above 5");
                }
                this.stars = value;
            }
        }
        public double RentAmount
        {
            get { return rentAmount; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The rent cannot be less or equal to 0");
                }
                this.rentAmount = value;
            }
        }
        public bool IsAvaliable { get { return isAvaliable; } set { this.isAvaliable = value; } }
        public Building(string _name, string _city, int _stars, double _rentAmount)
        {
            Name = _name;
            City = _city;
            Stars = _stars;
            RentAmount = _rentAmount;
        }
        public void Rent()
        {
            isAvaliable = true;
        }
        public override string ToString()
        {
            string stars = string.Empty;
            for(int i = 0; i < Stars; i++)
            {
                stars += "*";
            }
            return $"{stars}Building: {Name}; Location: {City}; RentAmount: {RentAmount}, IsAvailable: {IsAvaliable}  "; 
        }


    }

}
