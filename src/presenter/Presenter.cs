using LyricsFinder.src.view;
using LyricsFinderC.src.adapter;
using LyricsFinderC.src.view;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace LyricsFinderC.presenter;

public class Presenter
{
    private MainForm mainForm;
    private IWSConsumer consumer;
    private string artist, song, lyrics;

    public Presenter()
    {
        artist = string.Empty;
        song = string.Empty;
        lyrics = string.Empty;
        mainForm = new MainForm(this);
        consumer = new WSConsumer();
    }

    public string GetLyrics()
    {
        return lyrics;
    }

    public string GetArtist()
    {
        return artist;
    }

    public string GetSong()
    {
        return song;
    }

    public void GetUserLyrics(string artist, string song)
    {
        try
        {
            string url = UserRequestToUrl(artist, song);
            lyrics = consumer.GetLyricsFromJson(url);
            this.artist = artist;
            this.song = song;
            CapitalizeNames();
            lyrics = lyrics.Replace("\r\n", "\n\r\n");
            lyrics = lyrics.Replace("\n", "\r\n");
        }
        catch (Exception) 
        {
            throw;
        }
    }

    private void CapitalizeNames()
    {
        artist = artist.ToLower();
        artist = Char.ToUpper(artist[0]) + artist.Substring(1);
        song = song.ToLower();
        song = Char.ToUpper(song[0]) + song.Substring(1);
    }

    public void ChangeStartToLyrics()
    {
        mainForm.ChangeStartToLyrics();
    }

    public void GoBackToStart()
    {
        mainForm.GoBackToStart();
    }

    private string UserRequestToUrl(string artist, string song)
    {
        string url = "https://api.lyrics.ovh/v1/";
        url += artist.Replace(" ", "%20");
        url += "/";
        url += song.Replace(" ", "%20");
        return url;
    }

    public void Start()
    {
        Application.Run(mainForm);
    }
}