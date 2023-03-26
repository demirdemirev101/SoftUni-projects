using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> raiders = new List<BaseHero>();
            BaseHero hero;

            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            while (counter != n)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                try
                {
                    if (type == "Druid")
                    {
                        hero = new Druid(name);
                    }
                    else if (type == "Paladin")
                    {
                        hero = new Paladin(name);
                    }
                    else if (type == "Rogue")
                    {
                        hero = new Rogue(name);

                    }
                    else if (type == "Warrior")
                    {
                        hero = new Warrior(name);
                    }
                    else
                    {
                        throw new ArgumentException("Invalid hero!");
                    }

                    counter++;

                    raiders.Add(hero);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            long bossPower = long.Parse(Console.ReadLine());


            foreach (var r in raiders)
            {
                Console.WriteLine(r.CastAbility());
            }

            long allPower = raiders.Select(x => x.Power).Sum();

            if (allPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}