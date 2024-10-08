// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace BookingClient.Models;

public record ReviewScoresOutputDto(
    /// <value>Id of the hotel.</value>
    [property:
        JsonPropertyName("hotel_id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? HotelId = null,
    /// <value>URL of the hotel's page on Booking.com.</value>
    [property:
        JsonPropertyName("hotel_url"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? HotelUrl = null,
    /// <value>A breakdown of scores per reviewer type and review question.</value>
    [property:
        JsonPropertyName("score_breakdown"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<ScoreBreakdown>? ScoreBreakdown = null,
    /// <value>A breakdown of all review scores into buckets 1 - 10.</value>
    [property:
        JsonPropertyName("score_distribution"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<ScoreDistribution>? ScoreDistribution = null
);
