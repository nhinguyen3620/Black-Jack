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
        public Form1()
        {
            InitializeComponent();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            softMode.CheckState = CheckState.Unchecked;
            hardMode.CheckState = CheckState.Unchecked;
            seedVal.Text = string.Empty;
            dealerVal.Text = string.Empty;
            playerVal.Text = string.Empty;
            totalMoney.Text = "100";
            betVal.Text = string.Empty;
            dealerVal.Text = string.Empty;
            playerVal.Text = string.Empty;

        }
    }
}
