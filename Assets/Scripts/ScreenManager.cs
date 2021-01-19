using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    public static void TransitScreen(string openScreenName, string closeScreenName)
    {
        GameObject closeScreen = GameObject.Find(closeScreenName);
        Destroy(closeScreen);
        
        GameObject openScreen = Resources.Load<GameObject>("UIPanels/" + openScreenName);
        GameObject parentContainer = GameObject.Find("Canvas");

        var child = Instantiate(openScreen, parentContainer.transform);
    }

}
