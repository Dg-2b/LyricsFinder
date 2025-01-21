using LyricsFinderC.presenter;

namespace LyricsFinderC.runner;

static class Program
{
    static void Main()
    {
        Presenter presenter = new Presenter();
        presenter.Start();
    }
}