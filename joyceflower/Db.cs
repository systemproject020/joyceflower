using MySql.Data.MySqlClient;

namespace joyceflower
{
    internal static class Db
    {
        private const string ConnString =
            "Server=localhost;Port=3306;Database=joyceflower;Uid=root;Pwd=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnString);
        }
    }
}