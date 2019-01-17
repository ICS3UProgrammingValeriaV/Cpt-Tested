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
    public partial class Piano : Form
    {
        //declare global variables
        int counter = 1;
        int valueIndex;
        int speed = 15;
        int x_position;
        int coins= 0;
        int score = 0;
        int soundCounter = 1;
        //create list that contains the x values
        List<int> X_value = new List<int>();
        Random rndValues = new Random();
        SoundPlayer pianoNote = new SoundPlayer();
        public Piano()
        {
            InitializeComponent();
            //add positions values to the list
            X_value.Add(303);
            X_value.Add(202);
            X_value.Add(101);
            X_value.Add(0);

            //hide the pictue box and main menu button
            grbLose.Hide();
            btnMain.Hide();
            lblScore.Text = "Score: " + score;
            //import sound file
            player3.URL = "lose.wav";
            player3.Ctlcontrols.play();
        }

        //Function: playSound
        //input: void
        //output: void
        //This function checks what note should be played
        private void playSound()
        {
            if (soundCounter == 1)
            {
                //play sound 
                pianoNote.SoundLocation = "0.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 2)
            {
                //play sound 
                pianoNote.SoundLocation = "1.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 3)
            {
                //play sound 
                pianoNote.SoundLocation = "2.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 4)
            {
                //play sound 
                pianoNote.SoundLocation = "3.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 5)
            {
                //play sound 
                pianoNote.SoundLocation = "4.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 6)
            {
                //play sound 
                pianoNote.SoundLocation = "5.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 7)
            {
                //play sound 
                pianoNote.SoundLocation = "6.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 8)
            {
                //play sound 
                pianoNote.SoundLocation = "7.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 9)
            {
                //play sound 
                pianoNote.SoundLocation = "8.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 10)
            {
                //play sound 
                pianoNote.SoundLocation = "9.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 11)
            {
                //play sound 
                pianoNote.SoundLocation = "10.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 12)
            {
                //play sound 
                pianoNote.SoundLocation = "11.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 13)
            {
                //play sound 
                pianoNote.SoundLocation = "12.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 14)
            {
                //play sound 
                pianoNote.SoundLocation = "13.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 15)
            {
                //play sound 
                pianoNote.SoundLocation = "14.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 16)
            {
                //play sound 
                pianoNote.SoundLocation = "15.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 17)
            {
                //play sound 
                pianoNote.SoundLocation = "16.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 18)
            {
                //play sound 
                pianoNote.SoundLocation = "17.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 19)
            {
                //play sound 
                pianoNote.SoundLocation = "18.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 20)
            {
                //play sound 
                pianoNote.SoundLocation = "19.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 21)
            {
                //play sound 
                pianoNote.SoundLocation = "20.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 22)
            {
                //play sound 
                pianoNote.SoundLocation = "21.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 23)
            {
                //play sound 
                pianoNote.SoundLocation = "22.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 24)
            {
                //play sound 
                pianoNote.SoundLocation = "23.wav";
                //increment soundCounter
                soundCounter++;
            }
            else if (soundCounter == 25)
            {
                //play sound 
                pianoNote.SoundLocation = "24.wav";
                //increment soundCounter
                soundCounter = 1;
            }
           
            //play the sound
            pianoNote.Play();
            Console.WriteLine(soundCounter);
        }
      
        //Function: displayLose
        //input:void
        //output; void
        //stop the timer, display the piclose, display main menu button
        private void displayLose()
        {
            tmrFirstMove.Stop();
            player3.Ctlcontrols.stop();
            grbLose.Show();
            btnMain.Show();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //if the user pressed the right tile
            if (counter == 4)
            {
                //call the play function
                playSound();
                //set the counter to 1
                counter = 1;
                //generate random x value
                valueIndex = rndValues.Next(1, X_value.Count);
                x_position = X_value[valueIndex];
                picTile4.Location = new Point(x_position, picTile3.Location.Y  - 140);
                //start timer
                tmrFirstMove.Start();
                //increment the score by 1
                score++;
                //increase the speed
                Console.WriteLine(score);
                if (score == 5 || score == 15 || score == 25 || score == 35 || score == 55)
                {
                    speed += 5;
                    Console.WriteLine(speed);
                }


            }
            else
            {
                //display the lose screen
                displayLose();

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //if the user pressed the right tile
            if (counter == 3)
            {
                //call the play function
                playSound();
                //increment the counter
                counter++;
                //get the random x value
                valueIndex = rndValues.Next(1, X_value.Count);
                x_position = X_value[valueIndex];
                picTile3.Location = new Point(x_position, picTile2.Location.Y - 140);
                //start the timer
                tmrFirstMove.Start();
                //tmrFirstMove.Start(ref pictureBox1, ref pictureBox3, ref pictureBox4);
                //increment the score by 1
                score++;
                //increase the speed
                Console.WriteLine(score);
                if (score == 5 || score == 15 || score == 25 || score == 35 || score == 55)
                {
                    speed += 5;
                    Console.WriteLine(speed);
                }
            }
            else
            {
                //display the lose screen
                displayLose();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //if the user pressed the right tile
            if (counter == 2)
            {
                //call the play function
                playSound();
                //increment the counter
                counter++;
                //get the random x value
                valueIndex = rndValues.Next(1, X_value.Count);
                x_position = X_value[valueIndex];
                picTile2.Location = new Point(x_position, picTile1.Location.Y - 140);
                //start the timer
                tmrFirstMove.Start();
                //tmrFirstMove.Start(ref pictureBox1, ref pictureBox3, ref pictureBox4);
                //increment the score by 1
                score++;
                //increase the speed
                Console.WriteLine(score);
                if (score == 5 || score == 15 || score == 25 || score == 35 || score == 55)
                {
                    speed += 5;
                    Console.WriteLine(speed);
                }
            }
            else
            {
                //display the lose screen
                displayLose();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //if the user pressed the right tile
            if (counter == 1)
            {
                //call the play function
                playSound();
                //increment the counter
                counter++;
                //get the random x value
                valueIndex = rndValues.Next(1, X_value.Count);
                x_position = X_value[valueIndex];
                picTile1.Location = new Point(x_position, picTile4.Location.Y - 140);
                //start the timer
                tmrFirstMove.Start();
                //increment the score by 1
                score++;
                //increase the speed
                Console.WriteLine(score);
                if (score == 5 || score == 15 || score == 25 || score == 35 || score == 55)
                {
                    speed += 5;
                    Console.WriteLine(speed);
                }
            }
            else
            {
                //display the lose screen
                displayLose();
            }
        }

        private void tmrFirstMove_Tick_1(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + score;
            //move the tiles by increment y value
            picTile1.Location = new Point(picTile1.Location.X, picTile1.Location.Y + speed);
            picTile2.Location = new Point(picTile2.Location.X, picTile2.Location.Y + speed);
            picTile3.Location = new Point(picTile3.Location.X, picTile3.Location.Y + speed);
            picTile4.Location = new Point(picTile4.Location.X, picTile4.Location.Y + speed);
            //if the tiles go out of the screen, display the lose screen
            if (picTile1.Location.Y >= 470)
            {
                displayLose();
            }
            else if (picTile2.Location.Y >= 470)
            {
                displayLose();
            }
            else if (picTile3.Location.Y >= 470)
            {
                displayLose();
            }
            else if (picTile4.Location.Y >= 470)
            {
                displayLose();
            }
           
        }

        private void btnMain_Click_2(object sender, EventArgs e)
        {
            //declare local variable
            frmMenu menu = new frmMenu(coins);
            instructions instr = new instructions(0, coins);
            Console.WriteLine(coins);
            //hide the form
            this.Hide();
            //establsih a connection between this form and flappy bird form
            menu.ShowDialog();
            //when the second form is closed, the main/this form is closed
            this.Close();
        }

        private void btnMain_Click_1(object sender, EventArgs e)
        {
            
        }


        private void Piano_Load(object sender, EventArgs e)
        {

        }

        private void clickForm(object sender, MouseEventArgs e)
        {
            //display the lose screen
            displayLose();

        }

        private void btnMain_Click(object sender, EventArgs e)
        {

        }

        private void player3_Enter(object sender, EventArgs e)
        {

        }
    }
}
