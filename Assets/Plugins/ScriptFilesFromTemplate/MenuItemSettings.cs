using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Sh1ch.Plugins
{
    static internal class MenuItemSettings
    {
        private const string PLUGIN_PATH = "Assets/Plugins/ScriptFilesFromTemplate/";
        private const string NEW_FILENAME = "NewFile.cs";

        private const string MENU_ITEM_ROOT = "Assets/Create/Add Script Files/";

        private const string SimpleScript = "Simple Script";
        private const string MonoBehaviour = "MonoBehaviour";
        private const string MonoBehaviourWithUniRx = "MonoBehaviour (UniRx)";

        [MenuItem(MENU_ITEM_ROOT + SimpleScript)]
        private static void CreateSimpleScript() => CreateScriptFile("SimpleScript.txt", NEW_FILENAME);

        [MenuItem(MENU_ITEM_ROOT + MonoBehaviour)]
        private static void CreateMonoBehaviour() => CreateScriptFile("TemplateMonoBehaviour.txt", NEW_FILENAME);

        [MenuItem(MENU_ITEM_ROOT + MonoBehaviourWithUniRx)]
        private static void CreateMonoBehaviourWithUniRx() => CreateScriptFile("TemplateMonoBehaviourWithUniRx.txt", NEW_FILENAME);

        private static void CreateScriptFile(string templateFileName, string newFileName)
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(System.IO.Path.Combine(PLUGIN_PATH, $"Templates/{templateFileName}"), newFileName);
        }
    }
}