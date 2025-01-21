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
            buttonOk.Location = new Point(314, 104);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(61, 29);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // MessageLabel
            // 
            MessageLabel.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MessageLabel.Location = new Point(13, 16);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(362, 85);
            MessageLabel.TabIndex = 1;
            MessageLabel.Text = "label1";
            // 
            // FormMessageBox
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(123, 131, 138);
            ClientSize = new Size(387, 145);
            Controls.Add(MessageLabel);
            Controls.Add(buttonOk);
            Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMessageBox";
            Text = "FormMessageBox";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOk;
        private Label MessageLabel;
    }
}