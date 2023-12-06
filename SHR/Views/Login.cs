using SHR.Event;
using SHR.Library;
using SHR.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHR.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 入力チェック
            var error = new CheckError();
            if (string.IsNullOrEmpty(txtId.Text)) { error.AddError("IDは必須です"); }
            if (string.IsNullOrEmpty(txtPw.Text)) { error.AddError("PWは必須です"); }

            // ログインチェック（入力チェックでエラーの場合は処理しない）
            if (!error.HasError())
            {
                var user = UsersEvent.GetUser(txtId.Text, txtPw.Text);
                if (user is null) { error.AddError("IDまたはPWが異なります"); }
                else if (!user.Active_Flag) { error.AddError("ユーザーが削除されています"); }
            }

            // メッセージ表示
            if (error.HasError()) 
            {
                MessageBox.Show(error.GetError(), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }　else { 
                MessageBox.Show("ログイン成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
