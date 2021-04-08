using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass5_vs
{
    public partial class Form1 : Form
    {
        //int numOfSpins = 0;

        //static int wins = 0;
        //static int loses = 0;

        //static int finished = 0; // Holds # buttons clicked. If 3, MessageBox prompted.

        //// Hold stopped card contents
        //static string picture1;
        //static string picture2;
        //static string picture3;

        int numOfSpins = 0;

        int wins = 0;
        int loses = 0;

        static int finished = 0; // Holds # buttons clicked. If 3, MessageBox prompted.

        // Hold stopped card contents
        string picture1;
        string picture2;
        string picture3;



        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            if(numOfSpins == 0)
            {
                this.Text = "Win:" + wins +  " Lose:" + loses;
                numOfSpins++;
            }
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
        }

        //Timer Enabled - Timer's Tick Actions
        private void timer1_Tick(object sender, EventArgs e)
        {
            Picture1Flip();
        } // end method timer1_Tick

        private void timer2_Tick(object sender, EventArgs e)
        {
            Picture2Flip();
        } // end method timer2_Tick

        private void timer3_Tick(object sender, EventArgs e)
        {
            Picture3Flip();
        } // end method timer3_Tick

        //Random Flipping of 3 PictureBoxes
        private void Picture1Flip()
        {
            int pic1Number = r.Next(1, 3 + 1);
            switch (pic1Number)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Watermelon;
                    picture1 = "Watermelon";
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.Banana;
                    picture1 = "Banana";
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.Orange;
                    picture1 = "Orange";
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.Cherry;
                    picture1 = "Cherry";
                    break;
            } // end switch1
        } // end method Picture1Flip

        private void Picture2Flip()
        {
            int pic2Number = r.Next(1, 3 + 1);
            switch (pic2Number)
            {
                case 1:
                    pictureBox2.Image = Properties.Resources.Watermelon;
                    picture2 = "Watermelon";
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources.Banana;
                    picture2 = "Banana";
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources.Orange;
                    picture2 = "Orange";
                    break;
                case 4:
                    pictureBox2.Image = Properties.Resources.Cherry;
                    picture2 = "Cherry";
                    break;
            } // end switch2
        } // end method Picture2Flip

        private void Picture3Flip()
        {
            int pic3Number = r.Next(1, 3 + 1);
            switch (pic3Number)
            {
                case 1:
                    pictureBox3.Image = Properties.Resources.Watermelon;
                    picture3 = "Watermelon";
                    break;
                case 2:
                    pictureBox3.Image = Properties.Resources.Banana;
                    picture3 = "Banana";
                    break;
                case 3:
                    pictureBox3.Image = Properties.Resources.Orange;
                    picture3 = "Orange";
                    break;
                case 4:
                    pictureBox3.Image = Properties.Resources.Cherry;
                    picture3 = "Cherry";
                    break;
            } // end switch3
        } // end method Picture3Flip

        //Disabling Timer - Prompt Message Box(DisplayMessageBox), if meet req.
        private void btnX1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            finished++;
            DisplayMessageBox();
        } // end method btnX1_Click

        private void btnX2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            finished++;
            DisplayMessageBox();
        } // end method btnX2_Click

        private void btnX3_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            finished++;
            DisplayMessageBox();
        } // end method btnX3_Click

        //Prompt Message Box(DisplayMessageBox), if meet req.
        private void DisplayMessageBox()
        {
            if ( (finished == 3) && ((picture1 == picture2) && (picture2 == picture3)) )
            {
                wins++;
                this.Text = "Win:" + wins + " Lose:" + loses;
                finished = 0;
                MessageBox.Show("You win!!!", "", MessageBoxButtons.OK);
            } else
            {
                if (finished == 3)
                {
                    loses++;
                    this.Text = "Win:" + wins + " Lose:" + loses;
                    finished = 0;
                    MessageBox.Show("Try again...", "", MessageBoxButtons.OK);
                } // end inner if
            }
        } // end method DisplayMessageBox

        //Flip Button Inteval Change
        private void btnFlip_Click(object sender, EventArgs e)
        {
            if(timer1.Interval == 1000)
            {
                timer1.Interval = 500;
                timer2.Interval = 500;
                timer3.Interval = 500;
                btnFlip.Text = "Flip once/second";
            } else
            {
                if (timer1.Interval == 500)
                {
                    timer1.Interval = 1000;
                    timer2.Interval = 1000;
                    timer3.Interval = 1000;
                    btnFlip.Text = "Flip twice/second";
                } // end inner if
            }
        } // end method btnFlip_Click

        //Close Form1 if Double Clicked
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

    } // end class Form1
} // end namespace Ass5_vs