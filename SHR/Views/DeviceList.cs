using SHR.Models;
using SHR.Views.Base;
using System.Data.Common;
using System.Windows.Forms;

namespace SHR.Views
{
    public partial class DeviceList : InnerBaseForm
    {
        public DeviceList()
        {
            InitializeComponent();
        }

        private void DeviceList_Load(object sender, EventArgs e)
        {
            // データソース指定
            viewList.DataSource = Devices.GetDevices();
            //viewList.DataContext = Devices.GetDevices();
            // カラム作成
            viewList.SetColumns(new List<string> {
                nameof(Devices.Code), nameof(Devices.OS.Name), nameof(Devices.DeviceType.Name)
            });
            viewList.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Devices.OS), ValueType =  });
        }
    }
}
