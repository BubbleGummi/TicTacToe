using System.ComponentModel;
using System.Drawing.Text;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true; //When it's true it's person X turn and when it's false it's person O turn. 
        int turn_count = 0; //The turns that have been made, after 9 turns it's a draw. 

        public Form1()
        {
            InitializeComponent();
        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Diana Hogescu", "Tic Tac Toe Game");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender; 
            if(turn)
                b.Text= "X";
            else 
                b.Text="O";
            turn = !turn;
            b.Enabled = false;

            CheckForWinner();
            turn_count++;
        }
        private void CheckForWinner()
        {
            bool winner = false;
            //horizontal checks for winner
            if((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                winner = true;
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                winner = true;
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                winner = true;
            //Vertical checks
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                winner = true;
            //Diagonal checks
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                winner = true;

            string winningPlayer;

            if (winner)
            {
                disableButtons();
                if (turn)
                    winningPlayer = "O";
                else
                    winningPlayer = "X";
                MessageBox.Show(winningPlayer + " wins!");
            }
            else
            {
                if (turn_count == 8)
                    MessageBox.Show("Draw!");
            }
        }
        private void disableButtons()
        { //For each pressed button in the form disable it so you can't press it again
            try //Using a try catch because the program doesnt like that it's trying to cast the menustrip which is not a button to a button
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch
            {

            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e) // New Game
        {
            turn = true; 
            turn_count= 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = ""; 
                }
            }
            catch
            {

            }
        }
    }
}