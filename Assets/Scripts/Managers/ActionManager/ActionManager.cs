using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
 
public static class ActionManager
{
    static Dictionary<KeyCode, string> keyMapping;
    public static KeyCode[] keyMaps = new KeyCode[7]
    {
        KeyCode.Q,
        KeyCode.E,
        KeyCode.W,
        KeyCode.S,
        KeyCode.A,
        KeyCode.D,
        KeyCode.LeftShift
    };
    static string[] defaults = new string[7]
    {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7"
    };
 
    static ActionManager()
    {
        InitializeDictionary();
        Debug.Log("GIM: Initializetion Finished");
    }
 
    private static void InitializeDictionary()
    {
        keyMapping = new Dictionary<KeyCode, string>();
        for(int i=0;i<keyMaps.Length;++i)
        {
            keyMapping.Add(keyMaps[i], defaults[i]);
        }
    }
    
    public static void DEBUG()
    {
        Debug.Log("=====================================");
        for(int i = 0; i < 7; i++)
        {
            if(Input.GetKey(keyMaps[i]))
            {
                Debug.Log(keyMapping[keyMaps[i]]);
            }
        }
        Debug.Log("=====================================");
    }
}
