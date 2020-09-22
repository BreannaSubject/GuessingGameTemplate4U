using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class ResultsScreen : UserControl
    {
        public ResultsScreen()
        {
            InitializeComponent();
        }

        private void ResultsScreen_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.numberGuesses.Count(); i++)
            {
                orderLabel1.Text += Convert.ToString(Form1.numberGuesses[i]) + " ";
            }
            List<int> sortedGuesses = new List<int>();
            sortedGuesses = Form1.numberGuesses;
            sortedGuesses.Sort();

            guessLabel.Text += Convert.ToString(Form1.number);


            for (int i = 0; i < sortedGuesses.Count(); i++)
            {
                orderLabel2.Text += Convert.ToString(sortedGuesses[i]) + " ";
            }
           
        }
    }
}
