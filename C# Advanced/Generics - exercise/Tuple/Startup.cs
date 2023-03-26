using System;

namespace Tuple
{
    public class Startup
    {
        static void Main(string[] args)
        {
            string[] nameAndAddress = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            CustomTuple<string, string, string> customTuple1 = new CustomTuple<string, string, string>();
            customTuple1.Item1 = nameAndAddress[0] + " " + nameAndAddress[1];
            customTuple1.Item2 = nameAndAddress[2];
            if (nameAndAddress.Length == 5)
            {
                customTuple1.Item3 = nameAndAddress[3] + " " + nameAndAddress[4];

            }
            else if (nameAndAddress.Length == 4)
            {
                customTuple1.Item3 = nameAndAddress[3];
            }
            Console.WriteLine(customTuple1.ToString());

            string[] personAndBeerAmount = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            CustomTuple<string, int, bool> customTuple2 = new CustomTuple<string, int, bool>();
            customTuple2.Item1 = personAndBeerAmount[0];
            customTuple2.Item2 = int.Parse(personAndBeerAmount[1]);
            customTuple2.Item3 = IsDrunk(personAndBeerAmount);
            Console.WriteLine(customTuple2.ToString());

            string[] integerAndDouble = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            CustomTuple<string, double, string> customTuple3 = new CustomTuple<string, double, string>();
            customTuple3.Item1 = integerAndDouble[0];
            customTuple3.Item2 = double.Parse(integerAndDouble[1]);
            customTuple3.Item3 = integerAndDouble[2];
            Console.WriteLine(customTuple3.ToString());
        }

        private static bool IsDrunk(string[] personAndBeerAmount)
        {
            return personAndBeerAmount[2] == "drunk";
        }
    }
}