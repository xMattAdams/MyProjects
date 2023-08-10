namespace WeatherApp
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
            this.longTextBox = new System.Windows.Forms.TextBox();
            this.latitudeTextBox = new System.Windows.Forms.TextBox();
            this.longLabel = new System.Windows.Forms.Label();
            this.latitudeLabel = new System.Windows.Forms.Label();
            this.timeAndTempList = new System.Windows.Forms.ListBox();
            this.timeAndTempLabel = new System.Windows.Forms.Label();
            this.getDataButton = new System.Windows.Forms.Button();
            this.validationLabel = new System.Windows.Forms.Label();
            this.avgListBox = new System.Windows.Forms.ListBox();
            this.saveToFileButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.avgTempLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // longTextBox
            // 
            this.longTextBox.Location = new System.Drawing.Point(126, 127);
            this.longTextBox.Name = "longTextBox";
            this.longTextBox.Size = new System.Drawing.Size(94, 22);
            this.longTextBox.TabIndex = 0;
            // 
            // latitudeTextBox
            // 
            this.latitudeTextBox.Location = new System.Drawing.Point(126, 172);
            this.latitudeTextBox.Name = "latitudeTextBox";
            this.latitudeTextBox.Size = new System.Drawing.Size(94, 22);
            this.latitudeTextBox.TabIndex = 1;
            // 
            // longLabel
            // 
            this.longLabel.AutoSize = true;
            this.longLabel.Location = new System.Drawing.Point(51, 130);
            this.longLabel.Name = "longLabel";
            this.longLabel.Size = new System.Drawing.Size(69, 16);
            this.longLabel.TabIndex = 2;
            this.longLabel.Text = "Longtitude";
            // 
            // latitudeLabel
            // 
            this.latitudeLabel.AutoSize = true;
            this.latitudeLabel.Location = new System.Drawing.Point(66, 175);
            this.latitudeLabel.Name = "latitudeLabel";
            this.latitudeLabel.Size = new System.Drawing.Size(54, 16);
            this.latitudeLabel.TabIndex = 3;
            this.latitudeLabel.Text = "Latitude";
            // 
            // timeAndTempList
            // 
            this.timeAndTempList.FormattingEnabled = true;
            this.timeAndTempList.ItemHeight = 16;
            this.timeAndTempList.Location = new System.Drawing.Point(307, 119);
            this.timeAndTempList.Name = "timeAndTempList";
            this.timeAndTempList.Size = new System.Drawing.Size(394, 212);
            this.timeAndTempList.TabIndex = 4;
            // 
            // timeAndTempLabel
            // 
            this.timeAndTempLabel.AutoSize = true;
            this.timeAndTempLabel.Location = new System.Drawing.Point(429, 100);
            this.timeAndTempLabel.Name = "timeAndTempLabel";
            this.timeAndTempLabel.Size = new System.Drawing.Size(139, 16);
            this.timeAndTempLabel.TabIndex = 7;
            this.timeAndTempLabel.Text = "Time and temperature";
            // 
            // getDataButton
            // 
            this.getDataButton.Location = new System.Drawing.Point(84, 280);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(136, 51);
            this.getDataButton.TabIndex = 8;
            this.getDataButton.Text = "Get Data";
            this.getDataButton.UseVisualStyleBackColor = true;
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // validationLabel
            // 
            this.validationLabel.AutoSize = true;
            this.validationLabel.Location = new System.Drawing.Point(54, 206);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(171, 16);
            this.validationLabel.TabIndex = 9;
            this.validationLabel.Text = "*Use numbers and dot only!";
            this.validationLabel.Visible = false;
            // 
            // avgListBox
            // 
            this.avgListBox.FormattingEnabled = true;
            this.avgListBox.ItemHeight = 16;
            this.avgListBox.Location = new System.Drawing.Point(399, 373);
            this.avgListBox.Name = "avgListBox";
            this.avgListBox.Size = new System.Drawing.Size(185, 212);
            this.avgListBox.TabIndex = 10;
            // 
            // saveToFileButton
            // 
            this.saveToFileButton.Enabled = false;
            this.saveToFileButton.Location = new System.Drawing.Point(84, 460);
            this.saveToFileButton.Name = "saveToFileButton";
            this.saveToFileButton.Size = new System.Drawing.Size(136, 51);
            this.saveToFileButton.TabIndex = 12;
            this.saveToFileButton.Text = "Save Results";
            this.saveToFileButton.UseVisualStyleBackColor = true;
            this.saveToFileButton.Click += new System.EventHandler(this.saveToFileButton_Click);
            // 
            // avgTempLabel
            // 
            this.avgTempLabel.AutoSize = true;
            this.avgTempLabel.Location = new System.Drawing.Point(397, 354);
            this.avgTempLabel.Name = "avgTempLabel";
            this.avgTempLabel.Size = new System.Drawing.Size(187, 16);
            this.avgTempLabel.TabIndex = 13;
            this.avgTempLabel.Text = "Day and average temperature";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(846, 563);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(136, 51);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 626);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.avgTempLabel);
            this.Controls.Add(this.saveToFileButton);
            this.Controls.Add(this.avgListBox);
            this.Controls.Add(this.validationLabel);
            this.Controls.Add(this.getDataButton);
            this.Controls.Add(this.timeAndTempLabel);
            this.Controls.Add(this.timeAndTempList);
            this.Controls.Add(this.latitudeLabel);
            this.Controls.Add(this.longLabel);
            this.Controls.Add(this.latitudeTextBox);
            this.Controls.Add(this.longTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox longTextBox;
        private System.Windows.Forms.TextBox latitudeTextBox;
        private System.Windows.Forms.Label longLabel;
        private System.Windows.Forms.Label latitudeLabel;
        private System.Windows.Forms.ListBox timeAndTempList;
        private System.Windows.Forms.Label timeAndTempLabel;
        private System.Windows.Forms.Button getDataButton;
        private System.Windows.Forms.Label validationLabel;
        private System.Windows.Forms.ListBox avgListBox;
        private System.Windows.Forms.Button saveToFileButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label avgTempLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

