using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int pipeSpeed = 5;
        int gravity = 5;
        int Inscore = 0;




        public Form1()
        {
            InitializeComponent();

            endText1.Visible = false;
            endText2.Visible = false;






        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //Ruch
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            flappyBird.Top += gravity;
            scoreText.Text = " " + Inscore; 
            //Kolizje
            if (flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

            else if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds))
            {
                endGame();
            }

            else if (flappyBird.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                endGame();
            }

            //Respawn rur
            if (pipeBottom.Left< -80)
            {
                pipeBottom.Left = 1000;
                Inscore += 1;
            }

            else if (pipeTop.Left< -95)
            {
                pipeTop.Left = 1100;
                Inscore += 1;
            }
        }

        private void inGameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = true;
                gravity = -5;
            }
        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = false;
                gravity = 5;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            endText1.Visible = true;
            endText2.Visible = true;
            endText1.Text = "Koniec gry!!!";
            endText2.Text = "Wynik: " + Inscore;

            
        }



    }
}
