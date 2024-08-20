using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class emojisFound
{
    [JsonProperty("emoji")]
    public string emoji { get; set; }

    [JsonProperty("description")]
    public string description { get; set; }

    [JsonProperty("category")]
    public string category { get; set; }

    [JsonProperty("aliases")]
    public string[] aliases { get; set; }

    [JsonProperty("tags")]
    public string[] tags { get; set; }

    [JsonProperty("unicode_version")]
    public string unicodeversion { get; set; }

    [JsonProperty("ios_version")]
    public string iosversion { get; set; }

    [JsonProperty("codePoint")]
    public string codePoint { get; set; }

}

public class data
{
    [JsonProperty("count")]
    public int count { get; set; }

    [JsonProperty("emojisFound")]
    public emojisFound[] emojisFound { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
