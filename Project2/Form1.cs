using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace Project2
{
    public partial class Form1 : Form
    {
        aDeckofCards deck;
        List<aCard> dealer_cards = new List<aCard>();
        List<aCard> player_cards = new List<aCard>();

        int playerValue = 0;
        int dealerValue = 0;

        int player_ace = 0;
        int dealer_ace = 0;


        public Form1()
        {
            InitializeComponent();

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

            resetCards(sender, e);
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

            // Reset previous game
            resetCards(sender, e);
            gameResult.Visible = false;
            deck = new aDeckofCards();

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

        private void hitButton_Click(object sender, EventArgs e)
        {
            // Check Black Jack
            if (checkBlackJack(player_cards))
            {
                MessageBox.Show("You are already Natural Black Jack", "Error");
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
            } else if (playerValue == 21)
            {
                MessageBox.Show("You got 21 already", "Error");
            } else
            {
                MessageBox.Show("You can't draw more cards", "Error");
            }
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            if (player_cards.Count == 0)
            {
                MessageBox.Show("You have to play game first!!", "Error");
                return;
            }

            // Draw until dealer's hand is > 17
            while (dealerValue < 17)
            {
                PictureBox pic_dealer = drawCardAndStore("dealerCard", ref dealer_cards);

                Controls.Add(pic_dealer);
                pic_dealer.BringToFront();
            }
            dealerVal.Text = dealerValue.ToString();

            int bet = (int.Parse(betMoney.Text));

            // Check Black Jack
            if (checkBlackJack(player_cards) && checkBlackJack(dealer_cards))
            {
                gameResult.Text = "DRAW!!";
            } else if (checkBlackJack(player_cards) && !checkBlackJack(dealer_cards))
            {
                totalMoney.Text = (int.Parse(totalMoney.Text) + bet).ToString();
                gameResult.Text = "You WIN!!";
            } else if (!checkBlackJack(player_cards) && checkBlackJack(dealer_cards))
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

        private PictureBox drawCardAndStore(String name, ref List<aCard> database)
        {
            aCard newCard = deck.Draw();

            int height_place;
            if (name == "playerCard")
            {
                height_place = 170;

                // Check if the drawn card is Ace
                if (newCard.getValue() == 11)
                {
                    player_ace += 1;
                }
                playerValue += newCard.getValue();

                // If total value is > 21 then Ace has value of 1
                if (playerValue > 21 && player_ace > 0)
                {
                    player_ace -= 1;
                    playerValue -= 10;
                }
            }
            else
            {
                height_place = 40;

                // Check if the drawn card is Ace
                if (newCard.getValue() == 11)
                {
                    dealer_ace += 1;
                }
                dealerValue += newCard.getValue();

                // If total value is > 21 then Ace has value of 1
                if (dealerValue > 21 && dealer_ace > 0)
                {
                    dealer_ace -= 1;
                    dealerValue -= 10;
                }
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

        private bool checkBlackJack(List<aCard> cards)
        {
            if (cards[0].getValue() + cards[1].getValue() == 21)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
