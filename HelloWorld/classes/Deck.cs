
namespace BlackJack.classes
{
    public class Deck
    {
        List<Card> cards = new List<Card>();
        Card card;

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
        {// the cards get a random order 
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

        public Card DrawCard()
        {
            if (cards.Count <= 0)
            {
                 
                 return null;
            }

            Card drawCard = cards[0];
            cards.RemoveAt(0);
            return drawCard;
        }
    }
}