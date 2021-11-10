using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    /// <summary>
    /// main class for our Form1 is derived directly from the Form class
    /// </summary>
    public partial class Form1 : Form
    {
        // <summary>
        // create a global die object
        // </summary>
        aDie dice = new aDie();

        /// <summary>
        /// main method to initialize the Form
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            seedVal.Text = "999";
        }

  
        /// <summary>
        /// this method will be called whenever user click the ROLL! button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rollButton_Click(object sender, EventArgs e)
        {
            // create 2 int variables to store the resulting faces for 2 dices   
            int dice1 = dice.roll();
            int dice2 = dice.roll();

            // use switch statements to display corresponding image for each result of dice 1       
            switch (dice1)
            {
                case 1:
                     pic1.Image = Properties.Resources.face1;
                    break;
                case 2:
                    pic1.Image = Properties.Resources.face2;
                    break;
                case 3:
                    pic1.Image = Properties.Resources.face3;
                    break;
                case 4:
                    pic1.Image = Properties.Resources.face4;
                    break;
                case 5:
                    pic1.Image = Properties.Resources.face5;
                    break;
                case 6:
                    pic1.Image = Properties.Resources.face6;
                    break;
            }

            //stretch image to fit the picture box
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;

     
            // use switch statements to display corresponding image for each result of dice 2 
            switch (dice2)
            {
                case 1:
                    pic2.Image = Properties.Resources.face1;
                    break;
                case 2:
                    pic2.Image = Properties.Resources.face2;
                    break;
                case 3:
                    pic2.Image = Properties.Resources.face3;
                    break;
                case 4:
                    pic2.Image = Properties.Resources.face4;
                    break;
                case 5:
                    pic2.Image = Properties.Resources.face5;
                    break;
                case 6:
                    pic2.Image = Properties.Resources.face6;
                    break;
            }

            //stretch image to fit the picture box
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

  
        /// <summary>
        /// fill series "Dice 1" in the histogram
        /// </summary>
        /// <param name="arr1"></param>
        private void fillDice1(int[] arr1)
        {
            //AddXY value in histogram in series "Dice1"  
            for (int i = 0; i < 6; i++)
            {
                chart1.Series[0].Points.AddXY(i + 1, arr1[i]);
            }
        }


        /// <summary>
        /// fill series "Dice 2" in the histogram
        /// </summary>
        /// <param name="arr2"></param>
        private void fillDice2(int[] arr2)
        {
            //AddXY value in histogram in series "Dice 2" 
            for (int i = 0; i < 6; i++)
            {
                chart1.Series[1].Points.AddXY(i + 1, arr2[i]);
            }
        }


        /// <summary>
        /// this function is to fill all the statistics when rolling the dices
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <param name="rolls"></param>
        private void fillStat(int [] arr1, int[] arr2, int rolls)
        {
            // this variable to hold the mean of Dice 1
            float meanDice1;
  
            // this variable to hold the mean of Dice 2
            float meanDice2;

    
            // this variable to hold the sum of Dice 1  
            float sum1 = 0;

            // this variable to hold the sum of Dice 2
            float sum2 = 0;

            // use for loop to calculate the sum of Dice 1
            for (int i = 0; i < arr1.Length; i++)
            {
                sum1 += (i + 1) * arr1[i];
            }

            // calculate the mean of Dice 1 and display in the text box
            meanDice1 = sum1 / rolls;
            mean1.Text = meanDice1.ToString("0.00");

            // use for loop to calculate the sum of Dice 2
            for (int i = 0; i < arr2.Length; i++)
            {
                sum2 += (i + 1) * arr2[i];
            }

            // calculate the mean of Dice 2 and display in the text box
            meanDice2 = sum2 / rolls;
            mean2.Text = meanDice2.ToString("0.00");

            // these variables are to hold the indexes that have max and min values for Dice 1 and Dice 2
            int maxIndex1 = Array.IndexOf(arr1, arr1.Max());
            int maxIndex2 = Array.IndexOf(arr2, arr2.Max());
            int minIndex1 = Array.IndexOf(arr1, arr1.Min());
            int minIndex2 = Array.IndexOf(arr2, arr2.Min());

            // these variables are to hold the min and max values of Dice 1 and Dice 2
            int max1 = arr1[maxIndex1];
            int max2 = arr2[maxIndex2];
            int min1 = arr1[minIndex1];
            int min2 = arr2[minIndex2];

            //display the min and max values into the Text Box
            maxCount1.Text = max1 + " Face " + (maxIndex1 + 1);
            maxCount2.Text = max2 + " Face " + (maxIndex2 + 1);
            minCount1.Text = min1 + " Face " + (minIndex1 + 1);
            minCount2.Text = min2 + " Face " + (minIndex2 + 1);
        }


        /// <summary>
        /// this function will be called whenever user clicks the Statistics button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void stas_Click(object sender, EventArgs e)
        {
            //clear all points in the histogram before generating a new roll
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            //these variables are to hold the number of rolls, the number of roll of update 
            //the histogram and the seed number
            int rolls;
            int period;
            int seeds = new int();


            // get the number of rolls from the combo box
            try
            {
                rolls = int.Parse(comboBox.Text);
            }
            catch
            {
                //show error message in case number of rolls is not integer
                MessageBox.Show("Please choose a value for number of rolls", "Error");
                return;
            }

    
            // get the seed number. If it is empty, choose the default value    
            if (!String.IsNullOrEmpty(seedVal.Text))
            {
                // try to parse the value in the text box into the seeds variable
                try
                {
                    seeds = int.Parse(seedVal.Text);
                }
                catch
                {
                    //show error message when user doesnt enter integer
                    MessageBox.Show("Please enter a valid number!");
                    return;
                }
            }

            // creating aDie object
            // use default value if user doesnt specify seeds
            // or use the seeds user specified to create object
            aDie dice1 = (String.IsNullOrEmpty(seedVal.Text)) ? new aDie() : new aDie(seeds);

 
            // calculate the period to update the histogram
            // if number of rolls < 100, set period = rolls
            period = rolls / 100;
            if (rolls < 100)
            {
                period = rolls;
            }


            // create 2 arrays to hold the frequency of each face for 2 Dices
            int[] arr1 = { 0, 0, 0, 0, 0, 0 };
            int[] arr2 = { 0, 0, 0, 0, 0, 0 };

            //track the current number of rolls
            int count = 0; 

            //loop through each roll
            for (int i = 0; i < rolls; i++)
            {
                //create 2 variables to hold the value of each die
                int d1 = dice1.roll();
                int d2 = dice1.roll();

                //increase the frequency 
                arr1[d1 - 1]++;
                arr2[d2 - 1]++;

                //increment count
                count++;

                //update the histogram 
                if (count % period == 0)
                {
                    await Task.Delay(50);
                    
                    //fill the histogram
                    fillDice1(arr1);
                    fillDice2(arr2);
                }

                //disable the reset and statistics buttons when rolling is in process
                resetButton.Enabled = false;
                stas.Enabled = false;
            }

            //fill all the statistics after rolling is done
            fillStat(arr1, arr2, rolls);

            //enable the reset and statistics button after rolling is done
            resetButton.Enabled = true;
            stas.Enabled = true;
        }


        /// <summary>
        /// this function clears everything when user clicks the reset button
        /// and allows user to change the seed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            //clear 2 histograms
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart2.Series[0].Points.Clear();
    
            //clear the statistics
            mean1.Clear();
            mean2.Clear();
            minCount1.Clear();
            minCount2.Clear();
            maxCount1.Clear();
            maxCount2.Clear();
            
            //clear the seeds number
            seedVal.Clear();

            //clear the number of rolls
            comboBox.SelectedIndex = -1;

            //enable user to change the seeds number
            seedVal.ReadOnly = false;
        }

        /// <summary>
        /// This function fills the summary after clicking the sum of 2 dices button
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="rolls"></param>
        void fillSummary(int[] arr, int rolls)
        {
            //these variables are to hold the mean and sum of the sum of 2 dices
            float mean;
            float sum = 0;

            //use for loop to calculate sum
            for (int i = 0; i < arr.Length; i++)
            {
                sum += (i + 2) * arr[i];
            }

            //calculate and display the mean
            mean = sum / rolls;
            mean3.Text = mean.ToString("0.00");

            //find the indexes holding the min and max values
            int minIndex = Array.IndexOf(arr, arr.Min());
            int maxIndex = Array.IndexOf(arr, arr.Max());

            //find the min and max values
            int min = arr[minIndex];
            int max = arr[maxIndex];

            //display the min and max values
            min3.Text = min + " (Sum = " + (minIndex + 2) + ")";
            max3.Text = max + " (Sum = " + (maxIndex + 2) + ")";
        }


        /// <summary>
        /// this function will be called whenever user clicks the Sum Of 2 Dices button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void sumButton_Click(object sender, EventArgs e)
        {
            //clear all points in the histogram before generating a new roll
            chart2.Series[0].Points.Clear();

            //these variables are to hold the number of rolls and seeds number
            int rolls;
            int seeds = new int();
            int period;

            // get the number of rolls from the combo box
            try
            {
                rolls = int.Parse(comboBox.Text);
            }
            catch
            {
                //show the error message when user doesnt enter integer
                MessageBox.Show("Please choose a value for number of rolls", "Error");
                return;
            }

            // get the seed number. If it is empty, choose the default value
            if (!String.IsNullOrEmpty(seedVal.Text))
            {
                // try to parse the value in the text box into the seeds variable
                try
                {
                    seeds = int.Parse(seedVal.Text);
                }
                catch
                {
                    //show the error message when user doesnt enter integer
                    MessageBox.Show("Please enter a valid number!");
                    return;
                }
            }

            //calculate the period to update the histogram
            //if number of rolls < 100, set period = rolls
            period = rolls / 100;
            if (rolls < 100)
            {
                period = rolls;
            }


            // creating aDie object
            // use default value if user doesnt specify seeds
            // or use the seeds user specified to create object
            aDie dice1 = (String.IsNullOrEmpty(seedVal.Text)) ? new aDie() : new aDie(seeds);

            //to create an array of 11 elements to hold the sum of 2 dices (from 2 to 12)
            int[] arr = new int[11];

            //track the current number of rolls
            int count = 0;

            //loop through each roll
            for (int i = 0; i < rolls; i++)
            {
                //these variables are to hold the value of each die when rolling
                int d1 = dice1.roll();
                int d2 = dice1.roll();

                //increase the frequency of the corresponding sum
                arr[d1 + d2 -2]++;

                //increment count
                count++;

                //update the histogram
                if (count % period == 0)
                {
                    await Task.Delay(50);
                    //AddXY value in histogram in series "Sum"  
                    for (int j = 0; j < 11; j++)
                    {
                        chart2.Series["Sum"].Points.AddXY(j + 2, arr[j]);
                    }
                }

                //disable the Sum Of 2 Dices button when rolling is in process
                sumButton.Enabled = false;
            }
            //fill the summary after rolling is done
            fillSummary(arr, rolls);

            //enable the Sum Of 2 Dices button after rolling is done
            sumButton.Enabled = true;     
        }
    }
}
