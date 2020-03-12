using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alien_Invasion
{
    public partial class Form1 : Form
    {

        //Wartosci
        bool goup; //mozemy leciec w gore
        bool godown; //mozemy leciec w dol
        bool shot = false; //sprawdzenie czy wystrzelilismy jakies pociski
        int score = 0; //licznik punktow
        int speed = 8; //szybkosc ufo i czasteczek
        Random rand = new Random(); //losowosc w generowaniu
        int playerSpeed = 7; //szybkosc helikoptera
        int index; //to do zmieniania grafik ufokow
















        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                //wciskamy przycisk - lecimy w gore
                goup = true; 
            

            }

            if (e.KeyCode==Keys.Down)
            {
                //wciskamy przycisk - lecimy w dol
                godown = true;
            }
              
               //kiedy wciskamy spacje,ale nie strzelalismy przed jej wcisnieciem - strzelamy tylko,gdy mamy wcisnieta spacje
            if(e.KeyCode == Keys.Space && shot == false)
            {
                makeBullet();
                shot = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                //puszczamy przycisk - nie lecimy w gore
                goup = false;
            }

            if(e.KeyCode == Keys.Up)
            {
                //puszczamy przycisk - nie lecimy w dol
                godown = false;
            }
             
            if(shot == true)
            {
                //puszczamy spacje - nie strzelamy
                shot = false;

            }
        }

        private void gametick(object sender, EventArgs e)
        {
            //pillar1 leci w lewa strone
            pillar1.Left -= speed;

            //pillar2 leci w lewa strone
            pillar2.Left -= speed;

            //ufo leci w lewa strone

            ufo.Left -= speed;

            foreach (Control X in this.Controls)
            {
                //jeśli X jest pictureboxem i (AND) ma nazwe "bullet",to wtedy zachowa się,według poniższych komend
                if (X is PictureBox && (string)X.Tag == "bullet")
                {

                    //pocisk leci w prawo
                    X.Left += 15;

                    //jesli pocisk wyleci poza ekran z prawej,to zniknie
                    if (X.Left > 900)
                    {
                        this.Controls.Remove(X);

                        //usuwamy X z pamieci aplikacji
                        X.Dispose();
                    }

                    //pocisk zderza sie z UFO,znika i dostajemy pkt,a UFO jest przeniesione poza screen - znika
                    if (X.Bounds.IntersectsWith(ufo.Bounds))
                    {
                        score += 1;

                        this.Controls.Remove(X);

                        X.Dispose();

                        ufo.Left = 1000;


                        //UFO pojawia sie w randomowej lokacji w pionie na screenie
                        ufo.Top = rand.Next(40, 330) - ufo.Height;

                        //uruchomienie funkcji,ktora zmienia image UFO
                        changeUFO();
                    }

                }


            }

            //wynik pokaze sie w labelu
            label1.Text = "Score:" + score;

            if (goup)
            {
                player.Top -= playerSpeed;
            }

            if (godown)
            {
                player.Top += playerSpeed;
            }
             
            //jesli pillar wyleci poza screena,pojawi sie znowu z przodu
            if(pillar1.Left < -150)
            {
                pillar1.Left = 900;
            }

            if (pillar2.Left < -150)
            {
                pillar2.Left = 1000;
            }

             //jesli ufo wylecialo poza screen albo gracz zderzyl sie z ufo albo z pillarami,to koniec gry 
             if(ufo.Left < -5 ||
                player.Bounds.IntersectsWith(ufo.Bounds) ||
                player.Bounds.IntersectsWith(pillar1.Bounds) ||
                player.Bounds.IntersectsWith(pillar2.Bounds) 
                )

            {
                //koniec gry
                gameTimer.Stop();

                //okienko z info o przegranej i ze statami
                MessageBox.Show("Przegrałeś,zniszczyłeś  " + score + " statków UFO");

                //znikanie pocisku i trafionego UFO,zachowanie pocisku,kolizja pocisku z UFO,punkty za trafione UFO 
             
            }
                                                                   

        }

        private void changeUFO()
        {
            index += 1; //najpierw zwiekszamy index,pozniej go porownujemy

            if (index > 3)
            {
                //jesli index osiagnie wartosc wieksza niz 3,wraca do wartosci 1,zeby naprzemian losowac 3 skiny ufo
                index = 1;
            }

            //zmiana skina ufo
            switch(index)
            {
                //jesli index osiagnie wartosc 1,pojawi sie skin 1 na pictureboxie4
                case 1:
                    ufo.Image = Properties.Resources.alien1;
                    break;

                //jesli index osiagnie wartosc 2,pojawi sie skin 2 na pictureboxie4
                case 2:
                    ufo.Image = Properties.Resources.alien2;
                    break;

                //jesli index osiagnie wartosc 3,pojawi sie skin 3 na pictureboxie4
                case 3:
                    ufo.Image = Properties.Resources.alien3;
                    break;
            }


        }
        
        private void makeBullet()
        {
            //nowy picturebox dla pocisku
            PictureBox bullet = new PictureBox();

            //kolorek pocisku
            bullet.BackColor = System.Drawing.Color.DarkOrange;

            //wysokosc pocisku
            bullet.Height = 5;

            //szerokosc pocisku
            bullet.Width = 10;

            //pocisk zrespi sie przed helikopterem
            bullet.Left = player.Left + player.Width;

            //pocisk zrespi sie przed helikopterem,ale idealnie posrodku
            bullet.Top = player.Top + player.Height /2;

            
            //nazywamy pocisk jako ,,bullet"
            bullet.Tag = "bullet";

            //dodajemy pocisk do gry
            this.Controls.Add(bullet);
                
                
                
                
                
                
                
        }




    }
}
