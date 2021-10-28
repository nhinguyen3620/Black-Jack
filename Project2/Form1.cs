using System;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
        static aDeckofCards deck = new aDeckofCards();

        public Form1()
        {
            InitializeComponent();

            // Resize image to fit the picture box
            dealer_card1.SizeMode = PictureBoxSizeMode.StretchImage;
            dealer_card2.SizeMode = PictureBoxSizeMode.StretchImage;
            dealer_card3.SizeMode = PictureBoxSizeMode.StretchImage;
            dealer_card4.SizeMode = PictureBoxSizeMode.StretchImage;
            dealer_card5.SizeMode = PictureBoxSizeMode.StretchImage;
            //====
            player1_card1.SizeMode = PictureBoxSizeMode.StretchImage;
            player1_card2.SizeMode = PictureBoxSizeMode.StretchImage;
            player1_card3.SizeMode = PictureBoxSizeMode.StretchImage;
            player1_card4.SizeMode = PictureBoxSizeMode.StretchImage;
            player1_card5.SizeMode = PictureBoxSizeMode.StretchImage;

            // Automatically choose soft 17 mode

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            softMode.CheckState = CheckState.Unchecked;
            hardMode.CheckState = CheckState.Unchecked;

            seedVal.Text = string.Empty;
            seedVal.ReadOnly = false;

            totalMoney.Text = "100";
            betMoney.Text = string.Empty;

            resetTable();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            // Check if the user bet yet
            if (String.IsNullOrEmpty(betMoney.Text))
            {
                MessageBox.Show("Please choose money to bet!", "Error");
                return;
            }

            // Check if the user's total is less than bet money
            if (int.Parse(totalMoney.Text) < int.Parse(betMoney.Text))
            {
                MessageBox.Show("Please choose bet amount equal or less than your total!", "Invalid");
                return;
            }

            resetTable();

            // Draw 2 cards for each player
            aCard firstCard = deck.Draw();
            aCard secondCard = deck.Draw();
            // Display player's cards
            player1_card1.Image = firstCard.getPicture();
            player1_card2.Image = secondCard.getPicture();


            // Draw a card for the dealer
            aCard card = deck.Draw();
            // Display dealer's card
            dealer_card1.Image = card.getPicture();
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            // Draw a card and display to player
            if (player1_card3.Image == null)
            {
                player1_card3.Image = deck.Draw().getPicture();
            } else if (player1_card4.Image == null)
            {
                player1_card4.Image = deck.Draw().getPicture();
            } else if (player1_card5.Image == null)
            {
                player1_card5.Image = deck.Draw().getPicture();
            } else
            {
                MessageBox.Show("You can't draw more cards", "Error");
                return;
            }
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            // Draw until dealer's hand is > 17
            while (false)   // TODO: Add condition for calculation 
            {
                aCard card = deck.Draw();
                // TODO: display dealer's card
            }

            // Calculate outcome
            if (true)   // TODO: if player wins
            {
                totalMoney.Text = (int.Parse(totalMoney.Text) + 15).ToString();
            }
            else if (true) // TODO: if lose
            {
                totalMoney.Text = (int.Parse(totalMoney.Text) - 10).ToString();
            }
        }

        private void resetTable()
        {
            dealerVal.Text = string.Empty;
            playerVal.Text = string.Empty;

            player1_card1.Image = null;
            player1_card2.Image = null;
            player1_card3.Image = null;
            player1_card4.Image = null;
            player1_card5.Image = null;

            dealer_card1.Image = null;
            dealer_card2.Image = null;
            dealer_card3.Image = null;
            dealer_card4.Image = null;
            dealer_card5.Image = null;
        }
    }
}
