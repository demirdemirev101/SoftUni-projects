namespace BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            List<ICitizenable> citizens = new List<ICitizenable>();
            List<Rebel> rebels = new List<Rebel>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length==4)
                {
                    string name=tokens[0];
                    int age=int.Parse(tokens[1]);
                    string id=tokens[2];
                    string birthdate=tokens[3];
                    ICitizenable citizen=new Citizen(name, age, id, birthdate);
                    citizens.Add(citizen);
                }
                else if (tokens.Length == 3)
                {
                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    string group=tokens[2];
                    Rebel rebel=new Rebel(name, age, group);
                    rebels.Add(rebel);  
                }
            }

            string command;
            while ((command=Console.ReadLine())!="End")
            {
                if (citizens.Any(c=>c.Name==command))
                {
                    ICitizenable citizen = citizens.First(c => c.Name == command);
                    citizen.BuyFood();
                }
                else if (rebels.Any(r=>r.Name==command))
                {
                    Rebel rebel = rebels.First(r => r.Name == command);
                    rebel.BuyFood();
                }
            }

            int totalFood = citizens.Sum(c => c.Food) + rebels.Sum(r => r.Food);
            Console.WriteLine(totalFood);
            }
        }
    }

