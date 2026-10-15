using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace DCSSMeetingScheduler.Shared {
    public class Connection {

        private static string connectionString = "server=localhost;database=dcss_db;username=root;pwd=;";

        public static MySqlConnection GetConnection() {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            return conn;
        }
    }
}
