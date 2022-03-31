using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    
    // User state
    public float _walkSpeed = 80f; // letter change to private

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void FixedUpdate()
    {
        
    }
    
    public void Move(float direction)
    {
        controller.Move(direction * _walkSpeed * Time.fixedDeltaTime, false, false); //fixedDeltaTime for FixedUpdate and deltaTime for Update
    }    
    
    public void Jump()
    {
        controller.Move(0f, false, true);
    }
}
