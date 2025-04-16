using BlackJack.classes;

namespace BlackJack
{
    public partial class Form1 : Form
    {

        Card twoOfHearts = new Card(Suits.HEARTS, FaceValues.TWO);
        Random random = new Random();
        Deck deck = new Deck();
        Hand hand;
        //List<Card> cards = new List<Card>();
        Player[] players = new Player[2];




        public enum GameStates
        {//Need to make a state diagram to use this
            //This is the order of how the player has to go about the game.
            SHUFLLE_CARDS,
            DEAL_AT_START,
            CHECK_NATURAL_PLAYER1,
            CHECK_NATURAL_PLAYER2,
            CHECK_NATURAL_DEALER,
        }

        int pointsDealer;
        GameStates currentGameStates = GameStates.SHUFLLE_CARDS;
        public Form1()
        {//BlackJack game
            InitializeComponent();
            players[0] = new Player(Player1Card1, Player1Card2);
            players[1] = new Player(Player2Card1, Player2Card2);
            hand = new Hand(dealerCard1, DealerCard2);
        }

        public void HandleEvent(GameStates gameState)
        {
            if (currentGameStates != gameState)
            {
                pointsDealer--;
            }
            else
            {
                pointsDealer++;
                switch (gameState)
                {
                    case GameStates.SHUFLLE_CARDS:
                        currentGameStates = GameStates.DEAL_AT_START;
                        break;
                    case GameStates.DEAL_AT_START:
                        currentGameStates = GameStates.CHECK_NATURAL_PLAYER1;
                        break;
                    case GameStates.CHECK_NATURAL_PLAYER1:
                        currentGameStates = GameStates.CHECK_NATURAL_PLAYER2;
                        break;
                    case GameStates.CHECK_NATURAL_PLAYER2:
                        currentGameStates = GameStates.CHECK_NATURAL_DEALER;
                        break;
                }
            }

            PointsForDealer.Text = pointsDealer.ToString();
        }

        private void ShuffleDeck_Click(object sender, EventArgs e)
        {
            HandleEvent(GameStates.SHUFLLE_CARDS);
            deck.Shuffle();
            System.Diagnostics.Debug.WriteLine("it works");
        }

        private void DrawCard_Click(object sender, EventArgs e)
        {
            Card drawCard = deck.DrawCard();
            drawCard.Flip();
            DrawCardText.Text = drawCard.ToString();
        }

        public Card DealCards()
        {
            Card dealFirstCard = deck.DrawCard();
            return dealFirstCard;
        }

        private void DealingCardsButton(object sender, EventArgs e)
        {
            //Dealing the cards to the players
            for (int i = 0; i < 2; i++)
            {
                for (int x = 0; x < 2; x++)
                {
                    Card dealingCard = DealCards();
                    dealingCard.Flip();
                    players[i].recieveCard(dealingCard);
                }
            }

            //Dealing the cards to the dealer
            for (int i = 0; i < 1; i++)
            {
                Card dealingCard = DealCards();
                dealingCard.Flip();
                hand.recieveCard(dealingCard);
            }
            Card dealingHiddenCard = DealCards();
            hand.recieveCard(dealingHiddenCard);//second card is hidden
            System.Diagnostics.Debug.WriteLine("You have dealt the cards.");
            HandleEvent(GameStates.DEAL_AT_START);

        }
        public void CheckNatural()
        {//dealer has to check if the hand of the player has a Natural

            if (players[0].Natural() == true)
            {
                System.Diagnostics.Debug.WriteLine("player has natural");
            }
            if (players[1].Natural() == true)
            {
                HandleEvent(GameStates.CHECK_NATURAL_PLAYER2);
                System.Diagnostics.Debug.WriteLine("player has natural");
            }
        }

        private void natural_Click(object sender, EventArgs e)
        {
            CheckNatural();
        }

        private void CheckNaturalPlayer1_Click(object sender, EventArgs e)
        {
            CheckNatural();
            HandleEvent(GameStates.CHECK_NATURAL_PLAYER1);
        }

        private void CheckNaturalPlayer2_Click(object sender, EventArgs e)
        {
            CheckNatural();
            HandleEvent(GameStates.CHECK_NATURAL_PLAYER2);
        }

        private void CheckNaturalDealer_Click(object sender, EventArgs e)
        {
            
        }
    }
}
