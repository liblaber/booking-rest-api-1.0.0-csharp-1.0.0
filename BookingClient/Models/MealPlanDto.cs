// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using BookingClient.Json;

namespace BookingClient.Models;

/// <summary>The meal plan policy for this product.</summary>
public record MealPlanDto(
    /// <value>The meals included in the meal plan.</value>
    [property:
        JsonPropertyName("meals"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<MealPlanDto.Meals>? Meals_ = null,
    /// <value>The meal plan included in this product.</value>
    [property:
        JsonPropertyName("plan"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        MealPlanDto.Plan? Plan_ = null
)
{
    /// <summary>The meals included in the meal plan.</summary>
    public record Meals : ValueEnum<string>
    {
        internal Meals(string value)
            : base(value) { }

        public Meals()
            : base("BREAKFAST") { }

        public static Meals Breakfast = new("BREAKFAST");
        public static Meals Dinner = new("DINNER");
        public static Meals Lunch = new("LUNCH");
    }

    /// <summary>The meal plan included in this product.</summary>
    public record Plan : ValueEnum<string>
    {
        internal Plan(string value)
            : base(value) { }

        public Plan()
            : base("ALL_INCLUSIVE") { }

        public static Plan AllInclusive = new("ALL_INCLUSIVE");
        public static Plan BreakfastIncluded = new("BREAKFAST_INCLUDED");
        public static Plan FullBoard = new("FULL_BOARD");
        public static Plan HalfBoard = new("HALF_BOARD");
        public static Plan NoPlan = new("NO_PLAN");
    }
}
