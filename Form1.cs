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
        public string currentPlayer = "X";
        public string winningPlayer;
        public bool hasWon = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void playerPicksPosition(object sender, EventArgs e)
        {
            var tileToPlay = (PictureBox)sender;

            if (currentPlayer == "X")
            {
                tileToPlay.Image = Properties.Resources.x;
                tileToPlay.Tag = "X";
                //checkForWin();
                currentPlayer = "O";
            }
            else if (currentPlayer == "O")
            {
                tileToPlay.Image = Properties.Resources.o;
                tileToPlay.Tag = "O";
                //checkForWin();
                currentPlayer = "X";
            }
        }

        private bool checkForWin()
        {
            if ((String)a1.Tag == "X" && (String)a2.Tag =="X" && (String)a3.Tag == "X")
            {
                winningPlayer = "X";
                hasWon = true;
                return hasWon;
            }
            else if ((String)b1.Tag == "X" && (String)b2.Tag == "X" && (String)b3.Tag == "X")
            {
                winningPlayer = "X";
                hasWon = true;
                return hasWon;
            }
            else if ((String)c1.Tag == "X" && (String)c2.Tag == "X" && (String)c3.Tag == "X")
            {
                winningPlayer = "X";
                hasWon = true;
                return hasWon;
            }
        }
    }
}
