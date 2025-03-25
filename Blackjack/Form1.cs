using Blackjack.Game;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        private Deck deck = new Deck();
        private bool divideCardInstance = false;
        private Card pulledCard; private Player player1; private Player player2; private Player player3; private Player player4;
        private Player dealer = new Player(true);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Hide();
            label3.Hide();
            label2.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            button6.Hide();
            label9.Hide();
            button7.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card kaart = deck.pullCard();
            label2.Show();
            label2.Text = kaart.toString();
            pulledCard = kaart;
            divideCard();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (divideCardInstance)
            {
                player2.addCard(pulledCard);
                label11.Show();
                label11.Text = player2.getCards();
                label2.Hide();
                button2.Hide(); button3.Hide(); button4.Hide(); button5.Hide(); button7.Hide(); label9.Hide();
            }
            else
            {
                Player playerFirst = new Player(false);
                player1 = playerFirst;
                Player playerSecond = new Player(false);
                player2 = playerSecond;
                label5.Show(); label6.Show();
                gameStart();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (divideCardInstance)
            {
                player1.addCard(pulledCard);
                label10.Show();
                label10.Text = player1.getCards();
                label2.Hide();
                button2.Hide(); button3.Hide(); button4.Hide(); button5.Hide(); button7.Hide(); label9.Hide();
            }
            else
            {
                Player playerFirst = new Player(false);
                player1 = playerFirst;
                label5.Show();
                gameStart();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (divideCardInstance)
            {
                player3.addCard(pulledCard);
                label12.Show();
                label12.Text = player3.getCards();
                label2.Hide();
                button2.Hide(); button3.Hide(); button4.Hide(); button5.Hide(); button7.Hide(); label9.Hide();
            }
            else
            {
                Player playerFirst = new Player(false);
                player1 = playerFirst;
                Player playerSecond = new Player(false);
                player2 = playerSecond;
                Player playerThird = new Player(false);
                player3 = playerThird;
                label5.Show(); label6.Show(); label7.Show();
                gameStart();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (divideCardInstance)
            {
                player4.addCard(pulledCard);
                label13.Show();
                label13.Text = player4.getCards();
                label2.Hide();
                button2.Hide(); button3.Hide(); button4.Hide(); button5.Hide(); button7.Hide(); label9.Hide();
            }
            else
            {
                Player playerFirst = new Player(false);
                player1 = playerFirst;
                Player playerSecond = new Player(false);
                player2 = playerSecond;
                Player playerThird = new Player(false);
                player3 = playerThird;
                Player playerFour = new Player(false);
                player4 = playerFour;
                label5.Show(); label6.Show(); label7.Show(); label8.Show();
                gameStart();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public void gameStart()
        {
            label4.Hide();
            button2.Hide(); button3.Hide(); button4.Hide(); button5.Hide();
            label3.Show(); button1.Show(); button6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            deck.shuffleDeck();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            dealer.addCard(pulledCard);
            label14.Show();
            label14.Text = dealer.getCards();
            label2.Hide();
            button2.Hide(); button3.Hide(); button4.Hide(); button5.Hide(); button7.Hide(); label9.Hide();
        }
        public void divideCard()
        {
            button2.Show(); button3.Show(); button4.Show(); button5.Show(); button7.Show(); label9.Show();
            divideCardInstance = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
