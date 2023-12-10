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

namespace SHR.Library
{
    public partial class CustomDataGridView : DataGridView
    {
        public CustomDataGridView()
        {
            InitializeComponent();
            // 見た目を整える
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            RowHeadersVisible = false;
            // 枠の設定
            BorderStyle = BorderStyle.None;
            CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            AdvancedColumnHeadersBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;
            // 枠いっぱいに表示
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // カラムを自動的に作らないように設定
            //AutoGenerateColumns = false;
            // フォント設定
            Font = new Font("Yu Gothic UI", 12);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public virtual void SetColumns(List<string> columns)
        {
            foreach (string column in columns)
            {
                Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = column });
            }
        }
    }
}
