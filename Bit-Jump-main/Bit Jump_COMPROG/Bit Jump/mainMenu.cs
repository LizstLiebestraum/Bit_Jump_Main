using System;
using System.Windows.Forms;

namespace Bit_Jump
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            Form1 gameForm = new Form1(); // Assumes Form1 is the game screen
            gameForm.Show();              // Show the game form
            this.Hide();                  // Hide the main menu
        }

        private void Quitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the entire application
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Optional: add behavior when picture is clicked
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
