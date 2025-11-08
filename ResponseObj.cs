using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// EmojisFound data
    /// </summary>
    public class EmojisFound
    {
        [JsonProperty("emoji")]
        public string Emoji { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("aliases")]
        public string[] Aliases { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("unicode_version")]
        public string Unicodeversion { get; set; }

        [JsonProperty("ios_version")]
        public string Iosversion { get; set; }

        [JsonProperty("codePoint")]
        public string CodePoint { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("emojisFound")]
        public EmojisFound[] EmojisFound { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
