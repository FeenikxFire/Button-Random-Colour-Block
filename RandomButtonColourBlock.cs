using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomButtonColourBlock : MonoBehaviour
{
    [Tooltip("Colourblocks you wish the button to choose from. Don't forget to set Alpha, Colour Multiplier & Fade Duration")]
    public ColorBlock[] myColourBlocks; //Manually pick colours.

    private Button myButton;    //Fills on Start();

    private int random; //Used to decide which colourblock will be chosen.

    // Use this for initialization
    void Start()
    {
        myButton = GetComponent<Button>();
        RollRandomHighlightColour();
    }

    public void RollRandomHighlightColour()
    {
        random = Random.Range(0, myColourBlocks.Length);
        myButton.colors = myColourBlocks[random];
    }
}
