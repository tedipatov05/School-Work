// See https://aka.ms/new-console-template for more information

using Първи_и_резервен_отбор;

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    List<string> input = Console.ReadLine()
        .Split(' ')
        .ToList();

    Person person1 = new Person(input[0],input[1], Convert.ToInt32(input[2]), Convert.ToDouble(input[3]));
    Team team = new Team(input[0] + input[1]);
    team.Output(person1);
}
