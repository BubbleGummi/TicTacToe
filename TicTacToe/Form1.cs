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

        private void A1_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {

        }
    }
}