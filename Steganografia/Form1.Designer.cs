namespace Steganografia
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelName1 = new System.Windows.Forms.Label();
            this.labelName2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelUsedSpace = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelImageSpace = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelAvailableSpace = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelFreePer = new System.Windows.Forms.Label();
            this.labelUsedPer = new System.Windows.Forms.Label();
            this.textBoxRbits = new System.Windows.Forms.TextBox();
            this.textBoxGbits = new System.Windows.Forms.TextBox();
            this.textBoxBbits = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureBoxHidden = new System.Windows.Forms.PictureBox();
            this.buttonOpenHidden = new System.Windows.Forms.Button();
            this.panelProgressBarGreen = new System.Windows.Forms.Panel();
            this.panelProgressBar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHidden)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(432, 251);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(123, 33);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "Otwórz plik";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(409, 142);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(88, 33);
            this.buttonEncode.TabIndex = 2;
            this.buttonEncode.Text = "Zaszyfruj";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(503, 142);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(82, 33);
            this.buttonDecode.TabIndex = 3;
            this.buttonDecode.Text = "Odszyfruj";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(389, 290);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(224, 22);
            this.textBoxFilePath.TabIndex = 4;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(409, 114);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(176, 22);
            this.textBoxMessage.TabIndex = 5;
            this.textBoxMessage.Enter += new System.EventHandler(this.textBoxMessage_Enter);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(436, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wpisz wiadomość";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(619, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(373, 292);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "R";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(304, 403);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(109, 66);
            this.buttonCheck.TabIndex = 12;
            this.buttonCheck.Text = "Szukaj ukrytej wiadomości";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelName1
            // 
            this.labelName1.AutoSize = true;
            this.labelName1.Location = new System.Drawing.Point(122, 12);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(116, 17);
            this.labelName1.TabIndex = 14;
            this.labelName1.Text = "Oryginalny obraz";
            // 
            // labelName2
            // 
            this.labelName2.AutoSize = true;
            this.labelName2.Location = new System.Drawing.Point(702, 10);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(226, 17);
            this.labelName2.TabIndex = 15;
            this.labelName2.Text = "Obraz z zaszyfrowaną zawartością";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(381, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Zajęte miejsce:";
            // 
            // labelUsedSpace
            // 
            this.labelUsedSpace.Location = new System.Drawing.Point(487, 353);
            this.labelUsedSpace.Name = "labelUsedSpace";
            this.labelUsedSpace.Size = new System.Drawing.Size(134, 17);
            this.labelUsedSpace.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Wolne miejsce w obrazie:";
            // 
            // labelImageSpace
            // 
            this.labelImageSpace.Location = new System.Drawing.Point(487, 328);
            this.labelImageSpace.Name = "labelImageSpace";
            this.labelImageSpace.Size = new System.Drawing.Size(165, 17);
            this.labelImageSpace.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(494, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "G";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(577, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "B";
            // 
            // labelAvailableSpace
            // 
            this.labelAvailableSpace.Location = new System.Drawing.Point(506, 383);
            this.labelAvailableSpace.Name = "labelAvailableSpace";
            this.labelAvailableSpace.Size = new System.Drawing.Size(107, 17);
            this.labelAvailableSpace.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Dostępne miejsce:";
            // 
            // labelFreePer
            // 
            this.labelFreePer.Location = new System.Drawing.Point(633, 383);
            this.labelFreePer.Name = "labelFreePer";
            this.labelFreePer.Size = new System.Drawing.Size(101, 17);
            this.labelFreePer.TabIndex = 35;
            // 
            // labelUsedPer
            // 
            this.labelUsedPer.Location = new System.Drawing.Point(633, 353);
            this.labelUsedPer.Name = "labelUsedPer";
            this.labelUsedPer.Size = new System.Drawing.Size(90, 17);
            this.labelUsedPer.TabIndex = 36;
            // 
            // textBoxRbits
            // 
            this.textBoxRbits.Location = new System.Drawing.Point(392, 36);
            this.textBoxRbits.Name = "textBoxRbits";
            this.textBoxRbits.Size = new System.Drawing.Size(48, 22);
            this.textBoxRbits.TabIndex = 39;
            // 
            // textBoxGbits
            // 
            this.textBoxGbits.Location = new System.Drawing.Point(480, 36);
            this.textBoxGbits.Name = "textBoxGbits";
            this.textBoxGbits.Size = new System.Drawing.Size(48, 22);
            this.textBoxGbits.TabIndex = 40;
            // 
            // textBoxBbits
            // 
            this.textBoxBbits.Location = new System.Drawing.Point(565, 36);
            this.textBoxBbits.Name = "textBoxBbits";
            this.textBoxBbits.Size = new System.Drawing.Size(48, 22);
            this.textBoxBbits.TabIndex = 41;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(465, 181);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 33);
            this.buttonSave.TabIndex = 42;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // pictureBoxHidden
            // 
            this.pictureBoxHidden.Location = new System.Drawing.Point(12, 347);
            this.pictureBoxHidden.Name = "pictureBoxHidden";
            this.pictureBoxHidden.Size = new System.Drawing.Size(286, 188);
            this.pictureBoxHidden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxHidden.TabIndex = 43;
            this.pictureBoxHidden.TabStop = false;
            // 
            // buttonOpenHidden
            // 
            this.buttonOpenHidden.Location = new System.Drawing.Point(304, 469);
            this.buttonOpenHidden.Name = "buttonOpenHidden";
            this.buttonOpenHidden.Size = new System.Drawing.Size(109, 66);
            this.buttonOpenHidden.TabIndex = 44;
            this.buttonOpenHidden.Text = "Otwórz zapisany plik";
            this.buttonOpenHidden.UseVisualStyleBackColor = true;
            this.buttonOpenHidden.Click += new System.EventHandler(this.buttonOpenHidden_Click);
            // 
            // panelProgressBarGreen
            // 
            this.panelProgressBarGreen.BackColor = System.Drawing.Color.Red;
            this.panelProgressBarGreen.Location = new System.Drawing.Point(463, 440);
            this.panelProgressBarGreen.Name = "panelProgressBarGreen";
            this.panelProgressBarGreen.Size = new System.Drawing.Size(150, 14);
            this.panelProgressBarGreen.TabIndex = 46;
            this.panelProgressBarGreen.Visible = false;
            // 
            // panelProgressBar
            // 
            this.panelProgressBar.BackColor = System.Drawing.Color.Lime;
            this.panelProgressBar.Location = new System.Drawing.Point(463, 420);
            this.panelProgressBar.Name = "panelProgressBar";
            this.panelProgressBar.Size = new System.Drawing.Size(150, 14);
            this.panelProgressBar.TabIndex = 47;
            this.panelProgressBar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 547);
            this.Controls.Add(this.panelProgressBarGreen);
            this.Controls.Add(this.panelProgressBar);
            this.Controls.Add(this.buttonOpenHidden);
            this.Controls.Add(this.pictureBoxHidden);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxBbits);
            this.Controls.Add(this.textBoxGbits);
            this.Controls.Add(this.textBoxRbits);
            this.Controls.Add(this.labelUsedPer);
            this.Controls.Add(this.labelFreePer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelAvailableSpace);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelImageSpace);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelUsedSpace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelName2);
            this.Controls.Add(this.labelName1);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Steganografia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHidden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelName1;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelUsedSpace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelImageSpace;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelAvailableSpace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelFreePer;
        private System.Windows.Forms.Label labelUsedPer;
        private System.Windows.Forms.TextBox textBoxRbits;
        private System.Windows.Forms.TextBox textBoxGbits;
        private System.Windows.Forms.TextBox textBoxBbits;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBoxHidden;
        private System.Windows.Forms.Button buttonOpenHidden;
        private System.Windows.Forms.Panel panelProgressBarGreen;
        private System.Windows.Forms.Panel panelProgressBar;
    }
}

