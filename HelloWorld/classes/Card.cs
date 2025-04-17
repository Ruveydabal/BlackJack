
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
        Image img; //I don't use it.

        public Suits Suits { get { return suits; } }
        public int Value { get { return value; } }
        public bool ShowFaceValue { get { return showFaceValue;} }

        public Card(Suits suits, FaceValues faceValues)
        {
            this.suits = suits;
            this.faceValues = faceValues;

            switch(faceValues)
            {//Changes the faceValues of the cards.
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
        {//when you use this function you get to see the value of the card
            showFaceValue = true;
        }

        public override string ToString()
        {//Returns facevalue and the suit of the card
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
