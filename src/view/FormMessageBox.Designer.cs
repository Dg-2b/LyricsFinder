namespace LyricsFinderC.src.view
{
    partial class FormMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMessageBox));
            buttonOk = new Button();
            MessageLabel = new Label();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.BackgroundImageLayout = ImageLayout.Center;
            buttonOk.ForeColor = Color.FromArgb(123, 131, 138);
            buttonOk.Location = new Point(366, 104);
            buttonOk.Margin = new Padding(4, 3, 4, 3);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(71, 29);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // MessageLabel
            // 
            MessageLabel.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MessageLabel.ForeColor = Color.FromArgb(163, 189, 255);
            MessageLabel.Location = new Point(15, 16);
            MessageLabel.Margin = new Padding(4, 0, 4, 0);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(422, 85);
            MessageLabel.TabIndex = 1;
            MessageLabel.Text = "label1";
            // 
            // FormMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(451, 145);
            Controls.Add(MessageLabel);
            Controls.Add(buttonOk);
            Font = new Font("Corbel", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(163, 189, 255);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMessageBox";
            Text = "FormMessageBox";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOk;
        private Label MessageLabel;
    }
}