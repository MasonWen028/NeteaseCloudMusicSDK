
using Newtonsoft.Json;

public class CommentVideoRequestModel
{
    [JsonProperty("rid")]
    public string Rid { get; set; }
    [JsonProperty("limit")]
    public int Limit { get; set; }
    [JsonProperty("offset")]
    public int Offset { get; set; }
    [JsonProperty("beforeTime")]
    public long BeforeTime { get; set; }
}
