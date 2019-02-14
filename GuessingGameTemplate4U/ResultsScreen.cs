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

            outputLabel.Text += "Guesses made: " + Form1.playerGuesses.Count() + "\n";
            outputLabel.Text += "Original order: ";

            // print guesses
            for (int i = 0; i < Form1.playerGuesses.Count(); i++)
            {
                outputLabel.Text += Form1.playerGuesses[i] + " ";     
            }

            // sorted guesses 
            outputLabel.Text += "\nSorted order: ";

            // sort guesses
            Form1.playerGuesses.Sort();
            
            // print sorted guess
            for (int i = 0; i < Form1.playerGuesses.Count(); i++)
            {
                outputLabel.Text += Form1.playerGuesses[i] + " ";     
            }
        }
    }
}
