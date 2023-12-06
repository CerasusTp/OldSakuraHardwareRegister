using Dapper;
using MySql.Data.MySqlClient;
using SHR.Library;
using SHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHR.Event
{
    public class UsersEvent
    {
        // ユーザー情報取得
        public static Users? GetUser(string _user_id)
        {
            using (var con = DbConnector.GetDbConnector())
            {
                con.Open();
                // Dapperの設定変更（アンダーバーを使えるようにする）
                DefaultTypeMap.MatchNamesWithUnderscores = true;
                return con.QuerySingleOrDefault<Users>(
                    "SELECT * From shr.users WHERE user_id = @user_id",
                    new { user_id = _user_id });
            }
        }

        // ユーザー情報取得（パスワード判定）
        public static Users? GetUser(string _user_id, string _password)
        {
            using (var con = DbConnector.GetDbConnector())
            {
                con.Open();
                return con.QueryFirstOrDefault<Users>(
                    "SELECT * From shr.users WHERE user_id = @user_id AND password = @password",
                    new { user_id = _user_id, password = _password });
            }
        }
    }
}
