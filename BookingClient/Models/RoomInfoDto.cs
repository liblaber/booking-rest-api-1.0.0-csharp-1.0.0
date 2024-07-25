// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace BookingClient.Models;

public record RoomInfoDto(
    [property:
        JsonPropertyName("bathroom_count"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        double? BathroomCount = null,
    [property:
        JsonPropertyName("bedroom_count"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        double? BedroomCount = null,
    [property:
        JsonPropertyName("bedrooms"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<BedroomDto>? Bedrooms = null,
    [property:
        JsonPropertyName("occupancy"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        RoomOccupancyDto? Occupancy = null,
    [property:
        JsonPropertyName("room_size"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        RoomSizeDto? RoomSize = null,
    [property:
        JsonPropertyName("room_type_id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? RoomTypeId = null
);
