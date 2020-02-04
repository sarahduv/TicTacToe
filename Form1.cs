using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public String currentPlayer = "X";
        public PictureBox[] allTiles;
        public PictureBox[][] possibleWins;
        public String winningPlayer;
        public bool hasWon = false;
        public bool draw = false;
        public int maxInARow = 4;

        public Form1()
        {
            InitializeComponent();
            allTiles = new PictureBox[9] { a1, a2, a3, b1, b2, b3, c1, c2, c3 };

            var possibleWinOne = new PictureBox[3] { a1, a2, a3 };
            var possibleWinTwo = new PictureBox[3] { b1, b2, b3 };
            var possibleWinThree = new PictureBox[3] { c1, c2, c3 };
            var possibleWinFour = new PictureBox[3] { a1, b1, c1 };
            var possibleWinFive = new PictureBox[3] { a2, b2, c2 };
            var possibleWinSix = new PictureBox[3] { a3, b3, c3 };
            var possibleWinSeven = new PictureBox[3] { a1, b2, c3 };
            var possibleWinEight = new PictureBox[3] { a3, b2, c1 };

            possibleWins = new PictureBox[][] {
                possibleWinOne,
                possibleWinTwo,
                possibleWinThree,
                possibleWinFour,
                possibleWinFive,
                possibleWinSix,
                possibleWinSeven,
                possibleWinEight,

            };
        }

        private void playerPicksPosition(object sender, EventArgs e)
        {
            if (hasWon || draw)
            {
                MessageBox.Show("Reset the game");
                return;
            }
                
            var tileToPlay = (PictureBox)sender;

            if (currentPlayer == "X" && tileToPlay.Tag == null)
            {
                tileToPlay.Image = Properties.Resources.x;
                tileToPlay.Tag = "X";
                
                if (checkForWin())
                {
                    hasWon = true;
                    MessageBox.Show("Player " + currentPlayer + " has won.");
                }

                if (thereIsADraw())
                {
                    MessageBox.Show("It's a draw");
                }

                currentPlayer = "O";
                changingTurnLabel.Text = "O";
            }
            else if (currentPlayer == "O" && tileToPlay.Tag == null)
            {
                tileToPlay.Image = Properties.Resources.o;
                tileToPlay.Tag = "O";

                if (checkForWin())
                {
                    hasWon = true;
                    MessageBox.Show("Player " + currentPlayer + " has won.");
                }

                currentPlayer = "X";
                changingTurnLabel.Text = "X";
            }
            else
            {
                MessageBox.Show("This tile is taken, choose another tile.");
            }
        }

        private bool checkForWin()
        {
            var validInARow = 0;
            for (var possibleWin = 0; possibleWin < possibleWins.Length; possibleWin++)
            {
                validInARow = 0;

                for (var index = 0; index < possibleWins[possibleWin].Length; index++)
                {
                    if ((String)possibleWins[possibleWin][index].Tag == currentPlayer)
                    {
                        validInARow++;

                        if (validInARow >= maxInARow)
                        {
                            winningPlayer = currentPlayer;
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool thereIsADraw()
        {
            bool allTilesTakenWithNoWin = true;

            for (var tile = 0; tile < allTiles.Length; tile++)
            {
                if (allTiles[tile].Tag == null)
                {
                    allTilesTakenWithNoWin = false;
                    return allTilesTakenWithNoWin;
                }
            }
            draw = true;
            return allTilesTakenWithNoWin;
        }

        private void resetBoard(object sender, EventArgs e)
        {
            for (var tile = 0; tile < allTiles.Length; tile++)
            {
                allTiles[tile].Tag = null;
                allTiles[tile].Image = null;
                currentPlayer = "X";
                hasWon = false;
                winningPlayer = null;
            }
        }
    }
}
