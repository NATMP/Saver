using static System.IO.Directory;
using static System.IO.Path;
using static UnityEngine.Application;
using static UnityEditor.AssetDatabase;
using UnityEditor;

namespace Test
{
    public static class ToolsMenu
    {
        private const string rootFolderName = "_Project";
        private static string[] childRootFolderName = { "Scripts", "Scene", "Audio", "Editor", "Animation", "Sprite" };
        private const string spriteFolderName = "_Project/Sprite";
        private static string[] childSpriteFolderName = { "Object", "Tileset", "UI" };
        private const string scriptFolderName = "_Project/Scripts";
        private static string[] childScriptFolderName = { "Player", "Enemies", "UI" };
        [MenuItem("Tools/Create Default Folder")]
        public static void CreateDefaultFolder()
        {
            CreateSubFolder(rootFolderName, childRootFolderName);
            CreateSubFolder(spriteFolderName, childSpriteFolderName);
            CreateSubFolder(scriptFolderName, childScriptFolderName);
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