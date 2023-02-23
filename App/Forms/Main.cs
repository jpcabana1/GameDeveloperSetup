using App.Code.Handlers;
using App.Code.Utils;

namespace App.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void RbProject_CheckedChanged(object sender, EventArgs e)
        {
            PbTemplate.Image = ImageHandler.GetImage("Project")!;
        }

        private void RbCharacter_CheckedChanged(object sender, EventArgs e)
        {
            PbTemplate.Image = ImageHandler.GetImage("Character")!;
        }

        private void RbAsset_CheckedChanged(object sender, EventArgs e)
        {
            PbTemplate.Image = ImageHandler.GetImage("Asset")!;
        }

        private void BtnFolder_Click(object sender, EventArgs e)
        {
            if (FbdLocation.ShowDialog() == DialogResult.OK)
            {
                TxtPath.Text = FbdLocation.SelectedPath;
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {

            if (TxtPath.Text.Trim() == string.Empty)
            {
                MessageBox.Show(MessageUtil.PathNotFound, MessageUtil.MessageLabel);
                return;
            }

            if (RbProject.Checked)
            {
                var data = FormHandler.GetRepositoryData(Visible); 
                var parameters = ScriptHandler.GetProjectParameters(Environment.CurrentDirectory, data.Url!, data.Name!, TxtPath.Text.Trim());
                ScriptHandler.ExecutePowerShellScript(ScriptUtil.ProjectScriptPath, parameters);
            }else if (RbCharacter.Checked)
            {
                var parameters = ScriptHandler.GetCharacterParameters(FormHandler.GetName(Visible), TxtPath.Text.Trim());
                ScriptHandler.ExecutePowerShellScript(ScriptUtil.CharacterScriptPath, parameters);
            }
            else
            {
                var parameters = ScriptHandler.GetAssetParameters(FormHandler.GetName(Visible), TxtPath.Text.Trim());
                ScriptHandler.ExecutePowerShellScript(ScriptUtil.AssetScriptPath, parameters);
            }

            MessageBox.Show(MessageUtil.CreatedMessage, MessageUtil.MessageLabel);
        }
    }


}
