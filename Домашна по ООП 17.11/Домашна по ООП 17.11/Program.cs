// See https://aka.ms/new-console-template for more information
using Домашна_по_ООП_17._11;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

int n = int.Parse(Console.ReadLine());
List<Products> Product1 = new List<Products>(n);
for(int i=0;i<n;i++)
{
    List<string> productInf = Console.ReadLine().Split(' ').ToList();
    Product1.Add(new Products(productInf[0], productInf[1], Convert.ToDouble(productInf[2])));

}
double discount = double.Parse(Console.ReadLine());
for(int i=0;i<=n-1;i++)
{
    Console.WriteLine($"The price of the {Product1[i].Name} is {Product1[i].Discount(discount):f2} lv.");
}


