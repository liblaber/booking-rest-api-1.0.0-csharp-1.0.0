// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace BookingClient.Models;

/// <summary>Lists all possible bedding options for this room or apartment.</summary>
public record BedOptionDto(
    /// <value>Lists all alternative bed configurations that are supported.</value>
    [property:
        JsonPropertyName("bed_configurations"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<BedConfigurationDto>? BedConfigurations = null,
    /// <value>Flags if this area includes its own bathroom.</value>
    [property:
        JsonPropertyName("has_bathroom"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? HasBathroom = null,
    /// <value>Flags if this area is marked as a bedroom, otherwise, it should be considered a living room.</value>
    [property:
        JsonPropertyName("is_bedroom"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? IsBedroom = null
);
