using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numVagons = int.Parse(Console.ReadLine());
            int[] numPeople = new int[numVagons];
            int sum = 0;
            for (int i = 0; i < numPeople.Length; i++)
            {

                numPeople[i] = int.Parse(Console.ReadLine());
                sum += numPeople[i];
            }
            Console.WriteLine(String.Join(" ", numPeople));
            Console.WriteLine(sum);

        }
    }
}
