using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System.Data.Common;


namespace SHR.Library
{
    public class DbConnector
    {
        public static DbConnection GetDbConnector()
        {
            // 接続文字列作成
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = Properties.Settings.Default.Server,
                Port = Properties.Settings.Default.Port,
                UserID = Properties.Settings.Default.User,
                Password = Properties.Settings.Default.PW,
                Database = Properties.Settings.Default.Database
            };

            return new MySqlConnection( builder.ToString() );
        }
    }
}
