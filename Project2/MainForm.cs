﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using Project_1;

//Group members: Nhi Nguyen & Nam Nguyen
namespace Project2
{
    /// <summary>
    /// This function holds data members of MainForm class
    /// </summary>
    public partial class MainForm : Form
    {

        private aShoe pileOfCards;
        private List<aCard> dealer_cards = new List<aCard>();
        private List<aCard> player_cards = new List<aCard>();

        // Current hand values
        private int playerValue = 0;
        private int dealerValue = 0;

        // Number of aces
        private int player_ace = 0;
        private int dealer_ace = 0;

        // Variables from Menu
        private int numOfDecks;
        private int seedValue;
        private bool softMode;

        /// <summary>
        /// This function initializes the Main Form
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // Get variables value from Main Menu
            numOfDecks = MenuForm.numberOfDecks;
            seedValue = MenuForm.seedValue;
            softMode = MenuForm.softModeButton;

            // Make hand values & Available $ readonly
            dealerVal.Enabled = false;
            playerVal.Enabled = false;
            totalMoney.Enabled = false;

            numDeck.Text = numOfDecks.ToString();
            seedV.Text = seedValue.ToString();
            gameMode.Text = softMode ? "Soft Mode" : "Hard Mode";

            aRandomVariable.rand = new Random(seedValue);
        }

        /// <summary>
        /// This function will be called when user clicks the Reset button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            betMoney.Text = string.Empty;

            resetCards(sender, e);

            if (!playButton.Enabled) togglePlayButton();
            if (!betMoney.Enabled) toggleBetValue();
            gameResult.Visible = false;

        }

        /// <summary>
        /// This function will be called when user clicks the Play button
        /// </summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButton_Click(object sender, EventArgs e)
        {
            // Check if the user bet yet
            if (String.IsNullOrEmpty(betMoney.Text))
            {
                MessageBox.Show("Please enter money to bet!", "Error");
                return;
            }

            // Check if the user's total is less than bet money
            if (int.Parse(totalMoney.Text) == 0)
            {
                MessageBox.Show("You ran out of money!", "Invalid");
                return;
            } else if (int.Parse(totalMoney.Text) < int.Parse(betMoney.Text))
            {
                MessageBox.Show("Please enter bet amount equal or less than your total!", "Invalid");
                return;
            }

            // Shuffle number of decks into a pile if the rest of cards < 3/4 total
            if (pileOfCards == null || pileOfCards.countNumOfCards() < numOfDecks * 52 * 1/4)
            {
                pileOfCards = new aShoe(aRandomVariable.rand, numOfDecks);
            }

            // Reset previous game
            resetCards(sender, e);
            gameResult.Visible = false;
            if (!hitButton.Enabled) toggleHitButton();
            if (!standButton.Enabled) toggleStandButton();
            if (playButton.Enabled) togglePlayButton();
            if (betMoney.Enabled) toggleBetValue();

            // Draw 2 cards for each player and display
            for (int i = 0; i < 2; i++)
            {
                PictureBox pic_player = drawCardAndStore("playerCard", ref player_cards);

                Controls.Add(pic_player);
                pic_player.BringToFront();
            }

            // Draw a card for the dealer and display
            PictureBox pic_dealer = drawCardAndStore("dealerCard", ref dealer_cards);

            Controls.Add(pic_dealer);
            pic_dealer.BringToFront();

            //Display player's and dealer's value
            playerVal.Text = playerValue.ToString();
            dealerVal.Text = dealerValue.ToString();

        }

        /// <summary>
        /// This function will be called when user clicks the Hit button
        /// </summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hitButton_Click(object sender, EventArgs e)
        {
            // Check if game is valid to proceed
            if (!isGameValidate()) return;

            // Check Black Jack
            if (isBlackJack(player_cards))
            {
                MessageBox.Show("You are already Natural Black Jack", "Error");
                standButton_Click(sender, e);
                return;
            }


            // Draw a card and display to player unless card amount < 11 or score > 21
            if (player_cards.Count < 11 && playerValue < 21)
            {
                PictureBox pic_player = drawCardAndStore("playerCard", ref player_cards);

                Controls.Add(pic_player);
                pic_player.BringToFront();

                playerVal.Text = playerValue.ToString();
            } else if (playerValue > 21)
            {
                MessageBox.Show("You are busted", "Error");
                standButton_Click(sender, e);
                return;
            } else if (playerValue == 21)
            {
                MessageBox.Show("You got 21 already", "Error");
                standButton_Click(sender, e);
                return;
            } else
            {
                MessageBox.Show("You can't draw more cards", "Error");
                standButton_Click(sender, e);
                return;
            }
        }

        /// <summary>
        /// This function will be called when user clicks the Stand button
        /// </summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void standButton_Click(object sender, EventArgs e)
        {
            // Check if game is valid to proceed
            if (!isGameValidate()) return;

            // Disable other buttons and enable Play button & Bet textbox
            if (hitButton.Enabled) toggleHitButton();
            if (standButton.Enabled) toggleStandButton();
            if (!playButton.Enabled) togglePlayButton();
            if (!betMoney.Enabled) toggleBetValue();

            // Check if game mode is Soft 17 or Hard 17
            int stop;
            if (softMode)
            {
                stop = 18;
            } else
            {
                stop = 17;
            }

            // Draw until dealer's hand meets condition
            while (dealerValue < stop)
            {
                PictureBox pic_dealer = drawCardAndStore("dealerCard", ref dealer_cards);

                Controls.Add(pic_dealer);
                pic_dealer.BringToFront();
            }
            dealerVal.Text = dealerValue.ToString();

            int bet = (int.Parse(betMoney.Text));

            // Check Black Jack
            if (isBlackJack(player_cards))
            {
                gameResult.Text = "You WIN!!";
            } else if (isBlackJack(player_cards) && !isBlackJack(dealer_cards))
            {
                totalMoney.Text = (int.Parse(totalMoney.Text) + bet * 3 / 2).ToString();
                gameResult.Text = "You WIN!!";
            } else if (!isBlackJack(player_cards) && isBlackJack(dealer_cards))
            {
                totalMoney.Text = (int.Parse(totalMoney.Text) - bet).ToString();
                gameResult.Text = "You LOSE!!";
            } else
            {
                // Calculate outcome
                if (playerValue > 21)   // Player Busted
                {
                    totalMoney.Text = (int.Parse(totalMoney.Text) - bet).ToString();
                    gameResult.Text = "You LOSE!!";
                }
                else if (dealerValue > 21)   // Dealer Busted
                {
                    totalMoney.Text = (int.Parse(totalMoney.Text) + bet * 3 / 2).ToString();
                    gameResult.Text = "You WIN!!";
                }
                else if (playerValue > dealerValue)     // Player Value is larger
                {
                    totalMoney.Text = (int.Parse(totalMoney.Text) + bet * 3 / 2).ToString();
                    gameResult.Text = "You WIN!!";
                }
                else if (playerValue < dealerValue)   // Player Value is smaller 
                {
                    totalMoney.Text = (int.Parse(totalMoney.Text) - bet).ToString();
                    gameResult.Text = "You LOSE!!";
                }
                else   // Draw
                {
                    gameResult.Text = "DRAW!!";
                }
            }

            gameResult.Visible = true;
        }

        /// <summary>
        /// This function resets some of the table properties when user click the Reset button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetCards(object sender, EventArgs e)
        {
            foreach (aCard card_player in player_cards)
            {
                Controls.Remove(card_player.card_display);

                card_player.card_display.Dispose();
            }
            player_cards.Clear();
            playerValue = 0;
            playerVal.Text = string.Empty;
            player_ace = 0;

            foreach (aCard card_dealer in dealer_cards)
            {
                Controls.Remove(card_dealer.card_display);

                card_dealer.card_display.Dispose();
            }
            dealer_cards.Clear();
            dealerValue = 0;
            dealerVal.Text = string.Empty;
            dealer_ace = 0;

        }

        /// <summary>
        /// this function helps drawing and storing the cards
        /// </summary>
        /// <param name="name"></param>
        /// <param name="database"></param>
        /// <returns></returns>
        private PictureBox drawCardAndStore(String name, ref List<aCard> database)
        {
            aCard newCard = pileOfCards.Draw();

            int height_place;
            if (name == "playerCard")
            {
                height_place = 175;

                // Check if the drawn card is Ace and recalculate best value
                checkAndRecalculateAce(newCard, ref playerValue, ref player_ace);
            }
            else
            {
                height_place = 40;

                // Check if the drawn card is Ace and recalculate best value
                checkAndRecalculateAce(newCard, ref dealerValue, ref dealer_ace);
            }

            PictureBox picture = new PictureBox
            {
                Name = name + (database.Count).ToString(),
                Size = new Size(75, 100),
                Location = new Point(300 + database.Count * 30, height_place),
                Image = newCard.getPicture()
            };
            picture.SizeMode = PictureBoxSizeMode.StretchImage;

            newCard.card_display = picture;
            database.Add(newCard);

            return picture;
        }

        /// <summary>
        /// This function decides the value of Ace card based on the total value of current cards
        /// </summary>
        /// <param name="card"></param>
        /// <param name="currentVal"></param>
        /// <param name="numAces"></param>
        private void checkAndRecalculateAce(aCard card, ref int currentVal, ref int numAces)
        {
            // Check if the drawn card is Ace
            if (card.getValue() == 11)
            {
                numAces += 1;
            }
            currentVal += card.getValue();

            // If total value is > 21 then Ace has value of 1
            if (currentVal > 21 && numAces > 0)
            {
                numAces -= 1;
                currentVal -= 10;
            }
        }

        /// <summary>
        /// This function checks if the first 2 cards are Black Jack
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        private bool isBlackJack(List<aCard> cards)
        {
            if (cards[0].getValue() + cards[1].getValue() == 21)
            {
                return true;
            } else
            {
                return false;
            }
        }

        /// <summary>
        /// This function check if all the requirements are met before starting the game
        /// </summary>
        /// <returns></returns>
        private bool isGameValidate()
        {
            // Check if player has started the game yet
            if (player_cards.Count == 0)
            {
                MessageBox.Show("You have to play game first!!", "Error");
                return false;
            }

            // Check if pile of cards is empty
            if (pileOfCards.isEmptyDeck())
            {
                MessageBox.Show("Can't draw, deck is empty!!", "Error");
                return false;
            }

            return true;
        }

        /// <summary>
        /// This function toggles the Stand button
        /// </summary>
        private void toggleStandButton()
        {
            if (standButton.Enabled) standButton.Enabled = false;
            else standButton.Enabled = true;
        }

        /// <summary>
        /// This function toggles the Hit button
        /// </summary>
        private void toggleHitButton()
        {
            if (hitButton.Enabled) hitButton.Enabled = false;
            else hitButton.Enabled = true;
        }

        /// <summary>
        /// This function toggles the Play button
        /// </summary>
        private void togglePlayButton()
        {
            if (playButton.Enabled) playButton.Enabled = false;
            else playButton.Enabled = true;
        }

        /// <summary>
        /// This function toggle the ability to bet value
        /// </summary>
        private void toggleBetValue()
        {
            if (betMoney.Enabled) betMoney.Enabled = false;
            else betMoney.Enabled = true;
        }
    }
}
