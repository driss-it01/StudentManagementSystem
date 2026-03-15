using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem.models
{
    abstract class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void DisplayInfo();
    }
}
