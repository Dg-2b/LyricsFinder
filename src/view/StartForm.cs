using LyricsFinderC.presenter;
using LyricsFinderC.src.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LyricsFinder.src.view
{
    public partial class StartForm : Form
    {
        public Presenter presenter;
        public StartForm(Presenter presenter)
        {
            this.presenter = presenter;
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(artistTextBox.Text) || String.IsNullOrEmpty(songTextBox.Text))
            {
                FormMessageBox.Show("Error", "Please fill in all blanks before continuing.");
            }
            else
            {
                try
                {
                    presenter.GetUserLyrics(artistTextBox.Text, songTextBox.Text);
                    presenter.ChangeStartToLyrics();
                }
                catch
                {
                    FormMessageBox.Show("Error", "Sorry, we don't have the lyrics for that song yet :C");
                }
            }
        }

        private void searchButton_MouseEnter(object sender, EventArgs e)
        {
            searchButton.BackColor = Color.FromArgb(123, 131, 138);
        }

        private void searchButton_MouseLeave(object sender, EventArgs e)
        {
            searchButton.BackColor = Color.Transparent;
        }

        private void gitHubLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = "https://github.com/Dg-2b/LyricsFinder", UseShellExecute = true });
        }

        private void apiLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = "https://lyricsovh.docs.apiary.io/#", UseShellExecute = true });
        }

        private void apiLabel_MouseEnter(object sender, EventArgs e)
        {
            apiLabel.ForeColor = Color.FromArgb(123, 131, 138);
        }

        private void apiLabel_MouseLeave(object sender, EventArgs e)
        {
            apiLabel.ForeColor = Color.FromArgb(163, 189, 255);
        }

        private void gitHubLabel_MouseEnter(object sender, EventArgs e)
        {
            gitHubLabel.ForeColor = Color.FromArgb(123, 131, 138);
        }

        private void gitHubLabel_MouseLeave(object sender, EventArgs e)
        {
            gitHubLabel.ForeColor = Color.FromArgb(163, 189, 255);
        }
    }
}
