using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GuessingGameTemplate4U
{
    public partial class MainScreen : UserControl
    {

        //creates a random number between 1 and 100 and stores it in a global 
        //variable that can be used throughout the program 
        public static Random randNum = new Random();
        int rand = randNum.Next(1, 101);
        int guess;
        public static int number = 0;

        public MainScreen()
        {
            InitializeComponent();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            number++;
            try
            {
                guess = Convert.ToInt16(inputBox.Text);


                if (guess < rand)
                {
                    outputLabel.Text = "Too Low!";

                }
                else if (guess > rand)
                {
                    outputLabel.Text = "Too High!";
                }
                else
                {
                    outputLabel.Text = "You Got it!";
                    Refresh();
                    Thread.Sleep(1000);

                    //TODO close this screen and open a Results Screen (you need to create this)
                    ResultsScreen results = new ResultsScreen();

                    Form f = this.FindForm();
                    f.Controls.Remove(this);
                    f.Controls.Add(results);
                    results.Location = new Point((f.Width - results.Width) / 2, (f.Height - results.Height) / 2);

                }
            }
            catch
            {

            }


            //TODO add guess to List of guesses on Form1

            Form1.numberGuesses.Add(guess);


            inputBox.Text = "";
            inputBox.Focus();
        }

    }
}
