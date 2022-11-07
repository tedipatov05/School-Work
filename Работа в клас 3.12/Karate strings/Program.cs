// See https://aka.ms/new-console-template for more information

using System.Text;

string karate = Console.ReadLine();
StringBuilder output = new StringBuilder();
int lengthR = 0;
for(int i=0;i<karate.Length;i++)
{
    if(karate[i]=='>')
    {
        lengthR = int.Parse(karate[i + 1].ToString());
    }
}
