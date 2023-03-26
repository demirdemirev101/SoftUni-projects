namespace FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private static List<Team> teams;
        static void Main()
        {
            teams = new List<Team>();
           
                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                
                    string[] arguments = command.Split(';');
                    string action = arguments[0];
                    string teamName = arguments[1];
                try
                {
                    switch (action)
                    {
                        case "Team":
                            CreateTeam(teamName);
                            break;
                        case "Add":
                            AddPlayer(arguments, teamName);
                            break;
                        case "Remove":
                            Remove(arguments, teamName);
                            break;
                        case "Rating":
                            RateTeam(teamName);
                            break;
                    }
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                catch (InvalidOperationException inv)
                {
                    Console.WriteLine(inv.Message);
                }

                }
        }

        public static void RateTeam(string teamName)
        {
            Team teamToRate = teams.FirstOrDefault(t => t.Name == teamName);
            if (teamToRate == null)
            {
                throw new InvalidOperationException($"Team {teamName} does not exist.");
            }
            Console.WriteLine(teamToRate.ToString());
        }

        public static void CreateTeam(string teamName)
        {
            Team newTeam = new Team(teamName);
            teams.Add(newTeam);
        }

        public static void Remove(string[] arguments, string teamName)
        {
            Team removingTeam = teams.FirstOrDefault(t => t.Name == teamName);
            if (removingTeam == null)
            {
                throw new InvalidOperationException($"Team {teamName} does not exist.");
            }
            string playerName = arguments[2];
            removingTeam.RemovePlayer(playerName);
        }

        public static void AddPlayer(string[] arguments, string teamName)
        {
            Team joiningTeam = teams.FirstOrDefault(t => t.Name == teamName);
            if (joiningTeam == null)
            {
                throw new InvalidOperationException($"Team {teamName} does not exist.");
            }
            string playerName = arguments[2];
            int endurance = int.Parse(arguments[3]);
            int sprint = int.Parse(arguments[4]);
            int dribble = int.Parse(arguments[5]);
            int passing = int.Parse(arguments[6]);
            int shooting = int.Parse(arguments[7]);

            Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

            joiningTeam.AddPlayer(player);
        }
    }
}
