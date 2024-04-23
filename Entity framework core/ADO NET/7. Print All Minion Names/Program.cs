using _2._Villain_Names;
using System.Data.SqlClient;

namespace _7._Print_All_Minion_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using SqlConnection connection = new SqlConnection(SqlQueries._connection);
            connection.Open();

            SqlCommand minionsNamesCMD = new SqlCommand(SqlQueries._minionNames, connection);
            var reader = minionsNamesCMD.ExecuteReader();
            var names = new List<string>();
            while (reader.Read())
            {
                names.Add(reader["Name"].ToString());
                Console.WriteLine(reader["Name"].ToString());
            }
            connection.Close();
            Console.WriteLine("****************************************");
            for (int first = 0, last = names.Count - 1; first <= last; first++, last--)
            {
                if (names[first] == names[last])
                {
                    Console.WriteLine(names[first]);
                    break;
                }
                Console.WriteLine(names[first]);
                Console.WriteLine(names[last]);
            }
        }
    }
}