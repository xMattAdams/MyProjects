namespace WindowsFormsApp8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbWynik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bDodawanie = new System.Windows.Forms.Button();
            this.bOdejmowanie = new System.Windows.Forms.Button();
            this.bMnozenie = new System.Windows.Forms.Button();
            this.bDzielenie = new System.Windows.Forms.Button();
            this.bWynik = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.GreenYellow;
            this.button3.Location = new System.Drawing.Point(376, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Zapisz";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Aqua;
            this.button4.Location = new System.Drawing.Point(491, 414);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Odczytaj";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Info;
            this.button5.Location = new System.Drawing.Point(608, 414);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 41);
            this.button5.TabIndex = 4;
            this.button5.Text = "Wyczyść";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(369, 127);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 111);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(376, 276);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(321, 111);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(376, 33);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(321, 39);
            this.textBox3.TabIndex = 7;
            // 
            // tbWynik
            // 
            this.tbWynik.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWynik.Location = new System.Drawing.Point(956, 51);
            this.tbWynik.Multiline = true;
            this.tbWynik.Name = "tbWynik";
            this.tbWynik.Size = new System.Drawing.Size(270, 60);
            this.tbWynik.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Miejsce zapisu transakcji";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lista produktów i należność";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Zapis transakcji";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.Gold;
            this.b1.Location = new System.Drawing.Point(956, 127);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 48);
            this.b1.TabIndex = 12;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.Gold;
            this.b2.Location = new System.Drawing.Point(1053, 127);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 48);
            this.b2.TabIndex = 13;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.Gold;
            this.b3.Location = new System.Drawing.Point(1151, 127);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 48);
            this.b3.TabIndex = 14;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.Gold;
            this.b4.Location = new System.Drawing.Point(956, 203);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 48);
            this.b4.TabIndex = 15;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.Gold;
            this.b5.Location = new System.Drawing.Point(1053, 203);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(75, 48);
            this.b5.TabIndex = 16;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.Color.Gold;
            this.b6.Location = new System.Drawing.Point(1151, 203);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(75, 48);
            this.b6.TabIndex = 17;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.Color.Gold;
            this.b7.Location = new System.Drawing.Point(956, 276);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(75, 48);
            this.b7.TabIndex = 18;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.Color.Gold;
            this.b8.Location = new System.Drawing.Point(1053, 276);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(75, 48);
            this.b8.TabIndex = 19;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.Color.Gold;
            this.b9.Location = new System.Drawing.Point(1151, 276);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(75, 48);
            this.b9.TabIndex = 20;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // bDodawanie
            // 
            this.bDodawanie.BackColor = System.Drawing.Color.GreenYellow;
            this.bDodawanie.Location = new System.Drawing.Point(956, 398);
            this.bDodawanie.Name = "bDodawanie";
            this.bDodawanie.Size = new System.Drawing.Size(75, 46);
            this.bDodawanie.TabIndex = 21;
            this.bDodawanie.Text = "+";
            this.bDodawanie.UseVisualStyleBackColor = false;
            this.bDodawanie.Click += new System.EventHandler(this.bDodawanie_Click);
            // 
            // bOdejmowanie
            // 
            this.bOdejmowanie.BackColor = System.Drawing.Color.OrangeRed;
            this.bOdejmowanie.Location = new System.Drawing.Point(956, 450);
            this.bOdejmowanie.Name = "bOdejmowanie";
            this.bOdejmowanie.Size = new System.Drawing.Size(75, 47);
            this.bOdejmowanie.TabIndex = 22;
            this.bOdejmowanie.Text = "-";
            this.bOdejmowanie.UseVisualStyleBackColor = false;
            this.bOdejmowanie.Click += new System.EventHandler(this.bOdejmowanie_Click);
            // 
            // bMnozenie
            // 
            this.bMnozenie.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bMnozenie.Location = new System.Drawing.Point(1053, 398);
            this.bMnozenie.Name = "bMnozenie";
            this.bMnozenie.Size = new System.Drawing.Size(75, 46);
            this.bMnozenie.TabIndex = 23;
            this.bMnozenie.Text = "*";
            this.bMnozenie.UseVisualStyleBackColor = false;
            this.bMnozenie.Click += new System.EventHandler(this.bMnozenie_Click);
            // 
            // bDzielenie
            // 
            this.bDzielenie.BackColor = System.Drawing.Color.Orange;
            this.bDzielenie.Location = new System.Drawing.Point(1053, 450);
            this.bDzielenie.Name = "bDzielenie";
            this.bDzielenie.Size = new System.Drawing.Size(75, 47);
            this.bDzielenie.TabIndex = 24;
            this.bDzielenie.Text = "/";
            this.bDzielenie.UseVisualStyleBackColor = false;
            this.bDzielenie.Click += new System.EventHandler(this.bDzielenie_Click);
            // 
            // bWynik
            // 
            this.bWynik.BackColor = System.Drawing.Color.Yellow;
            this.bWynik.Location = new System.Drawing.Point(1151, 398);
            this.bWynik.Name = "bWynik";
            this.bWynik.Size = new System.Drawing.Size(75, 99);
            this.bWynik.TabIndex = 25;
            this.bWynik.Text = "=";
            this.bWynik.UseVisualStyleBackColor = false;
            this.bWynik.Click += new System.EventHandler(this.bWynik_Click);
            // 
            // b0
            // 
            this.b0.BackColor = System.Drawing.Color.Gold;
            this.b0.Location = new System.Drawing.Point(1053, 345);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(75, 47);
            this.b0.TabIndex = 26;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = false;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.listBox2.Font = new System.Drawing.Font("Lucida Calligraphy", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 29;
            this.listBox2.Items.AddRange(new object[] {
            "LPG - 2 zl",
            "Diesel - 4 zl",
            "Benzyna - 5 zl",
            "",
            "Zapiekanka - 7 zl",
            "Tortilla - 10 zl"});
            this.listBox2.Location = new System.Drawing.Point(28, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(236, 265);
            this.listBox2.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp8.Properties.Resources._1691161003_f1c792;
            this.ClientSize = new System.Drawing.Size(1292, 533);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bWynik);
            this.Controls.Add(this.bDzielenie);
            this.Controls.Add(this.bMnozenie);
            this.Controls.Add(this.bOdejmowanie);
            this.Controls.Add(this.bDodawanie);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbWynik);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Narzędzie stacji benzynowej";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbWynik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bDodawanie;
        private System.Windows.Forms.Button bOdejmowanie;
        private System.Windows.Forms.Button bMnozenie;
        private System.Windows.Forms.Button bDzielenie;
        private System.Windows.Forms.Button bWynik;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.ListBox listBox2;
    }
}

