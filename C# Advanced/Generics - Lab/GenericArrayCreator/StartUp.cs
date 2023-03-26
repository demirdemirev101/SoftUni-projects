using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] numbers = ArrayCreator.Create(3, 123);

            string[] names = ArrayCreator.Create(3, "Demir");

            Console.WriteLine(string.Join(", ",numbers));

            Console.WriteLine(string.Join(", ",names));
        }
    }
}
