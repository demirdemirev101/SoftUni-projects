using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            int n=int.Parse(Console.ReadLine());

            Func<List<int>, List<int>> remove = numbers =>
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i]%n==0)
                    {
                        numbers.RemoveAt(i);
                    i -=1;
                    }
                }
                return numbers;
            };
            Func<List<int>, List<int>> reverse = numbers =>
            {
                int temp = int.MinValue;
                for (int j = 0; j < numbers.Count/2; j++)
                {
                   temp = numbers[j];
                    numbers[j] = numbers[numbers.Count-j - 1];
                    numbers[numbers.Count-j - 1] = temp;
                }

                return numbers;
            };
            numbers = remove(numbers);
             numbers=reverse(numbers);
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
