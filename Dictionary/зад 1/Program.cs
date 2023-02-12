using System;
using System.Linq;

namespace зад_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] hours = Console.ReadLine().Split(" ");
            Console.WriteLine(string.Join(", ",hours)
                .OrderBy(x => x)
                .ToArray());
        }
    }
}
