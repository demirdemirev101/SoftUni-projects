using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeVariables = Console.ReadLine();
            if (typeVariables == "int")
            {
                int intVariable1 = int.Parse(Console.ReadLine());
                int intVariable2 = int.Parse(Console.ReadLine());

                int result = GetMax(intVariable1, intVariable2);
                Console.WriteLine(result);
            }
            else if (typeVariables == "char")
            {
                char charVariable1 = char.Parse(Console.ReadLine());
                char charVariable2 = char.Parse(Console.ReadLine());

                char result = GetMax(charVariable1, charVariable2);
                Console.WriteLine(result);
            }
            else if (typeVariables == "string")
            {
                string stringVariable1 = Console.ReadLine();
                string stringVariable2 = Console.ReadLine();

                string result = GetMax(stringVariable1, stringVariable2);
                Console.WriteLine(result);
            }
        }
        static int GetMax(int intVariable1, int intVariable2)
        {
            if (intVariable1 > intVariable2)
            {
                return intVariable1;
            }
            else
            {
                return intVariable2;
            }
        }
        static char GetMax(char charVariable1, char charVariable2)
        {
            if (charVariable1 > charVariable2)
            {
                return charVariable1;
            }
            else
            {
                return charVariable2;
            }
        }
        static string GetMax(string stringVariable1, string stringVariable2)
        {
            int result = 0;
            result = stringVariable1.CompareTo(stringVariable2);
            if (result > 0)
            {
                return stringVariable1;
            }
            else
            {
                return stringVariable2;

            }
        }
    }
}
