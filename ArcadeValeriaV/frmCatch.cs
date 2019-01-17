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
    public partial class frmCatch : Form
    {
        //declare global variables
        bool goLeft;
        bool goRight;
        const int speed = 5;
        int score = 0;
        int missed = 0;
        int coins = 0;
        int fruitPosition;
        int junkPosition;
        int money = 0;
        Random rndY = new Random();
        Random rndX = new Random();
        Random rndIndex = new Random();
        

        //create two lists of images
        List<Image> fruits = new List<Image>();
        List<Image> unhealthy = new List<Image>();
        public frmCatch()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            //call te reset function
            reset();

            //add images to the fruits list
            fruits.Add(Properties.Resources.appl);
            fruits.Add(Properties.Resources.ras);
            fruits.Add(Properties.Resources.plum);
            fruits.Add(Properties.Resources.orange);
            fruits.Add(Properties.Resources.pine);

            //add images to the fruits list
            unhealthy.Add(Properties.Resources.ham);
            unhealthy.Add(Properties.Resources.hot);
            unhealthy.Add(Properties.Resources.pop_corn);

            //hide the lose screen
            grbLose.Hide();
            btnMain.Hide();

            //import sound file
            player1.URL = "catch.wav";
            player2.URL = "correct.wav";
            player3.URL = "wrong.wav";
            player4.URL = "lose.wav";

            //play the background music
            player1.Ctlcontrols.play();
        }

        //Procedure: getFruit
        //Input: void
        //Output: Image fruit
        //Description ths procedure picks a random object from fruits list
        private Image getFruit()
        {
            Image fruit;
            fruitPosition = rndIndex.Next(1, fruits.Count);
            fruit = fruits[fruitPosition];
            return fruit;
        }

        //Procedure: getJunk
        //Input: void
        //Output: Image junk
        //Description ths procedure picks a random object from fruits list
        private Image getJunk()
        {
            Image junk;
            fruitPosition = rndIndex.Next(1, unhealthy.Count);
            junk = unhealthy[fruitPosition];
            return junk;
        }


        //Function: reset
        //input: void
        //output: void
        //this function sets teh objects to theri original position
        private void reset()
        {
            //loop through each element in the form
            foreach (Control catchObject in this.Controls)
            {
                //is teh element a picture of a fruit
                if (catchObject is PictureBox && catchObject.Tag == "apple")
                {
                    //update the text
                    lblScore.Text = "Coins: " + coins;
                    lblMissed.Text = "Missed: " + missed;

                    //set the position
                    catchObject.Top = rndY.Next(100, 300) * -1;
                    catchObject.Left = rndX.Next(5, this.ClientSize.Width - catchObject.Width);
                    //set the intitial variables
                    score = 0;
                    missed = 0;
                    goLeft = false;
                    goRight = false;
                    //start the timer
                    tmrGame.Start();
                    picCoin.Show();

                }
            }
        }

        private void picBascket_Click(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void lblMissed_Click(object sender, EventArgs e)
        {

        }

        private void picHealth2_Click(object sender, EventArgs e)
        {

        }

        private void picCoin_Click(object sender, EventArgs e)
        {

        }

        private void picHealth1_Click(object sender, EventArgs e)
        {

        }

        private void picJunk_Click(object sender, EventArgs e)
        {

        }

        private void picLose_Click(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                //if teh left key is pressed move the image to the left
                goLeft = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                //if te right key is pressed move the image to the right
                goRight = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                //if teh left key is pressed set bool goLeft to false
                goLeft = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                //if te right key is pressed set bool goRight to false
                goRight = false;
            }
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {

            //update the text
            lblScore.Text = "Coins: " + coins;
            lblMissed.Text = "Missed: " + missed;
            //if teh go left boolean is true and chicken left is greater than 0
            if (goLeft == true && picBascket.Left > 0)
            {
                //move the bascket 12 pixels left
                picBascket.Left -= 12;
            }
            //if the go right is true and the bascket is within the form
            //move the bascket 12 pixels right
            else if (goRight == true && picBascket.Left + picBascket.Width < this.ClientSize.Width)
            {
                picBascket.Left += 12;
            }

            //loop through each element on the form
            foreach (Control catchObject in this.Controls)
            {
                //check if the object is an apple
                if (catchObject is PictureBox && catchObject.Tag == "apple")
                {
                    //move the object down
                    catchObject.Top += speed;
                    if (catchObject.Top + catchObject.Height > this.ClientSize.Height)
                    {
                        catchObject.Top = rndY.Next(100, 300) * -1;
                        catchObject.Left = rndX.Next(5, this.ClientSize.Width - catchObject.Width);

                        //set the images of the objects
                        picHealth1.Image = getFruit();
                        picHealth2.Image = getFruit();

                        missed = missed + 1;

                    }
                    else if (catchObject.Bounds.IntersectsWith(picBascket.Bounds))
                    {
                        catchObject.Top = rndY.Next(100, 300) * -1;
                        catchObject.Left = rndX.Next(5, this.ClientSize.Width - catchObject.Width);
                        score++;

                        //set the images of the objects
                        picHealth1.Image = getFruit();
                        picHealth2.Image = getFruit();

                        //play right sound
                        player2.Ctlcontrols.play();
                    }
                    else if (missed == 5)
                    {
                        grbLose.Show();
                        player1.Ctlcontrols.stop();
                        player4.Ctlcontrols.play();
                        btnMain.Show();
                        tmrGame.Stop();
                    }

                }
                //check if the object is an apple
                else if (catchObject is PictureBox && catchObject.Tag == "popcorn")
                {
                    //move the object down
                    catchObject.Top += speed;
                    if (catchObject.Top + catchObject.Height > this.ClientSize.Height)
                    {
                        catchObject.Top = rndY.Next(100, 300) * -1;
                        catchObject.Left = rndX.Next(5, this.ClientSize.Width - catchObject.Width);

                        //set the images of the objects
                        picJunk.Image = getJunk();

                    }
                    else if (catchObject.Bounds.IntersectsWith(picBascket.Bounds))
                    {
                        catchObject.Top = rndY.Next(100, 300) * -1;
                        catchObject.Left = rndX.Next(5, this.ClientSize.Width - catchObject.Width);

                        //set the images of the objects
                        picJunk.Image = getJunk();
                        missed = missed + 1;

                        //play wrong sound
                        player3.Ctlcontrols.play();
                    }
                    else if (missed == 5)
                    {
                        grbLose.Show();
                        player1.Ctlcontrols.stop();
                        player4.Ctlcontrols.play();
                        btnMain.Show();
                        tmrGame.Stop();
                    }

                }
                //check if the object is an apple
                else if (catchObject is PictureBox && catchObject.Tag == "coin")
                {
                    
                    //move the object down
                    catchObject.Top += speed;
                    if (catchObject.Top + catchObject.Height > this.ClientSize.Height)
                    {
                        catchObject.Top = rndY.Next(100, 300) * -1;
                        catchObject.Left = rndX.Next(5, this.ClientSize.Width - catchObject.Width);

                    }
                    //if it collides with the basket increase the score and move up
                    else if (catchObject.Bounds.IntersectsWith(picBascket.Bounds))
                    {
                        coins = coins + 10;
                        catchObject.Top = rndY.Next(100, 300) * -1;
                        catchObject.Left = rndX.Next(5, this.ClientSize.Width - catchObject.Width);
                        money++;
                        //play right sound
                        player2.Ctlcontrols.play();
                    }
                }


            }
        }


        private void btnMain_Click_1(object sender, EventArgs e)
        {
            //declare local variable
            frmMenu menu = new frmMenu(coins);
            instructions instr = new instructions(0, coins);
            Console.WriteLine(score);
            //hide the form
            this.Hide();
            //establsih a connection between this form and flappy bird form
            menu.ShowDialog();
            //when the second form is closed, the main/this form is closed
            this.Close();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {

        }
    }
}
