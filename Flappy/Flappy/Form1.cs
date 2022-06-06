using System;
using System.Drawing;
using System.Windows.Forms;

namespace Flappy
{
    public partial class Form1 : Form
    {
        int movcount = 1; // Control for move the bird using the animations of that 
        bool flyup = false; // Variable to know when use the space to up
        int distance = 0; // Distance variable between the pipelines
        bool gamestarted = false; // Stop the game when the bird crash in a wall or it'll start soon
        Random position = new Random();//Variable to make a position of the pipelines.
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        void startGame()//Method to start game
        {
            if (gamestarted)//Check if the game can start (in other words, if the space key was triggered)
            {
                bird.Location = new Point(19, 225);
                distance = position.Next(-140, 118);
                dpipeline.Location = new Point(270, -140 - distance);
                upipeline.Location = new Point(270, 270 - distance);
                lbscore.Text = "0";
            }
        }
        private void timer1_Tick(object sender, EventArgs e) // Timer to control the state of the bird
        {

            int movquantity = 5;//Declare this to get a limit of the movement
            if (movcount <= movquantity)
            {
                bird.Image = Properties.Resources.birdmovu;
                movcount++;
            }
            if ((movcount > movquantity / 2) && (movcount <= movquantity * 2))
            {
                bird.Image = Properties.Resources.birdmovd;
                movcount++;
            }
            movcount = (movcount > movquantity * 2) ? 0 : movcount;//return the movcount to 0 when get a limit of 10
            int y = bird.Location.Y;
            int x = bird.Location.X;
            if (flyup)//Fly movement of bird.
            {
                y = y - 30;
                flyup = false;
            }
            else//If don't press the Space Key, the bird will fall down
            {
                y+=2;
            }
            bird.Location = new Point(bird.Location.X, y);//Create a new position of the bird.

            //Determines if the limits of the object of the bird intersect with another object of te scenary
            if (bird.Bounds.IntersectsWith(pbbase.Bounds) || bird.Bounds.IntersectsWith(upipeline.Bounds) || bird.Bounds.IntersectsWith(dpipeline.Bounds))
            {
                //if this true, the game will finish
                gamestarted = false;
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
            }
            lbscore.Location = new Point(bird.Location.X+10, bird.Location.Y-25); //track the movement of the bird
            lbscore.Text = (dpipeline.Location.X == bird.Location.X) ? Convert.ToString((Convert.ToInt32(lbscore.Text) + 1)).ToString() : lbscore.Text;// Get the case when the bird goes between of the pipelines, making +1 to score.
        
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Space)) // control the space key pressed
            {
                if (!gamestarted)//Start the game if don't be started
                {
                    gamestarted = true;
                    startGame();
                    timer1.Start();
                    timer2.Start();
                    timer3.Start();
                }
                flyup = true;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)// Timer to control the generator of pipelines in the map
        {
            if(dpipeline.Location.X > -50)
            {
                dpipeline.Location = new Point(dpipeline.Location.X - 1, dpipeline.Location.Y);
                upipeline.Location = new Point(upipeline.Location.X - 1, upipeline.Location.Y);
            }
            else
            {
                distance = position.Next(-140, 118);
                dpipeline.Location = new Point(250, -140+distance);
                upipeline.Location = new Point(250, 270 + distance);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)//Timer to control the base of the map.
        {
            pbbase.Location = (pbbase.Location.X > -400) ? new Point(pbbase.Location.X - 1, pbbase.Location.Y) : pbbase.Location = new Point(-9, pbbase.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
