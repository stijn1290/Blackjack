using Blackjack.Game;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        private Deck deck = new Deck();
        private int playerIndex = 0;
        private bool divideCardInstance = false; private bool firstRoundPass = false; private bool dealerChoiseInstance = false; private bool resetInstance = false;
        private Card pulledCard; private Player? player1 = null; private Player? player2 = null; private Player? player3 = null; private Player? player4 = null;
        private Player dealer = new Player(true);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Hide();
            pictureBox5.Hide();
            label2.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            button6.Hide();
            button8.Hide();
            label9.Hide();
            button7.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
            label16.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label15.Hide();
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
            if ((player1?.playerWon() ?? false) || (player2?.playerWon() ?? false) || (player3?.playerWon() ?? false) || (player4?.playerWon() ?? false) || (dealer?.playerWon() ?? false))
            {
                newGame();
            }
            if (player1 != null && player1.playerLost())
            {
                playerLost("player1");
            }
            else if (player2 != null && player2.playerLost())
            {
                playerLost("player2");
            }
            else if (player3 != null && player3.playerLost())
            {
                playerLost("player3");
            }
            else if (player4 != null && player4.playerLost())
            {
                playerLost("player4");
            }
            else if (dealer != null && dealer.playerLost())
            {
                playerLost("dealer");
                newGame();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (divideCardInstance)
            {
                player2.addCard(pulledCard);
                player2.setScore(pulledCard.getValue());
                label5.Text = $"{player2.getScore()}";
                label11.Show();
                label11.Text = player2.getCards();
                label2.Hide();
                button2.Hide(); button3.Hide(); button4.Hide(); button5.Hide(); button7.Hide(); label9.Hide();
            }
            else if (dealerChoiseInstance)
            {
                dealer.doubling();
                label14.Text = $"{dealer.getCards()}";
                label8.Text = $"{dealer.getScore()}";
                dealerChoiseInstance = false;
                playerIndex = 1;
                button7.Hide(); button4.Hide(); button3.Hide();
                button7.Text = "dealer"; button3.Text = "2"; button4.Text = "3";
                roundPlayer();
            }
            else if (resetInstance)
            {
                label4.Show(); button2.Show(); button3.Show(); button4.Show(); button5.Show(); label15.Hide();
                button3.Text = "2"; button4.Text = "3"; button8.Text = "Volgende ronde";
                resetInstance = false;
            }
            else
            {
                Player playerFirst = new Player(false);
                player1 = playerFirst;
                Player playerSecond = new Player(false);
                player2 = playerSecond;
                pictureBox1.Show(); pictureBox2.Show();
                label5.Show(); label16.Show();
                label16.Text = $"{player1.getScore()}";
                label5.Text = $"{player2.getScore()}";
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
                player1.setScore(pulledCard.getValue());
                label16.Text = $"{player1.getScore()}";
                label10.Show();
                label10.Text = player1.getCards();
                label2.Hide();
                button2.Hide(); button3.Hide(); button4.Hide(); button5.Hide(); button7.Hide(); label9.Hide();
            }
            else
            {
                Player playerFirst = new Player(false);
                player1 = playerFirst;
                pictureBox1.Show();
                label16.Show();
                label16.Text = $"{player1.getScore()}";
                gameStart();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (divideCardInstance)
            {
                player3.addCard(pulledCard);
                player3.setScore(pulledCard.getValue());
                label6.Text = $"{player3.getScore()}";
                label12.Show();
                label12.Text = player3.getCards();
                label2.Hide();
                button2.Hide(); button3.Hide(); button4.Hide(); button5.Hide(); button7.Hide(); label9.Hide();
            }
            else if (dealerChoiseInstance)
            {
                label14.Text = $"{dealer.getCards()}";
                label8.Text = $"{dealer.getScore()}";
                dealerChoiseInstance = false;
                playerIndex = 1;
                button7.Hide(); button4.Hide(); button3.Hide();
                button7.Text = "dealer"; button3.Text = "2"; button4.Text = "3"; 
                roundPlayer();
            }
            else if (resetInstance)
            {
                Application.Exit();
            }
            else
            {
                Player playerFirst = new Player(false);
                player1 = playerFirst;
                Player playerSecond = new Player(false);
                player2 = playerSecond;
                Player playerThird = new Player(false);
                player3 = playerThird;
                pictureBox1.Show(); pictureBox2.Show(); pictureBox3.Show();
                label5.Show(); label16.Show(); label6.Show();
                label16.Text = $"{player1.getScore()}";
                label5.Text = $"{player2.getScore()}";
                label6.Text = $"{player3.getScore()}";
                gameStart();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (divideCardInstance)
            {
                player4.addCard(pulledCard);
                player4.setScore(pulledCard.getValue());
                label7.Text = $"{player4.getScore()}";
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
                pictureBox1.Show(); pictureBox2.Show(); pictureBox3.Show(); pictureBox4.Show();
                label5.Show(); label16.Show(); label6.Show(); label7.Show();
                label16.Text = $"{player1.getScore()}";
                label5.Text = $"{player2.getScore()}";
                label6.Text = $"{player3.getScore()}";
                label7.Text = $"{player4.getScore()}";
                gameStart();
            }
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
            pictureBox5.Show(); button1.Show(); button6.Show(); label8.Show();
            button8.Show();
            label8.Text = $"{dealer.getScore()}";
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
            if (dealerChoiseInstance)
            {
                dealer.hit();
                label14.Text = $"{dealer.getCards()}";
                label8.Text = $"{dealer.getScore()}";
                dealerChoiseInstance = false;
                playerIndex = 1;
                button7.Hide(); button4.Hide(); button3.Hide();
                button7.Text = "dealer"; button3.Text = "2"; button4.Text = "3";
                roundPlayer();
            }
            else
            {
                dealer.addCard(pulledCard);
                dealer.setScore(pulledCard.getValue());
                label8.Text = $"{dealer.getScore()}";
                label14.Show();
                label14.Text = dealer.getCards();
                label2.Hide();
                button2.Hide(); button3.Hide(); button4.Hide(); button5.Hide(); button7.Hide(); label9.Hide();
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((player1?.playerWon() ?? false) || (player2?.playerWon() ?? false) || (player3?.playerWon() ?? false) || (player4?.playerWon() ?? false) || (dealer?.playerWon() ?? false))
            {
                newGame();
            }
            if (player1 != null && player1.playerLost())
            {
                playerLost("player1");
            }
            else if (player2 != null && player2.playerLost())
            {
                playerLost("player2");
            }
            else if (player3 != null && player3.playerLost())
            {
                playerLost("player3");
            }
            else if (player4 != null && player4.playerLost())
            {
                playerLost("player4");
            }
            else if (dealer != null && dealer.playerLost())
            {
                playerLost("dealer");
                newGame();
            }
            if (!firstRoundPass)
            {
                if (button8.Text == "Ja")
                {
                    firstRoundPass = true;
                    roundPlayer();
                }
                label15.Show();
                button8.Text = "Ja";
            }
            else
            {
                roundPlayer();
            }
        }
        public void roundPlayer()
        {
            button8.Text = "Bevestig keuze";
            switch (playerIndex)
            {
                case 1:
                    if (player1 != null)
                    {
                        label15.Text = player1.roundSimulation("player 1");
                        label10.Text = $"{player1.getCards()}";
                        label16.Text = $"{player1.getScore()}";
                    }
                    break;
                case 2:
                    if (player2 != null)
                    {
                        label15.Text = player2.roundSimulation("player 2");
                        label11.Text = $"{player2.getCards()}";
                        label5.Text = $"{player2.getScore()}";
                    }
                    break;
                case 3:
                    if (player3 != null)
                    {
                        label15.Text = player3.roundSimulation("player 3");
                        label12.Text = $"{player3.getCards()}";
                        label6.Text = $"{player3.getScore()}";
                    }
                    break;
                case 4:
                    if (player4 != null)
                    {
                        label15.Text = player4.roundSimulation("player 4");
                        label13.Text = $"{player4.getCards()}";
                        label7.Text = $"{player4.getScore()}";
                    }
                    break;
                case 5:
                    dealerChoiseInstance = true;
                    button4.Text = "Passen"; button3.Text = "Dubbelen"; button7.Text = "hit";
                    button4.Show(); button3.Show(); button7.Show();
                    break;
                default:
                    break;
            }
            playerIndex++;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        public void newGame()
        {
            button1.Hide(); pictureBox5.Hide(); label2.Hide();
            pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide();
            button6.Hide(); button8.Hide(); button7.Hide(); button5.Hide(); button2.Hide();
            label2.Hide(); label9.Hide(); label10.Hide(); label11.Hide(); label12.Hide();
            label13.Hide(); label14.Hide(); label15.Hide(); label16.Hide(); label5.Hide();
            label6.Hide(); label7.Hide(); label8.Hide();
            button3.Show(); button4.Show();
            button3.Text = "New game";
            button4.Text = "Quit game";
            divideCardInstance = false;
            resetInstance = true;
            dealerChoiseInstance = false;
            firstRoundPass = false;
            playerIndex = 0;
            deck = new Deck();
            player1 = null;
            player2 = null;
            player3 = null;
            player4 = null;
            dealer = new Player(true);
        }
        public void playerLost(string name)
        {
            if (name == "player1")
            {
                label10.Hide();
                pictureBox1.Hide();
                label16.Text = "Speler 1 is af";
                player1 = null;
            }
            else if (name == "player2")
            {
                label11.Hide();
                pictureBox2.Hide();
                label5.Text = "Speler 2 is af";
                player2 = null;
            }
            else if (name == "player3")
            {
                label12.Hide();
                pictureBox3.Hide();
                label6.Text = "Speler 3 is af";
                player3 = null;
            }
            else if (name == "player4")
            {
                label13.Hide();
                pictureBox4.Hide();
                label7.Text = "Speler 4 is af";
                player4 = null;
            }
            else
            {
                label14.Hide();
                pictureBox5.Hide();
                label8.Text = "De dealer is af";
                dealer = null;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
