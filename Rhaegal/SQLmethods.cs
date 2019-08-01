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
using System.Threading;
using System.Diagnostics;
using System.Collections;

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
                string currentDay = System.DateTime.Now.DayOfWeek.ToString();
                string currentTime = DateTime.Now.TimeOfDay.ToString();
                string WorkStream = "Livesite";

                switch (currentDay)
                {
                    case "Monday":
                        command.CommandText = "select Alias, sh.Shift " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begMon and endMon or " +
                                              "Sh.Shift = 'Mid' and @time NOT BETWEEN endMon and begMon or " +
                                              "sh.Shift = 'NightsEast' and @time NOT BETWEEN endMon and begMon; ";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Tuesday":
                        command.CommandText = "select Alias, sh.Shift " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begTue and endTue or " +
                                              "Sh.Shift = 'Mid' and @time NOT BETWEEN endTue and begTue or " +
                                              "sh.Shift = 'NightsEast' and @time NOT BETWEEN endTue and begTue; ";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Wednesday":
                        command.CommandText = "select Alias, sh.Shift " +
                                              "from Operators as Op "+
                                              "join Shifts as Sh "+
                                              "on (Sh.Shift = Op.Shift) "+
                                              "where Op.Workstream = @workstream "+
                                              "and @time between begWed and endWed or "+
                                              "Sh.Shift = 'Mid' and @time NOT BETWEEN endWed and begWed or " +
                                              "sh.Shift = 'NightsEast' and @time NOT BETWEEN endWed and begWed; ";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Thursday":
                        command.CommandText = "select Alias, sh.Shift " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begWed and endWed or " +
                                              "Sh.Shift = 'Mid' and @time NOT BETWEEN endWed and begWed or " +
                                              "sh.Shift = 'NightsEast' and @time NOT BETWEEN endWed and begWed; ";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Friday":
                        command.CommandText = "select Alias, sh.Shift " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begFri and endFri or " +
                                              "Sh.Shift = 'Mid' and @time NOT BETWEEN endFri and begFri or " +
                                              "sh.Shift = 'NightsEast' and @time NOT BETWEEN endFri and begFri; ";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Saturday":

                        break;
                    case "Sunday":

                        break;
                    default:
                        break;
                }

                command.Parameters.AddWithValue("@time", currentTime);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                string label = //"----------------------------------\n" + 
                               "  __              __,        \n" +
                               " ( /   o         (    o _/_  \n" +
                               "  /   ,  _  ,__   `. ,  /  _ \n" +
                               "(/___/(_/ |/ (/_(___)(_(__(/_\n\n\n";
                board[0] = board[0] + label;

                while (reader.Read())
                {
                    
;                   string post = "----------------------------------\n" + 
                                  (string)reader.GetValue(0) + "\t-\t" + (String)reader.GetValue(1) + "\n" + 
                                  "----------------------------------\n";
                    board[0] = board[0] + post;

                   
                }
                connection.Close();

            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                string currentDay = System.DateTime.Now.DayOfWeek.ToString();
                string currentTime = DateTime.Now.TimeOfDay.ToString();
                string WorkStream = "Networking";

                switch (currentDay)
                {
                    case "Monday":
                        command.CommandText = "select Alias, sh.Shift " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begMon and endMon or " +
                                              "Sh.Shift = 'Mid' and @time NOT BETWEEN endMon and begMon or " +
                                              "sh.Shift = 'NightsEast' and @time NOT BETWEEN endMon and begMon; ";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Tuesday":
                        command.CommandText = "select Alias, sh.Shift " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begTue and endTue or " +
                                              "Sh.Shift = 'Mid' and @time NOT BETWEEN endTue and begTue or " +
                                              "sh.Shift = 'NightsEast' and @time NOT BETWEEN endTue and begTue; ";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Wednesday":
                        command.CommandText = "select Alias, sh.Shift " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begWed and endWed or " +
                                              "Sh.Shift = 'Mid' and @time NOT BETWEEN endWed and begWed or " +
                                              "sh.Shift = 'NightsEast' and @time NOT BETWEEN endWed and begWed; ";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Thursday":
                        command.CommandText = "select Alias, sh.Shift " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begWed and endWed or " +
                                              "Sh.Shift = 'Mid' and @time NOT BETWEEN endWed and begWed or " +
                                              "sh.Shift = 'NightsEast' and @time NOT BETWEEN endWed and begWed; ";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Friday":
                        command.CommandText = "select Alias, sh.Shift " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begFri and endFri or " +
                                              "Sh.Shift = 'Mid' and @time NOT BETWEEN endFri and begFri or " +
                                              "sh.Shift = 'NightsEast' and @time NOT BETWEEN endFri and begFri; ";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Saturday":

                        break;
                    case "Sunday":

                        break;
                    default:
                        break;
                }

                command.Parameters.AddWithValue("@time", currentTime);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                string label = //"----------------------------------\n" +
                               " _ __\n" +
                               "( /  )   _/_              /  \n" +
                               " /  / _  /  , , , __ _   /< \n" +
                               "/  (_(/_(__(_(_/_(_)/ (_/ |_\n";


                board[1] = board[1] + label;

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
                string currentDay = System.DateTime.Now.DayOfWeek.ToString();
                string currentTime = DateTime.Now.TimeOfDay.ToString();
                string WorkStream = "Infra";

                switch (currentDay)
                {
                    case "Monday":
                        command.CommandText = "select Alias, sh.Shift " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begMon and endMon or " +
                                              "Sh.Shift = 'Mid' and @time NOT BETWEEN endMon and begMon or " +
                                              "sh.Shift = 'NightsEast' and @time NOT BETWEEN endMon and begMon; ";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Tuesday":
                        command.CommandText = "select Alias, sh.Shift " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begTue and endTue or " +
                                              "Sh.Shift = 'Mid' and @time NOT BETWEEN endTue and begTue or " +
                                              "sh.Shift = 'NightsEast' and @time NOT BETWEEN endTue and begTue; ";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Wednesday":
                        command.CommandText = "select Alias, sh.Shift " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begWed and endWed or " +
                                              "Sh.Shift = 'Mid' and @time NOT BETWEEN endWed and begWed or " +
                                              "sh.Shift = 'NightsEast' and @time NOT BETWEEN endWed and begWed; ";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Thursday":
                        command.CommandText = "select Alias, sh.Shift " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begWed and endWed or " +
                                              "Sh.Shift = 'Mid' and @time NOT BETWEEN endWed and begWed or " +
                                              "sh.Shift = 'NightsEast' and @time NOT BETWEEN endWed and begWed; ";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Friday":
                        command.CommandText = "select Alias, sh.Shift " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begFri and endFri or " +
                                              "Sh.Shift = 'Mid' and @time NOT BETWEEN endFri and begFri or " +
                                              "sh.Shift = 'NightsEast' and @time NOT BETWEEN endFri and begFri; ";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Saturday":

                        break;
                    case "Sunday":

                        break;
                    default:
                        break;
                }

                command.Parameters.AddWithValue("@time", currentTime);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                string label = //"----------------------------------\n" +
                               "  ___                \n" +
                               " ( /       /)        \n" +
                               "  / _ _   // _   __, \n" +
                               "_/_/ / /_//_/ (_(_/(_\n" +
                               "        /)           \n" +
                               "       (/            \n";


                board[2] = board[2] + label;


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
                string currentDay = System.DateTime.Now.DayOfWeek.ToString();
                string currentTime = DateTime.Now.TimeOfDay.ToString();
                string WorkStream = "CXP";

                switch (currentDay)
                {
                    case "Monday":
                        command.CommandText = "select Alias, sh.Shift " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begMon and endMon or " +
                                              "Sh.Shift = 'Mid' and @time NOT BETWEEN endMon and begMon or " +
                                              "sh.Shift = 'NightsEast' and @time NOT BETWEEN endMon and begMon; ";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Tuesday":
                        command.CommandText = "select Alias, sh.Shift " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begTue and endTue or " +
                                              "Sh.Shift = 'Mid' and @time NOT BETWEEN endTue and begTue or " +
                                              "sh.Shift = 'NightsEast' and @time NOT BETWEEN endTue and begTue; ";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Wednesday":
                        command.CommandText = "select Alias, sh.Shift " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begWed and endWed or " +
                                              "Sh.Shift = 'Mid' and @time NOT BETWEEN endWed and begWed or " +
                                              "sh.Shift = 'NightsEast' and @time NOT BETWEEN endWed and begWed; ";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Thursday":
                        command.CommandText = "select Alias, sh.Shift " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begWed and endWed or " +
                                              "Sh.Shift = 'Mid' and @time NOT BETWEEN endWed and begWed or " +
                                              "sh.Shift = 'NightsEast' and @time NOT BETWEEN endWed and begWed; ";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Friday":
                        command.CommandText = "select Alias, sh.Shift " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begFri and endFri or " +
                                              "Sh.Shift = 'Mid' and @time NOT BETWEEN endFri and begFri or " +
                                              "sh.Shift = 'NightsEast' and @time NOT BETWEEN endFri and begFri; ";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Saturday":

                        break;
                    case "Sunday":

                        break;
                    default:
                        break;
                }

                command.Parameters.AddWithValue("@time", currentTime);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                string label = //"----------------------------------\n" +
                              "   ,___  _,  , _ __ \n" +
                              "  /   / ( |,' ( /  )\n" +
                              " /        +    /--' \n" +
                              "(___/  _,'| __/     \n\n\n";
                board[3] = board[3] + label;


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

        public override void CreateOperator(string Alias, string Workstream, string Location, string Shift)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "insert into operators values(@alias,@workstream,null,@location,@shift);";

                command.Parameters.AddWithValue("@workstream", Workstream);
                command.Parameters.AddWithValue("@alias", Alias);
                command.Parameters.AddWithValue("@location", Location);
                command.Parameters.AddWithValue("@shift", Shift);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public override void ModifyShift()
        {
            throw new NotImplementedException();
        }

        public override void ModifyLocation()
        {
            throw new NotImplementedException();
        }

        public override void ModifyWorkstream()
        {
            throw new NotImplementedException();
        }

        public override string[] PopAlias()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                string Item;
                int i = 0;

                MessageBox.Show("it isnt completely broken");

                command.CommandText = "select Alias from Operators;";
               //command.Parameters.AddWithValue("@alias", Alias);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                int count = (int)command.ExecuteScalar();

                string[] List = new string[count-1];

                while (reader.Read())
                {
                    while(count > i)
                    {
                        List[i] = List[i] + (string)reader.GetValue(0);
                        i++;
                        
                            
                    }
                }


                connection.Close();
                return List;
            }
        }
    }
}
