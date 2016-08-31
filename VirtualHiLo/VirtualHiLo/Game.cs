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
        Random rand = new Random();

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
            randNumber = rand.Next(1, 101);
            userGuess = 0;

            checkDifficulty();
            guessBtn.Visible = true;
            resultTextBox.Clear();
            guessesLbl.Text = Convert.ToString(userDifficulty - userGuess);
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
            if(easyGuessMenuItem.Checked)
            {
                easyGuessMenuItem.Checked = false;
            } else if (mediumGuessMenuItem.Checked)
            {
                mediumGuessMenuItem.Checked = false;
            } else if (hardGuessMenuItem.Checked)
            {
                hardGuessMenuItem.Checked = false;
            } else
            {
                expertGuessMenuItem.Checked = false;
            }
        }
        private void checkDifficulty()
        {
            if (easyGuessMenuItem.Checked)
            {
                userDifficulty = 10;
            }
            else if (mediumGuessMenuItem.Checked)
            {
                userDifficulty = 7;
            }
            else if (hardGuessMenuItem.Checked)
            {
                userDifficulty = 5;
            }
            else if (expertGuessMenuItem.Checked)
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
