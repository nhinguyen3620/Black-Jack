using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project2
{
    public class aShoe : IDrawCard
    {
        private readonly int numOfDecks;
        private List<aCard> shoe = new List<aCard>();

        public aShoe(int numOfDecks = 1, int seedValue = 999)
        {
            this.numOfDecks = numOfDecks;
            for (int i = 0; i < numOfDecks; i++)
            {
                aDeckofCards newDeck = new aDeckofCards();

                shoe.AddRange(newDeck.getDeck());
            }
        }

        public bool isEmptyDeck()
        {
            return shoe.Count == 0 ? true : false;
        }

        public aCard Draw()
        {
            Random random = new Random();
            int val = random.Next(0, shoe.Count);

            aCard drawnCard = shoe[val];
            shoe.RemoveAt(val);

            return drawnCard;
        }
    }
}
