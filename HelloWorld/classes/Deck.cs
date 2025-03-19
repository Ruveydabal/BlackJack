using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.classes
{
    public class Deck
    {
        List<Card> cards = new List<Card>();

        public Deck()
        {
           // Creates 52 unique cards

            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (FaceValues faceValue in Enum.GetValues(typeof(FaceValues)))
                {
                    cards.Add(new Card(suit, faceValue));
                }
            }
        }

        public void Shuffle()
        {
            Random random = new Random();

            int cardLength =cards.Count;

            while (cardLength > 1)
            {
                int randomize = random.Next(cardLength--);
                Card temp = cards[cardLength];
                cards[cardLength] = cards[randomize];
                cards[randomize] = temp;
            }   
        }

    }
}

    
