using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace _1._Change_Town_Names_Casing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputCountry = Console.ReadLine().Trim();

            SqlConnection connection = new SqlConnection(@"Server=DESKTOP-LNN960H\SQLEXPRESS; Database=MinionsDB;Integrated Security=True");
            connection.Open();

            const string commandUpdate = @"
            UPDATE Towns
            SET Name = UPPER(Name)
            WHERE CountryCode = (SELECT c.Id FROM Countries AS c WHERE c.Name = @countryName)";

            SqlCommand cmdUpdate = new SqlCommand(commandUpdate, connection);
            cmdUpdate.Parameters.AddWithValue("@countryName", inputCountry);

            cmdUpdate.ExecuteNonQuery();
            if (cmdUpdate.ExecuteNonQuery() == 0)
            {
                Console.WriteLine("No town names were affected.");
                return;
            }

            const string commandSelect = @" SELECT t.Name 
                                            FROM Towns as t
                                               JOIN Countries AS c ON c.Id = t.CountryCode
                                            WHERE c.Name = @countryName";

            SqlCommand cmdSelect = new SqlCommand(commandSelect, connection);
            cmdSelect.Parameters.AddWithValue("@countryName", inputCountry);
            SqlDataReader reader = cmdSelect.ExecuteReader();
            if (reader == null)
            {
                Console.WriteLine("No town names were affected.");
            }
            List<string> townNames = new List<string>();
            while (reader.Read())
            {

                townNames.Add(reader["Name"].ToString());

            }
            Console.WriteLine($"{townNames.Count} town names were affected.");
            Console.Write("[");
            Console.Write(string.Join(", ", townNames));
            Console.Write("]");
        }
    }
}