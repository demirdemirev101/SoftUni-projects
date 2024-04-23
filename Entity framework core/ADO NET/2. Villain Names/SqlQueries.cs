using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._Villain_Names
{
    public class SqlQueries
    {
        public const string _connection = @"Server=DESKTOP-LNN960H\SQLEXPRESS; Database=MinionsDB;Integrated Security=True";

        public const string _villainNames = @"SELECT v.Name, COUNT(mv.VillainId) AS MinionsCount  
            FROM Villains AS v 
            JOIN MinionsVillains AS mv ON v.Id = mv.VillainId 
        GROUP BY v.Id, v.Name 
          HAVING COUNT(mv.VillainId) > 3 
        ORDER BY COUNT(mv.VillainId)";

        public const string _villainName = @"SELECT Name FROM Villains WHERE Id = @Id";

        public const string _minionsByVillainId = @"SELECT ROW_NUMBER() OVER (ORDER BY m.Name) AS RowNum,
                m.Name, 
                m.Age
        FROM MinionsVillains AS mv
        JOIN Minions As m ON mv.MinionId = m.Id
        WHERE mv.VillainId = @Id
        ORDER BY m.Name";

            public const string _updateTownsByCountryName = @"UPDATE Towns
       SET Name = UPPER(Name)
     WHERE CountryCode = (SELECT c.Id FROM Countries AS c WHERE c.Name = @countryName)";

            public const string _showUpperCasedTowns = @"SELECT t.Name 
       FROM Towns as t
       JOIN Countries AS c ON c.Id = t.CountryCode
      WHERE c.Name = @countryName";

        public const string _deleteFromMinionsVillains = @"DELETE FROM MinionsVillains 
      WHERE VillainId = @villainId";

        public const string _deleteVillain = @"DELETE FROM Villains
      WHERE Id = @villainId";

        public const string _minionNames = @"SELECT Name FROM Minions";

            public const string _updateNamesAndAgesOfMinions = @" UPDATE Minions
       SET Name = LOWER(LEFT(Name, 1)) + SUBSTRING(Name, 2, LEN(Name)), Age += 1
     WHERE Id = @Id";
        public const string _selectMinionNamesAndAges = @"SELECT Name, Age FROM Minions";
        public const string _OlderProc = @"usp_GetOlder";

        public const string _minionsNameaAndAgesById = @"SELECT Name, Age FROM Minions WHERE Id = @Id";
    }
}
