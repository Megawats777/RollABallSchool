using UnityEngine;
using System.Collections;

public class PlayerSphere : MonoBehaviour
{
    /*----Variables----*/

    // Reference to the rigidbody component
    Rigidbody sphereRb;

    // The amount of force applied to the ball
    public float pushForwardForce = 10.0f;
    public float pushBackwardForce = 10.0f;
    public float pushRightForce = 10.0f;
    public float pushLeftForce = 10.0f;
    public float jumpForce = 10.0f;

    // Can the player sphere jump
    private bool canJump = true;

    // Use this for initialization
    void Start()
    {
        // Get the rigidbody component
        sphereRb = GetComponent<Rigidbody>();

        // Reverse the pushBackward and pushLeft forces
        pushBackwardForce *= -1.0f;
        pushLeftForce *= -1.0f;

    }

    // Update is called once per frame
    void Update()
    {
        // Perform the sphere's movement    
        sphereMovement();
    }

    // If the player hits can object
    void OnCollisionEnter(Collision collision)
    {
        // When the player hits an object allow the player to jump again
        canJump = true;
    }

    // Perform the sphere's movement
    private void sphereMovement()
    {
        // Push the sphere forward
        pushForward();

        // Push the sphere backwards
        pushBackwards();

        // Push the sphere to the right
        pushRight();

        // Push the sphere to the left
        pushLeft();

        // Make the sphere jump
        jump();
    }

    // Push the sphere forward
    private void pushForward()
    {
        // If the player is pressing the push forward button
        if (Input.GetButton("Push Forward"))
        {
            // Push the sphere forwards
            sphereRb.AddForce(0.0f, 0.0f, pushForwardForce);
        }
    }

    // Push the sphere backwards
    private void pushBackwards()
    {
        // If the player is pressing the push backward button
        if (Input.GetButton("Push Backward"))
        {
            // Push the sphere backwards
            sphereRb.AddForce(0.0f, 0.0f, pushBackwardForce);
        }
    }

    // Push the sphere to the right
    private void pushRight()
    {
        // If the player is pressing the push right button
        if (Input.GetButton("Push Right"))
        {
            // Push the sphere to the right
            sphereRb.AddForce(pushRightForce, 0.0f, 0.0f);
        }

    }

    // Push the sphere to the left
    private void pushLeft()
    {
        // If the player is pressing the push left button
        if (Input.GetButton("Push Left"))
        {
            // Push the sphere left
            sphereRb.AddForce(pushLeftForce, 0.0f, 0.0f);
        }
    }

    // Make the sphere jump
    private void jump()
    {
        // If the player is pressing the jump button
        if (Input.GetButtonDown("Jump"))
        {
            // If the player is allowed to jump then jump
            if (canJump == true)
            {
                // Make the sphere jump
                sphereRb.AddForce(0.0f, jumpForce, 0.0f);

                // Allow the player to no longer jump until the sphere collides with another object
                canJump = false;
            }
        }
    }
}
