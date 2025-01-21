using LyricsFinderC.presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LyricsFinder.src.view
{
    public partial class LyricsForm : Form
    {
        public Presenter presenter;
        public LyricsForm(Presenter presenter)
        {
            this.presenter = presenter;
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            presenter.GoBackToStart();
        }

        private void returnButton_MouseEnter(object sender, EventArgs e)
        {
            returnButton.BackColor = Color.FromArgb(123, 131, 138);
        }

        private void returnButton_MouseLeave(object sender, EventArgs e)
        {
            returnButton.BackColor = Color.Transparent;
        }

        public void SetLyrics(String lyrics)
        {
            lyricsTextBox.Text = lyrics;
        }

        public void SetArtistAndSong(string artist, string song)
        {
            artistLabel.Text = artist;
            songLabel.Text = song;
        }
    }
}
