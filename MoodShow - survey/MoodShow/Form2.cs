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
namespace MoodShow
{
    public partial class Form2 : Form
    {
        Thread Th2;
        public Form2()
        {
            InitializeComponent();
        }
         public static int Counter;

        private void Form2_Load(object sender, EventArgs e)
        {
            ButtonYes2.Visible = false;
            ButtonNo2.Visible = false;
            Label2.Visible = false;
            ButtonYes3.Visible = false;
            ButtonNo3.Visible = false;
            Label3.Visible = false;
            ButtonYes4.Visible = false;
            ButtonNo4.Visible = false;
            Label4.Visible = false;
            ButtonYes5.Visible = false;
            ButtonNo5.Visible = false;
            Label5.Visible = false;
            ButtonYes6.Visible = false;
            ButtonNo6.Visible = false;
            Label6.Visible = false;
        }


        private void ButtonYes_Click(object sender, EventArgs e)
        {
           
            ButtonYes.Visible = false;
            ButtonNo.Visible = false;
            Label1.Visible = false;
            Counter += 1;
            ButtonYes2.Visible = true;
            ButtonNo2.Visible = true;
            Label2.Visible = true;
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            ButtonYes.Visible = false;
            ButtonNo.Visible = false;
            Label1.Visible = false;
            Counter -= 1;
            ButtonYes2.Visible = true;
            ButtonNo2.Visible = true;
            Label2.Visible = true;
        }

        private void ButtonYes2_Click(object sender, EventArgs e)
        {
            ButtonYes2.Visible = false;
            ButtonNo2.Visible = false;
            Label2.Visible = false;
            Counter += 1;
            ButtonYes3.Visible = true;
            ButtonNo3.Visible = true;
            Label3.Visible = true;
        }

        private void ButtonNo2_Click(object sender, EventArgs e)
        {
            ButtonYes2.Visible = false;
            ButtonNo2.Visible = false;
            Label2.Visible = false;
            Counter -= 1;
            ButtonYes3.Visible = true;
            ButtonNo3.Visible = true;
            Label3.Visible = true;
        }

        private void ButtonYes3_Click(object sender, EventArgs e)
        {
            ButtonYes3.Visible = false;
            ButtonNo3.Visible = false;
            Label3.Visible = false;
            Counter += 1;
            ButtonYes4.Visible = true;
            ButtonNo4.Visible = true;
            Label4.Visible = true;
        }

        private void ButtonNo3_Click(object sender, EventArgs e)
        {
            ButtonYes3.Visible = false;
            ButtonNo3.Visible = false;
            Label3.Visible = false;
            Counter -= 1;
            ButtonYes4.Visible = true;
            ButtonNo4.Visible = true;
            Label4.Visible = true;
        }

        private void ButtonYes4_Click(object sender, EventArgs e)
        {
            ButtonYes4.Visible = false;
            ButtonNo4.Visible = false;
            Label4.Visible = false;
            Counter += 1;
            ButtonYes5.Visible = true;
            ButtonNo5.Visible = true;
            Label5.Visible = true;
        }

        private void ButtonNo4_Click(object sender, EventArgs e)
        {
            ButtonYes4.Visible = false;
            ButtonNo4.Visible = false;
            Label4.Visible = false;
            Counter -= 1;
            ButtonYes5.Visible = true;
            ButtonNo5.Visible = true;
            Label5.Visible = true;
        }

        private void ButtonYes5_Click(object sender, EventArgs e)
        {
            ButtonYes5.Visible = false;
            ButtonNo5.Visible = false;
            Label5.Visible = false;
            Counter += 1;
            ButtonYes6.Visible = true;
            ButtonNo6.Visible = true;
            Label6.Visible = true;
        }

        private void ButtonNo5_Click(object sender, EventArgs e)
        {
            ButtonYes5.Visible = false;
            ButtonNo5.Visible = false;
            Label5.Visible = false;
            Counter -= 1;
            ButtonYes6.Visible = true;
            ButtonNo6.Visible = true;
            Label6.Visible = true;
        }

        private void ButtonYes6_Click(object sender, EventArgs e)
        {
            ButtonYes6.Visible = false;
            ButtonNo6.Visible = false;
            Label6.Visible = false;
            Counter += 1;
            this.Close();
            Th2 = new Thread(OpenNewForm2);
            Th2.SetApartmentState(ApartmentState.STA);
            Th2.Start();

        }

        private void ButtonNo6_Click(object sender, EventArgs e)
        {
            ButtonYes6.Visible = false;
            ButtonNo6.Visible = false;
            Label6.Visible = false;
            Counter -= 1;
            this.Close();
            Th2 = new Thread(OpenNewForm2);
            Th2.SetApartmentState(ApartmentState.STA);
            Th2.Start();
        }

        private void OpenNewForm2(object obj)
        {
            Application.Run(new Form3());
        }

       
    }
}
