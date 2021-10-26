using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
        static aDeckofCards deck = new aDeckofCards();

        public Form1()
        {
            InitializeComponent();
        }



        private void resetButton_Click(object sender, EventArgs e)
        {
            softMode.CheckState = CheckState.Unchecked;
            hardMode.CheckState = CheckState.Unchecked;
            seedVal.Text = string.Empty;
            seedVal.ReadOnly = false;
            dealerVal.Text = string.Empty;
            playerVal.Text = string.Empty;
            totalMoney.Text = "100";
            betVal.Text = string.Empty;
            dealerVal.Text = string.Empty;
            playerVal.Text = string.Empty;
            p1.Image = null;
            p2.Image = null;
            p3.Image = null;
            p4.Image = null;
            p5.Image = null;
            p1.Image = null;
            p2.Image = null;
            p3.Image = null;
            p4.Image = null;
            p5.Image = null;
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            // Draw a card
            aCard card = deck.Draw();
            // TODO: display player's card
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

        private void playButton_Click(object sender, EventArgs e)
        {
            // Draw 2 cards for each player
            aCard firstCard = deck.Draw();
            aCard secondCard = deck.Draw();
            // TODO: display player's cards

            // Draw a card for the dealer
            aCard card = deck.Draw();
            // TODO: display dealer's card
        }
    }
}
