using UnityEngine;
using System.Collections;

public class PlayerCameraManager : MonoBehaviour
{
    /*----Variables----*/

    // Reference to the player sphere
    PlayerSphere playerSphereRef;

    // The new camera location
    Vector3 cameraLocation = new Vector3(0.0f, 0.0f, 0.0f);

    // The camera distance on the Z axis
    public float cameraDistanceZ = 20.0f;

    // The camera distance on the Y axis
    public float cameraDistanceY = 17.0f;

    // Use this for initialization
    void Start ()
    {
        // Get the PlayerSphere
        playerSphereRef = FindObjectOfType<PlayerSphere>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Set the camera's new location
        setCameraLocation();
	}

    // Set the camera's new location
    private void setCameraLocation()
    {
        // The new camera location on the Z axis
        float newLocationZ = 0.0f;

        newLocationZ = playerSphereRef.transform.position.z - cameraDistanceZ;

        // Set the new camera location
        cameraLocation = new Vector3(playerSphereRef.transform.position.x, cameraDistanceY, newLocationZ);

        // Set the transform position to the new camera location
        transform.position = cameraLocation;

    }

}
