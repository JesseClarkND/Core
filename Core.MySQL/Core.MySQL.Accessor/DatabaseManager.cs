using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Core.MySQL.Accessor
{
    public class DatabaseManager
    {
        private static string _dbString = "";
        public static MySqlConnection GetConnection()
        {
            if (String.IsNullOrEmpty(_dbString))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"C:\datasource.xml");

                XmlNode node = doc.DocumentElement.SelectSingleNode("/root/SQLConnectionString");
                _dbString = node.InnerText;
            }

            MySqlConnection conn = new MySqlConnection(_dbString);

            return conn;
        }
    }
}