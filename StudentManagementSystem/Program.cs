// See https://aka.ms/new-console-template for more information
using StudentManagementSystem.models;
using StudentManagementSystem.Utils;

List<Student> students = new List<Student>();

int n = InputHelper.ReadInt("How many students? ", 1, 100);

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"\nStudent {i + 1}:");
    string name = InputHelper.ReadString("Name: ");
    int age = InputHelper.ReadInt("Age (18-30): ", 18, 30);
    int score = InputHelper.ReadInt("Score (0-100): ", 0, 100);

    students.Add(new Student(name, age, score));
}

Console.WriteLine("\n--- Students Info ---");
int sumScore = 0;
foreach (var s in students)
{
    s.DisplayInfo();
    sumScore += s.Score;
}

double avg = (double)sumScore / students.Count;
Console.WriteLine($"\nAverage Score: {avg:F2}");
