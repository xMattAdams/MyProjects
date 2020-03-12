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
namespace Steganografia
{
    public partial class Form1 : Form
    {

        string fileName;
        public int fileSize = 0;
        public Bitmap image, imageDifference;
        public int bitsR = 0, bitsG = 0, bitsB = 0;


        public Form1()
        {
            InitializeComponent();

        }

        
        
        
        
        
        
        
        
        
        
        
        
        
        private char[] ConvertStringToBinary(int j, TextBox textBox)
        {
            int signDecimalValue = Convert.ToInt32(Convert.ToChar(textBox.Text.Substring(j, 1)));   // zamiana znaku "a" na liczbe 97

            var signBinaryValue = Convert.ToString(signDecimalValue, 2)     // zamiana 97 na binary 01101000
                    .PadLeft(8, '0')
                    .ToArray();

            return signBinaryValue;
        }


        private char[] ConvertByteToBinary(int j, byte b)
        {
            int signBytelValue = Convert.ToInt32(Convert.ToChar(b));   // zamiana znaku "a" na liczbe 97

            var signBinaryValue = Convert.ToString(signBytelValue, 2)     // zamiana 97 na binary 01101000
                    .PadLeft(8, '0')
                    .ToArray();

            return signBinaryValue;
        }



        private void DisplayCapacity(Image image, int file)
        {
            double imageCapacityBits;
            double imageUsedBits;
            double imageAvailableBits;
            double imageAvailableBitsPercentage;

            imageCapacityBits = image.Width * image.Height;
            imageUsedBits = file;
            imageAvailableBits = imageCapacityBits - imageUsedBits;
            imageAvailableBitsPercentage = (imageAvailableBits / imageCapacityBits) * 100;

            labelImageSpace.Text =  imageCapacityBits + "b (" + Math.Round((imageCapacityBits / 8000), 2) + "kB)";
            labelUsedSpace.Text = imageUsedBits + "b (" + Math.Round((imageUsedBits / 8000), 2) + "kB)";
            labelAvailableSpace.Text =  imageAvailableBits + "b (" + Math.Round((imageAvailableBits / 8000), 2) + "kB)";

            labelFreePer.Text = Math.Round(imageAvailableBitsPercentage, 2) + " (%)";
            labelUsedPer.Text = Math.Round((100D - imageAvailableBitsPercentage), 2) + " (%)";

            panelProgressBar.Visible = true;
            panelProgressBarGreen.Visible = true;

            //double width = 414 * (200D * imageAvailableBitsPercentage / 100);
            panelProgressBarGreen.Width = Convert.ToInt32(imageUsedBits/100);
            panelProgressBar.Width = Convert.ToInt32(imageAvailableBits / 100);
            Console.WriteLine(panelProgressBarGreen.Width);
        }







        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files (*.png; *.jpg)|*.png; *.jpg";
            openDialog.InitialDirectory = @"C:\Users\matix\Desktop";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openDialog.FileName.ToString();
                pictureBox1.ImageLocation = textBoxFilePath.Text;


            }


        }



























        private void buttonEncode_Click(object sender, EventArgs e)
        {


            if (pictureBox1.Image != null &&
                textBoxRbits.Text != "" &&
                textBoxGbits.Text != "" &&
                textBoxBbits.Text != "")
            {
                int.TryParse(textBoxRbits.Text, out bitsR);
                int.TryParse(textBoxGbits.Text, out bitsG);
                int.TryParse(textBoxBbits.Text, out bitsB);

                Bitmap imageOriginal = new Bitmap(pictureBox1.ImageLocation);

                for (int i = 0; i < imageOriginal.Width; i++)
                {
                    for (int j = 0; j < imageOriginal.Height; j++)
                    {
                        string signValueR = "", signValueG = "", signValueB = "";
                        Color pixel = imageOriginal.GetPixel(i, j);

                        if ((i * imageOriginal.Height) + j < textBoxMessage.TextLength)
                        {
                            var signBinaryValue = ConvertStringToBinary(j, textBoxMessage);

                            for (int y = 0; y < 8; y++)
                            {
                                if (y >= 0 && y <= bitsR - 1)
                                    signValueR += signBinaryValue[y].ToString();
                                if (y > bitsR - 1 && y <= bitsR + bitsG - 1)
                                    signValueG += signBinaryValue[y].ToString();                // dzielenie bitow na czesci 11 110 100
                                if (y > bitsR + bitsG - 1 && y <= bitsR + bitsG + bitsB - 1)
                                    signValueB += signBinaryValue[y].ToString();
                            }

                            imageOriginal.SetPixel(i, j, Color.FromArgb(
                                ((pixel.R >> bitsR) << bitsR) + Convert.ToInt32(signValueR, 2),
                                ((pixel.G >> bitsG) << bitsG) + Convert.ToInt32(signValueG, 2),     // zerowanie pierwszych bitsR bitów i
                                ((pixel.B >> bitsB) << bitsB) + Convert.ToInt32(signValueB, 2)));   // dodanie odpowiednich wartosci do kanalow
                        }
                        else if ((i * imageOriginal.Height) + j == textBoxMessage.TextLength)
                        {
                            string[] endValue = new string[] { "0", "0", "0", "0", "0", "0", "0", "0" };

                            for (int y = 0; y < 8; y++)
                            {
                                if (y >= 0 && y <= bitsR - 1)
                                    signValueR += endValue[y].ToString();
                                if (y > bitsR - 1 && y <= bitsR + bitsG - 1)
                                    signValueG += endValue[y].ToString();                // dzielenie bitow na czesci 11 110 100
                                if (y > bitsR + bitsG - 1 && y <= bitsR + bitsG + bitsB - 1)
                                    signValueB += endValue[y].ToString();
                            }

                            imageOriginal.SetPixel(i, j, Color.FromArgb(
                                ((pixel.R >> bitsR) << bitsR) + Convert.ToInt32(signValueR, 2),
                                ((pixel.G >> bitsG) << bitsG) + Convert.ToInt32(signValueG, 2),
                                ((pixel.B >> bitsB) << bitsB) + Convert.ToInt32(signValueB, 2)));

                            DisplayCapacity(imageOriginal, textBoxMessage.TextLength);
                        }
                    }
                }
                pictureBox2.Image = imageOriginal;
            }
            else if (pictureBox1.Image == null) MessageBox.Show("Choose image to encrypt!");
            else if (textBoxRbits.Text == "" ||
                textBoxGbits.Text == "" ||
                textBoxBbits.Text == "") MessageBox.Show("Choose the number of RGB bits to encrypt!");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogSave = new SaveFileDialog();
            dialogSave.Filter = "Image (*.png) | *.png;";

            if (pictureBox2.Image != null && dialogSave.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(dialogSave.FileName);
            }
            else if (pictureBox2.Image == null) MessageBox.Show("Load encrypted image!");
        }

        private void textBoxMessage_Enter(object sender, EventArgs e)
        {
            textBoxMessage.Text = "";
        }

        private void buttonOpenHidden_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogOpen = new OpenFileDialog();
            dialogOpen.Filter = "All files (*.*) | *.*;";

            if (dialogOpen.ShowDialog() == DialogResult.OK)
            {
                fileName = dialogOpen.FileName.ToString();
                pictureBoxHidden.ImageLocation = fileName;
            }
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null &&
                textBoxRbits.Text != "" &&
                textBoxGbits.Text != "" &&
                textBoxBbits.Text != "")
            {
                int temp = 1;
                int.TryParse(textBoxRbits.Text, out bitsR);
                int.TryParse(textBoxGbits.Text, out bitsG);
                int.TryParse(textBoxBbits.Text, out bitsB);

                Bitmap image = new Bitmap(pictureBox1.ImageLocation);
                for (int i = 0; i < image.Width; i++)
                {
                    for (int j = 0; j < image.Height; j++)
                    {
                        if (temp != 0)
                        {
                            string signValueR = "", signValueG = "", signValueB = "";
                            string signBinarySum = "";

                            Color pixel = image.GetPixel(i, j);
                            int R = pixel.R, G = pixel.G, B = pixel.B;

                            //Console.WriteLine(R + " " + G + " " + B);
                            var binaryR = Convert.ToString(R, 2).PadLeft(8, '0').ToArray();
                            var binaryG = Convert.ToString(G, 2).PadLeft(8, '0').ToArray();     // zamiana 97 na binary 01101000
                            var binaryB = Convert.ToString(B, 2).PadLeft(8, '0').ToArray();

                            for (int y = 8 - bitsR; y < 8; y++)
                            {
                                signValueR += binaryR[y].ToString();
                            }
                            for (int y = 8 - bitsG; y < 8; y++)
                            {
                                signValueG += binaryG[y].ToString();
                            }
                            for (int y = 8 - bitsB; y < 8; y++)
                            {
                                signValueB += binaryB[y].ToString();
                            }
                            //Console.WriteLine(signValueR + " " + signValueG + " " + signValueB);

                            signBinarySum += signValueR + signValueG + signValueB;  //string 11 100 101
                            temp = Convert.ToInt32(signBinarySum, 2);
                            char let = Convert.ToChar(temp);
                            Console.WriteLine(temp);
                            //Console.WriteLine(temp + " " + let);
                            //Console.WriteLine(signValueR + " " + signValueG + " " + signValueB);
                            textBoxMessage.Text += let.ToString();

                        }
                        if (i < 1 && j < textBoxMessage.TextLength)
                        {

                            //int signDecimalValue = Convert.ToInt32(Convert.ToChar(textBoxMessage.Text.Substring(j, 1)));   // zamiana znaku "a" na liczbe 97

                            //Console.WriteLine(signDecimalValue);
                            //Console.WriteLine(signValueR + " " + signValueG + " " + signValueB);
                            //Console.WriteLine(Convert.ToInt32(signValueR, 2) + " " + Convert.ToInt32(signValueG, 2) + " " + Convert.ToInt32(signValueB, 2));
                        }
                    }
                }

                //for (int i = 0; i < 200; i++)
                //{
                //    for (int j = 0; j < 1; j++)
                //    {
                //        if (i < 1 && j < 10)
                //        {
                //            Color pixel = new Bitmap(pictureBoxOriginal.Image).GetPixel(i, j);
                //            Color pixelD = new Bitmap(pictureBoxEncoded.Image).GetPixel(i, j);
                //            Console.WriteLine("Decoded: " + pixel.R + " " + pixel.G + " " + pixel.B);
                //            Console.WriteLine("Encoded: " + pixelD.R + " " + pixelD.G + " " + pixelD.B);
                //        }
                //    }
                //}
            }
            else if (pictureBox1.Image == null) MessageBox.Show("Wybierz obraz do szyfrowania!");
            else if (textBoxRbits.Text == "" ||
                textBoxGbits.Text == "" ||
                textBoxBbits.Text == "") MessageBox.Show("Wybierz wartość RGB do szyfrowania");
        }

















        //sprawdzenie koloru drugiego pixela od końca (jeżeli jest pusty, została wykonana operacja zaszyfrowania)
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null && pictureBoxHidden.Image != null)
            {
                Bitmap imageOriginal = new Bitmap(pictureBox1.ImageLocation);
                Bitmap imageToCheck = new Bitmap(pictureBoxHidden.ImageLocation);

                bool imageClear = true;

                for (int i = 0; i < imageOriginal.Width; i++)
                {
                    if (imageClear == true)
                    {
                        for (int j = 0; j < imageOriginal.Height; j++)
                        {
                            Color pixelOriginal = imageOriginal.GetPixel(i, j);
                            Color pixelToCheck = imageToCheck.GetPixel(i, j);

                            if (pixelOriginal.R != pixelToCheck.R ||
                                pixelOriginal.G != pixelToCheck.G ||
                                pixelOriginal.B != pixelToCheck.B)
                            {
                                imageClear = false;
                                break;
                            }
                        }
                    }
                    else break;
                }
                if (imageClear == true) MessageBox.Show("Obraz nie zawiera ukrytej wiadomości!");
                else if (imageClear == false) MessageBox.Show("Wykryto ukrytą wiadomość!");
            }
            else MessageBox.Show("Wczytaj oryginalny i zaszyfrowany obraz!");




        }
        
        //private void buttonForBar_Click(object sender, EventArgs e)
        //{
        //    panelProgressBarGreen.Width += 10;
        //    Console.WriteLine(panelProgressBarGreen.Width);
        //}









    }
}
