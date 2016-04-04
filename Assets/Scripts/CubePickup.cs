using UnityEngine;
using System.Collections;

public class CubePickup : MonoBehaviour
{
    /*----Variables----*/

    // The rate at which the cube will rotate
    public float rotationRate = 15.0f;

    // Reference to the box collider
    BoxCollider collisionBox;

    // Reference to the mesh renderer 
    MeshRenderer cubeMesh;

    // Use this for initialization
    void Start()
    {
        // Get the box collider
        collisionBox = GetComponent<BoxCollider>();

        // Get the mesh renderer
        cubeMesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the sphere
        rotateCube();
    }

    // When the player overalps the box collider
    void OnTriggerEnter(Collider other)
    {
        // Disable the cube when the collider is overlaped by the player
        if (other.gameObject.tag == "Player")
        {
            // Disable the cube
            disableCube();
        }
    }

    // Rotate the sphere
    private void rotateCube()
    {
        transform.Rotate(new Vector3(rotationRate * Time.deltaTime, rotationRate * Time.deltaTime, rotationRate * Time.deltaTime));
    }

    // Disable the cube
    private void disableCube()
    {
        // Disable the box collider
        collisionBox.enabled = false;

        // Disable the mesh renderer
        cubeMesh.enabled = false;
    }

    // Enable the cube
    private void enableCube()
    {
        // Enable the box collider
        collisionBox.enabled = true;

        // Enable the mesh renderer
        cubeMesh.enabled = true;
    }

}
