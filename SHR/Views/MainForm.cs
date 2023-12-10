using Microsoft.VisualBasic.Logging;
using SHR.Models;
using SHR.Views.Base;
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
    public partial class MainForm : BaseForm
    {
        // ユーザー情報保持
        public readonly Users? users;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ChildForm_Load(new Login());
        }

        private void ChildForm_Load(Form form)
        {
            // 子フォームの設定
            form.TopLevel = false;
            // 親ウィンドウ全体に表示
            form.Dock = DockStyle.Fill;
            // 親ウィンドウ全体に表示
            // 子フォームの終了時イベントを追加
            form.FormClosed += new FormClosedEventHandler(ChildForm_ClosedEvent);
            MainPanel.Controls.Add(form);
            form.Show();
        }

        private void ChildForm_ClosedEvent(object? sender, FormClosedEventArgs e)
        {
            // senderからフォーム取得
            InnerBaseForm? form = (InnerBaseForm?)sender;
            // Nullの場合エラー
            if (form is null) 
            {
                MessageBox.Show("想定されていないエラーが発生しました\n管理者に連絡してください",
                                "想定外のエラー",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                Close();
            }
            else
            {
                // 当該フォーム削除
                MainPanel.Controls.Remove(form);
                // 新しいフォームを表示
                ChildForm_Load(FormClassGenerate(form.NextFormType));
            }
        }
        
        // クラスタイプから子フォームを作成
        private InnerBaseForm FormClassGenerate(Type type)
        {
            InnerBaseForm? form;
            try { 
                form = (InnerBaseForm?)Activator.CreateInstance(type); 
            } catch (MissingMethodException) {
                // エラーならとりあえずメニューフォームを返す
                return new Menu(); 
            }

            // Nullならメニューフォームを返す
            return form ?? new Menu();
        }
    }
}
