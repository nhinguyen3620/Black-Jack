using System;
using System.Collections.Generic;

namespace Project2
{
    public class aDeckofCards : IDrawCard
    {
        private List<aCard> deck = new List<aCard>();

        public aDeckofCards()
        {
            for (int i = 0; i < 52; i++)
            {
                aCard.ValueType value = aCard.calcValue((i % 13) + 1);
                aCard.FaceType face = aCard.calcFace((i % 4) + 1);

                deck.Add(new aCard(value, face, null));
            }
        }

        public aCard Draw()
        {
            Random r = new Random();

            int val = r.Next(0, deck.Count);

            aCard drawnCard = deck[val];
            deck.RemoveAt(val);

            return drawnCard;
        }
    }
}
