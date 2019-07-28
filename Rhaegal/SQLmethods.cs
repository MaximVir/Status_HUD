using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Rhaegal
{
    public class SQLmethods : SQLabstract
    {

        public override void PostToBoard()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "Select Alias, Status from Operators Where Status != 'null'";

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                string board = "";

                while (reader.Read())
                {
                    string post = "||\t" + (string)reader.GetValue(0) + "\t|\t" + (String)reader.GetValue(1) + "\t||" + "\n";
                    board = board + post;
                    
                    //richtextbox1.Text =
                }
                MessageBox.Show(board);
                connection.Close();

            }
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
