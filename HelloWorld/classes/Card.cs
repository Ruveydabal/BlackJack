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

     class Card
    {
        Suits suits;
        FaceValues faceValues;
        int value;
        Image img; 

        public Suits Suits 
        {  
            get 
            { 
                return suits; 
            } 
            set
            {
                suits = value;
            }
        }


        public Card(Suits suits, FaceValues faceValues)
        {
            this.suits = suits;
            this.faceValues = new FaceValues();

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
        
        
    }
}
