using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LyricsFinder.src.view;
using LyricsFinderC.presenter;

namespace LyricsFinder.src.view
{
    public partial class MainForm : Form
    {
        private Presenter presenter;
        public MainForm(Presenter presenter)
        {
            this.presenter = presenter;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StartForm starForm = new StartForm(presenter);
            starForm.Dock = DockStyle.Fill;
            starForm.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(starForm);
            starForm.Show();
        }

        public void ChangeStartToLyrics()
        {
            LyricsForm lyricsForm = new LyricsForm(presenter);
            lyricsForm.SetLyrics(presenter.GetLyrics());
            lyricsForm.SetArtistAndSong(presenter.GetArtist(), presenter.GetSong()); 
            lyricsForm.Dock = DockStyle.Fill;
            lyricsForm.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(lyricsForm);
            lyricsForm.Show();
        }

        public void GoBackToStart()
        {
            StartForm startForm = new StartForm(presenter);
            startForm.Dock = DockStyle.Fill;
            startForm.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(startForm);
            startForm.Show();
        }
    }
}
