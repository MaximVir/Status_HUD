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
        string Status, Alias, cmdString;
        SqlDataReader Reader;

        


        public override void PostToBoard()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {

            }
        }

        public override void SetStatus(string Status, string Alias)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();

                SqlCommand command = new SqlCommand("update operators set Status = '@status' where Alias = '@alias';", cnn);
                command.Parameters.AddWithValue("@status", Status);
                command.Parameters.AddWithValue("@alias", Alias);

                //command.Connection.Open();
                command.ExecuteNonQuery();

                try
                {
                    //cnn.Open();
                    //MessageBox.Show("good");
                }
                catch (SqlException)
                {
                    MessageBox.Show("bad");
                }






                cnn.Close();
            }
        }
    }
}
