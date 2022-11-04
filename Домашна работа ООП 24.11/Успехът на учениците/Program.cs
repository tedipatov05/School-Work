// See https://aka.ms/new-console-template for more information

using Успехът_на_учениците;

int n = int.Parse(Console.ReadLine());
List<Students> Student1 = new List<Students>();
for(int i=0;i<n;i++)
{
    List<string> studentsInf = Console.ReadLine().Split(' ').ToList();
    studentsInf.RemoveRange(0, 2);
    List<int> grades = studentsInf.Select(int.Parse).ToList();
    Students student = new Students(studentsInf[0], studentsInf[1], grades);
}
for(int i=0;i<n;i++)
{
    Console.WriteLine($"{Student1[i].FirstName} {Student1[i].SecondName} -> {Student1[i].Average:f2}");
}
