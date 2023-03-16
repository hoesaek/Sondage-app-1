using MySql.Data.MySqlClient;

namespace AppSondage
{
    internal class BDD
    {
        public MySqlConnection GetDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection String.
            string connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }
    }
}
