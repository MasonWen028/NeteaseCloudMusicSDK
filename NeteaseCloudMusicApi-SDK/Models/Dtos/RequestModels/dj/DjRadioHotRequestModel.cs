
using Newtonsoft.Json;

public class DjRadioHotRequestModel
{
    [JsonProperty("cateId")]
    public string CateId { get; set; }
    [JsonProperty("limit")]
    public int Limit { get; set; }
    [JsonProperty("offset")]
    public int Offset { get; set; }
}
