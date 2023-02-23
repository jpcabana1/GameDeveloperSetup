using System.Management.Automation;

namespace App.Code.Handlers
{
    public static class ScriptHandler
    {
        public static Dictionary<string, string> GetProjectParameters(string scriptsPath, string repositoryUrl, string repositoryName, string path)
        => new()
        {
            { "ScriptsPath", scriptsPath }, { "RepositoryUrl", repositoryUrl },
            { "RepositoryName", repositoryName }, { "Path", path }
        };

        public static Dictionary<string, string> GetCharacterParameters(string name, string path)
             => new() { {"CharacterName", name}, {"Path", path} };

        public static Dictionary<string, string> GetAssetParameters(string name, string path)
            => new() { { "AssetName", name }, { "Path", path } };

        public static void ExecutePowerShellScript(string scriptFilePath, Dictionary<string, string> parameters)
        {
            PowerShell.Create()
                .AddScript(File.ReadAllText(scriptFilePath))
                .AddParameters(parameters)
                .Invoke();
        }
    }
    
}
