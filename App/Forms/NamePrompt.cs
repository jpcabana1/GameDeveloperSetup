using App.Code.Utils;

namespace App.Forms
{
    public partial class NamePrompt : Form
    {
        public NamePrompt()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (TxtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show(MessageUtil.NameNotSelected, MessageUtil.MessageLabel);
            }
            else
            {
                Close();
            }
        }
    }
}
