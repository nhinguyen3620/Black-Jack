using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Group members: Nam Nguyen & Nhi Nguyen
namespace Project2
{
    /// <summary>
    /// This function holds the data member of MenuForm class
    /// </summary>
    public partial class MenuForm : Form
    {
        public static int seedValue;
        public static int numberOfDecks;
        public static bool softModeButton = true;
        public static bool hardModeButton = false;

        /// <summary>
        /// This function initializes the MenuForm class
        /// </summary>
        public MenuForm()
        {
            InitializeComponent();
            softMode.Checked = true;
        }

        /// <summary>
        /// This function will be called when user clicks the Play button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This function ensures that user can only choose one mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This function ensures that user can only choose one mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
