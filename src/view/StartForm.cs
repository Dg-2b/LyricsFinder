using LyricsFinderC.presenter;
using LyricsFinderC.src.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
