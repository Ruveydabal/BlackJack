using BlackJack.classes;
using System.Runtime.CompilerServices;

namespace BlackJack
{
    public partial class Form1 : Form
    {

        Card twoOfHearts = new Card(Suits.HEARTS, FaceValues.TWO);
        Random random = new Random();
        Deck deck = new Deck();

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
            DrawCardText.Text = drawCard.ToString();
        }
    }
}
