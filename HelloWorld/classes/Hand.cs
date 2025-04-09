using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BlackJack.classes
{
    public class Hand
    {
        List<Card> cards = new List<Card>();
        System.Windows.Forms.Label label;
        System.Windows.Forms.Label label2;
 
        public Hand(System.Windows.Forms.Label label, System.Windows.Forms.Label label2)
        {
            this.label = label;//card1
            this.label2 = label2;//card2
        }

        public void recieveCard(Card card)
        {//giving the cards 
            cards.Add(card);
            this.label.Text = cards[0].ToString();
            
            if(cards.Count >= 2 ) 
            {
                this.label2.Text = cards[1].ToString();
            }
        }

        public bool Natural()
        {
            //the player has 2 cards
            //if one of the cards faceValue == 10
            //and the second cards faceValue == 11
            //the player has Natural

            if (cards.Count == 2)
            {
                if (cards[0].Value == 10 && cards[1].Value == 11 || cards[0].Value == 11 && cards[1].Value == 10)
                {
                   return true;
                }
            }

            return false;
        }
        
    }
}
