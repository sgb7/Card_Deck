using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Deck
{
    protected LinkedList<CardModel> Cards { get; set; }

    public Deck()
    {
        Cards = new LinkedList<CardModel>();
    }

    public void AddToTop(CardModel card)
    {
        Cards.AddLast(card);
    }

    public CardModel RemoveFromTop()
    {
        CardModel topCard = Cards.Last();
        Cards.RemoveLast();
        return topCard;

    }

    void Shuffle<T>(List<T> list)
    {
        System.Random random = new System.Random();
        int n = list.Count;
        while (n > 1)
        {
            int k = random.Next(n);
            n--;
            T temp = list[k];
            list[k] = list[n];
            list[n] = temp;
        }
    }

}
