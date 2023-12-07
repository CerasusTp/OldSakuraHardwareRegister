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
    public partial class Menu : BaseForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // ログインフォーム作成
            Login login = new Login();
            // 表示（OK以外ならアプリケーション終了）
            if (login.ShowDialog() != DialogResult.OK) { Close(); }
        }
    }
}
