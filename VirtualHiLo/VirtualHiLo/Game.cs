using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
    /* To Do:
     * Add highscores
     * Difficulties
     *      - Easy = 10 Guesses
     *      - Normal = 7 Guesses
     *      - Hard = 3 Guesses
     *      - Expert = 1 Guess
     */
namespace VirtualHiLo
{
    public partial class virtualHiLo : Form
    {
        int userGuess = 0;
        int randNumber;
        int userDifficulty;
        
        public virtualHiLo()
        {
            InitializeComponent();
            guessBtn.Visible = false;
            easyGuessMenuItem.Checked = true;
        }

        private void guessBtn_Click(object sender, EventArgs e)
        {
            string n = userInputTextBox.Text;
            int guessedNumber;
            guessesLbl.Text = Convert.ToString(userDifficulty - userGuess);

            if (int.TryParse(n, out guessedNumber))             //Checks to make sure input is integer
            {
                if (guessedNumber > 101 || guessedNumber < 0)
                {
                    resultTextBox.AppendText("You must enter a value between 1 and 100.");
                }
                if (userGuess != userDifficulty) //10 Guesses
                {
                    if (guessedNumber > randNumber)
                    {
                        resultTextBox.AppendText("Too high!\n");
                    }
                    else if (guessedNumber < randNumber)
                    {
                        resultTextBox.AppendText("Too low!\n");
                    }
                    else
                    {
                        guessBtn.Visible = false;
                        resultTextBox.AppendText("Correct!");
                    }
                    userGuess++;
                }
                else
                {
                    guessBtn.Visible = false;
                    resultTextBox.AppendText("You have ran out of guesses, the answer is: " + randNumber + "!");
                }
            } else
            {
                resultTextBox.AppendText("You must enter a value between 1 and 100.");
            }
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            randNumber = rand.Next(1, 101);
            userGuess = 0;

            checkDifficulty();
            guessBtn.Visible = true;
            resultTextBox.Clear();
            guessesLbl.Text = Convert.ToString(userDifficulty - userGuess);
            //label1.Text = Convert.ToString(randNumber);
        }

        private void easyGuessMenuItem_Click(object sender, EventArgs e)
        {
            clearMenuChecked();
            easyGuessMenuItem.Checked = true;
        }

        private void mediumGuessMenuItem_Click(object sender, EventArgs e)
        {
            clearMenuChecked();
            mediumGuessMenuItem.Checked = true;
        }
        private void hardGuessMenuItem_Click(object sender, EventArgs e)
        {
            clearMenuChecked();
            hardGuessMenuItem.Checked = true;
        }
        private void expertGuessMenuItem_Click(object sender, EventArgs e)
        {
            clearMenuChecked();
            expertGuessMenuItem.Checked = true;
        }
        private void clearMenuChecked()
        {
            if(easyGuessMenuItem.Checked == true)
            {
                easyGuessMenuItem.Checked = false;
            } else if (mediumGuessMenuItem.Checked == true)
            {
                mediumGuessMenuItem.Checked = false;
            } else if (hardGuessMenuItem.Checked == true)
            {
                hardGuessMenuItem.Checked = false;
            } else
            {
                expertGuessMenuItem.Checked = false;
            }
        }
        private void checkDifficulty()
        {
            if (easyGuessMenuItem.Checked == true)
            {
                userDifficulty = 10;
            }
            else if (mediumGuessMenuItem.Checked == true)
            {
                userDifficulty = 7;
            }
            else if (hardGuessMenuItem.Checked == true)
            {
                userDifficulty = 5;
            }
            else if (expertGuessMenuItem.Checked == true)
            {
                userDifficulty = 3;
            }
            else
            {
                userDifficulty = 10;
            }
        }
    }
}
