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
using Rhaegal.Formatting;
using Rhaegal.Time;

namespace Rhaegal
{
    public class SQLmethods : SQLabstract
    {
        readonly Formatmethods f = new Formatmethods();
        readonly Timemethods t = new Timemethods();

        public override string[] PostToBoard()
        {
            string[] board = new string[4];

            string currentDay = t.GetDay();
            string currentTime = t.GetTime();

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            { 
                string WorkStream = "Livesite";

                switch (currentDay)
                {
                    case "Monday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begMon and endMon or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids' and @time NOT BETWEEN endMon and begMon or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids_East' and @time NOT BETWEEN endMon and begMon;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Tuesday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begTue and endTue or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids' and @time NOT BETWEEN endTue and begTue or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids_East' and @time NOT BETWEEN endTue and begTue;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Wednesday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begWed and endWed or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids' and @time NOT BETWEEN endWed and begWed or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids_East' and @time NOT BETWEEN endWed and begWed;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Thursday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begWed and endWed or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids' and @time NOT BETWEEN endThu and begThu or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids_East' and @time NOT BETWEEN endThu and begThu or " +
                                              "Op.Workstream = @workstream and sh.Shift = 'NightsEast' and @time NOT BETWEEN endThu and begThu;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Friday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begFri and endFri or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids' and @time NOT BETWEEN endFri and begFri or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids_East' and @time NOT BETWEEN endFri and begFri;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Saturday":
                        command.CommandText = "select Alias, Location " +
                                             "from Operators as Op " +
                                             "join Shifts as Sh " +
                                             "on (Sh.Shift = Op.Shift) " +
                                             "where Op.Workstream = @workstream " +
                                             "and @time between begFri and endFri or " +
                                             "Op.Workstream = @workstream and sh.Shift = 'WkEd_Days_A' and @time NOT BETWEEN endSat and begSat;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Sunday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begFri and endFri or " +
                                              "Op.Workstream = @workstream and sh.Shift = 'WkEd_Days_A' and @time NOT BETWEEN endSun and begSun;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    default:
                        break;
                }

                command.Parameters.AddWithValue("@time", currentTime);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                string label =  
                               "  __              __,        \n" +
                               " ( /   o         (    o _/_  \n" +
                               "  /   ,  _  ,__   `. ,  /  _ \n" +   
                               "(/___/(_/ |/ (/_(___)(_(__(/_\n\n\n"+ "==================================\n" ;
                board[0] = board[0] + label;

                while (reader.Read())
                {
                    string line = f.printFormatted((string)reader.GetValue(0), (string)reader.GetValue(1));
                    string post = //"----------------------------------\n" + 
                                  line  +
                                  "----------------------------------\n";
                    board[0] = board[0] + post;
                }
                connection.Close();

            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                string WorkStream = "Networking";

                switch (currentDay)
                {
                    case "Monday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begMon and endMon or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids' and @time NOT BETWEEN endMon and begMon or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids_East' and @time NOT BETWEEN endMon and begMon;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Tuesday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begTue and endTue or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids' and @time NOT BETWEEN endTue and begTue or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids_East' and @time NOT BETWEEN endTue and begTue;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Wednesday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begWed and endWed or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids' and @time NOT BETWEEN endWed and begWed or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids_East' and @time NOT BETWEEN endWed and begWed;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Thursday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begWed and endWed or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids' and @time NOT BETWEEN endThu and begThu or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids_East' and @time NOT BETWEEN endThu and begThu or " +
                                              "Op.Workstream = @workstream and sh.Shift = 'NightsEast' and @time NOT BETWEEN endThu and begThu;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Friday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begFri and endFri or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids' and @time NOT BETWEEN endFri and begFri or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids_East' and @time NOT BETWEEN endFri and begFri;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Saturday":
                        command.CommandText = "select Alias, Location " +
                                             "from Operators as Op " +
                                             "join Shifts as Sh " +
                                             "on (Sh.Shift = Op.Shift) " +
                                             "where Op.Workstream = @workstream " +
                                             "and @time between begFri and endFri or " +
                                             "Op.Workstream = @workstream and sh.Shift = 'WkEd_Days_A' and @time NOT BETWEEN endSat and begSat;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Sunday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begFri and endFri or " +
                                              "Op.Workstream = @workstream and sh.Shift = 'WkEd_Days_A' and @time NOT BETWEEN endSun and begSun;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
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
                               "/  (_(/_(__(_(_/_(_)/ (_/ |_\n\n\n" + 
                               "==================================\n";


                board[1] = board[1] + label;

                while (reader.Read())
                {
                    string line = f.printFormatted((string)reader.GetValue(0), (string)reader.GetValue(1));
                    string post = //"----------------------------------\n" +
                                  line +
                                  "----------------------------------\n";
                    board[1] = board[1] + post;
                }
                connection.Close();

            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                string WorkStream = "Infra";

                switch (currentDay)
                {
                    case "Monday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begMon and endMon or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids' and @time NOT BETWEEN endMon and begMon or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids_East' and @time NOT BETWEEN endMon and begMon;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Tuesday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begTue and endTue or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids' and @time NOT BETWEEN endTue and begTue or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids_East' and @time NOT BETWEEN endTue and begTue;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Wednesday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begWed and endWed or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids' and @time NOT BETWEEN endWed and begWed or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids_East' and @time NOT BETWEEN endWed and begWed;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Thursday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begWed and endWed or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids' and @time NOT BETWEEN endThu and begThu or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids_East' and @time NOT BETWEEN endThu and begThu or " +
                                              "Op.Workstream = @workstream and sh.Shift = 'NightsEast' and @time NOT BETWEEN endThu and begThu;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Friday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begFri and endFri or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids' and @time NOT BETWEEN endFri and begFri or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids_East' and @time NOT BETWEEN endFri and begFri;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Saturday":
                        command.CommandText = "select Alias, Location " +
                                             "from Operators as Op " +
                                             "join Shifts as Sh " +
                                             "on (Sh.Shift = Op.Shift) " +
                                             "where Op.Workstream = @workstream " +
                                             "and @time between begFri and endFri or " +
                                             "Op.Workstream = @workstream and sh.Shift = 'WkEd_Days_A' and @time NOT BETWEEN endSat and begSat;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Sunday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begFri and endFri or " +
                                              "Op.Workstream = @workstream and sh.Shift = 'WkEd_Days_A' and @time NOT BETWEEN endSun and begSun;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
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
                               "       (/            \n" + "==================================\n";


                board[2] = board[2] + label;


                while (reader.Read())
                {
                    string line = f.printFormatted((string)reader.GetValue(0), (string)reader.GetValue(1));
                    string post = //"----------------------------------\n" +
                                  line +
                                  "----------------------------------\n";
                    board[2] = board[2] + post;
                }
                connection.Close();

            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                string WorkStream = "CXP";

                switch (currentDay)
                {
                    case "Monday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begMon and endMon or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids' and @time NOT BETWEEN endMon and begMon or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids_East' and @time NOT BETWEEN endMon and begMon;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Tuesday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begTue and endTue or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids' and @time NOT BETWEEN endTue and begTue or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids_East' and @time NOT BETWEEN endTue and begTue;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Wednesday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begWed and endWed or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids' and @time NOT BETWEEN endWed and begWed or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids_East' and @time NOT BETWEEN endWed and begWed;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Thursday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begWed and endWed or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids' and @time NOT BETWEEN endThu and begThu or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids_East' and @time NOT BETWEEN endThu and begThu or " +
                                              "Op.Workstream = @workstream and sh.Shift = 'NightsEast' and @time NOT BETWEEN endThu and begThu;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Friday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begFri and endFri or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids' and @time NOT BETWEEN endFri and begFri or " +
                                              "Op.Workstream = @workstream and Sh.Shift = 'Mids_East' and @time NOT BETWEEN endFri and begFri;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Saturday":
                        command.CommandText = "select Alias, Location " +
                                             "from Operators as Op " +
                                             "join Shifts as Sh " +
                                             "on (Sh.Shift = Op.Shift) " +
                                             "where Op.Workstream = @workstream " +
                                             "and @time between begFri and endFri or " +
                                             "Op.Workstream = @workstream and sh.Shift = 'WkEd_Days_A' and @time NOT BETWEEN endSat and begSat;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
                        break;
                    case "Sunday":
                        command.CommandText = "select Alias, Location " +
                                              "from Operators as Op " +
                                              "join Shifts as Sh " +
                                              "on (Sh.Shift = Op.Shift) " +
                                              "where Op.Workstream = @workstream " +
                                              "and @time between begFri and endFri or " +
                                              "Op.Workstream = @workstream and sh.Shift = 'WkEd_Days_A' and @time NOT BETWEEN endSun and begSun;";
                        command.Parameters.AddWithValue("@workstream", WorkStream);
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
                              "(___/  _,'| __/     \n\n\n" + "==================================\n";
                board[3] = board[3] + label;


                while (reader.Read())
                {
                    string line = f.printFormatted((string)reader.GetValue(0), (string)reader.GetValue(1));
                    string post = //"----------------------------------\n" +
                                  line +
                                  "----------------------------------\n";
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

        public override void DeleteOperator(string Alias)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "delete from Operators where alias = @alias;";

                command.Parameters.AddWithValue("@alias", Alias);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public override void ModifyShift(string Shift, string Alias)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "update Operators set Shift = @shift where Alias = @alias;";

                command.Parameters.AddWithValue("@shift", Shift);
                command.Parameters.AddWithValue("@alias", Alias);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public override void ModifyLocation(string Location, string Alias)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "update Operators set Location = @location where Alias = @alias;";

                command.Parameters.AddWithValue("@location", Location);
                command.Parameters.AddWithValue("@alias", Alias);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public override void ModifyWorkstream(string Workstream, string Alias)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "update Operators set Workstream = @workstream where Alias = @alias;";

                command.Parameters.AddWithValue("@workstream", Workstream);
                command.Parameters.AddWithValue("@alias", Alias);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public override void ModifyAlias(string OldAlias, string NewAlias)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "update Operators set Alias = @new where Alias = @old;";

                command.Parameters.AddWithValue("@old", OldAlias);
                command.Parameters.AddWithValue("@new", NewAlias);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public override string[] PopAlias()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                List<String> populate = new List<String>();
                string[] List;

                command.CommandText = "select Alias from Operators order by Alias;";

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    populate.Add((string)reader.GetValue(0));
                }

                connection.Close();

                List = populate.ToArray();

                return List;
            }
        }

        public override string[] PopWorkStream()
        {
            string[] List = { "Livesite","Networking","Infra","CXP","Other" };
            return List;
        }

        public override string[] PopShift()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                List<String> populate = new List<String>();
                string[] List;

                command.CommandText = "select Shift from Shifts;";

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    populate.Add((string)reader.GetValue(0));
                }

                connection.Dispose();

                List = populate.ToArray();

                return List;
            }
        }

        public override string[] PopLocation()
        {
            string[] List = { "West", "East", "Other" };
            return List;
        }

        
    }
}
