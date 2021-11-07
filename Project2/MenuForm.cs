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
    public partial class MenuForm : Form
    {
        public static int seedValue;
        public static int numberOfDecks;
        public static bool softModeButton = true;
        public static bool hardModeButton = false;

        public MenuForm()
        {
            InitializeComponent();
            softMode.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the user choose number of decks yet
            if (String.IsNullOrEmpty(numDeckVal.Text))
            {
                MessageBox.Show("Please enter number of decks!", "Error");
                return;
            } else
            {
                numberOfDecks = int.Parse(numDeckVal.Text);
            }

            // Check if the user choose seed value yet
            if (String.IsNullOrEmpty(seedVal.Text))
            {
                MessageBox.Show("Please enter seed value!", "Error");
                return;
            }
            else
            {
                seedValue = int.Parse(seedVal.Text);
            }

            var newPlayer = new MainForm();
            newPlayer.Show();
        }

        private void softMode_CheckedChanged(object sender, EventArgs e)
        {
            if (softMode.Checked)
            {
                hardMode.Checked = false;

                softModeButton = true;
                hardModeButton = false;
            } else
            {
                hardMode.Checked = true;

                softModeButton = false;
                hardModeButton = true;
            }
        }

        private void hardMode_CheckedChanged(object sender, EventArgs e)
        {
            if (hardMode.Checked)
            {
                softMode.Checked = false;

                softModeButton = false;
                hardModeButton = true;
            } else
            {
                softMode.Checked = true;

                softModeButton = true;
                hardModeButton = false;
            }
        }
    }
}
