using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace ArcadeValeriaV
{
    public partial class frmSplashScreen : Form
    {
        
        public frmSplashScreen()
        {
            InitializeComponent();
            tmrBurn.Start();

        }
        private void picLogo_Click(object sender, EventArgs e)
        {


        }

        private void tmrBurn_Tick(object sender, EventArgs e)
        {
            //declare local variable
            SoundPlayer backgroundMusic = new SoundPlayer();
            //get sound file
            backgroundMusic.SoundLocation = "fire.wav";
            //play the sound
            backgroundMusic.Play();

            //create a global variable
            frmMenu menuForm = new frmMenu(0);

            const int MAX_FRAMES = 9;
            
            for (int counter = 1; counter <= MAX_FRAMES; counter ++)
            {
                if (counter == 1)
                {
                    picLogo.Image = Properties.Resources.fireText2;
                    picCompany.Image = Properties.Resources.GameVille1;
                }
                else if (counter == 2)
                {
                    picLogo.Image = Properties.Resources.fireText3;
                    picCompany.Image = Properties.Resources.GameVille2;
                }
                else if (counter == 3)
                {
                    picLogo.Image = Properties.Resources.fireText4;
                    picCompany.Image = Properties.Resources.GameVille3;
                }
                else if (counter == 4)
                {
                    picLogo.Image = Properties.Resources.fireText5;
                    picCompany.Image = Properties.Resources.GameVille4;
                }
                else if (counter == 5)
                {
                    picLogo.Image = Properties.Resources.fireText6;
                    picCompany.Image = Properties.Resources.GameVille5;
                }
                else if (counter == 6)
                {
                    picLogo.Image = Properties.Resources.fireText7;
                    picCompany.Image = Properties.Resources.GameVille6;
                }
                else if (counter == 7)
                {
                    picLogo.Image = Properties.Resources.fireText8;
                    picCompany.Image = Properties.Resources.GameVille7;
                }
                else if (counter == 8)
                {
                    picLogo.Image = Properties.Resources.fireText9;
                    picCompany.Image = Properties.Resources.GameVille8;
                }
                else if (counter == 9)
                {
                    picLogo.Image = Properties.Resources.fireText10;
                    picCompany.Image = Properties.Resources.GameVille9;
                    tmrBurn.Stop();
                    //hide this form
                    this.Hide();
                    //establsih a connection between this form and second/game form
                    menuForm.ShowDialog();
                    //when the second form is closed, the main/this form is closed
                    this.Close();
                }
                //refresh the form
                this.Refresh();
                //pause the loop for 100 miliseconds
                Thread.Sleep(5);

            }           
        }

        private void picCompany_Click(object sender, EventArgs e)
        {

        }
    }   
}
