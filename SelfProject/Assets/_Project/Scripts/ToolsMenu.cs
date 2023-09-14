using static System.IO.Directory;
using static System.IO.Path;
using static UnityEngine.Application;
using static UnityEditor.AssetDatabase;
using UnityEditor;

namespace Test
{
    public static class ToolsMenu
    {
        [MenuItem("Tools/Create Default Folder")]
        public static void CreateDefaultFolder()
        {
            CreateSubFolder("_Project", "Scripts", "Scene", "Audio","Editor","Animation","Sprite");
            Refresh();
        }
        public static void CreateSubFolder(string root, params string[] dir)
        {
            var fullpath = Combine(dataPath, root);
            foreach (var newDirectory in dir)
            {
                CreateDirectory(Combine(fullpath, newDirectory));
            }
        }
    }
}