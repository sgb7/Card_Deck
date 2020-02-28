using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    CardModel cardModel;
    Deck deck;
    int cardIndex = 0;

    public GameObject card;

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 50, 150, 28), "Add Deck"))
        {

        }

        if (GUI.Button(new Rect(10, 130, 150, 28), "Draw From Bottom"))
        {

        }

        if (GUI.Button(new Rect(10, 90, 150, 28), "Draw From Top"))
        {

        }

        if (GUI.Button(new Rect(10, 10, 150, 28), "Shuffle"))
        {
            //deck.Shuffle();
        }
    }


}
