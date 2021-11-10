﻿using System;
using System.Collections.Generic;
using Project_1;

namespace Project2
{
    public class aShoe : aRandomVariable, IDrawCard
    {
        private readonly int numOfDecks;
        private List<aCard> shoe = new List<aCard>();
        private Random random;

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

        public int countNumOfCards()
        {
            return shoe.Count;
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
