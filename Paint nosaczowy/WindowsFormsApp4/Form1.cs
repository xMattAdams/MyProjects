using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Point current = new Point();
        public Point old = new Point();
        public Pen p = new Pen(Color.Black, 5);
        public Graphics g;
        public Graphics h;
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            h = pictureBox1.CreateGraphics();
        }

        public string[,] tablica2D { get; private set; }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
            if (radioButton8.Checked)
                p.Width = 1;
            else if (radioButton7.Checked)
                p.Width = 5;
            else if (radioButton6.Checked)
                p.Width = 10;
            else if (radioButton5.Checked)
                p.Width = 20;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                current = e.Location;
                g.DrawLine(p, old, current);
                old = current;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
     


        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            int x,x1,y,y2;
            x = Convert.ToInt32(textBox3.Text);
            y = Convert.ToInt32(textBox2.Text);
            x1 = Convert.ToInt32(textBox4.Text);
            y2= Convert.ToInt32(textBox5.Text);
            Pen YellowPen = new Pen(Color.Yellow);
            h.DrawLine(YellowPen, x, y, x1, y2); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            SolidBrush Glowa = new SolidBrush(Color.DarkOrange);
            h.FillEllipse(Glowa, 20, 20, 400, 400);

            SolidBrush Twarz0 = new SolidBrush(Color.DarkOrange);
            h.FillEllipse(Twarz0, 50, 50, 300, 300);

            SolidBrush Twarz = new SolidBrush(Color.DarkOrange);
            h.FillEllipse(Twarz, 50, 50, 250, 250);

            SolidBrush Twarz2 = new SolidBrush(Color.Orange);
            h.FillEllipse(Twarz2, 50, 50, 200, 200);

            SolidBrush Twarz3 = new SolidBrush(Color.OrangeRed);
            h.FillEllipse(Twarz3, 50, 50, 150, 150);

            SolidBrush Nochal = new SolidBrush(Color.Red);
            h.FillEllipse(Nochal, 50, 50, 100, 100);

            SolidBrush Nochal2 = new SolidBrush(Color.Red);
            h.FillEllipse(Nochal2, 50, 50, 50, 50);

            SolidBrush Nochal3 = new SolidBrush(Color.Red);
            h.FillEllipse(Nochal3, 50, 50, 50, 50);

            SolidBrush Nochal4 = new SolidBrush(Color.Red);
            h.FillEllipse(Nochal4, 40, 60, 60, 60);

            SolidBrush Nochal5 = new SolidBrush(Color.Red);
            h.FillEllipse(Nochal5, 35, 70, 60, 60);

            SolidBrush Nochal6 = new SolidBrush(Color.Red);
            h.FillEllipse(Nochal6, 30, 80, 60, 60);

            SolidBrush Nochal7 = new SolidBrush(Color.Red);
            h.FillEllipse(Nochal7, 25, 90, 60, 60);

            SolidBrush Nochal8 = new SolidBrush(Color.Red);
            h.FillEllipse(Nochal8, 20, 100, 60, 60);

            SolidBrush Nochal9 = new SolidBrush(Color.Red);
            h.FillEllipse(Nochal9, 15, 110, 60, 60);

            SolidBrush Nochal10 = new SolidBrush(Color.Red);
            h.FillEllipse(Nochal10, 10, 120, 60, 60);

            SolidBrush Nochal11 = new SolidBrush(Color.Red);
            h.FillEllipse(Nochal11, 5, 130, 60, 60);


            SolidBrush Oko = new SolidBrush(Color.White);
            h.FillEllipse(Oko, 250, 10, 95, 95);

            SolidBrush Oko2 = new SolidBrush(Color.White);
            h.FillEllipse(Oko2, 200, -25, 95, 95);

            SolidBrush Zrenica = new SolidBrush(Color.Brown);
            h.FillEllipse(Zrenica, 215, 30, 30, 30);

            SolidBrush Zrenica2 = new SolidBrush(Color.Brown);
            h.FillEllipse(Zrenica2, 260, 60, 30, 30);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                p.Color = cd.Color;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
            pictureBox1.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            listBox1.Visible = true;
            button9.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox9.Text);
            int y = Convert.ToInt32(textBox10.Text);

            tablica2D = new string[x, y];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int x_ = Convert.ToInt32(textBox6.Text);
            int y_ = Convert.ToInt32(textBox7.Text);

            string w = textBox8.Text;
            tablica2D[x_, y_] = w;

        }

        private void button11_Click(object sender, EventArgs e)
        {

            foreach(string element in tablica2D)
            {

                listBox1.Items.Add(element);



            }


            

        }
    }
}
