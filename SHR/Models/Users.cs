﻿using Dapper;
using SHR.Library;
using System.ComponentModel;

namespace SHR.Models
{
    public class Users
    {
        public int Id { get; set; }
        public required string User_Id { get; set; }
        public required string User_Name { get; set; }
        public required string Password { get; set; }
        public bool Active_Flag { get; set; }

        // 引数なしのコンストラクタがないとDapperがエラーになる
        public Users() { }

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
