// See https://aka.ms/new-console-template for more information



int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i<n;i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
List<int> elements = new List<int>();
List<int> counts = new List<int>();
for (int i = 0; i < arr.Length; i++)
{
    if (!elements.Contains(arr[i]))
    {
        elements.Add(arr[i]);
    }
}
for (int i = 0; i < elements.Count; i++)
{

    int br = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (elements[i] == arr[j])
        {
            br++;
        }
        

    }
    counts.Add(br);

}
for (int i = 0; i < elements.Count; i++)
{
    Console.WriteLine($"{elements[i]} -> {counts[i]}");
}


