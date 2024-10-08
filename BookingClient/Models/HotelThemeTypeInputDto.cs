// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace BookingClient.Models;

public record HotelThemeTypeInputDto(
    /// <value>Limit the results to these themes.</value>
    [property:
        JsonPropertyName("theme_ids"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<long>? ThemeIds = null,
    /// <value>The number of rows to offset the results by. NOTE: this needs to be 0 or a multiple of 100.</value>
    [property:
        JsonPropertyName("offset"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? Offset = null,
    /// <value>The maximum number of rows to return. NOTE: this needs to be a multiple of 100.</value>
    [property:
        JsonPropertyName("row"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? Row = null
);
