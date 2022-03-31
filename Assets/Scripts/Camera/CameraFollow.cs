using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Player;
    public float dampTime = 0.4f; // Time it take to raed the player position
    public float zScore = -10f;
    private Vector3 cameraPos;
    private Vector3 velocity = Vector3.zero;
    
    // Update is called once per frame
    void Update()
    {
        cameraPos = new Vector3(Player.position.x, Player.position.y, zScore);   
        transform.position = Vector3.SmoothDamp(gameObject.transform.position, cameraPos, ref velocity, dampTime); 
    }
}
