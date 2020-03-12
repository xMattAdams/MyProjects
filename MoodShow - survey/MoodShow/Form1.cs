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
    public partial class Form1 : Form
    {
        Thread Th;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            this.Close();
            Th = new Thread(OpenNewForm);
            Th.SetApartmentState(ApartmentState.STA);
            Th.Start();
            
        }

        private void OpenNewForm(object obj)
        {
            Application.Run(new Form2());
        }


    }
}
