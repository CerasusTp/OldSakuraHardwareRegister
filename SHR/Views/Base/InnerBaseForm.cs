using MaterialSkin;
using MaterialSkin.Controls;

namespace SHR.Views.Base
{
    public partial class InnerBaseForm : MaterialForm
    {
        // 指定がない場合はメニューが開くようにする
        public Type NextFormType = typeof(Menu);
        public InnerBaseForm()
        {
            InitializeComponent();

        }

        private void btnInnerClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected void btnInnerClose_Disable()
        {
            btnInnerClose.Visible = false;
        }
    }
}
