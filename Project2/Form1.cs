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
        aDeckofCards deck = new aDeckofCards();

        public Form1()
        {
            InitializeComponent();

            totalMoney.Text = "100";
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

        private void hitButton_Click(object sender, EventArgs e)
        {
            // Draw a card
            aCard card = deck.Draw();
            // TODO: display player's card
        }

        private void button2_Click(object sender, EventArgs e)
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
            } else if (true) // TODO: if lose
            {
                totalMoney.Text = (int.Parse(totalMoney.Text) - 10).ToString();
            }
        }
    }
}
