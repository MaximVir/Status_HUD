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
                string begDay, endDay;

                command.CommandText = "Select Alias, Status From Operators Where Workstream = 'LiveSite' and Shift IN(select Shift from Shifts where @time BETWEEN begMon and endMon or " +
                                                                                                                            "Shift = 'Mid' and @time NOT BETWEEN endMon and begMon or " +
                                                                                                                            "Shift = 'WkEndNiteA' and @time NOT BETWEEN endMon and begMon);";
                command.Parameters.AddWithValue("@time", currentTime);

                switch (currentDay)
                {
                    case "Monday":
                        begDay = "begMon";
                        endDay = "endMon";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Tuesday":
                        begDay = "begTue";
                        endDay = "endTue";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Wednesday":
                        begDay = "begWed";
                        endDay = "endWed";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Thursday":
                        begDay = "begThu";
                        endDay = "endThu";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Friday":
                        begDay = "begFri";
                        endDay = "endFri";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Saturday":
                        begDay = "begSat";
                        endDay = "endSat";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Sunday":
                        begDay = "begSun";
                        endDay = "endSun";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    default:
                        break;
                }

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
                string begDay, endDay;

                command.CommandText = "Select Alias, Status From Operators Where Workstream = 'Networking' and Shift IN(select Shift from Shifts where @time BETWEEN begMon and endMon or " +
                                                                                                                            "Shift = 'Mid' and @time NOT BETWEEN endMon and begMon or " +
                                                                                                                            "Shift = 'WkEndNiteA' and @time NOT BETWEEN endMon and begMon);";
                command.Parameters.AddWithValue("@time", currentTime);

                switch (currentDay)
                {
                    case "Monday":
                        begDay = "begMon";
                        endDay = "endMon";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Tuesday":
                        begDay = "begTue";
                        endDay = "endTue";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Wednesday":
                        begDay = "begWed";
                        endDay = "endWed";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Thursday":
                        begDay = "begThu";
                        endDay = "endThu";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Friday":
                        begDay = "begFri";
                        endDay = "endFri";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Saturday":
                        begDay = "begSat";
                        endDay = "endSat";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Sunday":
                        begDay = "begSun";
                        endDay = "endSun";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    default:
                        break;
                }
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                string label = //"----------------------------------\n" +
                               " _ __\n" +
                               "( /  )   _/_              / / \n" +
                               " /  / _  /  , , , __ _   /< \n" +
                               "/  (_(/_(__(_(_/_(_)/ (_/ |\n\n\n";
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
                string begDay, endDay;

                command.CommandText = "Select Alias, Status From Operators Where Workstream = 'Infra' and Shift IN(select Shift from Shifts where @time BETWEEN begMon and endMon or " +
                                                                                                                            "Shift = 'Mid' and @time NOT BETWEEN endMon and begMon or " +
                                                                                                                            "Shift = 'WkEndNiteA' and @time NOT BETWEEN endMon and begMon);";
                command.Parameters.AddWithValue("@time", currentTime);

                switch (currentDay)
                {
                    case "Monday":
                        begDay = "begMon";
                        endDay = "endMon";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Tuesday":
                        begDay = "begTue";
                        endDay = "endTue";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Wednesday":
                        begDay = "begWed";
                        endDay = "endWed";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Thursday":
                        begDay = "begThu";
                        endDay = "endThu";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Friday":
                        begDay = "begFri";
                        endDay = "endFri";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Saturday":
                        begDay = "begSat";
                        endDay = "endSat";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Sunday":
                        begDay = "begSun";
                        endDay = "endSun";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    default:
                        break;
                }
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                string label = //"----------------------------------\n" +
                               "  ___                \n" +
                               " ( /       /)        \n" +
                               "  / _ _   // _   __, \n" +
                               "_/_/ / /_//_/ (_(_/(_\n" +
                               "        /)           \n" +
                               "       (/            \n";


//" _         ___            \n" +
//"| |       / __)           \n" +
//"| |____ _| |__ ____ _____ \n" +
//"| |  _ (_   __) ___|____ |\n" +
//"| | | | || | | |   / ___ |\n" +
//"|_|_| |_||_| |_|   "+"|_____|";

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
                string begDay, endDay;

                command.CommandText = "Select Alias, Status From Operators Where Workstream = 'CXP' and Shift IN(select Shift from Shifts where @time BETWEEN begMon and endMon or " +
                                                                                                                            "Shift = 'Mid' and @time NOT BETWEEN endMon and begMon or " +
                                                                                                                            "Shift = 'WkEndNiteA' and @time NOT BETWEEN endMon and begMon);";
                command.Parameters.AddWithValue("@time", currentTime);

                switch (currentDay)
                {
                    case "Monday":
                        begDay = "begMon";
                        endDay = "endMon";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Tuesday":
                        begDay = "begTue";
                        endDay = "endTue";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Wednesday":
                        begDay = "begWed";
                        endDay = "endWed";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Thursday":
                        begDay = "begThu";
                        endDay = "endThu";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Friday":
                        begDay = "begFri";
                        endDay = "endFri";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Saturday":
                        begDay = "begSat";
                        endDay = "endSat";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    case "Sunday":
                        begDay = "begSun";
                        endDay = "endSun";
                        command.Parameters.AddWithValue("@beg", begDay);
                        command.Parameters.AddWithValue("@end", endDay);
                        break;
                    default:
                        break;
                }
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                string label = //"----------------------------------\n" +
                              "   ,___  _,  , _ __ \n" +
                              "  /   / ( |,' ( /  )\n" +
                              " /       +    /--' \n" +
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
    }
}
