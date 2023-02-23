namespace App.Code.Handlers
{
    public static class ImageHandler
    {
        public static Image GetImage(string path) => 
            (Image)Properties.Resources.ResourceManager.GetObject(path)!;
        
    }
}
