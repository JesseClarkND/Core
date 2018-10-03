using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.MySQL.Accessor
{
    public class DatabaseManager
    {
        public static MySqlConnection GetConnection()
        {
            //string sqlDbString = "Server=69.89.31.72;Port=3306;Database=blackdx5_test;Uid=blackdx5_tester;Pwd=B2$oxg(pkxEE;";//Settings.ConnectionString;

           // MySqlConnection conn = new MySqlConnection(sqlDbString);

            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "69.89.31.72";
            conn_string.Port = 3306;
            conn_string.UserID = "blackdx5_tester";
            conn_string.Password = "B2$oxg(pkxEE";
            conn_string.Database = "blackdx5_test";

            MySqlConnection conn = new MySqlConnection(conn_string.ToString());

            return conn;
        }
    }
}