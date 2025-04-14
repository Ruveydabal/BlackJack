
namespace BlackJack.classes
{
    public class Player
    {
        Hand hand;
       
        public Player(Label label, Label label2) 
        {
            hand = new Hand(label, label2);
        }

        public void recieveCard(Card card)
        {
            hand.recieveCard(card);
        }

       public bool Natural()
        {
            if (hand.Natural() == true)
            {//Has Natural
                return true;
            }

            else
            {//Does not have Natural
                return false;
            }
            
        }
    }
}
