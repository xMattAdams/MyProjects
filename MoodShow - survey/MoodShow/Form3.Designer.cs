namespace MoodShow
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonEnd = new System.Windows.Forms.Button();
            this.Picture1 = new System.Windows.Forms.PictureBox();
            this.Picture2 = new System.Windows.Forms.PictureBox();
            this.Picture3 = new System.Windows.Forms.PictureBox();
            this.Picture4 = new System.Windows.Forms.PictureBox();
            this.Picture5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture5)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonEnd
            // 
            this.ButtonEnd.BackColor = System.Drawing.Color.Gold;
            this.ButtonEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEnd.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEnd.Location = new System.Drawing.Point(271, 28);
            this.ButtonEnd.Name = "ButtonEnd";
            this.ButtonEnd.Size = new System.Drawing.Size(447, 116);
            this.ButtonEnd.TabIndex = 0;
            this.ButtonEnd.Text = "CHECK YOUR MOOD!";
            this.ButtonEnd.UseVisualStyleBackColor = false;
            this.ButtonEnd.Click += new System.EventHandler(this.ButtonEnd_Click);
            // 
            // Picture1
            // 
            this.Picture1.BackgroundImage = global::MoodShow.Properties.Resources._0ef3543f7eb319f6203a13e85e69d0a6;
            this.Picture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Picture1.Location = new System.Drawing.Point(226, 150);
            this.Picture1.Name = "Picture1";
            this.Picture1.Size = new System.Drawing.Size(578, 568);
            this.Picture1.TabIndex = 1;
            this.Picture1.TabStop = false;
            // 
            // Picture2
            // 
            this.Picture2.BackgroundImage = global::MoodShow.Properties.Resources._34100286_exhausted_emoticon_smiley_cartoon;
            this.Picture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Picture2.Location = new System.Drawing.Point(226, 150);
            this.Picture2.Name = "Picture2";
            this.Picture2.Size = new System.Drawing.Size(578, 568);
            this.Picture2.TabIndex = 2;
            this.Picture2.TabStop = false;
            // 
            // Picture3
            // 
            this.Picture3.BackgroundImage = global::MoodShow.Properties.Resources.neutral_or_surprised_emoticon_face_vector_20670889;
            this.Picture3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Picture3.Location = new System.Drawing.Point(226, 150);
            this.Picture3.Name = "Picture3";
            this.Picture3.Size = new System.Drawing.Size(578, 568);
            this.Picture3.TabIndex = 3;
            this.Picture3.TabStop = false;
            // 
            // Picture4
            // 
            this.Picture4.BackgroundImage = global::MoodShow.Properties.Resources.smiling_female_emoticon_vector_18816088;
            this.Picture4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Picture4.Location = new System.Drawing.Point(226, 150);
            this.Picture4.Name = "Picture4";
            this.Picture4.Size = new System.Drawing.Size(578, 568);
            this.Picture4.TabIndex = 4;
            this.Picture4.TabStop = false;
            // 
            // Picture5
            // 
            this.Picture5.BackgroundImage = global::MoodShow.Properties.Resources._6db3b93210de140175211a0ff5cd1543;
            this.Picture5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Picture5.Location = new System.Drawing.Point(226, 150);
            this.Picture5.Name = "Picture5";
            this.Picture5.Size = new System.Drawing.Size(578, 568);
            this.Picture5.TabIndex = 5;
            this.Picture5.TabStop = false;
            this.Picture5.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = global::MoodShow.Properties.Resources._240_F_104104674_GgG1cKKJo7070zlIHrnJCDXdeEUVBtKI;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1061, 736);
            this.Controls.Add(this.Picture5);
            this.Controls.Add(this.Picture4);
            this.Controls.Add(this.Picture3);
            this.Controls.Add(this.Picture2);
            this.Controls.Add(this.Picture1);
            this.Controls.Add(this.ButtonEnd);
            this.Name = "Form3";
            this.Text = "MoodShow";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonEnd;
        private System.Windows.Forms.PictureBox Picture1;
        private System.Windows.Forms.PictureBox Picture2;
        private System.Windows.Forms.PictureBox Picture3;
        private System.Windows.Forms.PictureBox Picture4;
        private System.Windows.Forms.PictureBox Picture5;
    }
}