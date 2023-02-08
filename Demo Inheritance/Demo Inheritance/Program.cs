using System;

namespace Demo_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Shiikov", 12, "Cat", 176, 72);
            dog.GetName();
            Console.WriteLine(dog.SayHello());
            
        }
    }
}
