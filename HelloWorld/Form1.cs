using BlackJack.classes;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BlackJack
{
    public partial class Form1 : Form
    {

        Card twoOfHearts = new Card(Suits.HEARTS, FaceValues.TWO);
        Random random = new Random();
        Deck deck = new Deck();
        //List<Card> cards = new List<Card>();
        Player players = new Player();

        

        /*private enum GameStates
        {//need to make a state diagram to use this
            START_GAME,
            SHUFLLE_CARDS,
            DEAL_AT_START,
        }*/

        //for the dealer
        int RoundsWon;
        int RoundsLost;
        int Record;

        public Form1()
        {
            InitializeComponent();

            Console.WriteLine(twoOfHearts.Suits);
        }



        private void ShuffleDeck_Click(object sender, EventArgs e)
        {

            deck.Shuffle();
            System.Diagnostics.Debug.WriteLine("it works");

        }

        private void DrawCard_Click(object sender, EventArgs e)
        {
            Card drawCard = deck.DrawCard();
            drawCard.Flip();
            DrawCardText.Text = drawCard.ToString();
        }

        public void Natural()
        {
        }

        public Card DealCards()
        {
            Card dealFirstCard = deck.DrawCard();
            dealFirstCard.Flip();
            return dealFirstCard;
        }

        private void DealingCardsButton(object sender, EventArgs e)
        {
            Card dealCards = DealCards();
            dealCards.Flip();
            //need to make it so that all the players get a different card and not the same one.

            //Player1Card1.Text = dealCards.ToString();

      
            
        }
    }
}
