// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace BookingClient.Models;

/// <summary>The charge breakdown. Includes taxes and fees.</summary>
public record ExtraChargesDtoListChargeDto(
    /// <value>Charges not included in 'book'.</value>
    [property:
        JsonPropertyName("excluded"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<ChargeDto>? Excluded = null,
    /// <value>Charges included in 'book'.</value>
    [property:
        JsonPropertyName("included"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<ChargeDto>? Included = null,
    [property:
        JsonPropertyName("conditional"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<ChargeDto>? Conditional = null
);
