// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using BookingClient.Json;

namespace BookingClient.Models;

public record RatingDto(
    /// <value>Number of validated reviews for this accommodation.</value>
    [property:
        JsonPropertyName("number_of_reviews"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? NumberOfReviews = null,
    /// <value>Boolean value is "true" if this accommodation is in the Booking.com's preferred program and "false" otherwise.</value>
    [property:
        JsonPropertyName("preferred"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? Preferred = null,
    /// <value>A decimal number indicating the current review score of this accommodation property, in the range 1..10.</value>
    [property:
        JsonPropertyName("review_score"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        double? ReviewScore = null,
    /// <value>Number of stars of this accommodation property.</value>
    [property:
        JsonPropertyName("stars"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        double? Stars = null,
    /// <value>An enumerated value describing which type of stars this accommodation has.</value>
    [property:
        JsonPropertyName("stars_type"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        RatingDto.StarsType? StarsType_ = null
)
{
    /// <summary>An enumerated value describing which type of stars this accommodation has.</summary>
    public record StarsType : ValueEnum<string>
    {
        internal StarsType(string value)
            : base(value) { }

        public StarsType()
            : base("ESTIMATED_BY_ACCOMMODATION") { }

        public static StarsType EstimatedByAccommodation = new("ESTIMATED_BY_ACCOMMODATION");
        public static StarsType EstimatedByBooking = new("ESTIMATED_BY_BOOKING");
        public static StarsType Official = new("OFFICIAL");
    }
}
