using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Inheritance
{
    public  class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void GetName()
        {
            Console.WriteLine($"I am {Name}");
        }
    }
}
