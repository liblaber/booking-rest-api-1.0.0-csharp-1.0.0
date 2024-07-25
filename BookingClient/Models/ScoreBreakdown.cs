// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace BookingClient.Models;

/// <summary>A breakdown of scores per reviewer type and review question.</summary>
public record ScoreBreakdown(
    /// <value>Average score from this reviewer type.</value>
    [property:
        JsonPropertyName("average_score"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        double? AverageScore = null,
    /// <value>Number of responses from this reviewer type.</value>
    [property:
        JsonPropertyName("count"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? Count = null,
    /// <value>Review scores per question.</value>
    [property:
        JsonPropertyName("question"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<QuestionDto>? Question = null,
    /// <value>Reviewer type.</value>
    [property:
        JsonPropertyName("reviewer_type"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? ReviewerType = null
);
