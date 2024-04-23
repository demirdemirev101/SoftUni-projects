using _2._Villain_Names;
using System.Data.SqlClient;

namespace _4._Add_Minions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] minionInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToArray();
            string minionName = minionInput[0];
            int minionAge = int.Parse(minionInput[1]);
            string townName = minionInput[2];
            string[] villainInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToArray();
            string villainName = villainInput[0];

            using SqlConnection connection = new SqlConnection(SqlQueries._connection);
            connection.Open();

            int townId = addTown(townName, connection);
            int minionId = AddMinion(minionName, minionAge, connection, townId);
            int villainId = AddVillain(villainName, connection);

            using SqlCommand addMinionsAndVillainsCMD = new SqlCommand(Queries._addMinionAndVillain, connection);
            addMinionsAndVillainsCMD.Parameters.AddWithValue("@minionId", minionId);
            addMinionsAndVillainsCMD.Parameters.AddWithValue("@villainId", villainId);
            addMinionsAndVillainsCMD.ExecuteNonQuery();

            Console.WriteLine($"Successfully added {minionName} to be minion of {villainName}.");
        }

        private static int AddMinion(string minionName, int minionAge, SqlConnection connection, int townId)
        {
            int minionId = 0;
            SqlCommand minionsCMD = new SqlCommand(Queries._minionName, connection);
            minionsCMD.Parameters.AddWithValue("@Name", minionName);
            var reader = minionsCMD.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                using SqlCommand addMinion = new SqlCommand(Queries._addMinion, connection);
                addMinion.Parameters.AddWithValue("@name", minionName);
                addMinion.Parameters.AddWithValue("@age", minionAge);
                addMinion.Parameters.AddWithValue("@townId", townId);

                addMinion.ExecuteNonQuery();

            }
            else
            {
                while (reader.Read())
                {
                    minionId = int.Parse(reader["Id"].ToString());
                }
                reader.Close();
            }

            return minionId;
        }
        private static int addTown(string townName, SqlConnection connection)
        {
             int townId = 0;
            SqlCommand townsCMD = new SqlCommand(Queries._townName, connection);
            townsCMD.Parameters.AddWithValue("@townName", townName);
            var reader = townsCMD.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                using SqlCommand addTownCMD = new SqlCommand(Queries._addTown, connection);
                addTownCMD.Parameters.AddWithValue("@townName", townName);
                addTownCMD.ExecuteNonQuery();

                Console.WriteLine($"Town {townName} was added to the database.");
            }
            else
            {
                while (reader.Read())
                {
                    townId = int.Parse(reader["Id"].ToString());
                }
                reader.Close();
            }
            return townId;

        }

        private static int AddVillain(string villainName, SqlConnection connection)
        {
            int villainId = 0;
            SqlCommand villainCMD = new SqlCommand(Queries._villainName, connection);
            villainCMD.Parameters.AddWithValue("@Name", villainName);
            var reader = villainCMD.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                using SqlCommand addVillainCMD = new SqlCommand(Queries._addVillain, connection);

                addVillainCMD.Parameters.AddWithValue("@villainName", villainName);
                addVillainCMD.ExecuteNonQuery();
                
                Console.WriteLine($"Villain {villainName} was added to the database.");
            }
            else
            {
                while (reader.Read())
                {
                    villainId = int.Parse(reader["Id"].ToString());
                }
                reader.Close();
            }
            return villainId;
        }
    }
}