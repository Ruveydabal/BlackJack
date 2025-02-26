using BlackJack.classes;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        Card twoOfHearts = new Card(Suits.HEARTS, FaceValues.TWO);
        public Form1()
        {
            InitializeComponent();

            Console.WriteLine(twoOfHearts.Suits);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
