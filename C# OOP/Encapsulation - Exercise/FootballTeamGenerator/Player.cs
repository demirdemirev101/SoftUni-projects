namespace FootballTeamGenerator
{
    using System;
    public class Player
    {
        private string name;
        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Stats=new Stats(endurance,sprint, dribble, passing, shooting);
        }
        public string Name 
        { 
            get=>this.name;
            private set 
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("A name should not be empty.");
                this.name = value;
            } 
        }
        public Stats Stats { get; private set; }
        public double OverallRating => (Stats.Passing + Stats.Shooting + Stats.Sprint + Stats.Dribble + Stats.Endurance)/5.0;
    }
}
