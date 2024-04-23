using System.Data.SqlClient;

namespace _2._Villain_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            using SqlConnection connection = new SqlConnection(SqlQueries._connection);
            connection.Open();

            using SqlCommand villainNamesCMD = new SqlCommand(SqlQueries._villainNames, connection);

            var reader=villainNamesCMD.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Name"]+" - " + reader["MinionsCount"]);
            }
            connection.Close();
        }
    }
}