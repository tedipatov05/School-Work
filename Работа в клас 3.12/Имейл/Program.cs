// See https://aka.ms/new-console-template for more information
static int SumLetters(string str)
{
    int sum = 0;
    for(int i=0;i<=str.Length;i++)
    {
        sum += (int)str[i];
    }
    return sum;
}
string email = Console.ReadLine();
string[] words = email.Split('@');
if(SumLetters(words[0])>=SumLetters(words[1]))
{
    Console.WriteLine("Call her!");
}
else
{
    Console.WriteLine("She is not the one.");
}