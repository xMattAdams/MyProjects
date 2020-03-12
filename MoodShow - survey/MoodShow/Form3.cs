using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MoodShow
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Picture1.Visible = false;
            Picture2.Visible = false;
            Picture3.Visible = false;
            Picture4.Visible = false;
            Picture5.Visible = false;
        }


        private void ButtonEnd_Click(object sender, EventArgs e)
        {
           if(Form2.Counter == -6)
            {
                Picture1.Visible = true;
            }

           if(Form2.Counter>-6 && Form2.Counter < 0)
            {
                Picture2.Visible = true;
            }

           if(Form2.Counter == 0)
            {
                Picture3.Visible = true;
            }

           if(Form2.Counter>0 && Form2.Counter < 5)
            {
                Picture4.Visible = true;
            }

           if(Form2.Counter == 6)
            {
                Picture5.Visible = true;
            }
        }

        
    }
}
