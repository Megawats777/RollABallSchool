using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NotifyTextManager : MonoBehaviour
{
    /*----Variables----*/

    // Reference to the CubeGameManager
    CubeGameManager cubeGameManagerRef;

    // Reference to the text component
    Text notifyText;

    // Use this for initialization
    void Start()
    {
        // Get the CubeGameManager
        cubeGameManagerRef = FindObjectOfType<CubeGameManager>();

        // Get the notifyTextComponent
        notifyText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // Update the content of the text component
        updateTextContent();
    }

    // Update the content of the text component
    private void updateTextContent()
    {
        // If the amount of pickups in the level is less than one then show you win
        if (cubeGameManagerRef.levelPickupsAmount < 1)
        {
            notifyText.text = "You Win";
        }

        // Otherwise show nothing
        else
        {
            notifyText.text = null;
        }
    }

}
