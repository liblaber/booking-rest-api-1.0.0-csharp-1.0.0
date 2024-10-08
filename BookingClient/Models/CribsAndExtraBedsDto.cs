// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace BookingClient.Models;

/// <summary>Lists room options regarding adding cribs and/or extra beds.</summary>
public record CribsAndExtraBedsDto(
    /// <value>
    /// Flags if cots and extra beds can be placed together in the room.
    /// `true` allows both up to their maximum limits. `false` requires exclusive choice of either cots or extra beds.
    /// </value>
    [property:
        JsonPropertyName("are_allowed"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? AreAllowed = null,
    /// <value>Maximum number of cribs that can be added.</value>
    [property:
        JsonPropertyName("maximum_number_of_cribs"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? MaximumNumberOfCribs = null,
    /// <value>Maximum number of extra beds that can be added.</value>
    [property:
        JsonPropertyName("maximum_number_of_extra_beds"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? MaximumNumberOfExtraBeds = null
);
