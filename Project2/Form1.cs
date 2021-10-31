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

            playerVal.Text = string.Empty;
            dealerVal.Text = string.Empty;

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

            int playerValue;
            int dealerValue;

            // Draw a card for the dealer
            aCard card = deck.Draw();
            // Display dealer's card
            dealer_card1.Image = card.getPicture();

            //calculate player's value
            playerValue = firstCard.getValue() + secondCard.getValue();
            playerVal.Text = playerValue.ToString();

            //calculate dealer's value
            dealerValue = card.getValue();
            dealerVal.Text = dealerValue.ToString();

        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            int playerValue = int.Parse(playerVal.Text);
            // Draw a card and display to player
            if (player1_card3.Image == null)
            {
                aCard card3 = deck.Draw();
                player1_card3.Image = card3.getPicture();
                playerValue += card3.getValue();
                playerVal.Text = playerValue.ToString();

            } else if (player1_card4.Image == null)
            {
                aCard card4 = deck.Draw();
                player1_card4.Image = card4.getPicture();
                playerValue += card4.getValue();
                playerVal.Text = (playerValue).ToString();
            } else if (player1_card5.Image == null)
            {
                aCard card5 = deck.Draw();
                player1_card5.Image = card5.getPicture();
                playerValue += card5.getValue();
                playerVal.Text = playerValue.ToString();
            } else
            {
                MessageBox.Show("You can't draw more cards", "Error");
                return;
            }


        }

        private void standButton_Click(object sender, EventArgs e)
        {
            if (player1_card1.Image == null)
            {
                MessageBox.Show("You have to play game first!!", "Error");
                return;
            }

           
            int playerValue = int.Parse(playerVal.Text);
            int dealerValue = int.Parse(dealerVal.Text);
           
            // Draw until dealer's hand is > 17
            if (dealerValue < 17)
            {
                aCard card2 = deck.Draw();
                dealer_card2.Image = card2.getPicture();
                dealerValue += card2.getValue();
                dealerVal.Text = dealerValue.ToString();
            }

            if (dealerValue < 17)
            {
                aCard card3 = deck.Draw();
                dealer_card3.Image = card3.getPicture();
                dealerValue += card3.getValue();
                dealerVal.Text = dealerValue.ToString();
            }

            if (dealerValue < 17)
            { 
                aCard card4 = deck.Draw();
                dealer_card4.Image = card4.getPicture();
                dealerValue += card4.getValue();
                dealerVal.Text = dealerValue.ToString();
            }

            if (dealerValue < 17)
            {
                aCard card5 = deck.Draw();
                dealer_card5.Image = card5.getPicture();
                dealerValue += card5.getValue();
                dealerVal.Text = dealerValue.ToString();
            }
            


            // Calculate outcome
            //win
            if (playerValue <= 21 && (playerValue > dealerValue || dealerValue > 21))
            {
                int bet = (int.Parse(betMoney.Text));
                totalMoney.Text = (int.Parse(totalMoney.Text) + bet * 3/2).ToString();
                gameResult.Text = "YOU WIN!!!";
                gameResult.Visible = true;
            }
            //lose
            if (dealerValue <= 21 && (playerValue < dealerValue || playerValue > 21)) 
            {
                int bet = (int.Parse(betMoney.Text));
                totalMoney.Text = (int.Parse(totalMoney.Text) - bet).ToString();
                gameResult.Text = "YOU LOSE!!!";
                gameResult.Visible = true;
            }
            //lose
            if (playerValue > 21 && dealerValue > 21)
            {
                int bet = (int.Parse(betMoney.Text));
                totalMoney.Text = (int.Parse(totalMoney.Text) - bet).ToString();
                gameResult.Text = "Both busted. You lose!!";
                gameResult.Visible = true;
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

            gameResult.Visible = false;
        }
    }
}
