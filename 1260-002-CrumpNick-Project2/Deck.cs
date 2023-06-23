/**
*--------------------------------------------------------------------
* File name: Deck.cs
* Project name: 1260-002-CrumpNick-Project2
*--------------------------------------------------------------------
* Author’s name and email: Nick Crump, CRUMPNA@ETSU.ED
* Course-Section: CSCI 1260-002
* Creation Date: 2/13/2023
* -------------------------------------------------------------------
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _1260_002_CrumpNick_Project2
{
    internal class Deck
    {
        private Card[] _deckCards;
        private int _nextCard;

        public Deck()
        {
            _deckCards = new Card[52];
            for (int i = 0; i < _deckCards.Length; i++)
            {
                _deckCards[i] = new Card(i);
            }
            _nextCard = 0;
        }

        public Deck(Deck existingDeck)
        {
            for (int i = 0; i < _deckCards.Length; i++)
            {
                _deckCards[i] = existingDeck._deckCards[i];
            }
            _nextCard = existingDeck._nextCard;
        }

        public void Shuffle()
        {
            _nextCard = 0;
            Random rand = new Random();
            int randNum = 0;
            Card tempCard = new Card();
            for (int i = 0; i < _deckCards.Length; i++)
            {
                randNum = rand.Next(0, 52);
                tempCard = _deckCards[randNum];
                _deckCards[randNum] = _deckCards[i];
                _deckCards[i] = tempCard;
            }
        }

        public Card DealACard()
        {
            Card card = _deckCards[_nextCard];
            _nextCard++;
            return card;
        }

        public Hand DealAHand(int handSize)
        {
            Hand hand = new Hand(handSize);
            for (int i = 0; i < handSize; i++)
            {
                hand.AddACard(DealACard());
            }
            return hand;
        }

        public string ToString()
        {
            string cards = "";
            for (int i = 0; i < _deckCards.Length; i++)
            {
                cards = cards + _deckCards[i].ToString();
                if (i < 51)
                {
                    cards = cards + ",\n";
                }
            }
            return cards;
        }
    }
}
