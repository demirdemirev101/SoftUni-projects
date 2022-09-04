using System;
using System.Text;
namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
      string[] file = Console.ReadLine()
                .Split('\\','.');

            
            StringBuilder fileName = new StringBuilder();
            StringBuilder fileExtension = new StringBuilder();
            
           fileName.Append(file[file.Length-2]);
           fileExtension.Append(file[file.Length-1]); 

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
