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
    public partial class frmMenu : Form
    {
        //declare global variable
        int counter = 1;
       
        public frmMenu()
        {
            InitializeComponent();
            //hide play game box
            grbPlay.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblPlay_Click(object sender, EventArgs e)
        {
            //display play game box
            grbPlay.Show();
        }

        private void lblCredits_Click(object sender, EventArgs e)
        {

        }

       
        private void lblBack_Click(object sender, EventArgs e)
        {
            //hide play group box
            grbPlay.Hide();
        }

        private void picFlappyBird_Click(object sender, EventArgs e)
        {
            counter = 1;
            //create a local variable
            instructions flappyBird = new instructions(counter,0);
            //hide the form
            this.Hide();
            //establsih a connection between this form and flappy bird form
            flappyBird.ShowDialog();
            //when the second form is closed, the main/this form is closed

            this.Close();
        }

        private void lblFlappyBird_Click(object sender, EventArgs e)
        {
            counter = 1;
            //create a local variable
            instructions flappyBird = new instructions(counter, 0);
            //hide the form
            this.Hide();
            //establsih a connection between this form and flappy bird form
            flappyBird.ShowDialog();
            //when the second form is closed, the main/this form is closed
            
            this.Close();
        }

        private void lblCathcGame_Click(object sender, EventArgs e)
        {
            counter = 2;
            //create a local variable
            instructions flappyBird = new instructions(counter, 0);
            //hide the form
            this.Hide();
            //establsih a connection between this form and flappy bird form
            flappyBird.ShowDialog();
            //when the second form is closed, the main/this form is closed

            this.Close();
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            counter = 2;
            //create a local variable
            instructions flappyBird = new instructions(counter, 0);
            //hide the form
            this.Hide();
            //establsih a connection between this form and flappy bird form
            flappyBird.ShowDialog();
            //when the second form is closed, the main/this form is closed

            this.Close();
        }

        private void picPianoTiles_Click(object sender, EventArgs e)
        {
            counter = 3;
            //create a local variable
            instructions flappyBird = new instructions(counter, 0);
            //hide the form
            this.Hide();
            //establsih a connection between this form and flappy bird form
            flappyBird.ShowDialog();
            //when the second form is closed, the main/this form is closed

            this.Close();
        }

        private void lblPianoTiles_Click(object sender, EventArgs e)
        {
            counter = 3;
            //create a local variable
            instructions flappyBird = new instructions(counter, 0);
            //hide the form
            this.Hide();
            //establsih a connection between this form and flappy bird form
            flappyBird.ShowDialog();
            //when the second form is closed, the main/this form is closed

            this.Close();
        }
    }
}
