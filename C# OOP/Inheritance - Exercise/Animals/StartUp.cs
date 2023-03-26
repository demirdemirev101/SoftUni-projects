using System;
using System.Text;

namespace Animals
{
    public class StartUp
    {
        static void Main()
        {
            StringBuilder result = new StringBuilder();

            string command=Console.ReadLine();
            while (command!="Beast!")
            {
                 string[] tokens=Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries);

                string name=tokens[0];
                int age = int.Parse(tokens[1]);
                string gender=string.Empty;
                if (tokens.Length>2)
                {
                    gender = tokens[2];
                }

                switch (command)
                {
                    case "Cat":
                        Cat cat = new Cat(name,age,gender);
                        result.AppendLine(cat.ToString());
                        break;
                    case "Dog":
                        Dog dog = new Dog(name, age, gender);
                        result.AppendLine(dog.ToString());
                        break;
                    case "Frog":
                        Frog frog = new Frog(name, age, gender);
                        result.AppendLine(frog.ToString());
                        break;
                    case "Kitten":
                        Kitten kitten = new Kitten(name,age);
                        result.AppendLine(kitten.ToString());
                        break;
                    case "Tomcat":
                        Tomcat tomcat = new Tomcat(name,age);
                        result.AppendLine(tomcat.ToString());
                        break;
                        default:
                        throw new Exception("Invalid operation!");
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(result.ToString());

        }
    }
}
