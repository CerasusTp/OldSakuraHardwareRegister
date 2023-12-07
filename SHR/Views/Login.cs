using SHR.Event;
using SHR.Library;
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
    public partial class Login : BaseForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void execute_login()
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
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            execute_login();
        }

        // PW入力後Enterでログイン処理
        private void txtPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                execute_login();
            }
        }

        // EnterでPW入力に移動
        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPw.Focus();
            }
        }
    }
}
