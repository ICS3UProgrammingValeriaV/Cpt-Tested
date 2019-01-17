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
    public partial class instructions : Form
    {
        //declare global variables
        int  money = 0;
        int birdCounter = 0;
        const int BIRD_1 = 200;
        const int BIRD_2 = 500;
        public instructions(int counter,int userMoney)
        {
            InitializeComponent();
            Console.WriteLine(userMoney + "user");
            //calculate the total ammount of money
            money = money + userMoney;
            lblMoney.Text = "$" + money;
            //if flappy bird button was pressed, display flappy bird instruction page
            if (counter == 1)
            {
                picInstr.Image = Properties.Resources.flappyBirdInst;
                lblCharacter.Text = "    Pick a\ncharacter";
                picBird1.Show();
                pictureBox1.Show();
                lblMoney.Show();
                lblPrice.Show();
                lblPrice2.Show();
                picBird2.Show();
                picBird3.Show();
                lblCharacter.Show();
                lblStart.Hide();
                btnStart2.Hide();
            }
            //if catch game button was pressed, display catch game instruction page
            else if (counter == 2)
            {
                picInstr.Image = Properties.Resources.instr;
                picBird1.Hide();
                picBird2.Hide();
                picBird3.Hide();
                pictureBox1.Hide();
                lblMoney.Hide();
                lblPrice.Hide();
                lblPrice2.Hide();
                lblCharacter.Hide();
                lblStart.Show();
                btnStart2.Hide();
            }
            //if piano tiles button was pressed, display piano tiles instruction page
            else if (counter == 3)
            {
                picInstr.Image = Properties.Resources.instrPiano;
                picBird1.Hide();
                picBird2.Hide();
                picBird3.Hide();
                pictureBox1.Hide();
                lblMoney.Hide();
                lblPrice.Hide();
                lblPrice2.Hide();
                lblCharacter.Hide();
                btnStart2.Show();
                lblStart.Hide();
            }
        }

        private void instructions_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            birdCounter = 1;
            //create a local variable
            frmFlappyBird flappyBird = new frmFlappyBird(birdCounter); 
            //hide the form
            this.Hide();
            //establsih a connection between this form and flappy bird form
            flappyBird.ShowDialog();
            //when the second form is closed, the main/this form is closed
            this.Close();
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {
            //if the user has enough money, enable the picture box
            if (money >= 200 )
            {
                picBird2.Enabled = true;
                money = money - BIRD_1;
                lblMoney.Text = "$" + money;

            }
        }

        private void picBird2_Click(object sender, EventArgs e)
        {
            if (picBird2.Enabled == true)
            {
                birdCounter = 2;
                //create a local variable
                frmFlappyBird flappyBird = new frmFlappyBird(birdCounter);
                //hide the form
                this.Hide();
                //establsih a connection between this form and flappy bird form
                flappyBird.ShowDialog();
                //when the second form is closed, the main/this form is closed
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //if the user has enough money, enable the picture box
            if (money >= 500)
            {
                picBird3.Enabled = true;
                money = money - BIRD_2;
                lblMoney.Text = "$" + money;

            }
        }

        private void picBird3_Click(object sender, EventArgs e)
        {
            if (picBird3.Enabled == true)
            {
                birdCounter = 3;
                //create a local variable
                frmFlappyBird flappyBird = new frmFlappyBird(birdCounter);
                //hide the form
                this.Hide();
                //establsih a connection between this form and flappy bird form
                flappyBird.ShowDialog();
                //when the second form is closed, the main/this form is closed
                this.Close();
            }
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            //create a local variable
            frmCatch flappyBird = new frmCatch();
            //hide the form
            this.Hide();
            //establsih a connection between this form and flappy bird form
            flappyBird.ShowDialog();
            //when the second form is closed, the main/this form is closed
            this.Close();
        }

        private void lblMoney_Click(object sender, EventArgs e)
        {

        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            //create a local variable
            Piano flappyBird = new Piano();
            //hide the form
            this.Hide();
            //establsih a connection between this form and flappy bird form
            flappyBird.ShowDialog();
            //when the second form is closed, the main/this form is closed
            this.Close();
        }
    }
}
