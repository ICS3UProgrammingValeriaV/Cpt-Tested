using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ArcadeValeriaV
{
    public partial class frmMenu : Form
    {
        //declare global variable
        int counter = 1;
        int userCoins = 0;
        
       
        public frmMenu(int coins)
        {
            InitializeComponent();
            //hide play game box
            grbPlay.Hide();
            userCoins = userCoins + coins;
            //play the sound
            player1.URL = "catch.wav";

            //play the background music
            player1.Ctlcontrols.play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblPlay_Click(object sender, EventArgs e)
        {
            //display play game box
            grbPlay.Show();
            lblFlappyBird.Show();
            lblPianoTiles.Show();
            lblCathcGame.Show();
            picFlappyBird.Show();
            picPianoTiles.Show();
            pngCatchGame.Show();
            grbPlay.BackgroundImage = Properties.Resources.arcadeBackground;
        }

        private void lblCredits_Click(object sender, EventArgs e)
        {
            //hife all the picture boxes and labels 
            grbPlay.Show();
            lblFlappyBird.Hide();
            lblPianoTiles.Hide();
            lblCathcGame.Hide();
            picFlappyBird.Hide();
            picPianoTiles.Hide();
            pngCatchGame.Hide();
            //change the back color
            grbPlay.BackgroundImage = Properties.Resources.credits;
        }

       
        private void lblBack_Click(object sender, EventArgs e)
        {
            //hide play group box
            grbPlay.Hide();
        }

        private void picFlappyBird_Click(object sender, EventArgs e)
        {
            player1.Ctlcontrols.stop();
            counter = 1;
            //create a local variable
            instructions flappyBird = new instructions(counter,userCoins);
            //hide the form
            this.Hide();
            //establsih a connection between this form and flappy bird form
            flappyBird.ShowDialog();
            //when the second form is closed, the main/this form is closed

            this.Close();
            player1.Ctlcontrols.stop();
        }

        private void lblFlappyBird_Click(object sender, EventArgs e)
        {
            player1.Ctlcontrols.stop();
            counter = 1;
            //create a local variable
            instructions flappyBird = new instructions(counter, userCoins);
            //hide the form
            this.Hide();
            //establsih a connection between this form and flappy bird form
            flappyBird.ShowDialog();
            //when the second form is closed, the main/this form is closed
            
            this.Close();
            player1.Ctlcontrols.stop();
        }

        private void lblCathcGame_Click(object sender, EventArgs e)
        {
            player1.Ctlcontrols.stop();
            counter = 2;
            //create a local variable
            instructions flappyBird = new instructions(counter, userCoins);
            //hide the form
            this.Hide();
            //establsih a connection between this form and flappy bird form
            flappyBird.ShowDialog();
            //when the second form is closed, the main/this form is closed

            this.Close();
            player1.Ctlcontrols.stop();
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            player1.Ctlcontrols.stop();
            counter = 2;
            //create a local variable
            instructions flappyBird = new instructions(counter, userCoins);
            //hide the form
            this.Hide();
            //establsih a connection between this form and flappy bird form
            flappyBird.ShowDialog();
            //when the second form is closed, the main/this form is closed

            this.Close();
            player1.Ctlcontrols.stop();
        }

        private void picPianoTiles_Click(object sender, EventArgs e)
        {
            player1.Ctlcontrols.stop();
            counter = 3;
            //create a local variable
            instructions flappyBird = new instructions(counter, userCoins);
            //hide the form
            this.Hide();
            //establsih a connection between this form and flappy bird form
            flappyBird.ShowDialog();
            //when the second form is closed, the main/this form is closed

            this.Close();
            player1.Ctlcontrols.stop();
        }

        private void lblPianoTiles_Click(object sender, EventArgs e)
        {
            player1.Ctlcontrols.stop();
            counter = 3;
            //create a local variable
            instructions flappyBird = new instructions(counter, userCoins);
            //hide the form
            this.Hide();
            //establsih a connection between this form and flappy bird form
            flappyBird.ShowDialog();
            //when the second form is closed, the main/this form is closed

            this.Close();
            
        }

        private void grbPlay_Enter(object sender, EventArgs e)
        {

        }
    }
}
