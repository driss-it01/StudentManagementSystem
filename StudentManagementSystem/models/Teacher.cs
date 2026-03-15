using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem.models
{
    internal class Teacher : Person
    {
        public string Subject;

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Subject: {Subject}");
        }
    }
}
