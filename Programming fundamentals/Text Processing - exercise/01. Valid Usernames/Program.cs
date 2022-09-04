using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            List<string> outPutUserNames = new List<string>();
            
            foreach(string username in userNames)
            {
                bool isValid = true;
                if (username.Length >= 3 && username.Length <= 16)
                    {
                    char[] currentChar = username.ToCharArray();
                    for (int i = 0; i < currentChar.Length; i++)
                    {
                        if (!(currentChar[i] == '-' || currentChar[i] == '_' || char.IsLetterOrDigit(currentChar[i])))
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                     outPutUserNames.Add(username);

                    }
                    }
            }
            // Console.WriteLine(string.Join(Environment.NewLine, outPutUserNames));
            Console.WriteLine(string.Join(Environment.NewLine, outPutUserNames));
        }
    }
}
