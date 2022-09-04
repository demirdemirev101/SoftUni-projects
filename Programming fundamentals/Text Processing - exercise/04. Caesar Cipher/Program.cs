using System;
using System.Linq;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            
                
                for (int i = 0; i < sentence.Length; i++)
                {
                    char c = sentence[i];
                    c+= (char)3;
                    
                Console.Write(c.ToString());
                }
            
            

        }
    }
}
