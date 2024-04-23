using _2._Villain_Names;
using System.Data.SqlClient;

namespace _5._Change_Town_Names_Casing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();

            using SqlConnection connection = new SqlConnection(SqlQueries._connection);
            connection.Open();

            using SqlCommand changeNamesCMD = new SqlCommand(SqlQueries._updateTownsByCountryName, connection);
            changeNamesCMD.Parameters.AddWithValue("@countryName", countryName);
            int changedRows = changeNamesCMD.ExecuteNonQuery();
            if (changedRows == 0)
            {
                ErrorMessage();
                connection.Close();
                return;
            }
            Console.WriteLine($"{changedRows} town names were affected.");

            using SqlCommand showupdatedTownsCMD = new SqlCommand(SqlQueries._showUpperCasedTowns, connection);
            showupdatedTownsCMD.Parameters.AddWithValue("@countryName", countryName);
            using SqlDataReader reader = showupdatedTownsCMD.ExecuteReader();
            var towns = new List<string>();
            while (reader.Read())
            {
                towns.Add(reader["Name"].ToString());
            }
            Console.WriteLine($"[{string.Join(", ", towns)}]");


        }

        private static void ErrorMessage()
        {
            Console.WriteLine("No town names were affected.");
        }
    }
}