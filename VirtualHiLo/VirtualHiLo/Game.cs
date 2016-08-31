using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            int guessedNumber = Convert.ToInt16(userInputTextBox.Text);
            guessesLbl.Text = Convert.ToString(7 - userGuess);
            if (userGuess != 7) //8 Guesses
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
            } else
            {
                guessBtn.Visible = false;
                resultTextBox.AppendText("You have ran out of guesses, the answer is: " + randNumber + "!");
            }
            userGuess++;
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
