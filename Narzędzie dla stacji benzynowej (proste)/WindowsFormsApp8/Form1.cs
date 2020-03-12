using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Wprowadź dane transakcji.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox3.Text = dialog.FileName;
                File.WriteAllText(dialog.FileName, textBox1.Text);

                MessageBox.Show("Transakcja zapisana pomyślnie.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
                return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox3.Text = dialog.FileName;
                var test = File.ReadLines(dialog.FileName);
                textBox3.Text = dialog.FileName;
                textBox2.Text = File.ReadAllText(dialog.FileName);

            }
            else
                return;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
        }
        //Kasa
        string Liczba1, Liczba2;
        char Dzialanie = ' ';
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bOdejmowanie_Click(object sender, EventArgs e)
        {
            Dzialanie = '-';
            tbWynik.Text = "";
        }

        private void bDodawanie_Click(object sender, EventArgs e)
        {
            Dzialanie = '+';
            tbWynik.Text = "";
        }

        private void bMnozenie_Click(object sender, EventArgs e)
        {
            Dzialanie = '*';
            tbWynik.Text = "";
        }

        private void bDzielenie_Click(object sender, EventArgs e)
        {
            Dzialanie = '/';
            tbWynik.Text = "";
            
           

              
        }

        private void bWynik_Click(object sender, EventArgs e)
        {
            switch (Dzialanie)
            {
                case ('+'):
                    tbWynik.Text = (int.Parse(Liczba1) + int.Parse(Liczba2)).ToString();
                    break;

                case ('-'):
                    tbWynik.Text = (int.Parse(Liczba1) - int.Parse(Liczba2)).ToString();
                    break;

                case ('*'):
                    tbWynik.Text = (int.Parse(Liczba1) * int.Parse(Liczba2)).ToString();
                    break;

                case ('/'):
                    tbWynik.Text = (int.Parse(Liczba1) / int.Parse(Liczba2)).ToString();
                    


                    break;

                    
                    

                    



            }
            Liczba1 = "";
            Liczba2 = "";
            Dzialanie = ' ';

        }

        private void b0_Click(object sender, EventArgs e)
        {
            Dzialanie2(0);

        }

        private void b7_Click(object sender, EventArgs e)
        {
            Dzialanie2(7);

        }

        private void b8_Click(object sender, EventArgs e)
        {
            Dzialanie2(8);

        }

        private void b9_Click(object sender, EventArgs e)
        {
            Dzialanie2(9);


        }

        private void b6_Click(object sender, EventArgs e)
        {
            Dzialanie2(6);

        }

        private void b5_Click(object sender, EventArgs e)
        {
            Dzialanie2(5);

        }

        private void b4_Click(object sender, EventArgs e)
        {
            Dzialanie2(4);

        }

        private void b1_Click(object sender, EventArgs e)
        {
            Dzialanie2(1);

        }

        private void b2_Click(object sender, EventArgs e)
        {
            Dzialanie2(2);

        }

        private void b3_Click(object sender, EventArgs e)
        {
            Dzialanie2(3);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Dzialanie2(int liczba)
        {

            if (Dzialanie == ' ')
            {
                Liczba1 += liczba;
                tbWynik.Text = Liczba1;
            }
            else
            {
                Liczba2 += liczba;
                tbWynik.Text = Liczba2;
            }

        }



    }
}








    

