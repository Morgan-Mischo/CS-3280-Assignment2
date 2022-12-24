using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CS3280_Assignment2
{
    public partial class Form1 : Form
    {
        #region Attributes

        /// <summary>
        /// Number of times the user has played the game
        /// </summary>
        private int num_played;

        /// <summary>
        /// Number of times the user has lost
        /// </summary>
        private int num_lost;

        /// <summary>
        ///Number of times the user has won
        /// </summary>
        private int num_won;

        /// <summary>
        /// Number the user guessed
        /// </summary>
        private int num_guessed;

        ///<summary>
        ///Number that the random generator made that will be compared
        ///</summary>
        private int num_compare;

        /// <summary>
        /// Frequency numbers for bottom section
        /// </summary>
        private int freq_1;
        private int freq_2;
        private int freq_3;
        private int freq_4;
        private int freq_5;
        private int freq_6;

        /// <summary>
        /// Percent numbers for bottom section
        /// </summary>
        private double perc_1;
        private double perc_2;
        private double perc_3;
        private double perc_4;
        private double perc_5;
        private double perc_6;

        /// <summary>
        /// Number of times guessed for bottom section
        /// </summary>
        private int guess_1;
        private int guess_2;
        private int guess_3;
        private int guess_4;
        private int guess_5;
        private int guess_6;

        #endregion

        #region Methods

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is where the user enters their guess
        /// It will check that guess is valid
        /// If not, it will show the entry_invalid label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guess_text_TextChanged(object sender, EventArgs e)
        {
            int guess_text_int = 0; //Int version of user's guess

            //User's guess in int
            if(Int32.TryParse(guess_text.Text, out guess_text_int)) 
            {
                roll_btn.Enabled = true; 
            } else
            {
                invalid_label.Text = "Entry is Invalid";
            }

            //Check if user guess is between 1 and 6
            if (guess_text_int < 1 || guess_text_int > 6)
            {
                //Show error label
                invalid_label.Text = "Entry is Invalid";
            } else
            {
                //Allow roll button to work
                roll_btn.Enabled = true;
            }
        }

        /// <summary>
        /// This method deals with the user clicking the roll button
        /// It use a random number generator function to create num_compare
        /// Set num_guessed
        /// Update num_played
        /// Call image updater
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roll_btn_Click(object sender, EventArgs e)
        {
            //Set num_guessed
            num_guessed = Int32.Parse(guess_text.Text);

            //Update num_played
            num_played += 1;

            //For loop to roll dice
            for (int i = 1; i < 8; i++)
            {
                image_updater(generate_rand()); 
            }

            //Set num_compare
            num_compare = generate_rand(); 

            //Call image updater
            image_updater(num_compare);

            game_logic();

        }


        /// <summary>
        /// Takes in the number and displays the correct image of the dice
        /// </summary>
        /// <param name="rand"></param>
        private void image_updater(int rand)
        {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

            pbImage.Image = Image.FromFile("die" + rand.ToString() + ".gif");
            pbImage.Refresh();
            Thread.Sleep(300);
        }

        /// <summary>
        /// Reset handler
        /// Deals with hitting the reset button
        /// Sets num_played, lost, and won back to 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset_btn_Click(object sender, EventArgs e)
        {
            guess_text.Text = "";
            invalid_label.Text = "";
            display_numbers(); 
        }

        //method : game logic
        //check if num guessed = num correct
        //if yes, num won + 1
        //if no, num lost + 1
        private void game_logic()
        {
            if (num_guessed == num_compare)
            {
                num_won += 1; 
            }
            else
            {
                num_lost += 1;
            }
            display_numbers();
            bottom_numbers(); 
        }

        /// <summary>
        /// Random number generator
        /// </summary>
        /// <returns>Random number int</returns>
        private int generate_rand()
        {
            Random rnd_num = new Random();
            return rnd_num.Next(1, 7); 
        }

        /// <summary>
        /// Updating the labels with the numbers
        /// </summary>
        private void display_numbers()
        {
            //Game info labels
            num_lost_label.Text = num_lost.ToString();
            num_played_label.Text = num_played.ToString();
            num_won_label.Text = num_won.ToString();

            //Frequency labels
            freq1_text.Text = freq_1.ToString();
            freq2_text.Text = freq_2.ToString();
            freq3_text.Text = freq_3.ToString();
            freq4_text.Text = freq_4.ToString();
            freq5_text.Text = freq_5.ToString();
            freq6_text.Text = freq_6.ToString();

            //Percent labels
            percent_text1.Text = perc_1.ToString();
            percent_text2.Text = perc_2.ToString();
            percent_text3.Text = perc_3.ToString();
            percent_text4.Text = perc_4.ToString();
            percent_text5.Text = perc_5.ToString();
            percent_text6.Text = perc_6.ToString();

            //Guess labels
            guess_text1.Text = guess_1.ToString();
            guess_text2.Text = guess_2.ToString();
            guess_text3.Text = guess_3.ToString();
            guess_text4.Text = guess_4.ToString();
            guess_text5.Text = guess_5.ToString();
            guess_text6.Text = guess_6.ToString();

        }

        /// <summary>
        /// Updates numbers at bottom
        /// </summary>
        private void bottom_numbers()
        {
            switch (num_compare)
            {
                case 1:
                    freq_1 += 1;
                    break;
                case 2:
                    freq_2 += 1;
                    break;
                case 3:
                    freq_3 += 1;
                    break;
                case 4:
                    freq_4 += 1;
                    break;
                case 5:
                    freq_5 += 1;
                    break;
                default:
                    freq_6 += 1;
                    break; 

            }

            switch (num_guessed)
            {
                case 1:
                    guess_1 += 1;
                    break;
                case 2:
                    guess_2 += 1;
                    break;
                case 3:
                    guess_3 += 1;
                    break;
                case 4:
                    guess_4 += 1;
                    break;
                case 5:
                    guess_5 += 1;
                    break;
                default:
                    guess_6 += 1;
                    break;

            }

            //Percent maths
            double d1 = (double)freq_1;
            double d2 = (double)freq_2;
            double d3 = (double)freq_3;
            double d4 = (double)freq_4;
            double d5 = (double)freq_5;
            double d6 = (double)freq_6;
            double play = (double)num_played;

            perc_1 = d1 / play;
            perc_2 = d2 / play;
            perc_3 = d3 / play;
            perc_4 = d4 / play;
            perc_5 = d5 / play;
            perc_6 = d6 / play;




        }
        #endregion


    }
}



