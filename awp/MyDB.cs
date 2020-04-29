using MySql.Data.MySqlClient;

namespace awp
{
    public class MyDB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=");
    }
}