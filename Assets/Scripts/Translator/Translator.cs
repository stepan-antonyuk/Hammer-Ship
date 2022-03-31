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


    // Update is called once per frame
    void Update()
    {
        foreach (var key in ActionManager.keyMaps)
        {
            if (Input.GetKey(key))
            {
                attributes[key].FixedUpdate(); // Update or FixedUpdate
            }
        }
    }
    
}

/*
public interface Action
{
    void Update();
}

public class Move : Action
{
    void Action.Update()
    {
        Debug.Log("Move");
    }
}

public class Jump : Action
{
    void Action.Update()
    {
        Debug.Log("Jump");
    }
}

public class Turn : Action
{
    void Action.Update()
    {
        Debug.Log("Turn");
    }
}
*/

