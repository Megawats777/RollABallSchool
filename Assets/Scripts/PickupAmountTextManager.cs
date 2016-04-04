using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PickupAmountTextManager : MonoBehaviour
{
    /*----Variables----*/

    // Reference to the CubeGameManager
    CubeGameManager cubeGameManagerRef;

    // Reference to the text component
    Text pickupAmountText;

	// Use this for initialization
	void Start ()
    {
        // Get the CubeGameManager
        cubeGameManagerRef = FindObjectOfType<CubeGameManager>();

        // Get the text component
        pickupAmountText = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        // Update the content of the text component
        setContent();
    }

    // Update the content of the text component
    private void setContent()
    {
        // If there is more than zero cubes then show the number of cubes remaining
        if (cubeGameManagerRef.levelPickupsAmount > 0)
        {
            pickupAmountText.text = "" + cubeGameManagerRef.levelPickupsAmount.ToString() + " Remaining";
        }

        // If there are no cubes remaining then show no text on the text component
        else if (cubeGameManagerRef.levelPickupsAmount < 1)
        {
            pickupAmountText.text = null;
        }
    }

}
