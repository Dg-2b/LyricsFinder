namespace LyricsFinder.src.view
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            artistLabel = new Label();
            songLabel = new Label();
            artistTextBox = new TextBox();
            songTextBox = new TextBox();
            colorDialog1 = new ColorDialog();
            searchButton = new Button();
            gitHubLabel = new Label();
            apiLabel = new Label();
            reiDancingpictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)reiDancingpictureBox).BeginInit();
            SuspendLayout();
            // 
            // artistLabel
            // 
            artistLabel.AutoSize = true;
            artistLabel.BackColor = Color.Transparent;
            artistLabel.Font = new Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            artistLabel.ForeColor = Color.Black;
            artistLabel.Location = new Point(188, 23);
            artistLabel.Name = "artistLabel";
            artistLabel.Size = new Size(78, 29);
            artistLabel.TabIndex = 0;
            artistLabel.Text = "Artist:";
            artistLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // songLabel
            // 
            songLabel.AutoSize = true;
            songLabel.BackColor = Color.Transparent;
            songLabel.Font = new Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            songLabel.ForeColor = Color.Black;
            songLabel.Location = new Point(193, 89);
            songLabel.Name = "songLabel";
            songLabel.Size = new Size(73, 29);
            songLabel.TabIndex = 0;
            songLabel.Text = "Song:";
            // 
            // artistTextBox
            // 
            artistTextBox.BackColor = Color.FromArgb(163, 189, 255);
            artistTextBox.Font = new Font("Corbel", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            artistTextBox.ForeColor = SystemColors.WindowText;
            artistTextBox.Location = new Point(282, 29);
            artistTextBox.Name = "artistTextBox";
            artistTextBox.Size = new Size(280, 26);
            artistTextBox.TabIndex = 1;
            // 
            // songTextBox
            // 
            songTextBox.BackColor = Color.FromArgb(163, 189, 255);
            songTextBox.Font = new Font("Corbel", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            songTextBox.ForeColor = SystemColors.WindowText;
            songTextBox.Location = new Point(282, 95);
            songTextBox.Name = "songTextBox";
            songTextBox.Size = new Size(280, 26);
            songTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Transparent;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new Point(568, 48);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(44, 49);
            searchButton.TabIndex = 3;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            searchButton.MouseEnter += searchButton_MouseEnter;
            searchButton.MouseLeave += searchButton_MouseLeave;
            // 
            // gitHubLabel
            // 
            gitHubLabel.AutoSize = true;
            gitHubLabel.Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gitHubLabel.ForeColor = Color.FromArgb(163, 189, 255);
            gitHubLabel.Location = new Point(325, 418);
            gitHubLabel.Name = "gitHubLabel";
            gitHubLabel.Size = new Size(73, 23);
            gitHubLabel.TabIndex = 4;
            gitHubLabel.Text = "Git Hub";
            gitHubLabel.Click += gitHubLabel_Click;
            gitHubLabel.MouseEnter += gitHubLabel_MouseEnter;
            gitHubLabel.MouseLeave += gitHubLabel_MouseLeave;
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            apiLabel.ForeColor = Color.FromArgb(163, 189, 255);
            apiLabel.Location = new Point(475, 418);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(37, 23);
            apiLabel.TabIndex = 5;
            apiLabel.Text = "Api";
            apiLabel.Click += apiLabel_Click;
            apiLabel.MouseEnter += apiLabel_MouseEnter;
            apiLabel.MouseLeave += apiLabel_MouseLeave;
            // 
            // reiDancingpictureBox
            // 
            reiDancingpictureBox.BackColor = Color.Transparent;
            reiDancingpictureBox.Image = (Image)resources.GetObject("reiDancingpictureBox.Image");
            reiDancingpictureBox.Location = new Point(319, 151);
            reiDancingpictureBox.Name = "reiDancingpictureBox";
            reiDancingpictureBox.Size = new Size(243, 264);
            reiDancingpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            reiDancingpictureBox.TabIndex = 7;
            reiDancingpictureBox.TabStop = false;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(800, 450);
            Controls.Add(reiDancingpictureBox);
            Controls.Add(apiLabel);
            Controls.Add(gitHubLabel);
            Controls.Add(searchButton);
            Controls.Add(songTextBox);
            Controls.Add(artistTextBox);
            Controls.Add(songLabel);
            Controls.Add(artistLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartForm";
            Text = "StarForm";
            ((System.ComponentModel.ISupportInitialize)reiDancingpictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label artistLabel;
        private Label songLabel;
        private TextBox artistTextBox;
        private TextBox songTextBox;
        private ColorDialog colorDialog1;
        private Button searchButton;
        private Label gitHubLabel;
        private Label apiLabel;
        private PictureBox reiDancingpictureBox;
    }
}