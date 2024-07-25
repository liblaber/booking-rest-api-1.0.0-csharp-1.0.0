// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace BookingClient.Models;

public record CheckinCheckoutTimesDto(
    /// <value>The time till when checkout can be done at this property.</value>
    [property:
        JsonPropertyName("checkin_from"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        LocalTime? CheckinFrom = null,
    /// <value>The time till when checkout can be done at this property.</value>
    [property:
        JsonPropertyName("checkin_to"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        LocalTime? CheckinTo = null,
    /// <value>The time till when checkout can be done at this property.</value>
    [property:
        JsonPropertyName("checkout_from"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        LocalTime? CheckoutFrom = null,
    /// <value>The time till when checkout can be done at this property.</value>
    [property:
        JsonPropertyName("checkout_to"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        LocalTime? CheckoutTo = null
);
