﻿using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int characters = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < characters; i++)
            {

                char character = char.Parse(Console.ReadLine());
                sum += (int)character;


            }
            Console.WriteLine($"The sum equals: {sum}");


        }
    }
}
