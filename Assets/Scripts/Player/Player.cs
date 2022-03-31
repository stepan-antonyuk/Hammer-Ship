using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

     // Physics
    public Rigidbody2D rigidBody2D;

    // User state
    private float _walkSpeed = 200f;
    private float _stairsSpeed = 0.5f;
    private float _runSpeed = 2f;
    private float _jumpForce = 100f;
    public Vector2 Direction; //{ get; set; }
    public Vector2 Speed; //{ get; set; }
    
    //Multipliers
    private float SpeedMultiplier = 1f;
    private float StairsMultiplier = 1f;
    private float RunMultiplier = 1f;

    // Update is called once per frame
    void Update()
    {
        //Update variables
        //Direction.x = 0f;
    
        //Input   
        //Direction = Direction.normalized;
    
        //Calculation
        //Speed = Direction * _walkSpeed;
    }
    
    void FixedUpdate()
    {
        //Vector2 deltaPosition = Speed * Time.fixedDeltaTime * 100f;
        //rigidBody2D.MovePosition(deltaPosition);
        //rigidBody2D.AddForce(deltaPosition);
        //Debug.Log(deltaPosition);
        
        //Vector2 velocity = Speed * Time.fixedDeltaTime * 100f; //TODO get rid of 100f
        //ApplyForceToReachVelocity(rigidBody2D, velocity, 10); // TODO get rid of 10
    }
    
    public static void ApplyForceToReachVelocity(Rigidbody2D rigidbody2D, Vector2 velocity, float force = 1, ForceMode2D mode = ForceMode2D.Force)
    {
        if (force == 0 || velocity.magnitude == 0)
            return;

        velocity = velocity + velocity.normalized * 0.2f * rigidbody2D.drag;

        //force = 1 => need 1 s to reach velocity (if mass is 1) => force can be max 1 / Time.fixedDeltaTime
        force = Mathf.Clamp(force, -rigidbody2D.mass / Time.fixedDeltaTime, rigidbody2D.mass / Time.fixedDeltaTime);

        //dot product is a projection from rhs to lhs with a length of result / lhs.magnitude https://www.youtube.com/watch?v=h0NJK4mEIJU
        if (rigidbody2D.velocity.magnitude == 0)
        {
            rigidbody2D.AddForce(velocity * force, mode);
        }
        else
        {
            var velocityProjectedToTarget = (velocity.normalized * Vector2.Dot(velocity, rigidbody2D.velocity) / velocity.magnitude);
            rigidbody2D.AddForce((velocity - velocityProjectedToTarget) * force, mode);
        }
    }
     
    public void Move(float direction)
    {
        Direction.x = direction;
        Direction = Direction.normalized;
        Speed = Direction * _walkSpeed;
        Vector2 velocity = Speed * Time.fixedDeltaTime; //TODO get rid of 100f 
        ApplyForceToReachVelocity(rigidBody2D, velocity, 10); // TODO get rid of 10
        Direction.x = 0f;
    }    
    
    public void Jump()
    {
        Direction.y = 1f;
        Direction = Direction.normalized;
        Speed = Direction * _jumpForce;
        Vector2 jumpingForce = Speed * Time.fixedDeltaTime;
        rigidBody2D.AddForce(jumpingForce);
        Direction.y = 0f;
    }
}
