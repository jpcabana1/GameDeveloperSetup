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
            PbTemplate.Image = (Image)Properties.Resources.ResourceManager.GetObject("Project")!;
        }

        private void RbCharacter_CheckedChanged(object sender, EventArgs e)
        {
            PbTemplate.Image = (Image)Properties.Resources.ResourceManager.GetObject("Character")!;
        }

        private void RbAsset_CheckedChanged(object sender, EventArgs e)
        {
            PbTemplate.Image = (Image)Properties.Resources.ResourceManager.GetObject("Asset")!;
        }
    }
}
