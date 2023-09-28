#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CreateHierachyTemplate : MonoBehaviour
{
    private static string[] template = { "=Manager=", "=Enemies=", "=Player=", "=UI=", "=Map=" };

    [MenuItem("Tools/Create Hierachy Template", priority = 1)]
    public static void CreateHierachyTemplateFunc()
    {
        for (int i = 0; i < template.Length; i++)
        {
            new GameObject(template[i]);
        }
    }
} 
#endif
