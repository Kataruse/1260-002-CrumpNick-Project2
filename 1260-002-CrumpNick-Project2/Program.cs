/**
*--------------------------------------------------------------------
* File name: Program.cs
* Project name: 1260-002-CrumpNick-Project2
*--------------------------------------------------------------------
* Author’s name and email: Nick Crump, CRUMPNA@ETSU.ED
* Course-Section: CSCI 1260-002
* Creation Date: 2/13/2023
* -------------------------------------------------------------------
*/

namespace _1260_002_CrumpNick_Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Lab 3 Program.cs
            Deck deck = new Deck();
            Console.WriteLine("--------------------DECK--------------------");
            Console.WriteLine(deck.ToString() + "\n");

            Console.WriteLine("--------------------SHUFFLED DECK--------------------");
            deck.Shuffle();
            Console.WriteLine(deck.ToString() + "\n");

            Deck deckNew = deck;
            Console.WriteLine("--------------------HAND 1 OF COPIED DECK--------------------");
            Console.WriteLine(deckNew.DealAHand(7).ToString());

            Console.WriteLine("--------------------HAND 2 OF COPIED DECK--------------------");
            Console.WriteLine(deckNew.DealAHand(7).ToString() + "\n");

            Console.Write("Press Enter to Continue: ");
            Console.ReadLine();
            Console.Clear();

            int players;
            int handSize;
            Hand uHand;
            //loops the user picking the # of cards and handsize till its within 52
            while (true) 
            {
                //loops until the user picks a integer for handsize
                while (true) 
                {
                    Console.Write("How Many Cards are in One Hand?: ");
                    try
                    {
                        handSize = Convert.ToInt32(Console.ReadLine());
                        uHand = new Hand(handSize);
                        Console.Clear();
                        break;
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("ERROR - handSize is not set to a integer!");
                    }
                }
                //loops until the user picks a integer for the # of players
                while (true)
                {
                    Console.Write("How Many Players are there?: ");
                    try
                    {
                        players = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        break;
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("ERROR - players is not set to a integer!");
                    }                    
                }
                if (52 - (players * handSize) >= 0)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"ERROR - not enough cards in the deck for {players} players to have {handSize} each!");
                }
            }
            deck.Shuffle();
            for (int i = 0; i < players; i++)
            {
                Console.WriteLine($"--------------------PLAYER {i + 1}'S HAND--------------------");
                Console.WriteLine(deck.DealAHand(handSize).ToString());
            }
        }
    }
}