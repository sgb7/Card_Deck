using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Deck
{
    List<int> cards;

    public IEnumerable<int> GetCards()
    {
        foreach (int i in cards)
        {
            yield return i;
        }
    }

    public void CreateDeck()
    {
        cards.Clear();

        for (int i = 0; i < 52; i++)
        {
            cards.Add(i);
        }
    }

    public void Shuffle()
    {
        int n = cards.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            int temp = cards[k];
            cards[k] = cards[n];
            cards[n] = temp;
        }

    }

    /*void Awake()
    {
        cards = new List<int>();
        CreateDeck();
    }*/



    /*protected LinkedList<CardModel> Cards { get; set; }

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

    public void Shuffle()
    {
        int n = Cards.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            int temp = Cards[k];
            Cards[k] = Cards[n];
            Cards[n] = temp;
        }
    }*/
}
