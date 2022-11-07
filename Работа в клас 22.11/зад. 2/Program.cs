// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());
Random num = new Random();
Stack<int> stack = new Stack<int>();
for(int i=0;i<n;i++)
{
    int number = num.Next(1, 100);
    stack.Push(number);
}

