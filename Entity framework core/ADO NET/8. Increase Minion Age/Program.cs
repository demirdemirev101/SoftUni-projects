using _2._Villain_Names;
using System.Collections;
using System.Data.SqlClient;

namespace _8._Increase_Minion_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ").ToArray().Select(x => int.Parse(x));
            Queue<int> minionIds = new Queue<int>(input);

            using SqlConnection connection = new SqlConnection(SqlQueries._connection);
            connection.Open();

            while (minionIds.Count > 0)
            {
                int id = minionIds.Dequeue();
                using SqlCommand updateCMD = new SqlCommand(SqlQueries._updateNamesAndAgesOfMinions, connection);
               
                updateCMD.Parameters.AddWithValue("@Id", id);
                updateCMD.ExecuteNonQuery();
            }
            
            using SqlCommand readCMD = new SqlCommand(SqlQueries._selectMinionNamesAndAges, connection);
            
            var reader = readCMD.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"{reader["Name"]} {reader["Age"]}");
            }
            
        }
    }
}