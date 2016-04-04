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

    // Perform the sphere's movement
    private void sphereMovement()
    {
        // Push the sphere forward
        pushForward();

        // Push the sphere backwards
        pushBackwards();

        // Push the sphere to the right
        pushLeft();

        // Push the sphere to the left
        pushRight();
    }

    // Push the sphere forward
    private void pushForward()
    {
        // If the player is pressing the push forward button
        if (Input.GetButton("Push Forward"))
        {

        }


    }

    // Push the sphere backwards
    private void pushBackwards()
    {
        // If the player is pressing the push backward button
        if (Input.GetButton("Push Backward"))
        {

        }

    }

    // Push the sphere to the right
    private void pushRight()
    {
        // If the player is pressing the push right button
        if (Input.GetButton("Push Right"))
        {

        }

    }

    // Push the sphere to the left
    private void pushLeft()
    {
        // If the player is pressing the push left button
        if (Input.GetButton("Push Left"))
        {

        }
    }
}
