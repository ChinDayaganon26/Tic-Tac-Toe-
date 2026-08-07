using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool playerTurn = true; // true = X, false = O
        int playerScore = 0;
        int cpuScore = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ihanda ang laro
        }

        // Dapat may Click event handler para sa bawat button!
        // Halimbawa:
        // private void button1_Click(object sender, EventArgs e) { ... }
    }
}
