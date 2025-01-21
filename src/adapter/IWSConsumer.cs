using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyricsFinderC.src.adapter
{
    public interface IWSConsumer
    {
        public Task<String> GetLyricsJson(string url);
        public String GetLyricsFromJson(string url);
    }
}
