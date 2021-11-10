using System;
using System.Collections.Generic;
using Project_1;

namespace Project2
{
    /// <summary>
    /// aShoe class inherits from aRandomVariable and IDrawCard
    /// </summary>
    public class aShoe : aRandomVariable, IDrawCard
    {
        private readonly int numOfDecks;
        private List<aCard> shoe = new List<aCard>();
        private Random random;

        /// <summary>
        /// constructor of aShoe
        /// </summary>
        /// <param name="rand"></param>
        /// <param name="numOfDecks"></param>
        public aShoe(Random rand, int numOfDecks = 1)
        {
            this.random = rand;

            this.numOfDecks = numOfDecks;
            for (int i = 0; i < numOfDecks; i++)
            {
                aDeckofCards newDeck = new aDeckofCards();

                shoe.AddRange(newDeck.getDeck());
            }
        }

        /// <summary>
        /// return the number of cards method
        /// </summary>
        /// <returns></returns>
        public int countNumOfCards()
        {
            return shoe.Count;
        }

        /// <summary>
        /// method to check if deck is empty
        /// </summary>
        /// <returns></returns>
        public bool isEmptyDeck()
        {
            return shoe.Count == 0 ? true : false;
        }

        /// <summary>
        /// draw card method
        /// </summary>
        /// <returns></returns>
        public aCard Draw()
        {
            int val = random.Next(0, shoe.Count);

            aCard drawnCard = shoe[val];
            shoe.RemoveAt(val);

            return drawnCard;
        }
    }
}
