using Dapper;
using SHR.Library;
using System.ComponentModel;

namespace SHR.Models
{
    public class Users
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("ユーザーID")]
        public required string User_Id { get; set; }

        [DisplayName("ユーザー名")]
        public required string User_Name { get; set; }

        [DisplayName("パスワード")]
        public required string Password { get; set; }

        [DisplayName("有効フラグ")]
        public bool Active_Flag { get; set; }
    }
}
