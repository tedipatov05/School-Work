// See https://aka.ms/new-console-template for more information
static List<int> Indexes(int[] numbers,int number)
{
    List<int> list = new List<int>();
    for(int i=0;i<numbers.Length;i++)
    {
        if(number==numbers[i])
        {
            list.Add(i);
        }
    }
    return list;
}
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int num = int.Parse(Console.ReadLine());
List<int> indexes = Indexes(numbers, num);
Console.WriteLine(String.Join(",",indexes));
