using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Actions
{
    void Update(); // Update or FixedUpdate
}

public class Move : Actions
{  
    private float direction;
    public GameObject player = GameObject.Find("Player");
    
    public Move(float direction)
    {
        this.direction = direction;
    }
    
    public Move()
    {
        this.direction = 0f;
    }
    
    void Actions.Update()
    {
        Debug.Log("Move");
        player.GetComponent<Player>().Move(direction);
    }
}

public class Jump : Actions
{
    public GameObject player = GameObject.Find("Player");
    
    void Actions.Update()
    {
        Debug.Log("Jump");
        player.GetComponent<Player>().Jump();
    }
}

public class Turn : Actions
{
    void Actions.Update()
    {
        Debug.Log("Turn");
    }
}
