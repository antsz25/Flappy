using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy
{
    public partial class Form1 : Form
    {
        int movcount = 1;
        bool flyup = false;
        int distance = 0;
        bool gamestarted = false;
        Random position = new Random();
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        void startGame()
        {
            if (gamestarted)
            {
                bird.Location = new Point(19, 225);
                distance = position.Next(-140, 118);
                dpipeline.Location = new Point(270, -140 - distance);
                upipeline.Location = new Point(270, 270 - distance);
                lbscore.Text = "0";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int movquantity = 5;
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
            movcount = (movcount > movquantity * 2) ? 0 : movcount;
            int y = bird.Location.Y;
            int x = bird.Location.X;
            if (flyup)
            {
                y = y - 30;
                flyup = false;
            }
            else
            {
                y+=2;
            }
            bird.Location = new Point(bird.Location.X, y);

            if (bird.Bounds.IntersectsWith(pbbase.Bounds) || bird.Bounds.IntersectsWith(upipeline.Bounds) || bird.Bounds.IntersectsWith(dpipeline.Bounds))
            {
                gamestarted = false;
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
            }
            lbscore.Location = new Point(bird.Location.X+10, bird.Location.Y-25);
            lbscore.Text = (dpipeline.Location.X == bird.Location.X) ? Convert.ToString((Convert.ToInt32(lbscore.Text) + 1)).ToString() : lbscore.Text;
        
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                if (!gamestarted)
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

        private void timer2_Tick(object sender, EventArgs e)
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

        private void timer3_Tick(object sender, EventArgs e)
        {
            pbbase.Location = (pbbase.Location.X > -400) ? new Point(pbbase.Location.X - 1, pbbase.Location.Y) : pbbase.Location = new Point(-9, pbbase.Location.Y);
        }
    }
}
