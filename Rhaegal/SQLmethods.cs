using System;
using System.Data.SqlClient;

namespace Rhaegal
{
    public class SQLmethods : SQLabstract
    {

        public override string[] PostToBoard()
        {
            string[] board = new string[4];

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "Select Alias, Status from Operators Where Status != 'null' and Workstream = 'Livesite'";

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    string post = "----------------------------------\n" + (string)reader.GetValue(0) + "\t-\t" + (String)reader.GetValue(1) + "\n" + "----------------------------------\n";
                    board[0] = board[0] + post;

                }
                connection.Close();

            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "Select Alias, Status from Operators Where Status != 'null' and Workstream = 'Networking'";

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    string post = "----------------------------------\n" + (string)reader.GetValue(0) + "\t-\t" + (String)reader.GetValue(1) + "\n" + "----------------------------------\n";
                    board[1] = board[1] + post;

                }
                connection.Close();

            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "Select Alias, Status from Operators Where Status != 'null' and Workstream = 'Infra'";

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    string post = "----------------------------------\n" + (string)reader.GetValue(0) + "\t-\t" + (String)reader.GetValue(1) + "\n" + "----------------------------------\n";
                    board[2] = board[2] + post;

                }
                connection.Close();

            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "Select Alias, Status from Operators Where Status != 'null' and Workstream = 'CXP'";

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    string post = "----------------------------------\n" + (string)reader.GetValue(0) + "\t-\t" + (String)reader.GetValue(1) + "\n" + "----------------------------------\n";
                    board[3] = board[3] + post;

                }
                connection.Close();

            }


            return board;
        }

        public override void SetStatus(string Status, string Alias)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "update operators set Status = @status where Alias = @alias;";

                    command.Parameters.AddWithValue("@status", Status);
                    command.Parameters.AddWithValue("@alias", Alias);

                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }

        public override int CheckExistance(string Alias)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT COUNT(*) FROM Operators WHERE Alias = @alias;";
                command.Parameters.AddWithValue("@alias", Alias);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                connection.Close();

                return count;

            }
        }
    }
}
