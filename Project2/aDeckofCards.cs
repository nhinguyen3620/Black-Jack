using System.Collections.Generic;

namespace Project2
{
    public class aDeckofCards
    {
        private readonly List<aCard> deck = new List<aCard>();
         
        public aDeckofCards()
        {
            for (int i = 0; i < 52; i++)
            {
                aCard.ValueType value = aCard.calcValue((i % 13) + 1);
                aCard.FaceType face = aCard.calcFace((i % 4) + 1);

                deck.Add(new aCard(value, face, null));
            }
        }
    }
}
