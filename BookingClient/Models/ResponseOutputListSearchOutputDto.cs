// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace BookingClient.Models;

public record ResponseOutputListSearchOutputDto(
    [property:
        JsonPropertyName("data"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<SearchOutputDto>? Data = null,
    /// <value>Uniquely identifies the request. Please provide this identifier when contacting support.</value>
    [property:
        JsonPropertyName("request_id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? RequestId = null,
    /// <value>Indicates that more results are available. Use this pagination token to retrieve the next page of results (via parameter `page`).</value>
    [property:
        JsonPropertyName("next_page"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? NextPage = null
);
