using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;

/*public class ExportAssetBundles : Editor {
    [MenuItem("Assets/Build AssetBundle")]
    static void ExportResource()
    {
        string path = "Assets/AssetBundle/myAssetBundle.unity3d";
        Object[] selection = Selection.GetFiltered(typeof(Object), SelectionMode.DeepAssets);
        BuildPipeline.BuildAssetBundle(Selection.activeObject, selection, path, BuildAssetBundleOptions.CollectDependencies | BuildAssetBundleOptions.CompleteAssets,BuildTarget.Android);
    }
}*/

// C# Example
// Builds an asset bundle from the selected objects in the project view.
// Once compiled go to "Menu" -> "Assets" and select one of the choices
// to build the Asset Bundle
public class BuildAssetBundlesExample : MonoBehaviour
{
    [MenuItem("Example/Build Asset Bundles")]
    static void BuildABs()
    {
        string path = "Assets/AssetBundle/";

        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
        // Put the bundles in a folder called "ABs" within the Assets folder.
        BuildPipeline.BuildAssetBundles(path, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
    }
}
