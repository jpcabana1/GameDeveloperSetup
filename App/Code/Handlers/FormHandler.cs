using App.Forms;

namespace App.Code.Handlers;
public static class FormHandler
{
    public static string GetName(bool visible)
    {
        var frmNamePrompt = new NamePrompt();
        visible = false;
        frmNamePrompt.ShowDialog();
        visible = true;
        return frmNamePrompt.TxtName.Text;
    }

    public static RepositoryData GetRepositoryData(bool visible)
    {
        var frmProjectSetup = new ProjectSetup();
        visible = false;
        frmProjectSetup.ShowDialog();
        visible = true;
        return new RepositoryData
        {
            Url = frmProjectSetup.TxtRepositoryUrl.Text,
            Name = frmProjectSetup.TxtRepositoryName.Text
        };
    }

    public record RepositoryData
    {
        public string? Url { get; set; }
        public string? Name { get; set; }
    }
}

