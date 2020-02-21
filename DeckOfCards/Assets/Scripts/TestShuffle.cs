using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO: Refactor so all testing buttons are in one script. (Just do multiple if(GUI.Button)'s in the OnGUI function.

public class TestShuffle : MonoBehaviour
{
    CardModel cardModel;
    int cardIndex = 0;

    public GameObject card;

    void OnGUI()
    {
        if(GUI.Button(new Rect(10, 10, 150, 28), "Shuffle"))
        {

        }
    }
}
