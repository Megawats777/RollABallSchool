using UnityEngine;
using System.Collections;

public class CubeGameManager : MonoBehaviour
{
    /*----Variables----*/

    // References to the cube pickups in the level
    CubePickup[] levelPickups;

    // Reference to the player sphere
    PlayerSphere playerSphereRef;

    // The number of cubes in the level
    [HideInInspector]
    public int levelPickupsAmount = 0;

    // The original amount of level pickups
    private int originalLevelPickupsAmount = 0;

    // The delay until the player restarts
    public float restartDelay = 1.5f;

	// Use this for initialization
	void Start ()
    {
        // Reference all the pickups
        getPickups();

        // Set the amount of pickups in the level
        setPickupAmount();

        // Get the player sphere
        playerSphereRef = FindObjectOfType<PlayerSphere>();

        originalLevelPickupsAmount = levelPickupsAmount;

    }

    // Update is called once per frame
    void Update ()
    {
        // Check for the amount of pickups in the level
        pickupAmountCheck();
    }

    // Reference all the pickups
    private void getPickups()
    {
        levelPickups = FindObjectsOfType<CubePickup>();
    }

    // Set the amount of pickups in the level
    private void setPickupAmount()
    {
        foreach(CubePickup pickup in levelPickups)
        {
            levelPickupsAmount++;
        }

        // Debug Statement
        print("There are " + levelPickupsAmount.ToString() + " pickups");
    }

    // Check for the amount of pickups in the level
    private void pickupAmountCheck()
    {
        // If there were less than 1 pickup restart the game
        if (levelPickupsAmount < 1)
        {
            StartCoroutine(restartGame());
        }
    }

    // Renable all the pickups in the level
    private void renableLevelPickups()
    {
        int pickupIndex = 0;

        foreach (CubePickup pickups in levelPickups)
        {
            levelPickups[pickupIndex].enableCube();
            pickupIndex++;
        }
    }

    // Reset the player's location
    private IEnumerator resetPlayerPosition()
    {
        // Reset the player's location to the origin point of the level
        playerSphereRef.transform.position = new Vector3(0.0f, 1.991f, 0.0f);

        // Reset the player's rotation
        playerSphereRef.transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);

        yield return new WaitForSeconds(0.1f);

        // Allow the player to move
        playerSphereRef.canMove = true;
    }

    // Restart the game
    IEnumerator restartGame()
    {
        yield return new WaitForSeconds(1.0f);

        // Do not allow the player to move
        playerSphereRef.canMove = false;

        yield return new WaitForSeconds(restartDelay);

        // Reset the amount of pickups in the level
        levelPickupsAmount = originalLevelPickupsAmount;

        // Renable all the pickups in the level
        renableLevelPickups();

        // Reset the player's location
        StartCoroutine(resetPlayerPosition());
    }

}
