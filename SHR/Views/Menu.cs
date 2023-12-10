using System;
using SHR.Models;
using SHR.Views.Base;

namespace SHR.Views
{
    public partial class Menu : InnerBaseForm
    {
        public Menu()
        {
            InitializeComponent();
            // 子フォームの閉じるボタン無効化
            btnInnerClose_Disable();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            cmbLocation.DataSource = Locations.GetLocations();
            cmbLocation.DisplayMember = nameof(Locations.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NextFormType = typeof(DeviceRegistration);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NextFormType = typeof(DeviceList);
            Close();
        }
    }
}
