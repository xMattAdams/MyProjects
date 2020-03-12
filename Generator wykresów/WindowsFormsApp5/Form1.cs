using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            //x
            g.DrawLine(new Pen(new SolidBrush(Color.Red)), new Point(0, 200), new Point(800, 200));
            //y
            g.DrawLine(new Pen(new SolidBrush(Color.Red)), new Point(440, 50), new Point(440, 350));

            //strzałka x
            g.DrawLine(new Pen(new SolidBrush(Color.Red)), new Point(680, 195), new Point(700, 200));
            g.DrawLine(new Pen(new SolidBrush(Color.Red)), new Point(680, 205), new Point(700, 200));

            //strzałka y
            g.DrawLine(new Pen(new SolidBrush(Color.Red)), new Point(435, 70), new Point(440, 50));
            g.DrawLine(new Pen(new SolidBrush(Color.Red)), new Point(445, 70), new Point(440, 50));

            //podziałki na x
            int x_ = 0;
            int y_ = 200;
            for (int x = 0; x<15; x++)
            {
                g.DrawLine(new Pen(new SolidBrush(Color.Red)), new Point(x_ + 63, y_ + 3), new Point(x_ + 63, y_ - 3));
                x_ += 63;
            }

            //podziałki na y
            x_ = 440;
             y_ = 50;
            for (int x=0; x<6; x++)
            {
                g.DrawLine(new Pen(new SolidBrush(Color.Red)), new Point(x_ - 3, y_ + 30), new Point(x_ + 3, y_ + 30));
                y_ += 40;
            }



            


        }
        float xMax = 40;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            xMax = (float)numericUpDown1.Value; 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            
            //cosinusik <3
            float x1 = 0;
            float y1 = 0;
            float y2 = 0;
            float yMax = 200;
       
            Pen p = new Pen(Brushes.Black, 3.0F);
            for (float x = 0; x < 39; x += 0.2F)
            {
                y2 = (float)Math.Sin(x);

                g.DrawLine(p, x1 * xMax, y1 * xMax + yMax, x * xMax, y2 * xMax + yMax);

                x1 = x;
                y1 = y2;
            }

            
        }
       
        private void button3_Click(object sender, EventArgs e)
        {

            Graphics g = pictureBox1.CreateGraphics();
            //sinusik DNA <3
            float x2 = 0;
            float y3 = 0;
            float y4 = 0;
            float yMax2 = 200;
            float xMax2 = 46;
            Pen p2 = new Pen(Brushes.Black, 3.0F);
            for (float x = 0; x < 30; x += 0.2F)
            {
                y3 = (float)Math.Sin(x);

                g.DrawLine(p2, x2 * xMax2, y3 * xMax2 + yMax2, x * xMax2, y4 * xMax2 + yMax2);

                x2 = x;
                y3 = y4;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

       
    }
}
