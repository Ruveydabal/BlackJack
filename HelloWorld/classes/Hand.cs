﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BlackJack.classes
{
    public class Hand
    {
        List<Card> cards = new List<Card>();
        Label label;
        Label label2;
 
        public Hand(Label label, Label label2)
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
            //the player has Natural
            if (cards[0].Value == 10 && cards[1].Value == 11 || cards[0].Value == 11 && cards[1].Value == 10)
            {
                System.Diagnostics.Debug.WriteLine("Natural in class Hand");
                return true;
            }//the player does not have Natural
            else
            {
                System.Diagnostics.Debug.WriteLine("no Natural in class Hand");
                return false;
            }            
        }
        
    }
}
