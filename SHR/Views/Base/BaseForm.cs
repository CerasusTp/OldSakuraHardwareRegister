using MaterialSkin;
using MaterialSkin.Controls;

namespace SHR.Views
{
    public partial class BaseForm : MaterialForm
    {
        public BaseForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800,
                Primary.Blue900,
                Primary.Blue500,
                Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void toolitemVersion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version：0.0.1", "バージョン情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
