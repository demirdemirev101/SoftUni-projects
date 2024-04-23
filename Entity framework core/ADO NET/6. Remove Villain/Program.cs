using _2._Villain_Names;
using System.Data.SqlClient;

namespace _6._Remove_Villain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Establishing connection with SQL server and reading the villain Id from the console
            int id=int.Parse(Console.ReadLine());
            using SqlConnection connection = new SqlConnection(SqlQueries._connection);
            connection.Open();

            //Selecting villain name from Villains table if he exists
            using SqlCommand villainNameCMD = new SqlCommand(SqlQueries._villainName, connection);
            villainNameCMD.Parameters.AddWithValue("@Id",id);
            var name=villainNameCMD.ExecuteScalar();
            if (name==null)
            {
                Console.WriteLine("No such villain was found.");
                return;
            }

            //begin transaction
            using SqlTransaction transaction = connection.BeginTransaction();
            //Delete the relations between Minions and villains in the MinionsVillains table
            using SqlCommand deleteMinonsVillainsCMD = new SqlCommand(SqlQueries._deleteFromMinionsVillains, connection);
            deleteMinonsVillainsCMD.Transaction = transaction;
            deleteMinonsVillainsCMD.Parameters.AddWithValue("@villainId", id);
            int deletedRows = deleteMinonsVillainsCMD.ExecuteNonQuery();
            Console.WriteLine(deletedRows.ToString());

            //Delete villain from Villains table
            using SqlCommand deleteVillainCMD = new SqlCommand(SqlQueries._deleteVillain, connection);
            deleteVillainCMD.Transaction = transaction;
            deleteVillainCMD.Parameters.AddWithValue("@villainId", id);
            deleteVillainCMD.ExecuteNonQuery();

            //Writing the result on the console
            Console.WriteLine($"{name} was deleted.");
            Console.WriteLine($"{deletedRows} minions were released.");
            
            //rollback
            transaction.Rollback();
        }
    }
}