using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Add_Minions
{
    public class Queries
    {
        public const string _townName = @"SELECT Id FROM Towns WHERE Name = @townName";
        public const string _addTown = @"INSERT INTO Towns (Name) VALUES (@townName)";
        public const string _villainName = @"SELECT Id FROM Villains WHERE [Name] = @Name";
        public const string _addVillain = @"INSERT INTO Villains (Name, EvilnessFactorId)  VALUES (@villainName, 4)";
        public const string _minionName = @"SELECT Id FROM Minions WHERE [Name] = @Name";
        public const string _addMinion = @"INSERT INTO Minions (Name, Age, TownId) VALUES (@name, @age, @townId)";
        public const string _addMinionAndVillain = @"INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (@minionId, @villainId)";
    }
}
