// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace BookingClient.Models;

/// <summary>Occupancy limits and options.</summary>
public record RoomMaximumOccupancyDto(
    /// <value>Maximum number of adults allowed.</value>
    [property:
        JsonPropertyName("adults"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? Adults = null,
    /// <value>Maximum number of children allowed (children will be typically defined by being under 18 years of age).</value>
    [property:
        JsonPropertyName("children"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? Children = null,
    /// <value>**DEPRECATED** Total capacity of adults + children allowed.</value>
    [property:
        JsonPropertyName("total_guests"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? TotalGuests = null
);
