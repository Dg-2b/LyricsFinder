using System.Drawing;

namespace LyricsFinder.src.view
{
    partial class LyricsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LyricsForm));
            artistLabel = new Label();
            songLabel = new Label();
            lyricsTextBox = new TextBox();
            returnButton = new Button();
            coverPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)coverPictureBox).BeginInit();
            SuspendLayout();
            // 
            // artistLabel
            // 
            artistLabel.BackColor = Color.FromArgb(123, 131, 138);
            artistLabel.BorderStyle = BorderStyle.FixedSingle;
            artistLabel.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            artistLabel.Location = new Point(479, 81);
            artistLabel.Name = "artistLabel";
            artistLabel.Size = new Size(300, 30);
            artistLabel.TabIndex = 0;
            artistLabel.Text = "Artist";
            artistLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // songLabel
            // 
            songLabel.BackColor = Color.FromArgb(163, 189, 255);
            songLabel.BorderStyle = BorderStyle.FixedSingle;
            songLabel.Font = new Font("Corbel", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            songLabel.ForeColor = Color.Black;
            songLabel.Location = new Point(479, 35);
            songLabel.Name = "songLabel";
            songLabel.Size = new Size(300, 46);
            songLabel.TabIndex = 1;
            songLabel.Text = "Song";
            songLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // lyricsTextBox
            // 
            lyricsTextBox.BackColor = Color.FromArgb(123, 131, 138);
            lyricsTextBox.BorderStyle = BorderStyle.FixedSingle;
            lyricsTextBox.Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lyricsTextBox.ForeColor = Color.Black;
            lyricsTextBox.Location = new Point(12, 22);
            lyricsTextBox.Multiline = true;
            lyricsTextBox.Name = "lyricsTextBox";
            lyricsTextBox.ReadOnly = true;
            lyricsTextBox.ScrollBars = ScrollBars.Vertical;
            lyricsTextBox.Size = new Size(446, 407);
            lyricsTextBox.TabIndex = 1;
            lyricsTextBox.Text = "Letra";
            lyricsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // returnButton
            // 
            returnButton.BackColor = Color.Transparent;
            returnButton.FlatAppearance.BorderSize = 0;
            returnButton.FlatStyle = FlatStyle.Flat;
            returnButton.ForeColor = Color.Transparent;
            returnButton.Image = (Image)resources.GetObject("returnButton.Image");
            returnButton.Location = new Point(731, 386);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(57, 52);
            returnButton.TabIndex = 2;
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += returnButton_Click;
            returnButton.MouseEnter += returnButton_MouseEnter;
            returnButton.MouseLeave += returnButton_MouseLeave;
            // 
            // coverPictureBox
            // 
            coverPictureBox.Image = (Image)resources.GetObject("coverPictureBox.Image");
            coverPictureBox.Location = new Point(509, 146);
            coverPictureBox.Name = "coverPictureBox";
            coverPictureBox.Size = new Size(241, 234);
            coverPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            coverPictureBox.TabIndex = 3;
            coverPictureBox.TabStop = false;
            // 
            // LyricsForm
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(800, 450);
            Controls.Add(coverPictureBox);
            Controls.Add(returnButton);
            Controls.Add(lyricsTextBox);
            Controls.Add(songLabel);
            Controls.Add(artistLabel);
            Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LyricsForm";
            Text = "LyricsForm";
            ((System.ComponentModel.ISupportInitialize)coverPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label artistLabel;
        private Label songLabel;
        private TextBox lyricsTextBox;
        private Button returnButton;
        private PictureBox coverPictureBox;
    }
}