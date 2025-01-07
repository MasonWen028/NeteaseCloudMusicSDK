﻿using Newtonsoft.Json;

/// <summary>
/// Represents the parameters required to retrieve the list of subscribed radio stations.
/// </summary>
public class RadioSubscriptionsRequestModel
{
    /// <summary>
    /// Gets or sets the maximum number of results to retrieve.
    /// Default is 30.
    /// </summary>
    [JsonProperty("limit")]
    public int Limit { get; set; } = 30;

    /// <summary>
    /// Gets or sets the offset for pagination.
    /// Default is 0.
    /// </summary>
    [JsonProperty("offset")]
    public int Offset { get; set; } = 0;

    /// <summary>
    /// Gets or sets a flag indicating whether to include the total count in the response.
    /// Default is true.
    /// </summary>
    [JsonProperty("total")]
    public bool Total { get; set; } = true;
}
