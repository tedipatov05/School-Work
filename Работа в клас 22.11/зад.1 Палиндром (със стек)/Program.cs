// See https://aka.ms/new-console-template for more information

string input = Console.ReadLine();
Stack<char> stack = new Stack<char>();
foreach (char element in input)
{
    stack.Push(element);
}
bool isPalindrom = true;
foreach(char element in input)
{
    if(element != stack.Pop())
    {
        isPalindrom = false;
    }
}
if(isPalindrom)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}