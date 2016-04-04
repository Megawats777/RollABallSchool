using UnityEngine;
using System.Collections;

public class CubeGameManager : MonoBehaviour
{
    /*----Variables----*/

    // References to the cube pickups in the level
    CubePickup[] levelPickups;

    // The number of cubes in the level
    [HideInInspector]
    public int levelPickupsAmount = 0;

	// Use this for initialization
	void Start ()
    {
        // Reference all the pickups
        getPickups();

        // Set the amount of pickups in the level
        setPickupAmount();
    }

    // Update is called once per frame
    void Update ()
    {
	
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
}
