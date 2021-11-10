using System.Drawing;
using System.Windows.Forms;

namespace Project2
{
    /// <summary>
    /// aCard class
    /// </summary>
    public class aCard
    {
        //create enum for Value and Face of cards
        public enum ValueType { Ace=11, Two=2, Three=3, Four=4, Five=5, Six=6, Seven=7, Eight=8, Nine=9, Ten=10, Jack=10, Queen=10, King=10, None=-1 }
        public enum FaceType { Spades=1, Clubs=2, Diamonds=3, Hearts=4, None=-1 }

        private readonly ValueType value;
        private readonly FaceType face;
        private readonly Image picture;
        public PictureBox card_display = null;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="value"></param>
        /// <param name="face"></param>
        /// <param name="picture"></param>
        public aCard(ValueType value, FaceType face, System.Drawing.Image picture)
        {
            this.value = value;
            this.face = face;
            this.picture = picture;
        }

        /// <summary>
        /// get picture method
        /// </summary>
        /// <returns></returns>
        public Image getPicture()
        {
            return this.picture;
        }

        /// <summary>
        /// get value method
        /// </summary>
        /// <returns></returns>
        public int getValue()
        {
            return (int)this.value;
        }

        /// <summary>
        /// return card value method
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
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

        /// <summary>
        /// return card face method
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
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
