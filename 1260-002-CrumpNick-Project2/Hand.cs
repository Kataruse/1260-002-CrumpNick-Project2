/**
*--------------------------------------------------------------------
* File name: Hand.cs
* Project name: 1260-002-CrumpNick-Project2
*--------------------------------------------------------------------
* Author’s name and email: Nick Crump, CRUMPNA@ETSU.ED
* Course-Section: CSCI 1260-002
* Creation Date: 2/15/2023
* -------------------------------------------------------------------
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1260_002_CrumpNick_Project2
{
    internal class Hand
    {
        private Card[] _gameHand;
        private int _handSize;
        private int _cardsInHand;

        public Hand()
        {
            _handSize = 5;
            _gameHand = new Card[5];
            _cardsInHand = 0;
        }

        public Hand(int handSize)
        {
            if (handSize >= 1 && handSize <= 52)
            {
                _handSize = handSize;
            }
            else
            {
                _handSize = 5;
            }
            _gameHand = new Card[_handSize];
            _cardsInHand = 0;
        }

        public Hand(Hand existingHand)
        {
            _handSize = existingHand._handSize;
            _cardsInHand = existingHand._cardsInHand;
            for (int i = 0; i < _gameHand.Length; i++)
            {
                _gameHand[i] = existingHand._gameHand[i];
            }
        }

        public void AddACard(Card card)
        {
            if (_cardsInHand < _handSize)
            {
                _gameHand[_cardsInHand] = card;
                _cardsInHand++;
            }
            return;
        }

        public string ToString()
        {
            string hand = "";
            for (int i = 0; i < _handSize; i++)
            {
                hand = hand + _gameHand[i].ToString();
                if (i + 1 < _handSize)
                {
                    hand = hand + ",\n";
                }
            }
            return hand;
        }

    }
}
