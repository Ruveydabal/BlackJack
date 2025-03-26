using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.classes
{
   
    public enum Suits
    {
        CLUBS,
        DIAMONDS,
        HEARTS,
        SPADES
    }

    public enum FaceValues
    {
        ACE = 1, 
        TWO, 
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        TEN,
        JACK,
        QUEEN,
        KING
    }

     public class Card
    {
        bool showFaceValue = false;
        Suits suits;
        FaceValues faceValues;
        int value;
        Image img; 

        public Suits Suits { get { return suits; } }
        public int Value { get { return value; } }
        public bool ShowFaceValue { get { return showFaceValue; } }

        public Card(Suits suits, FaceValues faceValues)
        {
            this.suits = suits;
            this.faceValues = faceValues;

            switch(faceValues)
            {
                case FaceValues.ACE:
                    this.value = 11;
                    break;
                    case FaceValues.TEN:
                    case FaceValues.JACK:
                    case FaceValues.QUEEN:
                    case FaceValues.KING:
                        this.value = 10;
                        break;
                    default:
                        this.value = (int)faceValues;
                        break;
            }
        }

        public void Flip()
        {
            showFaceValue = true;
        }
        public override string ToString()
        {
            if (showFaceValue == true)
            {
                return this.faceValues + " of " + this.suits;
            }
            else
            {
                return "The value is hidden";
            }
       
        }

    }
}
