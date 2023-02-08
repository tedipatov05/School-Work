using System;
using System.Linq;
using System.Collections.Generic;


namespace _02._Специални_думи
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            List<string> special = new List<string>();
            List<string> other = new List<string>();
            for(int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                if(word.Contains('e') && word.Length>5 && word[0] != word[word.Length-1])
                {
                    special.Add(word);
                }
                else
                {
                    other.Add(word);
                }
            }
            Console.WriteLine($"Special words: {string.Join(',',special)}");
            Console.WriteLine($"Other words: {string.Join(',', other)}");

        }
    }
}
