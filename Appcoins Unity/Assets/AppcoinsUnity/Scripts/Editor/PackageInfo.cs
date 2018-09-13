using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageInfo : MonoBehaviour {

    public static string GetPackageName()
    {
        return "AppCoins_Unity_Package_5_6";
    }

    public static bool ShouldCopyToMainRepo()
    {
    	return false;
    }
}
