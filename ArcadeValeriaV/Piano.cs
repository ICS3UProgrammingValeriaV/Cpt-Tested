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
    public partial class Piano : Form
    {
        //declare global variables
        int counter = 1;
        int valueIndex;
        int x_position;
        int score = 0;
        //create list that contains the x values
        List<int> X_value = new List<int>();
        Random rndValues = new Random();
        public Piano()
        {
            InitializeComponent();
            //add positions values to the list
            X_value.Add(303);
            X_value.Add(202);
            X_value.Add(101);
            X_value.Add(0);

            //hide the pictue box and main menu button
            picLose.Hide();
            btnMain.Hide();
        }
        private void tmrFirstMove_Tick(object sender, EventArgs e)//ref PictureBox pic1, ref PictureBox pic2, ref PictureBox
        {
           
        }

        //Function: displayLose
        //input:void
        //output; void
        //stop the timer, display the piclose, display main menu button
        private void displayLose()
        {
            tmrFirstMove.Stop();
            picLose.Show();
            btnMain.Show();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (counter == 4)
            {
                counter = 1;
                valueIndex = rndValues.Next(1, X_value.Count);
                x_position = X_value[valueIndex];
                picTile4.Location = new Point(x_position, picTile3.Location.Y  - 140);
                tmrFirstMove.Start();

            }
            else
            {
                displayLose();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (counter == 3)
            {
                counter++;
                valueIndex = rndValues.Next(1, X_value.Count);
                x_position = X_value[valueIndex];
                picTile3.Location = new Point(x_position, picTile2.Location.Y - 140);
                tmrFirstMove.Start();
                //tmrFirstMove.Start(ref pictureBox1, ref pictureBox3, ref pictureBox4);

            }
            else
            {
                displayLose();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (counter == 2)
            {
                counter++;
                valueIndex = rndValues.Next(1, X_value.Count);
                x_position = X_value[valueIndex];
                picTile2.Location = new Point(x_position, picTile1.Location.Y - 140);
                tmrFirstMove.Start();
                //tmrFirstMove.Start(ref pictureBox1, ref pictureBox3, ref pictureBox4);

            }
            else
            {
                displayLose();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (counter == 1)
            {
                counter++;
                valueIndex = rndValues.Next(1, X_value.Count);
                x_position = X_value[valueIndex];
                picTile1.Location = new Point(x_position, picTile4.Location.Y - 140);
                tmrFirstMove.Start();

            }
            else
            {
                displayLose();
            }
        }

        private void tmrFirstMove_Tick_1(object sender, EventArgs e)
        {
            picTile1.Location = new Point(picTile1.Location.X, picTile1.Location.Y + 10);
            picTile2.Location = new Point(picTile2.Location.X, picTile2.Location.Y + 10);
            picTile3.Location = new Point(picTile3.Location.X, picTile3.Location.Y + 10);
            picTile4.Location = new Point(picTile4.Location.X, picTile4.Location.Y + 10);
            picCoin.Location = new Point(picCoin.Location.X, picCoin.Location.Y + 10);
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

        private void Piano_Load(object sender, EventArgs e)
        {
           
        }

        private void clickForm(object sender, MouseEventArgs e)
        {
            
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

        private void picCoin_Click(object sender, EventArgs e)
        {
                valueIndex = rndValues.Next(1, X_value.Count);
                x_position = X_value[valueIndex];
                picCoin.Location = new Point(x_position, picTile4.Location.Y - 50);
                tmrFirstMove.Start();
                score = score + 10;
             if (picCoin.Location.Y >= 470)
             {
                valueIndex = rndValues.Next(1, X_value.Count);
                x_position = X_value[valueIndex];
                picCoin.Location = new Point(x_position, picTile4.Location.Y - 50);
             }

        }
    }
}
