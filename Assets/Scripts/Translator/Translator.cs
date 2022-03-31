using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translator : MonoBehaviour
{

    private Dictionary<KeyCode, Actions> attributes;
    private List<Actions> events = new List<Actions>(); 
    
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


    // Update is called once per frame
    void Update()
    {
        foreach (var key in attributes.Keys)
        {
            if (Input.GetKey(key))
            {
                //attributes[key].FixedUpdate(); // Update or FixedUpdate
                events.Add(attributes[key]);
            }
        }
    }
    
    void FixedUpdate()
    {
        foreach (var action in events)
        {
            action.Update(); // Update or FixedUpdate
        }
    }
    
}
