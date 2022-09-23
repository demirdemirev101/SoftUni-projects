using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            
            Stack<string> memory = new Stack<string>();
            StringBuilder text = new StringBuilder();
          
            memory.Push(string.Empty);
            for (int i = 0; i < numberOfOperations; i++)
            {
                string command = Console.ReadLine();
                string[] tokens=command.Split(' ');
                string action=tokens[0];

                switch (action)
                {
                    case"1":
                        string token = tokens[1];
                        text.Append(token);
                        memory.Push(text.ToString());
                        break;
                        
                    case"2":
                        
                        int count=int.Parse(tokens[1]);
                            text=text.Remove(text.Length-count,count);
                      
                        memory.Push(text.ToString());
                        
                        break;
                    
                    case"3":
                        int index=int.Parse(tokens[1]);
                        if (index>=0&&index<=text.Length)
                        {
                            Console.WriteLine(text[index-1]);
                                
                        }
                        
                        break;
                     
                    case"4":

                        memory.Pop();
                        string previousVersion = string.Join("",memory.Peek());

                       text = new StringBuilder(previousVersion);

                        break;
                }

            }
        }
    }
}
