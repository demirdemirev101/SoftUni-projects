using _2._Villain_Names;
using System.Data;
using System.Data.SqlClient;

namespace _9._Increase_Age_Stored_Procedure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = int.Parse(Console.ReadLine());

            using SqlConnection connection = new SqlConnection(SqlQueries._connection);
            connection.Open();

            SqlCommand makeOlderProcCMD = new SqlCommand(SqlQueries._OlderProc, connection);

            makeOlderProcCMD.CommandType = CommandType.StoredProcedure;

            makeOlderProcCMD.Parameters.AddWithValue("@id", id);
            makeOlderProcCMD.ExecuteNonQuery();

            using SqlCommand selectByIdCMD = new SqlCommand(SqlQueries._minionsNameaAndAgesById, connection);

            selectByIdCMD.Parameters.AddWithValue("@Id", id);
            var reader = selectByIdCMD.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"{reader["Name"]} - {reader["Age"]} years old.");
            }
        }
    }
}
