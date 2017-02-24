using System;
using UnityEngine;
using System.Collections;
class scriptAsset : MonoBehaviour
{
    public static readonly string BundleURL = "https://dl.dropboxusercontent.com/s/z7atujcvd83tizx/backdrop.1?dl=0";

    private string AssetName = "backdrop";

    IEnumerator Start()
    {
        using (WWW www = new WWW(BundleURL))
        {
            yield return www;
            if (www.error != null)
                throw new Exception("WWW download had an error:" + www.error);
            AssetBundle bundle = www.assetBundle;
            GameObject cube = Instantiate(bundle.LoadAsset(AssetName)) as GameObject;
            cube.transform.position = new Vector3(0f, 0f, 0f);
            bundle.Unload(false);

        }
    }
}
