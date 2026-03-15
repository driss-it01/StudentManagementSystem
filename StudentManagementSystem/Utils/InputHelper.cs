using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem.Utils
{
    static class InputHelper
    {
        public static int ReadInt(string message, int min, int max)
        {
            int value;
            while (true)
            {
                try
                {
                    Console.Write(message);
                    value = int.Parse(Console.ReadLine());
                    if (value < min || value > max) throw new Exception($"Value must be between {min} and {max}");
                    return value;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }

        public static string ReadString(string message)
        {
            string value;
            while (true)
            {
                Console.Write(message);
                value = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(value)) return value;
                Console.WriteLine("Error: Input cannot be empty");
            }
        }
    }
}
