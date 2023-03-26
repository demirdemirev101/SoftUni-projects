namespace FootballTeamGenerator
{
    using System;
	using System.Collections.Generic;
	using System.Linq;

	public class Team
    {
		private string name;
		private List<Player> playersList;
		private Team()
		{
            playersList = new List<Player>();
        }
		public Team(string name) : this()
		{
			Name = name;
		}
		public string Name
		{
			get { return name; }
			set
			{
				if(string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException("A name should not be empty.");
				name = value; 
			}
		}
		public int Rating =>this.playersList.Count>0 ?
			(int)Math.Round(this.playersList.Average(p => p.OverallRating), 0):0;
		public void AddPlayer(Player player)
		{
            playersList.Add(player);
		}
		public void RemovePlayer(string playerName)
		{
			Player player = playersList.FirstOrDefault(p=>p.Name==playerName);

			if (player==null)
			{
				throw new InvalidOperationException($"Player {playerName} is not in {Name} team.");
			}
			playersList.Remove(player);
		}
        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
        }
    }
}
