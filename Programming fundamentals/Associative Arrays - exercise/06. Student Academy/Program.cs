using System;
using System.Collections.Generic;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Dictionary<string, double> averageGrades = new Dictionary<string, double>();
            int numberOfStudents=int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfStudents; i++)
            {
                string studentName = Console.ReadLine();
                double gradeOfStudent=double.Parse(Console.ReadLine());
                if (!averageGrades.ContainsKey(studentName))
                {
                    averageGrades.Add(studentName,gradeOfStudent);
                }
                else
                {
                    averageGrades[studentName] += gradeOfStudent;
                    averageGrades[studentName] /= 2;
                }

            }
            foreach (var item in averageGrades)
            {
                if (item.Value>=4.50)
                {
                    Console.WriteLine($"{item.Key} -> { item.Value:f2}");
                }
            }
        }
    }
}
