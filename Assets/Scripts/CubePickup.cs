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

}
