using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem.models
{
    internal class Student : Person , IsGarding
    {
        public int Score;

        public Student(string name, int age, int score) : base(name, age)
        {
            Score = score;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Score: {Score}, Grade: {GetGrade()}");
        }

        public string GetGrade()
        {
            if (Score >= 90) return "A";
            else if (Score >= 80) return "B";
            else if (Score >= 70) return "C";
            else if (Score >= 60) return "D";
            else return "F";
        }
    }
}
