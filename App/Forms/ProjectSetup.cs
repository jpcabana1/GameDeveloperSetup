using App.Code.Utils;

namespace App.Forms
{
    public partial class ProjectSetup : Form
    {
        public ProjectSetup()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (TxtRepositoryName.Text.Trim() == string.Empty
                || TxtRepositoryUrl.Text.Trim() == string.Empty)
            {
                MessageBox.Show(MessageUtil.ErrorRepository, MessageUtil.MessageLabel);
                return;
            }

            Close();

        }
    }
}
