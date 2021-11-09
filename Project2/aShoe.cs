using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project2
{
    public class aShoe : IDrawCard
    {
        private readonly int numOfDecks;
        private List<aCard> shoe = new List<aCard>();
        private Random random;

        public aShoe(Random random, int numOfDecks = 1, int seedValue = 999)
        {
            this.random = random;

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
            int val = random.Next(0, shoe.Count);

            aCard drawnCard = shoe[val];
            shoe.RemoveAt(val);

            return drawnCard;
        }
    }
}
