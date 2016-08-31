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
     * Check that only integers are being inputted
     */
namespace VirtualHiLo
{
    public partial class virtualHiLo : Form
    {
        int userGuess = 0;
        int randNumber;
        
        public virtualHiLo()
        {
            InitializeComponent();
            guessBtn.Visible = false;
        }

        private void guessBtn_Click(object sender, EventArgs e)
        {
            string n = userInputTextBox.Text;
            int guessedNumber;
            guessesLbl.Text = Convert.ToString(7 - userGuess);

            if (int.TryParse(n, out guessedNumber))             //Checks to make sure input is integer
            {
                if (guessedNumber > 101 || guessedNumber < 0)
                {
                    resultTextBox.AppendText("You must enter a value between 1 and 100.");
                }
                if (userGuess != 9) //10 Guesses
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

            guessBtn.Visible = true;
            resultTextBox.Clear();
            guessesLbl.Text = Convert.ToString(7 - userGuess);
            //label1.Text = Convert.ToString(randNumber);
        }
    }
}
