using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translator : MonoBehaviour
{

    private Dictionary<KeyCode, Actions> attributes;
    
    // Start is called before the first frame update
    void Start()
    {
        attributes = new Dictionary<KeyCode, Actions>() {
            {KeyCode.Q, new Turn()},
            {KeyCode.E, new Turn()},
            {KeyCode.W, new Move()},
            {KeyCode.S, new Move()},
            {KeyCode.A, new Move(-1f)},
            {KeyCode.D, new Move(1f)},
            {KeyCode.LeftShift, new Jump()}
        };
    }
    
    void FixedUpdate()
    {
        foreach (var key in attributes.Keys)
        {
            if (Input.GetKey(key))
            {
                attributes[key].Update();
            }
        }
    }
    
}
