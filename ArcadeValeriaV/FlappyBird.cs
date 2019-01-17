using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcadeValeriaV
{
    public partial class frmFlappyBird : Form
    {
        //declare global variables
        int obstSpeed = 5;
        int gravity = 5;
        int score = 0;
        public frmFlappyBird(int birdCounter)
        {
            InitializeComponent();

            //check what bird is going to play
            if (birdCounter == 1)
            {
                picBird.Image = Properties.Resources.bird1;
            }
            else if (birdCounter == 2)
            {
                picBird.Image = Properties.Resources.bird2;
            }
            else if (birdCounter == 3)
            {
                picBird.Image = Properties.Resources.bird3;
            }

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            //cal the restart function
            restartGame();
            //hide the you lose pic
            picLose.Hide();
            btnMain.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void restartGame()
        {
            //set the initial value of coins
            lblCoins.Text = "Coins: 0";
            //set the position of the bird
            picBird.Location = new Point(12, 185);
            //reset the score
            score = 0;

        }

        private void bird_Click(object sender, EventArgs e)
        {

        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            //move the obstacles to the left by decreasing the x value
            picObst.Left -= obstSpeed;
            picObst2.Left -= obstSpeed;
            picObst3.Left -= obstSpeed;
            picCloud1.Left -= obstSpeed;
            picCloud2.Left -= obstSpeed;
            picCoin.Left -= obstSpeed;
            //move the bird down (gravity effect), by deacreasing the y value
            picBird.Top += gravity;
            //update the score
            lblCoins.Text = "Coins: " + score;

            //if the bird collides with the ground, call the endGame function
            if (picBird.Bounds.IntersectsWith(picGround.Bounds))
            {
                endGame();
            }
            //if the bird collides with the bottom obstacle, call the endGame function
            else if (picBird.Bounds.IntersectsWith(picObst.Bounds))
            {
                endGame();
            }
            //if the bird collides with the bottom obstacle, call the endGame function
            else if (picBird.Bounds.IntersectsWith(picObst2.Bounds))
            {
                endGame();
            }
            //if the bird collides with the top obstacle, call the endGame function
            else if (picBird.Bounds.IntersectsWith(picObst3.Bounds))
            {
                endGame();
            }
            //if the bird collides with the top obstacle, call the endGame function
            else if (picBird.Bounds.IntersectsWith(picCloud1.Bounds))
            {
                endGame();
            }
            //if the bird collides with the top obstacle, call the endGame function
            else if (picBird.Bounds.IntersectsWith(picCloud2.Bounds))
            {
                endGame();
            }
            //if the bird collides with the coin, increase score
            else if (picBird.Bounds.IntersectsWith(picCoin.Bounds))
            {
                score = score + 1;
                lblCoins.Text = "Coins: " + score;
                this.Controls.Remove(picCoin);
            }

            //if the obstacles go out of the screen, move the obstacles to theri initial position
            if (picObst.Left < -20)
            {
                picObst.Left = 500;
            }
           else if (picObst2.Left < -20)
            {
                picObst2.Left = 500;
            }
            else if (picObst3.Left < -20)
            {
                picObst3.Left = 500;
            }
            else if (picCloud1.Left < -35)
            {
                picCloud1.Left = 500;
            }
            else if (picCloud2.Left < -35)
            {
                picCloud2.Left = 500;
                picCoin.Show();
                this.Controls.Add(picCoin);
            }
            else if (picCoin.Left < -35)
            {
                picCoin.Left = picObst3.Left;
            }

        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            //if space bar is pressed, set gravity to -5
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            //if space bar is pressed, set gravity to 5
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void endGame()
        {
            //declare the text
            lblCoins.Text = "Coins: " + score;
            //stop the timer
            tmrGame.Stop();
            picLose.Show();
            btnMain.Show();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            //declare local variable
            frmMenu menu = new frmMenu();
            instructions instr = new instructions(0, score);
            Console.WriteLine(score);
            //hide the form
            this.Hide();
            //establsih a connection between this form and flappy bird form
            menu.ShowDialog();
            //when the second form is closed, the main/this form is closed
            this.Close();
        }
    }
}
