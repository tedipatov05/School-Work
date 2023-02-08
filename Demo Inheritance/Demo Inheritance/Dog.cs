using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Inheritance
{
    public  class Dog : Animal
    {
        public string Breed { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public Dog(string name, int age, string breed, int height, int weight)
            : base(name,age)
        {
            Breed = breed;
            Height = height;
            Weight = weight;

        } 
        public string SayHello()
        {
            return $"Hello, I am {base.Name}";
        }
    }
}
