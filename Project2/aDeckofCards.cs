using System;
using System.Drawing;
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

                deck.Add(new aCard(value, face, chooseCard(value + " of "  + face)));
            }
        }

        public List<aCard> getDeck()
        {
            return deck;
        }

        private Image chooseCard(String card)
        {
            switch (card)
            {
                case "Ace of Spades": return Properties.Resources.A_Sp;
                case "Ace of Clubs": return Properties.Resources.A_Club;
                case "Ace of Diamonds": return Properties.Resources.A_Dia;
                case "Ace of Hearts": return Properties.Resources.A_Hrt;
                case "Two of Spades": return Properties.Resources._2_Sp;
                case "Two of Clubs": return Properties.Resources._2_Club;
                case "Two of Diamonds": return Properties.Resources._2_Dia;
                case "Two of Hearts": return Properties.Resources._2_Hrt;
                case "Three of Spades": return Properties.Resources._3_Sp;
                case "Three of Clubs": return Properties.Resources._3_Club;
                case "Three of Diamonds": return Properties.Resources._3_Dia;
                case "Three of Hearts": return Properties.Resources._3_Hrt;
                case "Four of Spades": return Properties.Resources._4_Sp;
                case "Four of Clubs": return Properties.Resources._4_Club;
                case "Four of Diamonds": return Properties.Resources._4_Dia;
                case "Four of Hearts": return Properties.Resources._4_Hrt;
                case "Five of Spades": return Properties.Resources._5_Sp;
                case "Five of Clubs": return Properties.Resources._5_Dia;
                case "Five of Diamonds": return Properties.Resources._5_Dia;
                case "Five of Hearts": return Properties.Resources._5_Hrt;
                case "Six of Spades": return Properties.Resources._6_Sp;
                case "Six of Clubs": return Properties.Resources._6_Club;
                case "Six of Diamonds": return Properties.Resources._6_Dia;
                case "Six of Hearts": return Properties.Resources._6_Hrt;
                case "Seven of Spades": return Properties.Resources._7_Sp;
                case "Seven of Clubs": return Properties.Resources._7_Club;
                case "Seven of Diamonds": return Properties.Resources._7_Dia;
                case "Seven of Hearts": return Properties.Resources._7_Hrt;
                case "Eight of Spades": return Properties.Resources._8_Sp;
                case "Eight of Clubs": return Properties.Resources._8_Club;
                case "Eight of Diamonds": return Properties.Resources._8_Dia;
                case "Eight of Hearts": return Properties.Resources._8_Hrt;
                case "Nine of Spades": return Properties.Resources._9_Sp;
                case "Nine of Clubs": return Properties.Resources._9_Club;
                case "Nine of Diamonds": return Properties.Resources._9_Dia;
                case "Nine of Hearts": return Properties.Resources._9_Hrt;
                case "Ten of Spades": return Properties.Resources._10_Sp;
                case "Ten of Clubs": return Properties.Resources._10_Club;
                case "Ten of Diamonds": return Properties.Resources._10_Dia;
                case "Ten of Hearts": return Properties.Resources._10_Hrt;
                case "Jack of Spades": return Properties.Resources.J_Sp;
                case "Jack of Clubs": return Properties.Resources.J_CLub;
                case "Jack of Diamonds": return Properties.Resources.J_Dia;
                case "Jack of Hearts": return Properties.Resources.J_Hrt;
                case "Queen of Spades": return Properties.Resources.Q_Sp;
                case "Queen of Clubs": return Properties.Resources.Q_Club;
                case "Queen of Diamonds": return Properties.Resources.Q_Dia;
                case "Queen of Hearts": return Properties.Resources.Q_Hrt;
                case "King of Spades": return Properties.Resources.K_Sp;
                case "King of Clubs": return Properties.Resources.K_Club;
                case "King of Diamonds": return Properties.Resources.K_Dia;
                case "King of Hearts": return Properties.Resources.K_Hrt;
                default: return Properties.Resources.A_Sp;
            }
        }
    }
}
