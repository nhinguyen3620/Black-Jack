using System.Collections.Generic;

namespace Project2
{
    public class aShoe
    {
        private int numOfDecks;
        private List<aDeckofCards> shoe = new List<aDeckofCards>();

        public aShoe(int numOfDecks = 1)
        {
            this.numOfDecks = numOfDecks;
            for (int i = 0; i < numOfDecks; i++)
            {
                shoe.Add(new aDeckofCards());
            }
        }
    }
}
