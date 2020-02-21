using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestShuffle : MonoBehaviour
{
    CardModel cardModel;
    int cardIndex = 0;

    public GameObject card;

    void OnGUI()
    {
        if(GUI.Button(new Rect(10, 10, 100, 28), "Shuffle"))
        {

        }
    }
}
