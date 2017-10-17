using Newtonsoft.Json;
using System.Collections.Generic;

namespace Lastfm
{
    public class Artist
    {
        [JsonProperty("#text")]
        public string text { get; set; }
        public string mbid { get; set; }
    }

    public class Album
    {
        [JsonProperty("#text")]
        public string text { get; set; }
        public string mbid { get; set; }
    }

    public class Image
    {
        [JsonProperty("#text")]
        public string text { get; set; }
        public string size { get; set; }
    }

    public class Attr
    {
        public string nowplaying { get; set; }
    }

    public class Date
    {
        public string uts { get; set; }
        [JsonProperty("#text")]
        public string text { get; set; }
    }

    public class Track
    {
        public Artist artist { get; set; }
        public string name { get; set; }
        public string streamable { get; set; }
        public string mbid { get; set; }
        public Album album { get; set; }
        public string url { get; set; }
        public List<Image> image { get; set; }
        [JsonProperty("@attr")]
        public Attr attr { get; set; }
    }

    public class Attr2
    {
        public string user { get; set; }
        public string page { get; set; }
        public string perPage { get; set; }
        public string totalPages { get; set; }
        public string total { get; set; }
    }

    public class Recenttracks
    {
        public List<Track> track { get; set; }
        public Attr2 attr { get; set; }
    }

    public class RootObject
    {
        public Recenttracks recenttracks { get; set; }
    }
}
