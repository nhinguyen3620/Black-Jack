using System.Drawing;
using System.Windows.Forms;

namespace Project2
{
    public class aCard
    {
        public enum ValueType:int { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, None }
        public enum FaceType { Spades=1, Clubs=2, Diamonds=3, Hearts=4, None=-1 }

        private readonly ValueType value;
        private readonly FaceType face;
        private readonly Image picture;
        public PictureBox card_display;

        public aCard(ValueType value, FaceType face, System.Drawing.Image picture)
        {
            this.value = value;
            this.face = face;
            this.picture = picture;
        }

        public Image getPicture()
        {
            return this.picture;
        }

        public int getValue()
        {
            if (this.value == ValueType.Ace)
                return 11;
            else if (this.value == ValueType.Two)
                return 2;
            else if (this.value == ValueType.Three)
                return 3;
            else if (this.value == ValueType.Four)
                return 4;
            else if (this.value == ValueType.Five)
                return 5;
            else if (this.value == ValueType.Six)
                return 6;
            else if (this.value == ValueType.Seven)
                return 7;
            else if (this.value == ValueType.Eight)
                return 8;
            else if (this.value == ValueType.Nine)
                return 9;
            else if (this.value == ValueType.Ten || this.value == ValueType.Jack || this.value == ValueType.Queen || this.value == ValueType.King) 
                return 10;                
            else
                return 0;       
        }

        public static ValueType calcValue(int val)
        {
            switch (val)
            {
                case 1:
                    return ValueType.Ace;
                case 2:
                    return ValueType.Two;
                case 3:
                    return ValueType.Three;
                case 4:
                    return ValueType.Four;
                case 5:
                    return ValueType.Five;
                case 6:
                    return ValueType.Six;
                case 7:
                    return ValueType.Seven;
                case 8:
                    return ValueType.Eight;
                case 9:
                    return ValueType.Nine;
                case 10:
                    return ValueType.Ten;
                case 11:
                    return ValueType.Jack;
                case 12:
                    return ValueType.Queen;
                case 13:
                    return ValueType.King;
                default:
                    return ValueType.None;

            }
        }

        public static FaceType calcFace(int val)
        {
            switch (val)
            {
                case 1:
                    return FaceType.Spades;
                case 2:
                    return FaceType.Clubs;
                case 3:
                    return FaceType.Diamonds;
                case 4:
                    return FaceType.Hearts;
                default:
                    return FaceType.None;
            }

        }
    }
}
