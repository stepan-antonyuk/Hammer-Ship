using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
 
public class ActionManagerV2
{
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
    
    public static Dictionary<KeyCode, Actions> attributes;   
    
    // Start is called before the first frame update
    void Start()
    {
        attributes = new Dictionary<KeyCode, Actions>() {
            {KeyCode.Q, new Turn()},
            {KeyCode.E, new Turn()},
            {KeyCode.W, new Move()},
            {KeyCode.S, new Move()},
            {KeyCode.A, new Move()},
            {KeyCode.D, new Move()},
            {KeyCode.LeftShift, new Jump()}
        };
    }
}
