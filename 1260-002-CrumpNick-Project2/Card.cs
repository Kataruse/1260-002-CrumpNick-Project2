/**
*--------------------------------------------------------------------
* File name: Card.cs
* Project name: 1260-002-CrumpNick-Project2
*--------------------------------------------------------------------
* Author’s name and email: Nick Crump, CRUMPNA@ETSU.ED
* Course-Section: CSCI 1260-002
* Creation Date: 2/6/2023
* -------------------------------------------------------------------
*/
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace _1260_002_CrumpNick_Project2
{
    internal class Card
    {

        //below are the Card parameters
        private Suit suit;
        private Face face;

        //below are the Card constructors
        public Card()
        {
            SetSuit(Suit.Spades);
            SetFace(Face.Ace);
        }

        public Card(int n)
        {
            SetSuit((Suit)Enum.GetValues(typeof(Suit)).GetValue(n % 4));
            SetFace((Face)Enum.GetValues(typeof(Face)).GetValue(n % 13));
        }

        public Card(Card existingCard)
        {
            SetSuit(existingCard.GetSuit());
            SetFace(existingCard.GetFace());
        }

        //below are the card getter and setters
        public Face GetFace()
        {
            return this.face;
        }

        public Suit GetSuit()
        {
            return this.suit;
        }

        public void SetFace(Face face)
        {
            this.face = face;
        }

        public void SetSuit(Suit suit)
        {
            this.suit = suit;
        }

        //below are the Card methods
        public string ToString()
        {
            return $"the {face} of {suit}";
        }
    }
}
