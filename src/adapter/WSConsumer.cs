using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace LyricsFinderC.src.adapter;

public class WSConsumer : IWSConsumer
{
    private HttpClient client;

    public WSConsumer()
    {
        client = new HttpClient();
    }

    public async Task<String> GetLyricsJson(String url)
    {
        using (HttpClient client = new HttpClient())
        {
            var response = client.GetAsync(url).Result;
            string content = response.Content.ReadAsStringAsync().Result;
            return content;
        }
    }

    public String GetLyricsFromJson(String url)
    {
        try
        {
            JsonNode jsonNode = JsonNode.Parse(GetLyricsJson(url).Result);
            string lyrics = jsonNode["lyrics"].ToString();
            return lyrics;
        }
        catch (Exception)
        {
            throw;
        }
    }
}