// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace BookingClient.Models;

/// <summary>Contact information of the accommodation. It can be `null` if the data is missing.</summary>
public record ContactDto(
    /// <value>Email address of the accommodation. It can be `null` if the data is missing.</value>
    [property:
        JsonPropertyName("email"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? Email = null,
    /// <value>Telephone number of the accommodation. It can be `null` if the data is missing.</value>
    [property:
        JsonPropertyName("telephone"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? Telephone = null
);
