using System.Data.SqlClient;

namespace _4._Add_Minion
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Read data from the console
            string[] minionInput = Console.ReadLine().Split(" ");
            string minionName = minionInput[1];
            int minionAge = int.Parse(minionInput[2]);
            string townName= minionInput[3];

            string villainName=Console.ReadLine().Split(" ")[1];

            //Establishing connection
            const string connectionString = @"Server=DESKTOP-LNN960H\SQLEXPRESS; Database=MinionsDB;Integrated Security=True";
            using SqlConnection connection=new SqlConnection(connectionString);
            connection.Open();

            //Villain Id
            using SqlCommand villainCommand = new SqlCommand(@"SELECT Id FROM Villains WHERE Name = @Name", connection);
            villainCommand.Parameters.AddWithValue("@Name",villainName);
            var villainId = (int)(await villainCommand.ExecuteScalarAsync());

            //Minion Id
            using SqlCommand minionCommand = new SqlCommand(@"SELECT Id FROM Minions WHERE Name = @Name", connection);
            minionCommand.Parameters.AddWithValue("@Name", minionName);
            var minionId = (int)(await minionCommand.ExecuteScalarAsync());

            //Insert into villains
            using SqlCommand insertVillainsCommand = new SqlCommand(@"INSERT INTO Villains (Name, EvilnessFactorId) values(@name, @factor)", connection);

            insertVillainsCommand.Parameters.AddWithValue("@name", villainName);
            insertVillainsCommand.Parameters.AddWithValue("@factor", 4);
            var result = await insertVillainsCommand.ExecuteNonQueryAsync();

            //Insert into Towns
            using SqlCommand insertTownsCommand = new SqlCommand(@"insert into Towns(Name, CountryCode) 
                                                                            values (@name, @countryCode)", connection);
            insertTownsCommand.Parameters.AddWithValue("@name", townName);
            insertTownsCommand.Parameters.AddWithValue("@countryCode", 4);


            //Insert into Minions
            using SqlCommand insertMinionsCommand = new SqlCommand(@"INSERT INTO Minions (Name, Age, TownId) 
                                                                        VALUES (@name, @age, @townId)", connection);
            

            insertMinionsCommand.Parameters.AddWithValue("@name", minionName);
            insertMinionsCommand.Parameters.AddWithValue("@age", minionAge);
            //insertMinionsCommand.Parameters.AddWithValue("@townId", townId);
            insertMinionsCommand.ExecuteNonQuery();
           
        }
    }
}