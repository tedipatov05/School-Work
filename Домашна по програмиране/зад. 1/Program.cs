// See https://aka.ms/new-console-template for more information

using System.Text;

StringBuilder output = new StringBuilder();
string input = Console.ReadLine();
for(int i=0;i<input.Length;i++)
{
    if (char.IsUpper(input[i]))
    {
        output.Append(input[i]);
        
    }
}
Console.WriteLine(output);
